using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

using THNETII.InteropServices.Memory;
using THNETII.WinApi.Native.SCardErr;

using Xunit;

namespace THNETII.WinApi.Native.WinSCard.Test
{
    using static SCardErrConstants;
    using static WinSCardFunctions;

    public static class SCardListInterfaces
    {
        public static IEnumerable<object[]> SCardListCards()
        {
            int error;
            int cardsLength = 16;
            LPTSTR cardsBuffer = default;
            try
            {
                do
                {
                    cardsBuffer = Pointer.Create<LPTSTR>(
                        Marshal.ReAllocCoTaskMem(cardsBuffer.Pointer,
                            Marshal.SystemDefaultCharSize * cardsLength)
                        );
                    error = WinSCardFunctions.SCardListCards(default, default,
                        default, cardsBuffer, ref cardsLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                if (error != SCARD_E_NO_SERVICE)
                {
                    if (error != SCARD_S_SUCCESS)
                        throw new Win32Exception(error);

                    var cardsString = cardsBuffer.MarshalToString(cardsLength);
                    string[] cardsArray = cardsString.Split('\0', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string cardName in cardsArray)
                        yield return new object[] { cardName };
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(cardsBuffer.Pointer);
            }
        }

        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards))]
        public static void Can_call_ansi_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                int interfacesLength = 4;
                Span<Guid> interfacesArray;
                do
                {
                    interfacesArray = new Guid[interfacesLength];
                    error = SCardListInterfacesA(context, card,
                        interfacesArray, out interfacesLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
                interfacesArray = interfacesArray.Slice(0, interfacesLength);

                foreach (ref Guid @interface in interfacesArray)
                    _ = @interface;
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }

        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards))]
        public static void Can_call_unicode_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                int interfacesLength = 4;
                Span<Guid> interfacesArray;
                do
                {
                    interfacesArray = new Guid[interfacesLength];
                    error = SCardListInterfacesW(context, card,
                        interfacesArray, out interfacesLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
                interfacesArray = interfacesArray.Slice(0, interfacesLength);

                foreach (ref Guid @interface in interfacesArray)
                    _ = @interface;
            }
            finally
            {
                error = SCardReleaseContext(context);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
            }
        }

        [SkippableTheoryWindowsOS]
        [MemberData(nameof(SCardListCards))]
        public static void Can_call_auto_extern_function(string card)
        {
            int error = SCardEstablishContext(default, default, default,
                out var context);
            Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
            if (error != SCARD_S_SUCCESS)
                throw new Win32Exception(error);
            try
            {
                int interfacesLength = 4;
                Span<Guid> interfacesArray;
                do
                {
                    interfacesArray = new Guid[interfacesLength];
                    error = SCardListInterfaces(context, card,
                        interfacesArray, out interfacesLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);
                interfacesArray = interfacesArray.Slice(0, interfacesLength);

                foreach (ref Guid @interface in interfacesArray)
                    _ = @interface;
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
