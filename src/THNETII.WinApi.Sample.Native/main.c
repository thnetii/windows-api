#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <LM.h>
#include <winnt.h>
#include <Ntsecapi.h>

void main()
{
	const int size = sizeof(NET_VALIDATE_AUTHENTICATION_INPUT_ARG);
	const int value = AUDIT_QUERY_SYSTEM_POLICY;

	void* ptr = AuditComputeEffectivePolicyBySid;
}
