// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using HexaGen.Runtime;
using Hexa.NET.SPIRV.Core;

namespace Hexa.NET.SPIRVReflect
{
	/// <summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvReflectVariableFlagBits")]
	[Flags]
	public enum SpvReflectVariableFlags : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_VARIABLE_FLAGS_NONE")]
		[NativeName(NativeNameType.Value, "0")]
		FlagsNone = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_VARIABLE_FLAGS_UNUSED")]
		[NativeName(NativeNameType.Value, "1")]
		FlagsUnused = unchecked(1),

		/// <summary>
		/// If variable points to a copy of the PhysicalStorageBuffer struct<br/>
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_VARIABLE_FLAGS_PHYSICAL_POINTER_COPY")]
		[NativeName(NativeNameType.Value, "2")]
		FlagsPhysicalPointerCopy = unchecked(2),
	}
}
