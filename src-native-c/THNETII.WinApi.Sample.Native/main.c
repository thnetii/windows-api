#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    PGET_RUNTIME_FUNCTION_CALLBACK instance;
    const int size = sizeof(instance);
    const int value = SECURITY_MAX_SID_SIZE;

    const void* ptr = RtlCaptureStackBackTrace;

    return EXIT_SUCCESS;
}
