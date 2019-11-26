#include <Windows.h>
#include <schannel.h>
#include <credssp.h>

int main(int argc, char* argv[])
{
    ALG_ID instance;
    const int size = sizeof(instance);
    const int value = SECPKG_ATTR_EAP_KEY_BLOCK;

    const void* ptr = GetVersionEx;

    return EXIT_SUCCESS;
}
