#include <Windows.h>
#include <WinBase.h>

int main(int argc, char* argv[])
{
    WIN32_FIND_DATAA instance;
    const int size = sizeof(instance);
    const int value = POWER_REQUEST_CONTEXT_DETAILED_STRING;

    const void* ptr = RtlCaptureStackBackTrace;

    return EXIT_SUCCESS;
}
