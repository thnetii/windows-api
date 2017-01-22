#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <winnt.h>
#include <Ntsecapi.h>

void main()
{
	const int size = sizeof(MEMORYSTATUSEX);
	const int value = PAGE_EXECUTE;

	void* ptr = AuditEnumeratePerUserPolicy;
}
