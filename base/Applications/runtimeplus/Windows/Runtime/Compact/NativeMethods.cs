﻿/// Copyright (c) 2015 Jonathan Moore
///
/// This software is provided 'as-is', without any express or implied warranty. 
/// In no event will the authors be held liable for any damages arising from 
/// the use of this software.
/// 
/// Permission is granted to anyone to use this software for any purpose, 
/// including commercial applications, and to alter it and redistribute it 
/// freely, subject to the following restrictions:
///
/// 1. The origin of this software must not be misrepresented; 
/// you must not claim that you wrote the original software. 
/// If you use this software in a product, an acknowledgment in the product 
/// documentation would be appreciated but is not required.
/// 
/// 2. Altered source versions must be plainly marked as such, 
/// and must not be misrepresented as being the original software.
///
///3. This notice may not be removed or altered from any source distribution.
namespace System.Extensions.Compact
{
  using System;
  using System.Runtime.InteropServices;

  internal class NativeMethods
  {
    public const int SETPOWERMANAGEMENT = 6147;

    public enum VideoPowerState : byte
    {
      VideoPowerOn = 1,
      VideoPowerStandBy = 2,
      VideoPowerSuspend = 3,
      VideoPowerOff = 4,
    }

    [DllImport("coredll")]
    public static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("coredll")]
    public static extern void ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("coredll")]
    public static extern int ExtEscape(IntPtr hDc, uint nEscape, uint cbInput, byte[] plszInData, int cbOutput, IntPtr lpszOutData);
  }
}
