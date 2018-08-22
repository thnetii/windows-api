#include <Windows.h>

#include <NtDsAPI.h>

int main(int argc, char* argv[])
{
    const int size = sizeof(DS_KCC_TASKID);
    const int value = DS_REPSYNC_ABANDONED;

    DS_KCC_TASKID instance;

    UNREFERENCED_PARAMETER(instance);

    return EXIT_SUCCESS;
}
