#include <WinSCard.h>

int main(int argc, char* argv[])
{
    SCARDCONTEXT instance;
    const int size = sizeof(instance);
    const int value = SCARD_S_SUCCESS;

    const void* ptr = SCardListReaders;

    return EXIT_SUCCESS;
}
