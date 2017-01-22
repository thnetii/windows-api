#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <winnt.h>
#include <Ntsecapi.h>

void main()
{
	const int size = sizeof(CFG_CALL_TARGET_INFO);
	const int value = CFG_CALL_TARGET_VALID;

	void* ptr = AuditEnumeratePerUserPolicy;
}
