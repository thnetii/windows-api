#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    TOKEN_ELEVATION_TYPE instance;
    const int size = sizeof(instance);
    const int value = SANDBOX_INERT;

    const void* ptr = LocalFlags;

    return EXIT_SUCCESS;
}
