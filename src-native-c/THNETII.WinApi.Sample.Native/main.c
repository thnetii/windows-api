#include <Windows.h>

int main(int argc, char* argv[])
{
    FLASHWINFO instance;
    const int size = sizeof(instance);
    const int value = SEM_FAILCRITICALERRORS;

    const void* ptr = SetErrorMode;

    return EXIT_SUCCESS;
}