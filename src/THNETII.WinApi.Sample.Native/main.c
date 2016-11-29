#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>

void main()
{
	const int size = sizeof(IMAGE_DEBUG_INFORMATION);
	const int value = 0;

	void* ptr = GetApplicationRestartSettings;
}
