#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>

void main()
{
	const int size = sizeof(NET_API_STATUS);
	const int value = NERR_Success;

	void* ptr = NetApiBufferAllocate;
}
