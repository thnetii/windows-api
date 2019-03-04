#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    SECURITY_QUALITY_OF_SERVICE instance;
    const int size = sizeof(instance);
    const int value = SECURITY_STATIC_TRACKING;

    const void* ptr = CloseHandle;

    return EXIT_SUCCESS;
}
