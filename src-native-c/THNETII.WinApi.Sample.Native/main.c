#include <Windows.h>
#include <devpropdef.h>

int main(int argc, char* argv[])
{
    DEVPROPTYPE instance;
    const int size = sizeof(instance);
    const int value = DEVPROP_TYPE_EMPTY;

    const void* ptr = NULL;

    return EXIT_SUCCESS;
}
