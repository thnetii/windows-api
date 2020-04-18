namespace THNETII.WinApi.Native.WinNls
{
    // C:\Program Files (x86)\Windows Kits\10\Include\10.0.17134.0\um\WinNls.h, line 1294
    //
    //  Normalization forms
    //

    /// <summary>
    /// Specifies the supported normalization forms.
    /// </summary>
    /// <remarks>
    /// <para>Microsoft Docs page: <a href="https://docs.microsoft.com/en-us/windows/win32/api/winnls/ne-winnls-norm_form">NORM_FORM enumeration</a></para>
    /// </remarks>
    /// <seealso href="https://docs.microsoft.com/windows/desktop/Intl/national-language-support-enumeration-types">National Language Support Enumeration Types</seealso>
    public enum NORM_FORM
    {
        /// <summary>
        /// Not supported.
        /// </summary>
        NormalizationOther = 0,   // Not supported
        /// <summary>
        /// Unicode normalization form C, canonical composition. Transforms each decomposed grouping, consisting of a base character plus combining characters, to the canonical precomposed equivalent. For example, <c>A</c> + <c>¨</c> becomes <c>Ä</c>.
        /// </summary>
        NormalizationC = 0x1,     // Each base plus combining characters to the canonical precomposed equivalent.
        /// <summary>
        /// Unicode normalization form D, canonical decomposition. Transforms each precomposed character to its canonical decomposed equivalent. For example, <c>Ä</c> becomes <c>A</c> + <c>¨</c>.
        /// </summary>
        NormalizationD = 0x2,     // Each precomposed character to its canonical decomposed equivalent.
        /// <summary>
        /// Unicode normalization form KC, compatibility composition. Transforms each base plus combining characters to the canonical precomposed equivalent and all compatibility characters to their equivalents. For example, the ligature <c>ﬁ</c> becomes <c>f</c> + <c>i</c>; similarly, <c>A</c> + <c>¨</c> + <c>ﬁ</c> + <c>n</c> becomes <c>Ä</c> + <c>f</c> + <c>i</c> + <c>n</c>.
        /// </summary>
        NormalizationKC = 0x5,    // Each base plus combining characters to the canonical precomposed
                                  //   equivalents and all compatibility characters to their equivalents.
        /// <summary>
        /// Unicode normalization form KD, compatibility decomposition. Transforms each precomposed character to its canonical decomposed equivalent and all compatibility characters to their equivalents. For example, <c>Ä</c> + <c>ﬁ</c> + <c>n</c> becomes <c>A</c> + <c>¨</c> + <c>f</c> + <c>i</c> + <c>n</c>.
        /// </summary>
        NormalizationKD = 0x6     // Each precomposed character to its canonical decomposed equivalent
                                  //   and all compatibility characters to their equivalents.
    }
}
