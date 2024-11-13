// See https://aka.ms/new-console-template for more information
using HexaGen;
using HexaGen.Patching;

CsCodeGeneratorConfig generatorSettings = CsCodeGeneratorConfig.Load("generator.json");
CsCodeGenerator generator = new(generatorSettings);
generator.LogToConsole();
generator.PatchEngine.RegisterPrePatch(new NamingPatch(["Spvc"], NamingPatchOptions.None));
generator.Generate([.. Directory.GetFiles("include")], "../../../../Hexa.NET.SPIRVCross/Generated");