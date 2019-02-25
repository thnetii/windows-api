#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    XSAVE_FORMAT instance;
    const int size = sizeof(instance);
    const int value = SECURITY_MAX_SID_SIZE;

    const void* ptr = LocalFlags;

    return EXIT_SUCCESS;
}
