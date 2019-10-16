﻿using System;
using System.Runtime.InteropServices;
using ApxLabs.FastAndroidCamera;

namespace ZXing.Net.Mobile.Android
{
    public static class FastJavaArrayEx
    {
        public static void BlockCopyTo(this FastJavaByteArray self, int sourceIndex, byte[] array, int arrayIndex, int length)
        {
            unsafe
            {
                Marshal.Copy(new IntPtr(self.Raw + sourceIndex), array, arrayIndex, Math.Min(length, Math.Min(self.Count, array.Length - arrayIndex)));
            }
        }
    }
}