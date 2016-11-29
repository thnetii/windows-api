#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>
#include <ImageHlp.h>

void main()
{
	const int size = sizeof(IMAGE_NT_HEADERS);
	const int value = IMAGE_NUMBEROF_DIRECTORY_ENTRIES;

	void* ptr = BindImage;
}
