#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    PROCESSOR_IDLESTATE_POLICY instance;
    const int size = sizeof(instance);
    const int value = SECURITY_MAX_SID_SIZE;

    const void* ptr = RtlCaptureStackBackTrace;

    return EXIT_SUCCESS;
}
