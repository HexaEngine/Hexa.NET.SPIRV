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

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvFPDenormMode_")]
	[Flags]
	public enum SpvFPDenormMode : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPDenormModePreserve")]
		[NativeName(NativeNameType.Value, "0")]
		Preserve = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPDenormModeFlushToZero")]
		[NativeName(NativeNameType.Value, "1")]
		FlushToZero = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SpvFPDenormModeMax")]
		[NativeName(NativeNameType.Value, "2147483647")]
		Max = unchecked(2147483647),
	}
}