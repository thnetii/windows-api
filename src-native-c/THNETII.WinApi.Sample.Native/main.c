#include <Windows.h>
#include <WinBase.h>

int main(int argc, char* argv[])
{
    PVOID instance;
    const int size = sizeof(instance);
    const int value = IO_REPARSE_TAG_CSV;

    const void* ptr = RtlCaptureStackBackTrace;

    return EXIT_SUCCESS;
}
