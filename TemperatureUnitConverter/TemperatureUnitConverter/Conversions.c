#define _CRT_SECURE_NO_WARNINGS
#define MAX_CHARS 60
#define MAX_TEMPS 15

#include "ConversionsHeader.h"
#include <stdlib.h>
#include <stdio.h>


double* retrieveFahrenheit(int* returnSize) 
{
	FILE* from;
	int actualSize = 0;

	from = fopen("fahrenheit.txt", "r");

	if (from == NULL) 
	{
		perror("Error opening fahrenheit.txt");
		exit(1);
	}

	char line[MAX_CHARS];

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		actualSize++;
	}

	rewind(from);

	*returnSize = actualSize;

	double* arr = calloc(actualSize, sizeof(double));

	if (arr == NULL)
	{
		perror("Memory allocation failed!");
		exit(1);
	}

	int index = 0;

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		double num;

		if (sscanf(line, "%lf", &num) == 1) 
		{
			arr[index] = num;
			index++;
		}
	}
	
	fclose(from);

	return arr;
}
double* convertToCelsius()
{
	FILE* from;
	int actualSize = 0;


	from = fopen("fahrenheit.txt", "r");

	if (from == NULL) 
	{
		perror("Error opening fahrenheit.txt");
		exit(1);
	}

	char line[MAX_CHARS];

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		actualSize++;
	}

	rewind(from);

	double* arr = calloc(actualSize, sizeof(double));

	if (arr == NULL) 
	{
		perror("Memory allocation failed!");
		exit(1);
	}

	int index = 0;

	while (fgets(line, MAX_TEMPS, from) != NULL) 
	{
		double num;

		if (sscanf(line, "%lf", &num) == 1) 
		{
			arr[index] = ((num - 32) * (5.0/9.0));
			index++;
		}
	}

	fclose(from);

	return arr;
}

double* convertToKelvin() 
{
	FILE* from;
	int actualSize = 0;


	from = fopen("fahrenheit.txt", "r");

	if (from == NULL)
	{
		perror("Error opening fahrenheit.txt");
		exit(1);
	}

	char line[MAX_CHARS];

	while (fgets(line, MAX_TEMPS, from) != NULL)
	{
		actualSize++;
	}

	rewind(from);

	double* arr = calloc(actualSize, sizeof(double));

	if (arr == NULL)
	{
		perror("Memory allocation failed!");
		exit(1);
	}

	int index = 0;

	while (fgets(line, MAX_TEMPS, from) != NULL)
	{
		double num;

		if (sscanf(line, "%lf", &num) == 1)
		{
			arr[index] = ((num - 32) * (5.0 / 9.0)) + 273.15;
			index++;
		}
	}

	fclose(from);

	return arr;
}

int freeMemory(double* ptr) 
{
	if (ptr != NULL) {
		free(ptr);
		return 0;
	}
	return 1;
}