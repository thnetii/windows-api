#include <Windows.h>

#include <NtDsAPI.h>
#include <DSRole.h>

int main(int argc, char* argv[])
{
    DSROLE_SERVER_STATE instance;
    const int size = sizeof(instance);
    const int value = DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING;

    return EXIT_SUCCESS;
}
