#include <Windows.h>

#define SECURITY_WIN32 1
#include <security.h>
#include <AuthZ.h>
#include <credssp.h>

int main(int argc, char* argv[])
{
    CREDSSP_CRED instance;
    const int size = sizeof(instance);
    const int value = SECPKG_CRED_INBOUND;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
