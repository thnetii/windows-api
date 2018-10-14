#include <Windows.h>

int main(int argc, char* argv[])
{
    FLASHWINFO instance;
    const int size = sizeof(instance);
    const int value = HRESULT_FROM_WIN32(ERROR_SUCCESS);

    const void* ptr = GetLastError;

    return EXIT_SUCCESS;
}
