using System.Text;
using ImGuiNET;

namespace NetImGuiNET
{
    public class NetImGui
    {
        public const uint DEFAULT_SERVER_PORT = 8888;
        public const uint DEFAULT_CLIENT_PORT = 8889;
        
        public static void Startup()
        {
            NetImGuiNative.NetImgui_Startup();
        }

        public static unsafe void ConnectToApp(string clientName, string serverHost, uint serverPort = DEFAULT_SERVER_PORT)
        {
            byte* clientNameId;
            int clientNameByteCount = 0;
            if (clientName != null)
            {
                clientNameByteCount = Encoding.UTF8.GetByteCount(clientName);
                if (clientNameByteCount > Util.StackAllocationSizeLimit)
                {
                    clientNameId = Util.Allocate(clientNameByteCount + 1);
                }
                else
                {
                    byte* nativeClientNameStackBytes = stackalloc byte[clientNameByteCount + 1];
                    clientNameId = nativeClientNameStackBytes;
                }
                int nativeClientNameOffset = Util.GetUtf8(clientName, clientNameId, clientNameByteCount);
                clientNameId[nativeClientNameOffset] = 0;
            }
            else
            {
                clientNameId = null;
            }
            
            byte* serverHostId;
            int serverHostByteCount = 0;
            if (serverHost != null)
            {
                serverHostByteCount = Encoding.UTF8.GetByteCount(serverHost);
                if (serverHostByteCount > Util.StackAllocationSizeLimit)
                {
                    serverHostId = Util.Allocate(serverHostByteCount + 1);
                }
                else
                {
                    byte* nativeServerHostStackBytes = stackalloc byte[serverHostByteCount + 1];
                    serverHostId = nativeServerHostStackBytes;
                }
                int nativeServerHostOffset = Util.GetUtf8(serverHost, serverHostId, serverHostByteCount);
                serverHostId[nativeServerHostOffset] = 0;
            }
            else
            {
                serverHostId = null;
            }
            
            NetImGuiNative.NetImgui_ConnectToApp(clientNameId, serverHostId, serverPort);
            
            if (clientNameByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(clientNameId);
            }
            
            if (serverHostByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(serverHostId);
            }
        }

        public static unsafe void ConnectFromApp(string clientName, uint clientPort = DEFAULT_CLIENT_PORT)
        {
            byte* clientNameId;
            int clientNameByteCount = 0;
            if (clientName != null)
            {
                clientNameByteCount = Encoding.UTF8.GetByteCount(clientName);
                if (clientNameByteCount > Util.StackAllocationSizeLimit)
                {
                    clientNameId = Util.Allocate(clientNameByteCount + 1);
                }
                else
                {
                    byte* nativeClientNameStackBytes = stackalloc byte[clientNameByteCount + 1];
                    clientNameId = nativeClientNameStackBytes;
                }
                int nativeClientNameOffset = Util.GetUtf8(clientName, clientNameId, clientNameByteCount);
                clientNameId[nativeClientNameOffset] = 0;
            }
            else
            {
                clientNameId = null;
            }
            
            NetImGuiNative.NetImgui_ConnectFromApp(clientNameId, clientPort);
            
            if (clientNameByteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(clientNameId);
            }
        }

        public static void Disconnect()
        {
            NetImGuiNative.NetImgui_Disconnect();
        }

        public static void Shutdown()
        {
            NetImGuiNative.NetImgui_Shutdown();
        }

        public static bool IsConnected()
        {
            return NetImGuiNative.NetImgui_IsConnected() != 0;
        }

        public static bool IsConnectionPending()
        {
            return NetImGuiNative.NetImgui_IsConnectionPending() != 0;
        }

        public static bool IsDrawingRemote()
        {
            return NetImGuiNative.NetImgui_IsDrawingRemote() != 0;
        }

        public static bool IsDrawing()
        {
            return NetImGuiNative.NetImgui_IsDrawing() != 0;
        }
    }
}