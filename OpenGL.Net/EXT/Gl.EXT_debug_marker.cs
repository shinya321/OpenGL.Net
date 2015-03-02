
// Copyright (C) 2015 Luca Piccioni
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glInsertEventMarkerEXT.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="marker">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void InsertEventMarkerEXT(Int32 length, String marker)
		{
			Debug.Assert(Delegates.pglInsertEventMarkerEXT != null, "pglInsertEventMarkerEXT not implemented");
			Delegates.pglInsertEventMarkerEXT(length, marker);
			CallLog("glInsertEventMarkerEXT({0}, {1})", length, marker);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPushGroupMarkerEXT.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="marker">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void PushGroupMarkerEXT(Int32 length, String marker)
		{
			Debug.Assert(Delegates.pglPushGroupMarkerEXT != null, "pglPushGroupMarkerEXT not implemented");
			Delegates.pglPushGroupMarkerEXT(length, marker);
			CallLog("glPushGroupMarkerEXT({0}, {1})", length, marker);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPopGroupMarkerEXT.
		/// </summary>
		public static void PopGroupMarkerEXT()
		{
			Debug.Assert(Delegates.pglPopGroupMarkerEXT != null, "pglPopGroupMarkerEXT not implemented");
			Delegates.pglPopGroupMarkerEXT();
			CallLog("glPopGroupMarkerEXT()");
			DebugCheckErrors();
		}

	}

}