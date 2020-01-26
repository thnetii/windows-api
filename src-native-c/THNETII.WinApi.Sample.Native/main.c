#include <WinSCard.h>

int main(int argc, char* argv[])
{
    SCARD_READERSTATE instance;
    const int size = sizeof(instance);
    const int value = SCARD_PROTOCOL_T0;

    const void* ptr = SCardListReaders;

    return EXIT_SUCCESS;
}
