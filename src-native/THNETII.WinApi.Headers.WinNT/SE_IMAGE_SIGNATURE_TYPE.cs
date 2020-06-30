namespace THNETII.WinApi.Native.WinNT
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\winnt.h, line 11243
    /// <summary>
    /// Image signature types.
    /// </summary>
    public enum SE_IMAGE_SIGNATURE_TYPE
    {
        SeImageSignatureNone = 0,
        SeImageSignatureEmbedded,
        SeImageSignatureCache,
        SeImageSignatureCatalogCached,
        SeImageSignatureCatalogNotCached,
        SeImageSignatureCatalogHint,
        SeImageSignaturePackageCatalog,
    }
}
