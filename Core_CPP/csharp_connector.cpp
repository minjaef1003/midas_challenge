#include "csharp_connector.h"
#include "geometry.h"

int * createRoom(int* coords, int n1, int* roomList_ptr[], int n2)
{
	vector<Wall*> walls;
	vector<Vertex*> vertices;
	for (int i = 0; i < n1; i++) {
		Vertex* vt = new Vertex(coords[i * 2], coords[i * 2 + 1]);
		vertices.push_back(vt);
	}

	for (int i = 0; i < vertices.size(); i++) {
		if (i != vertices.size() - 1) walls.push_back(new Wall(vertices[i], vertices[i + 1]));
		else walls.push_back(new Wall(vertices[i], vertices[0]));
	}

	Room* new_room = new Room(walls);
	// TODO : coords -> room
	

	vector<Room*> exist_room_list;

	// roomList_ptr -> exist_room_list
	for (int i = 0; i < n; i++) {
		exist_room_list.push_back((Room*)roomList_ptr[i]);
	}

	return (int*)new_room;
}

int * updateRoom(int * room_ptr, int * coords, int n)
{
	Room* room = (Room*)room_ptr;


	return nullptr;
}
