using System.Runtime.InteropServices;

namespace GCLab;

// ===================================
// 3) Pinned buffer mantido por muito tempo
// ===================================
class Pinner
{
    private GCHandle _handle;
    public byte[] PinLongTime()
    {
        var data = new byte[256];
        _handle = GCHandle.Alloc(data, GCHandleType.Pinned);
        return data;
    }

    public void release_POH()
    {
        _handle.Free();
    }
}
