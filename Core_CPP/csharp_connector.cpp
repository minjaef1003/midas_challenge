#include "csharp_connector.h"
#include "geometry.h"

int * createRoom(double * coords, int** roomList_ptr, int n)
{
	Room* new_room = new Room();
	// TODO : coords -> room


	vector<Room*> exist_room_list;

	// roomList_ptr -> exist_room_list
	for (int i = 0; i < n; i++) {
		exist_room_list.push_back((Room*)roomList_ptr[i]);
	}


	return (int*)new_room;
}
