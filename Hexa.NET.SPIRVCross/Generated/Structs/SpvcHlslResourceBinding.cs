// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "spvc_hlsl_resource_binding")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcHlslResourceBinding
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "stage")]
		[NativeName(NativeNameType.Type, "SpvExecutionModel")]
		public SpvExecutionModel Stage;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "desc_set")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint DescSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "binding")]
		[NativeName(NativeNameType.Type, "unsigned int")]
		public uint Binding;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "cbv")]
		[NativeName(NativeNameType.Type, "spvc_hlsl_resource_binding_mapping")]
		public SpvcHlslResourceBindingMapping Cbv;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "uav")]
		[NativeName(NativeNameType.Type, "spvc_hlsl_resource_binding_mapping")]
		public SpvcHlslResourceBindingMapping Uav;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "srv")]
		[NativeName(NativeNameType.Type, "spvc_hlsl_resource_binding_mapping")]
		public SpvcHlslResourceBindingMapping Srv;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "sampler")]
		[NativeName(NativeNameType.Type, "spvc_hlsl_resource_binding_mapping")]
		public SpvcHlslResourceBindingMapping Sampler;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcHlslResourceBinding(SpvExecutionModel stage = default, uint descSet = default, uint binding = default, SpvcHlslResourceBindingMapping cbv = default, SpvcHlslResourceBindingMapping uav = default, SpvcHlslResourceBindingMapping srv = default, SpvcHlslResourceBindingMapping sampler = default)
		{
			Stage = stage;
			DescSet = descSet;
			Binding = binding;
			Cbv = cbv;
			Uav = uav;
			Srv = srv;
			Sampler = sampler;
		}


	}

}