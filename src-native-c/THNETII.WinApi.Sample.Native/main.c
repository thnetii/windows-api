#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    TOKEN_BNO_ISOLATION_INFORMATION instance;
    const int size = sizeof(instance);
    const int value = SANDBOX_INERT;

    const void* ptr = CloseHandle;

    return EXIT_SUCCESS;
}
