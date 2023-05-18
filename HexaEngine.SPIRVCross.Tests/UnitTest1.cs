namespace HexaEngine.SPIRVCross.Tests
{
    public unsafe class Tests
    {
        public static void ErrorCallback(void* userdata, byte* error)
        {
            throw new Exception(ToStringFromUTF8(error));
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
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
            SpvcErrorCallback errorCallback = new((nint)(delegate*<void*, byte*, void>)&ErrorCallback);

            // Create context.
            SPIRV.SpvcContextCreate(&context).CheckResult();

            // Set debug callback.
            context.SetErrorCallback(errorCallback, null);

            // Parse the SPIR-V.
            context.ParseSpirv((SpvId*)bytecode, word_count, &ir).CheckResult(context);

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
    }
}