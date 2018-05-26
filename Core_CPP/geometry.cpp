#include "geometry.h"

//Vertex
Vertex::Vertex()
{
}

Vertex::Vertex(int _x, int _y)
{
	x = _x;
	y = _y;
}

void Vertex::setVertex(Vertex* _vertex) {
	x = _vertex->x;
	y = _vertex->y;
}

void Vertex::moveX(int _x)
{
	x = _x;
}

void Vertex::moveY(int _y)
{
	y = _y;
}


//Line
Line::Line()
{
}

Line::Line(Vertex* _start, Vertex* _end)
{
	start->setVertex(_start);
	end->setVertex(_end);
}


void Line::moveStart(Vertex* _start) {
	start->setVertex(_start);
}
void Line::moveEnd(Vertex* _end) {
	end->setVertex(_end);
}

//Openings
Openings::Openings()
{
}

Openings::Openings(Line * _line, int _length)
{
	line = line;
	length = _length;
}

void Openings::moveOpening(Line * _line)
{
	line = _line;
}

void Openings::setLength(int _length)
{
	length = _length;
}


//Window
Window::Window()
{
}

//Door
Door::Door()
{
}

//Wall
Wall::Wall()
{
}

void Wall::addDoor(Door *)
{
}

void Wall::addWindow(Window *)
{
}

//Polygon
Polygon::Polygon()
{
}

void Polygon::addLine(Line *)
{
}

void Polygon::addVecLine(vector<Line*>)
{
}

//Room
Room::Room()
{
}

Room::Room(vector<Line*>*)
{

}

bool Room::checkClosure()
{
	return false;
}

//Furniture
Furniture::Furniture()
{
}