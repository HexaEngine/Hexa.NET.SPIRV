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
using Hexa.NET.SPIRV.Core;

namespace Hexa.NET.SPIRVReflect
{
	/// <summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// </summary>
	[NativeName(NativeNameType.Enum, "SpvReflectResourceType")]
	[Flags]
	public enum SpvReflectResourceType : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_RESOURCE_FLAG_UNDEFINED")]
		[NativeName(NativeNameType.Value, "0")]
		FlagUndefined = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_RESOURCE_FLAG_SAMPLER")]
		[NativeName(NativeNameType.Value, "1")]
		FlagSampler = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_RESOURCE_FLAG_CBV")]
		[NativeName(NativeNameType.Value, "2")]
		FlagCbv = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_RESOURCE_FLAG_SRV")]
		[NativeName(NativeNameType.Value, "4")]
		FlagSrv = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPV_REFLECT_RESOURCE_FLAG_UAV")]
		[NativeName(NativeNameType.Value, "8")]
		FlagUav = unchecked(8),
	}
}