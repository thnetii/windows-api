#include <Windows.h>

#include <Wsdevlicensing.h>

int main(int argc, char* argv[])
{
    void* instance;
    const int size = sizeof(instance);
    const int value = HRESULT_FROM_WIN32(ERROR_NOT_FOUND);

    const void* ptr = AcquireDeveloperLicense;

    return EXIT_SUCCESS;
}
