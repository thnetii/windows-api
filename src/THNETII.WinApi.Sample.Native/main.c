#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <winnt.h>

void main()
{
	const int size = sizeof(NET_VALIDATE_AUTHENTICATION_INPUT_ARG);
	const int value = TOKEN_ADJUST_GROUPS;

	void* ptr = NetValidatePasswordPolicy;
}
