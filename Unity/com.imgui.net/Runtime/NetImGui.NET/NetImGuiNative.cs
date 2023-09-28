using System.Runtime.InteropServices;

namespace NetImGuiNET
{
    public static unsafe partial class NetImGuiNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NetImgui_Startup();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NetImgui_ConnectToApp(byte* clientName, byte* serverHost, uint serverPort);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NetImgui_ConnectFromApp(byte* clientName, uint clientPort);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NetImgui_Disconnect();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NetImgui_Shutdown();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte NetImgui_IsConnected();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte NetImgui_IsConnectionPending();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte NetImgui_IsDrawingRemote();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte NetImgui_IsDrawing();
    }
}