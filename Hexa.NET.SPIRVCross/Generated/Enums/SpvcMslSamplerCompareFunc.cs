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
	/// Maps to C++ API. <br/>
	/// </summary>
	[NativeName(NativeNameType.Enum, "spvc_msl_sampler_compare_func")]
	[Flags]
	public enum SpvcMslSamplerCompareFunc : int
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_NEVER")]
		[NativeName(NativeNameType.Value, "0")]
		Never = unchecked(0),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_LESS")]
		[NativeName(NativeNameType.Value, "1")]
		Less = unchecked(1),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_LESS_EQUAL")]
		[NativeName(NativeNameType.Value, "2")]
		LessEqual = unchecked(2),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_GREATER")]
		[NativeName(NativeNameType.Value, "3")]
		Greater = unchecked(3),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_GREATER_EQUAL")]
		[NativeName(NativeNameType.Value, "4")]
		GreaterEqual = unchecked(4),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_EQUAL")]
		[NativeName(NativeNameType.Value, "5")]
		Equal = unchecked(5),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_NOT_EQUAL")]
		[NativeName(NativeNameType.Value, "6")]
		NotEqual = unchecked(6),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_ALWAYS")]
		[NativeName(NativeNameType.Value, "7")]
		Always = unchecked(7),

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.EnumItem, "SPVC_MSL_SAMPLER_COMPARE_FUNC_INT_MAX")]
		[NativeName(NativeNameType.Value, "2147483647")]
		IntMax = unchecked(2147483647),
	}
}