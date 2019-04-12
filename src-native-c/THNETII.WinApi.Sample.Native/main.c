#include <Windows.h>
#include <winnt.h>

int main(int argc, char* argv[])
{
    JOBOBJECT_BASIC_UI_RESTRICTIONS instance;
    const int size = sizeof(instance);
    const int value = JOB_OBJECT_SECURITY_FILTER_TOKENS;

    const void* ptr = GetHandleInformation;

    return EXIT_SUCCESS;
}
