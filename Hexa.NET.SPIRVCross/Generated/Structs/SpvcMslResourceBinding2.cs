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
using Hexa.NET.SPIRV.Core;

namespace Hexa.NET.SPIRVCross
{
	/// <summary>
	/// To be documented.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvcMslResourceBinding2
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		public SpvExecutionModel Stage;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint DescSet;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Binding;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint Count;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslBuffer;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslTexture;

		/// <summary>
		/// To be documented.
		/// </summary>
		public uint MslSampler;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvcMslResourceBinding2(SpvExecutionModel stage = default, uint descSet = default, uint binding = default, uint count = default, uint mslBuffer = default, uint mslTexture = default, uint mslSampler = default)
		{
			Stage = stage;
			DescSet = descSet;
			Binding = binding;
			Count = count;
			MslBuffer = mslBuffer;
			MslTexture = mslTexture;
			MslSampler = mslSampler;
		}


	}

}