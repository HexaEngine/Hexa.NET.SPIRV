namespace HexaEngine.Shaderc
{
    using HexaEngine.SPIRVCross;

    public static unsafe partial class SPIRV
    {
        static SPIRV()
        {
            LibraryLoader.SetImportResolver();
        }
    }
}