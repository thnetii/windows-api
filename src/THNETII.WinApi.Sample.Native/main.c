#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>
#include <ImageHlp.h>

void main()
{
	const int size = sizeof(LOADED_IMAGE);
	const int value = SPLITSYM_REMOVE_PRIVATE;

	void* ptr = MapFileAndCheckSum;
}
