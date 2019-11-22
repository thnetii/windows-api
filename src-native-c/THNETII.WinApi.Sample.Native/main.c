#include <Windows.h>
#include <WinBase.h>

#include <AuthZ.h>

int main(int argc, char* argv[])
{
    PAUTHZ_SECURITY_ATTRIBUTE_V1 instance;
    const int size = sizeof(instance);
    const int value = VER_PLATFORM_WIN32_NT;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
