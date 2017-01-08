#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <NTSecAPI.h>
#include <AuthZ.h>
#include <LM.h>

void main()
{
	const int size = sizeof(AUTHZ_INIT_INFO);
	const int value = MAXCOMMENTSZ;

	void* ptr = AllocateAndInitializeSid;
}
