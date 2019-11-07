#include <Windows.h>
#include <WinBase.h>

int main(int argc, char* argv[])
{
    LPCWSTR instance;
    const int size = sizeof(instance);
    const int value = MAX_COMPUTERNAME_LENGTH;

    const void* ptr = GetSystemInfo;

    return EXIT_SUCCESS;
}
