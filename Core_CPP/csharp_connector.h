#pragma once


extern "C" {
	__declspec(dllexport) int* createRoom(int* coords, int n1, int* roomList_ptr[], int n2);
	__declspec(dllexport) int* updateRoom(int* room, int* coords, int n);
}