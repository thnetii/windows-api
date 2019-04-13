#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    JOBOBJECT_CPU_RATE_CONTROL_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = JOB_OBJECT_CPU_RATE_CONTROL_ENABLE;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
