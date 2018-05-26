#pragma once


extern "C" {
	__declspec(dllexport) int* createRoom(int* coords, int* roomList_ptr[], int n, bool snap_mode);
	__declspec(dllexport) int* updateRoom(int* room, int* coords, int n, bool snap_mode);
}