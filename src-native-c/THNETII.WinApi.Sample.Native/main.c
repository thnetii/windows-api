#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    JOBOBJECT_END_OF_JOB_TIME_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = JOB_OBJECT_POST_AT_END_OF_JOB;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
