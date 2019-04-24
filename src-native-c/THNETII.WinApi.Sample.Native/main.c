#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    PROCESSOR_IDLESTATE_POLICY instance;
    const int size = sizeof(instance);
    const int value = PROCESSOR_IDLESTATE_POLICY_COUNT;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
