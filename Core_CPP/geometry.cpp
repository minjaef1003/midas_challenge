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

Line::Line(Line * _line)
{
	setLine(_line);
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

void Line::setLine(Line * _line)
{
	start->setVertex(_line->start);
	end->setVertex(_line->end);
}

//Window
Window::Window()
{
}

Window::Window( Wall * _wall, Line * _line)
{
	setLine(_line);
	parent = _wall;
}

void Window::moveLine(Line* _line)
{
	setLine(_line);
}

void Window::moveParent(Wall * _wall, Line * _line)
{
	parent = _wall;
	setLine(_line);
}

//Door
Door::Door()
{
}

Door::Door(Wall * _wall, Line * _line)
{
	setLine(_line);
	parent = _wall;

}

void Door::moveLine(Line * _line)
{
	setLine(_line);
}

void Door::moveParent(Wall * _wall, Line * _line)
{
	parent = _wall;
	setLine(_line);
}

//Wall
Wall::Wall()
{
}

void Wall::addDoor(Door * _door)
{
	doors.push_back(_door);
}

void Wall::addWindow(Window * _window)
{
	windows.push_back(_window);
}

//Polygon
Polygon::Polygon()
{
}

void Polygon::addLine(Line *)
{
}

void Polygon::addVecLine(vector<Line*> _vecLine)
{
	vecLine = _vecLine;
}

//Room
Room::Room()
{
}

Room::Room(vector<Wall*>& _vecLine)
{
	for (Wall* wl : _vecLine) {
		vecLine.push_back((Line*)wl);
	}
}

bool Room::checkClosure()
{

	return false;
}

//Furniture
Furniture::Furniture()
{
}