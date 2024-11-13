namespace Hexa.NET.SPIRVCross
{
    using System.Runtime.InteropServices;

    public static unsafe partial class SPIRV
    {
        static SPIRV()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) 
            {
                return "spirv-cross-c-shared";
            }
            return "libspirv-cross-c-shared";
        }
    }
}