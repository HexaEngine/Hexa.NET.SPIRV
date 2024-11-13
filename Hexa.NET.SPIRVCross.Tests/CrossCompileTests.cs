using Hexa.NET.SPIRVCross.Tests;

namespace Hexa.NET.SPIRVCross.Tests
{
    public unsafe class CrossCompileTests
    {
        private static void ErrorCallback(void* userdata, byte* error)
        {
            throw new Exception(ToStringFromUTF8(error));
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CrossCompileGLSL()
        {
            var fs = File.OpenRead("vs.spirv");
            int length = (int)fs.Length;
            byte* bytecode = Alloc<byte>(length);
            fs.Read(new Span<byte>(bytecode, length));
            fs.Close();

            uint word_count = (uint)length / 4;

            SpvcContext context = default;
            SpvcParsedIr ir;
            SpvcCompiler compiler;
            SpvcCompilerOptions options;
            SpvcErrorCallback errorCallback = new(ErrorCallback);

            // Create context.
            SPIRV.ContextCreate(&context).CheckResult();

            // Set debug callback.
            context.SetErrorCallback(errorCallback, null);

            // Parse the SPIR-V.
            context.ParseSpirv((uint*)bytecode, word_count, &ir).CheckResult(context);

            context.CreateCompiler(SpvcBackend.Glsl, ir, SpvcCaptureMode.TakeOwnership, &compiler).CheckResult(context);

            // Modify options.
            compiler.CreateCompilerOptions(&options).CheckResult();
            options.SetUint(SpvcCompilerOption.GlslVersion, 450).CheckResult(context);
            options.SetBool(SpvcCompilerOption.GlslEs, false).CheckResult(context);
            compiler.InstallCompilerOptions(options).CheckResult(context);

            byte* result = default;
            compiler.Compile(&result).CheckResult(context);
            string? code = ToStringFromUTF8(result);
            Console.WriteLine($"Cross-compiled source: \n{code}");

            // Frees all memory we allocated so far.
            context.Destroy();

            Free(bytecode);

            File.WriteAllText("vs.glsl", code);
        }

        [Test]
        public void CrossCompileHLSL()
        {
            var fs = File.OpenRead("vs.spirv");
            int length = (int)fs.Length;
            byte* bytecode = Alloc<byte>(length);
            fs.Read(new Span<byte>(bytecode, length));
            fs.Close();

            uint word_count = (uint)length / 4;

            SpvcContext context = default;
            SpvcParsedIr ir;
            SpvcCompiler compiler;
            SpvcCompilerOptions options;
            SpvcErrorCallback errorCallback = new(ErrorCallback);

            // Create context.
            SPIRV.ContextCreate(&context).CheckResult();

            // Set debug callback.
            context.SetErrorCallback(errorCallback, null);

            // Parse the SPIR-V.
            context.ParseSpirv((uint*)bytecode, word_count, &ir).CheckResult(context);

            context.CreateCompiler(SpvcBackend.Hlsl, ir, SpvcCaptureMode.TakeOwnership, &compiler).CheckResult(context);

            // Modify options.
            compiler.CreateCompilerOptions(&options).CheckResult();
            //SPIRV.SpvcCompilerOptionsSetUint(options, SpvcCompilerOption.HlslShaderModel, 450).CheckResult(context);
            compiler.InstallCompilerOptions(options).CheckResult(context);

            byte* result = default;
            compiler.Compile(&result).CheckResult(context);
            string? code = ToStringFromUTF8(result);
            Console.WriteLine($"Cross-compiled source: \n{code}");

            // Frees all memory we allocated so far.
            context.Destroy();

            Free(bytecode);

            File.WriteAllText("vs.hlsl", code);
        }

        [Test]
        public void CrossCompileMSL()
        {
            var fs = File.OpenRead("vs.spirv");
            int length = (int)fs.Length;
            byte* bytecode = Alloc<byte>(length);
            fs.Read(new Span<byte>(bytecode, length));
            fs.Close();

            uint word_count = (uint)length / 4;

            SpvcContext context = default;
            SpvcParsedIr ir;
            SpvcCompiler compiler;
            SpvcCompilerOptions options;
            SpvcErrorCallback errorCallback = new(ErrorCallback);

            // Create context.
            SPIRV.ContextCreate(&context).CheckResult();

            // Set debug callback.
            context.SetErrorCallback(errorCallback, null);

            // Parse the SPIR-V.
            context.ParseSpirv((uint*)bytecode, word_count, &ir).CheckResult(context);

            context.CreateCompiler(SpvcBackend.Msl, ir, SpvcCaptureMode.TakeOwnership, &compiler).CheckResult(context);

            // Modify options.
            compiler.CreateCompilerOptions(&options).CheckResult();
            //SPIRV.SpvcCompilerOptionsSetUint(options, SpvcCompilerOption.MslVersion, 450).CheckResult(context);
            compiler.InstallCompilerOptions(options).CheckResult(context);

            byte* result = default;
            compiler.Compile(&result).CheckResult(context);
            string? code = ToStringFromUTF8(result);
            Console.WriteLine($"Cross-compiled source: \n{code}");

            // Frees all memory we allocated so far.
            context.Destroy();

            Free(bytecode);

            File.WriteAllText("vs.msl", code);
        }
    }
}