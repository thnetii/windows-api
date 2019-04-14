#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    MEMORY_BASIC_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = PAGE_EXECUTE;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
