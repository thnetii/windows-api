#include <Windows.h>

int main(int argc, char* argv[])
{
    FLASHWINFO instance;
    const int size = sizeof(instance);
    const int value = MB_OK;

    const void* ptr = MessageBeep;

    return EXIT_SUCCESS;
}
