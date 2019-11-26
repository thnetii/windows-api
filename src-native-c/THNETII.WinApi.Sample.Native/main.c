#include <Windows.h>
#include <wincrypt.h>

int main(int argc, char* argv[])
{
    ALG_ID instance;
    const int size = sizeof(instance);
    const int value = ALG_CLASS_ALL;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
