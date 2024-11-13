namespace Hexa.NET.SPIRVCross
{
    using System.Runtime.InteropServices;

    public static unsafe partial class SPIRVCross
    {
        static SPIRVCross()
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