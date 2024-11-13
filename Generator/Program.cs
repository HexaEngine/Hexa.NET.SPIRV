// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

BatchGenerator batch = new();
batch
    .Start()
    .Setup<CsCodeGenerator>("base/generator.json")
    .AddPrePatch(new NamingPatch(["Spvc"], NamingPatchOptions.None))
    .Generate(["base/spirv.h"], "../../../../Hexa.NET.SPIRV.Core/Generated")
    .GetMetadata(out var metadata)

    .Setup<CsCodeGenerator>("cross/generator.json")
    .AddPrePatch(new NamingPatch(["Spvc"], NamingPatchOptions.None))
    .CopyFromMetadata(metadata)
    .Generate(["cross/spirv_cross_c.h"], "../../../../Hexa.NET.SPIRVCross/Generated")

    .Setup<CsCodeGenerator>("reflect/generator.json")
    .AddPrePatch(new NamingPatch(["SpvReflect"], NamingPatchOptions.None))
    .CopyFromMetadata(metadata)
    .Generate(["reflect/spirv_reflect.h"], "../../../../Hexa.NET.SPIRVReflect/Generated")
    .Finish();

