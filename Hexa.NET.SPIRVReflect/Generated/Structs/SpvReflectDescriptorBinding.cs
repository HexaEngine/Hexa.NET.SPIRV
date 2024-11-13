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

namespace Hexa.NET.SPIRVReflect
{
	/// <summary>
	/// <br/>
	/// <summary>
	/// To be documented.
	/// </summary>
	/// </summary>
	[NativeName(NativeNameType.StructOrClass, "SpvReflectDescriptorBinding")]
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SpvReflectDescriptorBinding
	{
		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.StructOrClass, "SpvReflectDescriptorBinding::")]
		[StructLayout(LayoutKind.Sequential)]
		public partial struct WordOffsetUnion
		{
			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "binding")]
			[NativeName(NativeNameType.Type, "uint32_t")]
			public uint Binding;

			/// <summary>
			/// To be documented.
			/// </summary>
			[NativeName(NativeNameType.Field, "set")]
			[NativeName(NativeNameType.Type, "uint32_t")]
			public uint Set;


			/// <summary>
			/// To be documented.
			/// </summary>
			public unsafe WordOffsetUnion(uint binding = default, uint set = default)
			{
				Binding = binding;
				Set = set;
			}


		}

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "spirv_id")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint SpirvId;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "name")]
		[NativeName(NativeNameType.Type, "char const *")]
		public unsafe byte* Name;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "binding")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Binding;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "input_attachment_index")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint InputAttachmentIndex;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "set")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Set;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "descriptor_type")]
		[NativeName(NativeNameType.Type, "SpvReflectDescriptorType")]
		public SpvReflectDescriptorType DescriptorType;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "resource_type")]
		[NativeName(NativeNameType.Type, "SpvReflectResourceType")]
		public SpvReflectResourceType ResourceType;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "image")]
		[NativeName(NativeNameType.Type, "SpvReflectImageTraits")]
		public SpvReflectImageTraits Image;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "block")]
		[NativeName(NativeNameType.Type, "SpvReflectBlockVariable")]
		public SpvReflectBlockVariable Block;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "array")]
		[NativeName(NativeNameType.Type, "SpvReflectBindingArrayTraits")]
		public SpvReflectBindingArrayTraits Array;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "count")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Count;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "accessed")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint Accessed;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "uav_counter_id")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint UavCounterId;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "uav_counter_binding")]
		[NativeName(NativeNameType.Type, "SpvReflectDescriptorBinding *")]
		public unsafe SpvReflectDescriptorBinding* UavCounterBinding;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "byte_address_buffer_offset_count")]
		[NativeName(NativeNameType.Type, "uint32_t")]
		public uint ByteAddressBufferOffsetCount;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "byte_address_buffer_offsets")]
		[NativeName(NativeNameType.Type, "uint32_t *")]
		public unsafe uint* ByteAddressBufferOffsets;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "type_description")]
		[NativeName(NativeNameType.Type, "SpvReflectTypeDescription *")]
		public unsafe SpvReflectTypeDescription* TypeDescription;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "word_offset")]
		[NativeName(NativeNameType.Type, "")]
		public WordOffsetUnion WordOffset;

		/// <summary>
		/// To be documented.
		/// </summary>
		[NativeName(NativeNameType.Field, "decoration_flags")]
		[NativeName(NativeNameType.Type, "SpvReflectDecorationFlags")]
		public SpvReflectDecorationFlags DecorationFlags;

		/// <summary>
		/// Requires SPV_GOOGLE_user_type<br/>
		/// </summary>
		[NativeName(NativeNameType.Field, "user_type")]
		[NativeName(NativeNameType.Type, "SpvReflectUserType")]
		public SpvReflectUserType UserType;


		/// <summary>
		/// To be documented.
		/// </summary>
		public unsafe SpvReflectDescriptorBinding(uint spirvId = default, byte* name = default, uint binding = default, uint inputAttachmentIndex = default, uint set = default, SpvReflectDescriptorType descriptorType = default, SpvReflectResourceType resourceType = default, SpvReflectImageTraits image = default, SpvReflectBlockVariable block = default, SpvReflectBindingArrayTraits array = default, uint count = default, uint accessed = default, uint uavCounterId = default, SpvReflectDescriptorBinding* uavCounterBinding = default, uint byteAddressBufferOffsetCount = default, uint* byteAddressBufferOffsets = default, SpvReflectTypeDescription* typeDescription = default, WordOffsetUnion wordOffset = default, SpvReflectDecorationFlags decorationFlags = default, SpvReflectUserType userType = default)
		{
			SpirvId = spirvId;
			Name = name;
			Binding = binding;
			InputAttachmentIndex = inputAttachmentIndex;
			Set = set;
			DescriptorType = descriptorType;
			ResourceType = resourceType;
			Image = image;
			Block = block;
			Array = array;
			Count = count;
			Accessed = accessed;
			UavCounterId = uavCounterId;
			UavCounterBinding = uavCounterBinding;
			ByteAddressBufferOffsetCount = byteAddressBufferOffsetCount;
			ByteAddressBufferOffsets = byteAddressBufferOffsets;
			TypeDescription = typeDescription;
			WordOffset = wordOffset;
			DecorationFlags = decorationFlags;
			UserType = userType;
		}


	}

}