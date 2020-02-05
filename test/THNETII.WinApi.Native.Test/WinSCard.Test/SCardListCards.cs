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

    public static class SCardListCards
    {
        [SkippableFactWindowsOS]
        public static void Can_list_all_cards_with_null_context_ansi()
        {
            int error;
            int cardsLength = 16;
            LPMSTR cardsBuffer = default;
            try
            {
                do
                {
                    cardsBuffer = Pointer.Create<LPMSTR>(
                        Marshal.ReAllocCoTaskMem(cardsBuffer.Pointer,
                            1 * cardsLength)
                        );
                    error = SCardListCardsA(default, default, default,
                        cardsBuffer, ref cardsLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (cardPtr, cardLength) in cardsBuffer.AsEnumerable(cardsLength))
                {
                    string cardName = cardPtr.MarshalToString(cardLength);
                    _ = cardName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(cardsBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_list_all_cards_with_null_context_unicode()
        {
            int error;
            int cardsLength = 16;
            LPMWSTR cardsBuffer = default;
            try
            {
                do
                {
                    cardsBuffer = Pointer.Create<LPMWSTR>(
                        Marshal.ReAllocCoTaskMem(cardsBuffer.Pointer,
                            2 * cardsLength)
                        );
                    error = SCardListCardsW(default, default, default,
                        cardsBuffer, ref cardsLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (cardPtr, cardLength) in cardsBuffer.AsEnumerable(cardsLength))
                {
                    string cardName = cardPtr.MarshalToString(cardLength);
                    _ = cardName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(cardsBuffer.Pointer);
            }
        }

        [SkippableFactWindowsOS]
        public static void Can_list_all_cards_with_null_context_auto()
        {
            int error;
            int cardsLength = 16;
            LPMTSTR cardsBuffer = default;
            try
            {
                do
                {
                    cardsBuffer = Pointer.Create<LPMTSTR>(
                        Marshal.ReAllocCoTaskMem(cardsBuffer.Pointer,
                            Marshal.SystemDefaultCharSize * cardsLength)
                        );
                    error = SCardListCards(default, default, default,
                        cardsBuffer, ref cardsLength);
                } while (error == SCARD_E_INSUFFICIENT_BUFFER);
                Skip.If(error == SCARD_E_NO_SERVICE, new Win32Exception(error).Message);
                if (error != SCARD_S_SUCCESS)
                    throw new Win32Exception(error);

                foreach (var (cardPtr, cardLength) in cardsBuffer.AsEnumerable(cardsLength))
                {
                    string cardName = cardPtr.MarshalToString(cardLength);
                    _ = cardName;
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(cardsBuffer.Pointer);
            }
        }

        public static IEnumerable<object[]> SCardEnumerateCards()
        {
            var cardsList = new List<object[]>();
            int error;
            int cardsLength = 16;
            LPMTSTR cardsBuffer = default;
            try
            {
                do
                {
                    cardsBuffer = Pointer.Create<LPMTSTR>(
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

                    foreach (var (cardPtr, cardLength) in cardsBuffer.AsEnumerable(cardsLength))
                    {
                        string cardName = cardPtr.MarshalToString(cardLength);
                        cardsList.Add(new object[] { cardName });
                    }
                }
            }
            finally
            {
                Marshal.FreeCoTaskMem(cardsBuffer.Pointer);
            }
            return cardsList;
        }
    }
}
