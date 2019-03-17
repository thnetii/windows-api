#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    EXCEPTION_REGISTRATION_RECORD instance;
    const int size = sizeof(instance);
    const int value = HANDLE_FLAG_INHERIT;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
