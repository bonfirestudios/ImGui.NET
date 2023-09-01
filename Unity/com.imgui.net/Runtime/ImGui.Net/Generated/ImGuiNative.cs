using System;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPosXY(float posX, float posY, ImGuiCond cond, float pivotX, float pivotY);
        
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeXY(float sizeX, float sizeY, ImGuiCond cond);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSizeXY(float sizeX, float sizeY);

        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTableXY(byte* str_id, int column, ImGuiTableFlags flags, float outer_size_x, float outer_size_y, float inner_width);
        
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonXY(byte* label, float sizeX, float sizeY);
    }
}