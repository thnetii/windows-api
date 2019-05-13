#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    PVOID instance;
    const int size = sizeof(instance);
    const int value = MEMORY_ALLOCATION_ALIGNMENT;

    const void* ptr = RtlCaptureStackBackTrace;

    return EXIT_SUCCESS;
}
