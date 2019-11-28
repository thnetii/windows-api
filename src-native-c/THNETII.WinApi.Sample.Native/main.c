#include <Windows.h>

int main(int argc, char* argv[])
{
    DEVICE_TYPE instance;
    const int size = sizeof(instance);
    const int value = FILE_DEVICE_BEEP;

    const void* ptr = &GUID_DEVINTERFACE_DISK;

    return EXIT_SUCCESS;
}
