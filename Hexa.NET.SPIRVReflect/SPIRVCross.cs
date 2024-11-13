namespace Hexa.NET.SPIRVReflect
{
    using System.Runtime.InteropServices;

    public static unsafe partial class SPIRVReflect
    {
        static SPIRVReflect()
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