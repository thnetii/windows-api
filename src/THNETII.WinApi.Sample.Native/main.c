#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>

void main()
{
	const int size = sizeof(NET_VALIDATE_AUTHENTICATION_INPUT_ARG);
	const int value = NET_VALIDATE_PASSWORD_LAST_SET;

	void* ptr = NetValidatePasswordPolicy;
}
