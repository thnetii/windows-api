#include <Windows.h>

#include <NtDsAPI.h>

int main(int argc, char* argv[])
{
    const int size = sizeof(DS_NAME_ERROR);
    const int value = DS_REPSYNC_ABANDONED;

    DS_NAME_ERROR instance;

    UNREFERENCED_PARAMETER(instance);

    return EXIT_SUCCESS;
}
