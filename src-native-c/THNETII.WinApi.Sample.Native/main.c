#include <Windows.h>

#define SECURITY_WIN32 1
#include <security.h>
#include <AuthZ.h>

int main(int argc, char* argv[])
{
    FILETIME instance;
    const int size = sizeof(instance);
    const int value = SECPKG_CRED_INBOUND;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
