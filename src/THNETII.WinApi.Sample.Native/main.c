#include <Windows.h>

#include <amsi.h>

int main(int argc, char* argv[])
{
    IAmsiStream instance;
    const int size = sizeof(instance);
    const int value = AMSI_ATTRIBUTE_APP_NAME;

    const void* ptr = FormatMessage;

    return EXIT_SUCCESS;
}
