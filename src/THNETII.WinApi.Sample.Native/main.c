#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>

void main()
{
	const int size = sizeof(NET_COMPUTER_NAME_TYPE);
	const int value = NETSETUP_JOIN_DOMAIN;

	void* ptr = NetGetDCName;
}
