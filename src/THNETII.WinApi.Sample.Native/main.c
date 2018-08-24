#include <Windows.h>

#include <amsi.h>

int main(int argc, char* argv[])
{
    AMSI_RESULT instance;
    const int size = sizeof(instance);
    const int value = AMSI_ATTRIBUTE_APP_NAME;

    return EXIT_SUCCESS;
}
