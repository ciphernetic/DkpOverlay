using System;
using System.Runtime.InteropServices;

namespace DkpOverlay
{
	internal enum GWL
	{
		GWL_WNDPROC = (-4),
		GWL_HINSTANCE = (-6),
		GWL_HWNDPARENT = (-8),
		GWL_STYLE = (-16),
		GWL_EXSTYLE = (-20),
		GWL_USERDATA = (-21),
		GWL_ID = (-12)
	}

	public struct RECT
	{
		public int Left;
		public int Top;
		public int Right;
		public int Bottom;
	}

	internal static class NativeMethods
	{
		[DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
		public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
		public static extern IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
	}
}
