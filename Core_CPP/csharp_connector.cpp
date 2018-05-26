#include "csharp_connector.h"
#include "geometry.h"

int * createRoom(int* coords, int* roomList_ptr[], int n, bool snap_mode)
{
	Room* new_room = new Room();
	// TODO : coords -> room
	

	vector<Room*> exist_room_list;

	// roomList_ptr -> exist_room_list
	for (int i = 0; i < n; i++) {
		exist_room_list.push_back((Room*)roomList_ptr[i]);
	}

	// 

	return (int*)new_room;
}

int * updateRoom(int * room_ptr, int * coords, int n, bool snap_mode)
{
	Room* room = (Room*)room_ptr;


	return nullptr;
}
