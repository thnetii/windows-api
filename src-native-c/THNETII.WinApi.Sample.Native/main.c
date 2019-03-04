#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1 instance;
    const int size = sizeof(instance);
    const int value = SANDBOX_INERT;

    const void* ptr = CloseHandle;

    return EXIT_SUCCESS;
}
