#include <WinSCard.h>

int main(int argc, char* argv[])
{
    SCARD_READERSTATE instance;
    const int size = sizeof(instance);
    const int value = SCARD_ABSENT;

    const void* ptr = SCardGetReaderDeviceInstanceId;

    return EXIT_SUCCESS;
}
