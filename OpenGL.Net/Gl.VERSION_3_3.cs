
// Copyright (C) 2015-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value that is the frequency divisor used for instanced rendering. See 
		/// Gl.VertexAttribDivisor. The initial value is 0.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE")]
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB")]
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_EXT")]
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_DIVISOR_NV")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_ARB_instanced_arrays")]
		[RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

		/// <summary>
		/// Value of GL_SRC1_COLOR symbol.
		/// </summary>
		[AliasOf("GL_SRC1_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int SRC1_COLOR = 0x88F9;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC1_COLOR symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_SRC1_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int ONE_MINUS_SRC1_COLOR = 0x88FA;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC1_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_SRC1_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int ONE_MINUS_SRC1_ALPHA = 0x88FB;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of active draw buffers when using dual-source blending. The value 
		/// must be at least 1. See Gl.BlendFunc and Gl.BlendFuncSeparate.
		/// </summary>
		[AliasOf("GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED symbol.
		/// </summary>
		[AliasOf("GL_ANY_SAMPLES_PASSED_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public const int ANY_SAMPLES_PASSED = 0x8C2F;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the sampler object currently bound to the active texture unit. The 
		/// initial value is 0. See Gl.BindSampler.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public const int SAMPLER_BINDING = 0x8919;

		/// <summary>
		/// Value of GL_RGB10_A2UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rgb10_a2ui", Api = "gl|glcore")]
		public const int RGB10_A2UI = 0x906F;

		/// <summary>
		/// Gl.GetTexParameter: returns the red component swizzle. The initial value is Gl.RED.
		/// </summary>
		[AliasOf("GL_TEXTURE_SWIZZLE_R_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_R = 0x8E42;

		/// <summary>
		/// Gl.GetTexParameter: returns the green component swizzle. The initial value is Gl.GREEN.
		/// </summary>
		[AliasOf("GL_TEXTURE_SWIZZLE_G_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_G = 0x8E43;

		/// <summary>
		/// Gl.GetTexParameter: returns the blue component swizzle. The initial value is Gl.BLUE.
		/// </summary>
		[AliasOf("GL_TEXTURE_SWIZZLE_B_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_B = 0x8E44;

		/// <summary>
		/// Gl.GetTexParameter: returns the alpha component swizzle. The initial value is Gl.ALPHA.
		/// </summary>
		[AliasOf("GL_TEXTURE_SWIZZLE_A_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_A = 0x8E45;

		/// <summary>
		/// Gl.GetTexParameter: returns the component swizzle for all channels in a single query.
		/// </summary>
		[AliasOf("GL_TEXTURE_SWIZZLE_RGBA_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_RGBA = 0x8E46;

		/// <summary>
		/// Value of GL_TIME_ELAPSED symbol.
		/// </summary>
		[AliasOf("GL_TIME_ELAPSED_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		public const int TIME_ELAPSED = 0x88BF;

		/// <summary>
		/// Gl.Get: data returns a single value, the 64-bit value of the current GL time. See Gl.QueryCounter.
		/// </summary>
		[AliasOf("GL_TIMESTAMP_EXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		public const int TIMESTAMP = 0x8E28;

		/// <summary>
		/// Value of GL_INT_2_10_10_10_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public const int INT_2_10_10_10_REV = 0x8D9F;

		/// <summary>
		/// bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to modify
		/// </param>
		/// <param name="colorNumber">
		/// The color number to bind the user-defined varying out variable to
		/// </param>
		/// <param name="index">
		/// The index of the color input to bind the user-defined varying out variable to
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to modify
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="colorNumber"/> is greater than or equal to Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="colorNumber"/> is greater than or equal to 
		/// Gl.MAX_DUAL_SOURCE_DRAW_BUFFERS and <paramref name="index"/> is greater than or equal to one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than one.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="name"/> starts with the reserved Gl. prefix.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.ogram is not the name of a program object.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.GetFragDataLocation"/>
		/// <seealso cref="Gl.GetFragDataIndex"/>
		/// <seealso cref="Gl.BindFragDataLocation"/>
		[AliasOf("glBindFragDataLocationIndexedEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name)
		{
			Debug.Assert(Delegates.pglBindFragDataLocationIndexed != null, "pglBindFragDataLocationIndexed not implemented");
			Delegates.pglBindFragDataLocationIndexed(program, colorNumber, index, name);
			LogFunction("glBindFragDataLocationIndexed({0}, {1}, {2}, {3})", program, colorNumber, index, name);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to query
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose index to query
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.BindFragDataLocation"/>
		/// <seealso cref="Gl.BindFragDataLocationIndexed"/>
		/// <seealso cref="Gl.GetFragDataLocation"/>
		[AliasOf("glGetFragDataIndexEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public static Int32 GetFragDataIndex(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFragDataIndex != null, "pglGetFragDataIndex not implemented");
			retValue = Delegates.pglGetFragDataIndex(program, name);
			LogFunction("glGetFragDataIndex({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// generate sampler object names
		/// </summary>
		/// <param name="samplers">
		/// Specifies an array in which the generated sampler object names are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.IsSampler"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void GenSamplers(UInt32[] samplers)
		{
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglGenSamplers != null, "pglGenSamplers not implemented");
					Delegates.pglGenSamplers((Int32)samplers.Length, p_samplers);
					LogFunction("glGenSamplers({0}, {1})", samplers.Length, LogValue(samplers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate sampler object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.IsSampler"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static UInt32 GenSampler()
		{
			UInt32[] retValue = new UInt32[1];
			GenSamplers(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// delete named sampler objects
		/// </summary>
		/// <param name="samplers">
		/// Specifies an array of sampler objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.IsSampler"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void DeleteSamplers(params UInt32[] samplers)
		{
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglDeleteSamplers != null, "pglDeleteSamplers not implemented");
					Delegates.pglDeleteSamplers((Int32)samplers.Length, p_samplers);
					LogFunction("glDeleteSamplers({0}, {1})", samplers.Length, LogValue(samplers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// determine if a name corresponds to a sampler object
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static bool IsSampler(UInt32 sampler)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSampler != null, "pglIsSampler not implemented");
			retValue = Delegates.pglIsSampler(sampler);
			LogFunction("glIsSampler({0}) = {1}", sampler, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// bind a named sampler to a texturing target
		/// </summary>
		/// <param name="unit">
		/// Specifies the index of the texture unit to which the sampler is bound.
		/// </param>
		/// <param name="sampler">
		/// Specifies the name of a sampler.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="unit"/> is greater than or equal to the value of 
		/// Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="sampler"/> is not zero or a name previously returned from a call to 
		/// glGenSamplers, or if such a name has been deleted by a call to glDeleteSamplers.
		/// </exception>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GetSamplerParameter"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void BindSampler(UInt32 unit, UInt32 sampler)
		{
			Debug.Assert(Delegates.pglBindSampler != null, "pglBindSampler not implemented");
			Delegates.pglBindSampler(unit, sampler);
			LogFunction("glBindSampler({0}, {1})", unit, sampler);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameteri.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void SamplerParameter(UInt32 sampler, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglSamplerParameteri != null, "pglSamplerParameteri not implemented");
			Delegates.pglSamplerParameteri(sampler, pname, param);
			LogFunction("glSamplerParameteri({0}, {1}, {2})", sampler, LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameteriv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void SamplerParameter(UInt32 sampler, Int32 pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameteriv != null, "pglSamplerParameteriv not implemented");
					Delegates.pglSamplerParameteriv(sampler, pname, p_param);
					LogFunction("glSamplerParameteriv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameterf.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void SamplerParameter(UInt32 sampler, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglSamplerParameterf != null, "pglSamplerParameterf not implemented");
			Delegates.pglSamplerParameterf(sampler, pname, param);
			LogFunction("glSamplerParameterf({0}, {1}, {2})", sampler, LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameterfv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void SamplerParameter(UInt32 sampler, Int32 pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterfv != null, "pglSamplerParameterfv not implemented");
					Delegates.pglSamplerParameterfv(sampler, pname, p_param);
					LogFunction("glSamplerParameterfv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameterIiv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[AliasOf("glSamplerParameterIivEXT")]
		[AliasOf("glSamplerParameterIivOES")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void SamplerParameterI(UInt32 sampler, Int32 pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIiv != null, "pglSamplerParameterIiv not implemented");
					Delegates.pglSamplerParameterIiv(sampler, pname, p_param);
					LogFunction("glSamplerParameterIiv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSamplerParameterIuiv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[AliasOf("glSamplerParameterIuivEXT")]
		[AliasOf("glSamplerParameterIuivOES")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void SamplerParameterI(UInt32 sampler, Int32 pname, UInt32[] param)
		{
			unsafe {
				fixed (UInt32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterIuiv != null, "pglSamplerParameterIuiv not implemented");
					Delegates.pglSamplerParameterIuiv(sampler, pname, p_param);
					LogFunction("glSamplerParameterIuiv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, 
		/// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, 
		/// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the sampler parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sampler"/> is not the name of a sampler object returned from a previous 
		/// call to glGenSamplers.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void GetSamplerParameter(UInt32 sampler, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
					Delegates.pglGetSamplerParameteriv(sampler, pname, p_params);
					LogFunction("glGetSamplerParameteriv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, 
		/// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, 
		/// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the sampler parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sampler"/> is not the name of a sampler object returned from a previous 
		/// call to glGenSamplers.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		[AliasOf("glGetSamplerParameterIivEXT")]
		[AliasOf("glGetSamplerParameterIivOES")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void GetSamplerParameterI(UInt32 sampler, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIiv != null, "pglGetSamplerParameterIiv not implemented");
					Delegates.pglGetSamplerParameterIiv(sampler, pname, p_params);
					LogFunction("glGetSamplerParameterIiv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, 
		/// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, 
		/// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the sampler parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sampler"/> is not the name of a sampler object returned from a previous 
		/// call to glGenSamplers.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		public static void GetSamplerParameter(UInt32 sampler, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
					Delegates.pglGetSamplerParameterfv(sampler, pname, p_params);
					LogFunction("glGetSamplerParameterfv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, 
		/// Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, 
		/// Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, and Gl.TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the sampler parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="sampler"/> is not the name of a sampler object returned from a previous 
		/// call to glGenSamplers.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		[AliasOf("glGetSamplerParameterIuivEXT")]
		[AliasOf("glGetSamplerParameterIuivOES")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sampler_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public static void GetSamplerParameterI(UInt32 sampler, Int32 pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterIuiv != null, "pglGetSamplerParameterIuiv not implemented");
					Delegates.pglGetSamplerParameterIuiv(sampler, pname, p_params);
					LogFunction("glGetSamplerParameterIuiv({0}, {1}, {2})", sampler, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// record the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
		/// </summary>
		/// <param name="id">
		/// Specify the name of a query object into which to record the GL time.
		/// </param>
		/// <param name="target">
		/// Specify the counter to query. <paramref name="target"/> must be Gl.TIMESTAMP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a query object that is already in use within a 
		/// glBeginQuery / glEndQuery block.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a query object returned from a previous call 
		/// to glGenQueries.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TIMESTAMP.
		/// </exception>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glQueryCounterEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		public static void QueryCounter(UInt32 id, Int32 target)
		{
			Debug.Assert(Delegates.pglQueryCounter != null, "pglQueryCounter not implemented");
			Delegates.pglQueryCounter(id, target);
			LogFunction("glQueryCounter({0}, {1})", id, LogEnumName(target));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjecti64vEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjecti64v != null, "pglGetQueryObjecti64v not implemented");
					Delegates.pglGetQueryObjecti64v(id, pname, p_params);
					LogFunction("glGetQueryObjecti64v({0}, {1}, {2})", id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjecti64vEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, out Int64 @params)
		{
			unsafe {
				fixed (Int64* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjecti64v != null, "pglGetQueryObjecti64v not implemented");
					Delegates.pglGetQueryObjecti64v(id, pname, p_params);
					LogFunction("glGetQueryObjecti64v({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectui64vEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectui64v != null, "pglGetQueryObjectui64v not implemented");
					Delegates.pglGetQueryObjectui64v(id, pname, p_params);
					LogFunction("glGetQueryObjectui64v({0}, {1}, {2})", id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectui64vEXT")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, out UInt64 @params)
		{
			unsafe {
				fixed (UInt64* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectui64v != null, "pglGetQueryObjectui64v not implemented");
					Delegates.pglGetQueryObjectui64v(id, pname, p_params);
					LogFunction("glGetQueryObjectui64v({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// modify the rate at which generic vertex attributes advance during instanced rendering
		/// </summary>
		/// <param name="index">
		/// Specify the index of the generic vertex attribute.
		/// </param>
		/// <param name="divisor">
		/// Specify the number of instances that will pass between updates of the generic attribute at slot <paramref 
		/// name="index"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		[AliasOf("glVertexAttribDivisorANGLE")]
		[AliasOf("glVertexAttribDivisorARB")]
		[AliasOf("glVertexAttribDivisorEXT")]
		[AliasOf("glVertexAttribDivisorNV")]
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_ARB_instanced_arrays")]
		[RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
		public static void VertexAttribDivisor(UInt32 index, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexAttribDivisor != null, "pglVertexAttribDivisor not implemented");
			Delegates.pglVertexAttribDivisor(index, divisor);
			LogFunction("glVertexAttribDivisor({0}, {1})", index, divisor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If <paramref name="type"/> indicates a floating-pont 
		/// format, then <paramref name="normalized"/> value must be Gl.FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP1(UInt32 index, Int32 type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP1ui != null, "pglVertexAttribP1ui not implemented");
			Delegates.pglVertexAttribP1ui(index, type, normalized, value);
			LogFunction("glVertexAttribP1ui({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribP1uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP1(UInt32 index, Int32 type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP1uiv != null, "pglVertexAttribP1uiv not implemented");
					Delegates.pglVertexAttribP1uiv(index, type, normalized, p_value);
					LogFunction("glVertexAttribP1uiv({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If <paramref name="type"/> indicates a floating-pont 
		/// format, then <paramref name="normalized"/> value must be Gl.FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP2(UInt32 index, Int32 type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP2ui != null, "pglVertexAttribP2ui not implemented");
			Delegates.pglVertexAttribP2ui(index, type, normalized, value);
			LogFunction("glVertexAttribP2ui({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribP2uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP2(UInt32 index, Int32 type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP2uiv != null, "pglVertexAttribP2uiv not implemented");
					Delegates.pglVertexAttribP2uiv(index, type, normalized, p_value);
					LogFunction("glVertexAttribP2uiv({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If <paramref name="type"/> indicates a floating-pont 
		/// format, then <paramref name="normalized"/> value must be Gl.FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP3(UInt32 index, Int32 type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP3ui != null, "pglVertexAttribP3ui not implemented");
			Delegates.pglVertexAttribP3ui(index, type, normalized, value);
			LogFunction("glVertexAttribP3ui({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribP3uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP3(UInt32 index, Int32 type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP3uiv != null, "pglVertexAttribP3uiv not implemented");
					Delegates.pglVertexAttribP3uiv(index, type, normalized, p_value);
					LogFunction("glVertexAttribP3uiv({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (Gl.VertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if Gl.TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If <paramref name="type"/> indicates a floating-pont 
		/// format, then <paramref name="normalized"/> value must be Gl.FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP4(UInt32 index, Int32 type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP4ui != null, "pglVertexAttribP4ui not implemented");
			Delegates.pglVertexAttribP4ui(index, type, normalized, value);
			LogFunction("glVertexAttribP4ui({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribP4uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexAttribP4(UInt32 index, Int32 type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP4uiv != null, "pglVertexAttribP4uiv not implemented");
					Delegates.pglVertexAttribP4uiv(index, type, normalized, p_value);
					LogFunction("glVertexAttribP4uiv({0}, {1}, {2}, {3})", index, LogEnumName(type), normalized, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP2ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP2(Int32 type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP2ui != null, "pglVertexP2ui not implemented");
			Delegates.pglVertexP2ui(type, value);
			LogFunction("glVertexP2ui({0}, {1})", LogEnumName(type), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP2uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP2(Int32 type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP2uiv != null, "pglVertexP2uiv not implemented");
					Delegates.pglVertexP2uiv(type, p_value);
					LogFunction("glVertexP2uiv({0}, {1})", LogEnumName(type), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP3(Int32 type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP3ui != null, "pglVertexP3ui not implemented");
			Delegates.pglVertexP3ui(type, value);
			LogFunction("glVertexP3ui({0}, {1})", LogEnumName(type), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP3(Int32 type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP3uiv != null, "pglVertexP3uiv not implemented");
					Delegates.pglVertexP3uiv(type, p_value);
					LogFunction("glVertexP3uiv({0}, {1})", LogEnumName(type), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP4(Int32 type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP4ui != null, "pglVertexP4ui not implemented");
			Delegates.pglVertexP4ui(type, value);
			LogFunction("glVertexP4ui({0}, {1})", LogEnumName(type), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void VertexP4(Int32 type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP4uiv != null, "pglVertexP4uiv not implemented");
					Delegates.pglVertexP4uiv(type, p_value);
					LogFunction("glVertexP4uiv({0}, {1})", LogEnumName(type), LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP1ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP1(Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP1ui != null, "pglTexCoordP1ui not implemented");
			Delegates.pglTexCoordP1ui(type, coords);
			LogFunction("glTexCoordP1ui({0}, {1})", LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP1uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP1(Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP1uiv != null, "pglTexCoordP1uiv not implemented");
					Delegates.pglTexCoordP1uiv(type, p_coords);
					LogFunction("glTexCoordP1uiv({0}, {1})", LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP2ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP2(Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP2ui != null, "pglTexCoordP2ui not implemented");
			Delegates.pglTexCoordP2ui(type, coords);
			LogFunction("glTexCoordP2ui({0}, {1})", LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP2uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP2(Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP2uiv != null, "pglTexCoordP2uiv not implemented");
					Delegates.pglTexCoordP2uiv(type, p_coords);
					LogFunction("glTexCoordP2uiv({0}, {1})", LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP3(Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP3ui != null, "pglTexCoordP3ui not implemented");
			Delegates.pglTexCoordP3ui(type, coords);
			LogFunction("glTexCoordP3ui({0}, {1})", LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP3(Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP3uiv != null, "pglTexCoordP3uiv not implemented");
					Delegates.pglTexCoordP3uiv(type, p_coords);
					LogFunction("glTexCoordP3uiv({0}, {1})", LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP4(Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP4ui != null, "pglTexCoordP4ui not implemented");
			Delegates.pglTexCoordP4ui(type, coords);
			LogFunction("glTexCoordP4ui({0}, {1})", LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void TexCoordP4(Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP4uiv != null, "pglTexCoordP4uiv not implemented");
					Delegates.pglTexCoordP4uiv(type, p_coords);
					LogFunction("glTexCoordP4uiv({0}, {1})", LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP1ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP1(Int32 texture, Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP1ui != null, "pglMultiTexCoordP1ui not implemented");
			Delegates.pglMultiTexCoordP1ui(texture, type, coords);
			LogFunction("glMultiTexCoordP1ui({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP1uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP1(Int32 texture, Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP1uiv != null, "pglMultiTexCoordP1uiv not implemented");
					Delegates.pglMultiTexCoordP1uiv(texture, type, p_coords);
					LogFunction("glMultiTexCoordP1uiv({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP2ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP2(Int32 texture, Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP2ui != null, "pglMultiTexCoordP2ui not implemented");
			Delegates.pglMultiTexCoordP2ui(texture, type, coords);
			LogFunction("glMultiTexCoordP2ui({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP2uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP2(Int32 texture, Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP2uiv != null, "pglMultiTexCoordP2uiv not implemented");
					Delegates.pglMultiTexCoordP2uiv(texture, type, p_coords);
					LogFunction("glMultiTexCoordP2uiv({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP3ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP3(Int32 texture, Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP3ui != null, "pglMultiTexCoordP3ui not implemented");
			Delegates.pglMultiTexCoordP3ui(texture, type, coords);
			LogFunction("glMultiTexCoordP3ui({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP3uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP3(Int32 texture, Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP3uiv != null, "pglMultiTexCoordP3uiv not implemented");
					Delegates.pglMultiTexCoordP3uiv(texture, type, p_coords);
					LogFunction("glMultiTexCoordP3uiv({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP4ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP4(Int32 texture, Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP4ui != null, "pglMultiTexCoordP4ui not implemented");
			Delegates.pglMultiTexCoordP4ui(texture, type, coords);
			LogFunction("glMultiTexCoordP4ui({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoordP4uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void MultiTexCoordP4(Int32 texture, Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP4uiv != null, "pglMultiTexCoordP4uiv not implemented");
					Delegates.pglMultiTexCoordP4uiv(texture, type, p_coords);
					LogFunction("glMultiTexCoordP4uiv({0}, {1}, {2})", LogEnumName(texture), LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void NormalP3(Int32 type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglNormalP3ui != null, "pglNormalP3ui not implemented");
			Delegates.pglNormalP3ui(type, coords);
			LogFunction("glNormalP3ui({0}, {1})", LogEnumName(type), coords);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void NormalP3(Int32 type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalP3uiv != null, "pglNormalP3uiv not implemented");
					Delegates.pglNormalP3uiv(type, p_coords);
					LogFunction("glNormalP3uiv({0}, {1})", LogEnumName(type), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void ColorP3(Int32 type, UInt32 color)
		{
			Debug.Assert(Delegates.pglColorP3ui != null, "pglColorP3ui not implemented");
			Delegates.pglColorP3ui(type, color);
			LogFunction("glColorP3ui({0}, {1})", LogEnumName(type), color);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void ColorP3(Int32 type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglColorP3uiv != null, "pglColorP3uiv not implemented");
					Delegates.pglColorP3uiv(type, p_color);
					LogFunction("glColorP3uiv({0}, {1})", LogEnumName(type), LogValue(color));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void ColorP4(Int32 type, UInt32 color)
		{
			Debug.Assert(Delegates.pglColorP4ui != null, "pglColorP4ui not implemented");
			Delegates.pglColorP4ui(type, color);
			LogFunction("glColorP4ui({0}, {1})", LogEnumName(type), color);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void ColorP4(Int32 type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglColorP4uiv != null, "pglColorP4uiv not implemented");
					Delegates.pglColorP4uiv(type, p_color);
					LogFunction("glColorP4uiv({0}, {1})", LogEnumName(type), LogValue(color));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSecondaryColorP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void SecondaryColorP3(Int32 type, UInt32 color)
		{
			Debug.Assert(Delegates.pglSecondaryColorP3ui != null, "pglSecondaryColorP3ui not implemented");
			Delegates.pglSecondaryColorP3ui(type, color);
			LogFunction("glSecondaryColorP3ui({0}, {1})", LogEnumName(type), color);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSecondaryColorP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		public static void SecondaryColorP3(Int32 type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglSecondaryColorP3uiv != null, "pglSecondaryColorP3uiv not implemented");
					Delegates.pglSecondaryColorP3uiv(type, p_color);
					LogFunction("glSecondaryColorP3uiv({0}, {1})", LogEnumName(type), LogValue(color));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
			internal extern static void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
			internal extern static Int32 glGetFragDataIndex(UInt32 program, String name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
			internal extern static unsafe void glGenSamplers(Int32 count, UInt32* samplers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
			internal extern static unsafe void glDeleteSamplers(Int32 count, UInt32* samplers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsSampler(UInt32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
			internal extern static void glBindSampler(UInt32 unit, UInt32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
			internal extern static void glSamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
			internal extern static void glSamplerParameterf(UInt32 sampler, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterfv(UInt32 sampler, Int32 pname, float* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterfv(UInt32 sampler, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
			internal extern static void glQueryCounter(UInt32 id, Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjecti64v(UInt32 id, Int32 pname, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryObjectui64v(UInt32 id, Int32 pname, UInt64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
			internal extern static void glVertexAttribDivisor(UInt32 index, UInt32 divisor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP1ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP1uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP2ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP2uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP3ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP3uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
			internal extern static void glVertexAttribP4ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribP4uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP2ui", ExactSpelling = true)]
			internal extern static void glVertexP2ui(Int32 type, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP2uiv(Int32 type, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP3ui", ExactSpelling = true)]
			internal extern static void glVertexP3ui(Int32 type, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP3uiv(Int32 type, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP4ui", ExactSpelling = true)]
			internal extern static void glVertexP4ui(Int32 type, UInt32 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glVertexP4uiv(Int32 type, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP1ui", ExactSpelling = true)]
			internal extern static void glTexCoordP1ui(Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP1uiv(Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP2ui", ExactSpelling = true)]
			internal extern static void glTexCoordP2ui(Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP2uiv(Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP3ui", ExactSpelling = true)]
			internal extern static void glTexCoordP3ui(Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP3uiv(Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP4ui", ExactSpelling = true)]
			internal extern static void glTexCoordP4ui(Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoordP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoordP4uiv(Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP1ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP1ui(Int32 texture, Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP1uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP1uiv(Int32 texture, Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP2ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP2ui(Int32 texture, Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP2uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP2uiv(Int32 texture, Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP3ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP3ui(Int32 texture, Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP3uiv(Int32 texture, Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP4ui", ExactSpelling = true)]
			internal extern static void glMultiTexCoordP4ui(Int32 texture, Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoordP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoordP4uiv(Int32 texture, Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalP3ui", ExactSpelling = true)]
			internal extern static void glNormalP3ui(Int32 type, UInt32 coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glNormalP3uiv(Int32 type, UInt32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorP3ui", ExactSpelling = true)]
			internal extern static void glColorP3ui(Int32 type, UInt32 color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glColorP3uiv(Int32 type, UInt32* color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorP4ui", ExactSpelling = true)]
			internal extern static void glColorP4ui(Int32 type, UInt32 color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorP4uiv", ExactSpelling = true)]
			internal extern static unsafe void glColorP4uiv(Int32 type, UInt32* color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColorP3ui", ExactSpelling = true)]
			internal extern static void glSecondaryColorP3ui(Int32 type, UInt32 color);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColorP3uiv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorP3uiv(Int32 type, UInt32* color);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);

			[AliasOf("glBindFragDataLocationIndexed")]
			[AliasOf("glBindFragDataLocationIndexedEXT")]
			[ThreadStatic]
			internal static glBindFragDataLocationIndexed pglBindFragDataLocationIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetFragDataIndex(UInt32 program, String name);

			[AliasOf("glGetFragDataIndex")]
			[AliasOf("glGetFragDataIndexEXT")]
			[ThreadStatic]
			internal static glGetFragDataIndex pglGetFragDataIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenSamplers(Int32 count, UInt32* samplers);

			[ThreadStatic]
			internal static glGenSamplers pglGenSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteSamplers(Int32 count, UInt32* samplers);

			[ThreadStatic]
			internal static glDeleteSamplers pglDeleteSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsSampler(UInt32 sampler);

			[ThreadStatic]
			internal static glIsSampler pglIsSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindSampler(UInt32 unit, UInt32 sampler);

			[ThreadStatic]
			internal static glBindSampler pglBindSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glSamplerParameteri pglSamplerParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* param);

			[ThreadStatic]
			internal static glSamplerParameteriv pglSamplerParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplerParameterf(UInt32 sampler, Int32 pname, float param);

			[ThreadStatic]
			internal static glSamplerParameterf pglSamplerParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterfv(UInt32 sampler, Int32 pname, float* param);

			[ThreadStatic]
			internal static glSamplerParameterfv pglSamplerParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* param);

			[AliasOf("glSamplerParameterIiv")]
			[AliasOf("glSamplerParameterIivEXT")]
			[AliasOf("glSamplerParameterIivOES")]
			[ThreadStatic]
			internal static glSamplerParameterIiv pglSamplerParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* param);

			[AliasOf("glSamplerParameterIuiv")]
			[AliasOf("glSamplerParameterIuivEXT")]
			[AliasOf("glSamplerParameterIuivOES")]
			[ThreadStatic]
			internal static glSamplerParameterIuiv pglSamplerParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameteriv(UInt32 sampler, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetSamplerParameteriv pglGetSamplerParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterIiv(UInt32 sampler, Int32 pname, Int32* @params);

			[AliasOf("glGetSamplerParameterIiv")]
			[AliasOf("glGetSamplerParameterIivEXT")]
			[AliasOf("glGetSamplerParameterIivOES")]
			[ThreadStatic]
			internal static glGetSamplerParameterIiv pglGetSamplerParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterfv(UInt32 sampler, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetSamplerParameterfv pglGetSamplerParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterIuiv(UInt32 sampler, Int32 pname, UInt32* @params);

			[AliasOf("glGetSamplerParameterIuiv")]
			[AliasOf("glGetSamplerParameterIuivEXT")]
			[AliasOf("glGetSamplerParameterIuivOES")]
			[ThreadStatic]
			internal static glGetSamplerParameterIuiv pglGetSamplerParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glQueryCounter(UInt32 id, Int32 target);

			[AliasOf("glQueryCounter")]
			[AliasOf("glQueryCounterEXT")]
			[ThreadStatic]
			internal static glQueryCounter pglQueryCounter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjecti64v(UInt32 id, Int32 pname, Int64* @params);

			[AliasOf("glGetQueryObjecti64v")]
			[AliasOf("glGetQueryObjecti64vEXT")]
			[ThreadStatic]
			internal static glGetQueryObjecti64v pglGetQueryObjecti64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectui64v(UInt32 id, Int32 pname, UInt64* @params);

			[AliasOf("glGetQueryObjectui64v")]
			[AliasOf("glGetQueryObjectui64vEXT")]
			[ThreadStatic]
			internal static glGetQueryObjectui64v pglGetQueryObjectui64v;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribDivisor(UInt32 index, UInt32 divisor);

			[AliasOf("glVertexAttribDivisor")]
			[AliasOf("glVertexAttribDivisorANGLE")]
			[AliasOf("glVertexAttribDivisorARB")]
			[AliasOf("glVertexAttribDivisorEXT")]
			[AliasOf("glVertexAttribDivisorNV")]
			[ThreadStatic]
			internal static glVertexAttribDivisor pglVertexAttribDivisor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP1ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP1ui pglVertexAttribP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP1uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP1uiv pglVertexAttribP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP2ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP2ui pglVertexAttribP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP2uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP2uiv pglVertexAttribP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP3ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP3ui pglVertexAttribP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP3uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP3uiv pglVertexAttribP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP4ui(UInt32 index, Int32 type, bool normalized, UInt32 value);

			[ThreadStatic]
			internal static glVertexAttribP4ui pglVertexAttribP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP4uiv(UInt32 index, Int32 type, bool normalized, UInt32* value);

			[ThreadStatic]
			internal static glVertexAttribP4uiv pglVertexAttribP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP2ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP2ui pglVertexP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP2uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP2uiv pglVertexP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP3ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP3ui pglVertexP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP3uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP3uiv pglVertexP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP4ui(Int32 type, UInt32 value);

			[ThreadStatic]
			internal static glVertexP4ui pglVertexP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP4uiv(Int32 type, UInt32* value);

			[ThreadStatic]
			internal static glVertexP4uiv pglVertexP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP1ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP1ui pglTexCoordP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP1uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP1uiv pglTexCoordP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP2ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP2ui pglTexCoordP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP2uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP2uiv pglTexCoordP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP3ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP3ui pglTexCoordP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP3uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP3uiv pglTexCoordP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP4ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glTexCoordP4ui pglTexCoordP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP4uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glTexCoordP4uiv pglTexCoordP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP1ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP1ui pglMultiTexCoordP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP1uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP1uiv pglMultiTexCoordP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP2ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP2ui pglMultiTexCoordP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP2uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP2uiv pglMultiTexCoordP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP3ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP3ui pglMultiTexCoordP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP3uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP3uiv pglMultiTexCoordP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP4ui(Int32 texture, Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glMultiTexCoordP4ui pglMultiTexCoordP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP4uiv(Int32 texture, Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glMultiTexCoordP4uiv pglMultiTexCoordP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalP3ui(Int32 type, UInt32 coords);

			[ThreadStatic]
			internal static glNormalP3ui pglNormalP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalP3uiv(Int32 type, UInt32* coords);

			[ThreadStatic]
			internal static glNormalP3uiv pglNormalP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorP3ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glColorP3ui pglColorP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorP3uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glColorP3uiv pglColorP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorP4ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glColorP4ui pglColorP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorP4uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glColorP4uiv pglColorP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColorP3ui(Int32 type, UInt32 color);

			[ThreadStatic]
			internal static glSecondaryColorP3ui pglSecondaryColorP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorP3uiv(Int32 type, UInt32* color);

			[ThreadStatic]
			internal static glSecondaryColorP3uiv pglSecondaryColorP3uiv;

		}
	}

}
