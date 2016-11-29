#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>

void main()
{
	const int size = sizeof(IMAGE_FUNCTION_ENTRY64);
	const int value = IMAGE_SCN_ALIGN_8192BYTES;

	void* ptr = GetApplicationRestartSettings;
}
