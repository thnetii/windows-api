#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    WOW64_ARCHITECTURE_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = UMS_VERSION;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
