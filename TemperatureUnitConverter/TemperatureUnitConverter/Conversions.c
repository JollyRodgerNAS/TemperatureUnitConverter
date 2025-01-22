#define _CRT_SECURE_NO_WARNINGS
#define MAX_CHARS 60
#define MAX_TEMPS 15

#include "ConversionsHeader.h"
#include <stdlib.h>
#include <stdio.h>


int* ConvertToCelsius(int* returnSize)
{
	FILE* from;
	int actualSize = 0;


	from = fopen("from.txt", "r");

	if (from == NULL) 
	{
		perror("Error opening from.txt");
		exit(1);
	}

	char line[MAX_CHARS];

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		actualSize++;
	}

	rewind(from);

	int* arr = calloc(actualSize, sizeof(int));

	if (arr == NULL) 
	{
		perror("Memory allocation failed!");
		exit(1);
	}
	*returnSize = actualSize;
	int index = 0;

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		int num;

		if (sscanf(line, "%d", &num) == 1) 
		{
			arr[index] = num;
			index++;
		}
	}

	return arr;
}

int freeMemory(int* ptr) 
{
	if (ptr != NULL) {
		free(ptr);
		return 0;
	}
	return 1;
}