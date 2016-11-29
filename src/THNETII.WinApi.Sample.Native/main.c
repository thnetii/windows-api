#include <stdlib.h>
#include <stdio.h>

#include <Windows.h>
#include <DbgHelp.h>
#include <ImageHlp.h>

void main()
{
	const int size = sizeof(PIMAGEHLP_STATUS_ROUTINE);
	const int value = BIND_ALL_IMAGES;

	void* ptr = BindImageEx;
}
