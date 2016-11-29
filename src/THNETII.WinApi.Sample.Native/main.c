#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>
#include <ImageHlp.h>

void main()
{
	const int size = sizeof(LOADED_IMAGE);
	const int value = CERT_PE_IMAGE_DIGEST_DEBUG_INFO;

	void* ptr = MapFileAndCheckSum;
}
