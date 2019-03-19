#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    QUOTA_LIMITS_EX instance;
    const int size = sizeof(instance);
    const int value = UMS_VERSION;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
