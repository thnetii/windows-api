#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    MEMORY_BASIC_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = PO_THROTTLE_NONE;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
