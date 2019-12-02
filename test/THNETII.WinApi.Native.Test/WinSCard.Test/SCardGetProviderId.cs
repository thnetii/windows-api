using System;
using System.ComponentModel;

using THNETII.WinApi.Native.SCardErr;

using Xunit;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    public static class SCardGetProviderId
    {
        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards.SCardEnumerateCards), MemberType = typeof(SCardListCards))]
        public static void Can_call_ansi_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                error = SCardGetProviderIdA(context, card, out Guid providerId);
                if (error == SCARD_E_INVALID_TARGET)
                    return;
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                _ = providerId;
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }

        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards.SCardEnumerateCards), MemberType = typeof(SCardListCards))]
        public static void Can_call_unicode_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                error = SCardGetProviderIdW(context, card, out Guid providerId);
                if (error == SCARD_E_INVALID_TARGET)
                    return;
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                _ = providerId;
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }

        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards.SCardEnumerateCards), MemberType = typeof(SCardListCards))]
        public static void Can_call_auto_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                error = SCardGetProviderId(context, card, out Guid providerId);
                if (error == SCARD_E_INVALID_TARGET)
                    return;
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                _ = providerId;
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }
    }
}
