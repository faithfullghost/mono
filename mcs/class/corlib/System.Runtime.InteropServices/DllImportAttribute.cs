//
// System.Runtime.InteropServices.DllImportAttribute.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;


namespace System.Runtime.InteropServices {

	[ComVisible(true)]
	[AttributeUsage (AttributeTargets.Method, Inherited=false)]
	[StructLayout (LayoutKind.Sequential)]
	public sealed class DllImportAttribute: Attribute {
		#region Sync with reflection.h
		public CallingConvention CallingConvention;
		public CharSet CharSet;
		private string Dll;
		public string EntryPoint;
		public bool ExactSpelling;
		public bool PreserveSig;
		public bool SetLastError;

#if NET_1_1
		public bool BestFitMapping;
		public bool ThrowOnUnmappableChar;
#else
		private bool BestFitMapping;
		private bool ThrowOnUnmappableChar;
#endif
		#endregion

		public string Value {
			get {return Dll;}
		}
		
		public DllImportAttribute (string dllName) {
			Dll = dllName;
		}

		
	}
}
