#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    JOB_SET_ARRAY instance;
    const int size = sizeof(instance);
    const int value = HANDLE_FLAG_INHERIT;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
