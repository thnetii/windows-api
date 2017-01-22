#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <winnt.h>
#include <Ntsecapi.h>

void main()
{
	const int size = sizeof(MEMORYSTATUSEX);
	const int value = PROCESS_HEAP_ENTRY_BUSY;

	void* ptr = AuditEnumeratePerUserPolicy;
}
