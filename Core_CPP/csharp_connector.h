#pragma once


extern "C" {
	__declspec(dllexport) int* createRoom(double* coords, int* roomList_ptr[], int n, bool snap_mode);
	__declspec(dllexport) int* updateRoom(int* room, double* coords, int n, bool snap_mode);
}