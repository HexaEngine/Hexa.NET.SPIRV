﻿namespace Generator
{
    using CppAst;
    using System.Text;

    public static partial class CsCodeGenerator
    {
        private static readonly HashSet<string> s_keywords = new HashSet<string>
        {
            "object",
            "event",
        };

        private static readonly Dictionary<string, string> s_csNameMappings = new()
        {
            { "uint8_t", "byte" },
            { "uint16_t", "ushort" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int8_t", "sbyte" },
            { "int32_t", "int" },
            { "int16_t", "short" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "unsigned char", "byte" },
            { "signed char", "sbyte" },
            { "char", "byte" },
            { "size_t", "nuint" },

            { "spvc_bool", "bool" },
            { "spvc_constant_id", "uint" },
            { "spvc_variable_id", "uint" },
            { "spvc_type_id", "uint" },
            { "spvc_hlsl_binding_flags", "uint" },
            { "spvc_msl_shader_input", "SpvcMslShaderInterfaceVar" },
            { "spvc_msl_vertex_format", "SpvcMslShaderVariableFormat" }
        };

        public static void Generate(CppCompilation compilation, string outputPath)
        {
            GenerateConstants(compilation, outputPath);
            GenerateEnums(compilation, outputPath);
            GenerateHandles(compilation, outputPath);
            GenerateStructAndUnions(compilation, outputPath);
            GenerateCommands(compilation, outputPath);
        }

        public static void AddCsMapping(string typeName, string csTypeName)
        {
            s_csNameMappings[typeName] = csTypeName;
        }

        private static void GenerateConstants(CppCompilation compilation, string outputPath)
        {
        }

        private static string NormalizeFieldName(string name)
        {
            var parts = name.Split('_', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new();
            for (int i = 0; i < parts.Length; i++)
            {
                sb.Append(char.ToUpper(parts[i][0]));
                sb.Append(parts[i][1..]);
            }
            name = sb.ToString();
            if (s_keywords.Contains(name))
                return "@" + name;

            return name;
        }

        private static string GetCsCleanName(string name)
        {
            if (s_csNameMappings.TryGetValue(name, out string? mappedName))
            {
                return mappedName;
            }
            else if (name.StartsWith("PFN"))
            {
                return "nint";
            }

            StringBuilder sb = new();
            bool wasLower = false;
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (c == '_')
                {
                    wasLower = true;
                    continue;
                }
                if (i == 0)
                {
                    c = char.ToUpper(c);
                }

                if (wasLower)
                {
                    c = char.ToUpper(c);
                    wasLower = false;
                }
                sb.Append(c);
            }

            if (sb[^1] == 'T')
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }

        private static string GetCsTypeName(CppType? type, bool isPointer = false)
        {
            if (type is CppPrimitiveType primitiveType)
            {
                return GetCsTypeName(primitiveType, isPointer);
            }

            if (type is CppQualifiedType qualifiedType)
            {
                return GetCsTypeName(qualifiedType.ElementType, isPointer);
            }

            if (type is CppEnum enumType)
            {
                var enumCsName = GetCsCleanName(enumType.Name);
                if (isPointer)
                    return enumCsName + "*";

                return enumCsName;
            }

            if (type is CppTypedef typedef)
            {
                var typeDefCsName = GetCsCleanName(typedef.Name);
                if (isPointer)
                    return typeDefCsName + "*";

                return typeDefCsName;
            }

            if (type is CppClass @class)
            {
                var className = GetCsCleanName(@class.Name);
                if (isPointer)
                    return className + "*";

                return className;
            }

            if (type is CppPointerType pointerType)
            {
                return GetCsTypeName(pointerType);
            }

            if (type is CppArrayType arrayType)
            {
                return GetCsTypeName(arrayType.ElementType, true);
            }

            return string.Empty;
        }

        private static string GetCsTypeName(CppPrimitiveType primitiveType, bool isPointer)
        {
            switch (primitiveType.Kind)
            {
                case CppPrimitiveKind.Void:
                    return isPointer ? "void*" : "void";

                case CppPrimitiveKind.Char:
                    return isPointer ? "sbyte*" : "sbyte";

                case CppPrimitiveKind.Bool:
                    return isPointer ? "bool*" : "bool";

                case CppPrimitiveKind.WChar:
                    return isPointer ? "char*" : "char";

                case CppPrimitiveKind.Short:
                    return isPointer ? "short*" : "short";

                case CppPrimitiveKind.Int:
                    return isPointer ? "int*" : "int";

                case CppPrimitiveKind.LongLong:
                    break;

                case CppPrimitiveKind.UnsignedChar:
                    return isPointer ? "byte*" : "byte";

                case CppPrimitiveKind.UnsignedShort:
                    return isPointer ? "ushort*" : "ushort";

                case CppPrimitiveKind.UnsignedInt:
                    return isPointer ? "uint*" : "uint";

                case CppPrimitiveKind.UnsignedLongLong:
                    break;

                case CppPrimitiveKind.Float:
                    return isPointer ? "float*" : "float";

                case CppPrimitiveKind.Double:
                    return isPointer ? "double*" : "double";

                case CppPrimitiveKind.LongDouble:
                    break;

                default:
                    return string.Empty;
            }

            return string.Empty;
        }

        private static string GetCsTypeName(CppPointerType pointerType)
        {
            if (pointerType.ElementType is CppQualifiedType qualifiedType)
            {
                if (qualifiedType.ElementType is CppPrimitiveType primitiveType)
                {
                    return GetCsTypeName(primitiveType, true);
                }
                else if (qualifiedType.ElementType is CppClass @classType)
                {
                    return GetCsTypeName(@classType, true);
                }
                else if (qualifiedType.ElementType is CppPointerType subPointerType)
                {
                    return GetCsTypeName(subPointerType, true) + "*";
                }
                else if (qualifiedType.ElementType is CppTypedef typedef)
                {
                    return GetCsTypeName(typedef, true);
                }
                else if (qualifiedType.ElementType is CppEnum @enum)
                {
                    return GetCsTypeName(@enum, true);
                }

                return GetCsTypeName(qualifiedType.ElementType, true);
            }

            return GetCsTypeName(pointerType.ElementType, true);
        }

        private static bool WriteCsSummary(CppComment? comment, CodeWriter writer)
        {
            if (comment is CppCommentFull full)
            {
                writer.WriteLine("/// <summary>");
                for (int i = 0; i < full.Children.Count; i++)
                {
                    WriteCsSummary(full.Children[i], writer);
                }
                writer.WriteLine("/// </summary>");
                return true;
            }
            if (comment is CppCommentParagraph paragraph)
            {
                for (int i = 0; i < paragraph.Children.Count; i++)
                {
                    WriteCsSummary(paragraph.Children[i], writer);
                }
                return true;
            }
            if (comment is CppCommentText text)
            {
                writer.WriteLine($"/// " + text.Text);
                return true;
            }

            if (comment == null || comment.Kind == CppCommentKind.Null)
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}