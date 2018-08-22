#include <Windows.h>

#include <NtDsAPI.h>

int main(int argc, char* argv[])
{
    const int size = sizeof(DS_NAME_FORMAT);
    const int value = DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING;

    DS_NAME_FORMAT instance;

    UNREFERENCED_PARAMETER(instance);

    return EXIT_SUCCESS;
}
