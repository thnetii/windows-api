#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    JOBOBJECT_BASIC_LIMIT_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = JOB_OBJECT_LIMIT_ACTIVE_PROCESS;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
