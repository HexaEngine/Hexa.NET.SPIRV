namespace Hexa.NET.SPIRVReflect.Tests
{
    public unsafe class ReflectTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SpvReflectShaderModule shaderModule = default;
            byte[] spirvBinary = File.ReadAllBytes("shader.spv");
            fixed (byte* pData = spirvBinary)
            {
                if (SPIRVReflect.CreateShaderModule((nuint)spirvBinary.Length, pData, ref shaderModule) != SpvReflectResult.Success)
                {
                    Assert.Fail("Failed to initialize SPIR-V Reflect module.");
                    return;
                }
            }

            for (int i = 0; i < shaderModule.EntryPointCount; i++)
            {
                SpvReflectEntryPoint entryPoint = shaderModule.EntryPoints[i];

                string name = ToStringFromUTF8(entryPoint.Name)!;
                Console.WriteLine(name);
            }

            for (int i = 0; i < shaderModule.DescriptorBindingCount; i++)
            {
                var binding = shaderModule.DescriptorBindings[i];

                string name = ToStringFromUTF8(binding.Name)!;
                Console.WriteLine(name);
            }

            SPIRVReflect.DestroyShaderModule(ref shaderModule);

            Assert.Pass();
        }
    }
}