#include <Windows.h>
#include <WinBase.h>

int main(int argc, char* argv[])
{
    LPCWSTR instance;
    const int size = sizeof(instance);
    const int value = PROCESSOR_ARCHITECTURE_AMD64;

    const void* ptr = GetEnvironmentVariableA;

    return EXIT_SUCCESS;
}
