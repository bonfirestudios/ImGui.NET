using Unity.Collections.LowLevel.Unsafe;

namespace ImGuiNET
{
    #if UNITY_EDITOR
    public static class Unsafe
    {
        public static unsafe ref T AsRef<T>(void* ptr) where T : struct => ref UnsafeUtility.AsRef<T>(ptr);
        
        public static int SizeOf<T>() where T : struct => UnsafeUtility.SizeOf<T>();

        public static unsafe void CopyBlock(ref byte destination, ref byte source, uint byteCount)
        {
            UnsafeUtility.MemCpy(UnsafeUtility.AddressOf(ref destination), UnsafeUtility.AddressOf(ref source), byteCount);
        }

        public static unsafe void CopyBlock(void* destination, void* source, uint byteCount)
        {
            UnsafeUtility.MemCpy(destination, source, byteCount);
        }

        public static unsafe void InitBlockUnaligned(void* startAddress, byte value, uint byteCount)
        {
            UnsafeUtility.MemSet(startAddress, value, byteCount);
        }

        public static unsafe T Read<T>(void* source) where T : struct
        {
            T value = default;
            
            UnsafeUtility.MemCpy(UnsafeUtility.AddressOf(ref value), source, UnsafeUtility.SizeOf<T>());

            return value;
        }
    }
    #endif
}