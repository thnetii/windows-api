#include <Windows.h>

#include <NtDsAPI.h>
#include <DSRole.h>

int main(int argc, char* argv[])
{
    DSROLE_PRIMARY_DOMAIN_INFO_LEVEL instance;
    const int size = sizeof(instance);
    const int value = DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING;

    return EXIT_SUCCESS;
}
