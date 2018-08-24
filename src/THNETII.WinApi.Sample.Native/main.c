#include <Windows.h>

#include <amsi.h>

int main(int argc, char* argv[])
{
    IAmsiStream instance;
    const int size = sizeof(instance);
    const int value = E_NOT_VALID_STATE;

    const void* ptr = FormatMessage;

    return EXIT_SUCCESS;
}
