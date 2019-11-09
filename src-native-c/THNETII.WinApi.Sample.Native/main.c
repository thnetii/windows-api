#include <Windows.h>
#include <WinBase.h>

int main(int argc, char* argv[])
{
    OSVERSIONINFOW instance;
    const int size = sizeof(instance);
    const int value = VER_PLATFORM_WIN32_NT;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
