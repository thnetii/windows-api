#include <Windows.h>

#include <amsi.h>

int main(int argc, char* argv[])
{
    IAntimalwareProvider instance;
    const int size = sizeof(instance);
    const int value = E_INVALIDARG;

    const void* ptr = AmsiInitialize;

    return EXIT_SUCCESS;
}
