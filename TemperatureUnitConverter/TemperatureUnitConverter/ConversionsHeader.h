#ifdef __cplusplus
extern "C" {
#endif

	__declspec(dllexport) double* convertToCelsius();
	__declspec(dllexport) double* convertToKelvin();
	__declspec(dllexport) double* retrieveFahrenheit(int* returnSize);
	__declspec(dllexport) int freeMemory(int* ptr);

#ifdef __cplusplus
}
#endif
#pragma once
