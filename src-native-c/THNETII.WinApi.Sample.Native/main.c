#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    TOKEN_DEFAULT_DACL instance;
    const int size = sizeof(instance);
    const int value = SANDBOX_INERT;

    const void* ptr = LocalFlags;

    return EXIT_SUCCESS;
}
