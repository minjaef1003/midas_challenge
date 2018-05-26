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

Vertex::Vertex(Vertex * _vertex)
{
	x = _vertex->x;
	y = _vertex->y;
}

void Vertex::setX(int _x)
{
	x = _x;
}

void Vertex::setY(int _y)
{
	y = _y;
}

int Vertex::getX()
{
	return x;
}

int Vertex::getY()
{
	return y;
}

void Vertex::setVertex(Vertex* _vertex) {
	x = _vertex->x;
	y = _vertex->y;
}


//Line
Line::Line()
{
}

Line::Line(Line * _line)
{
	start->setVertex(_line->start);
	end->setVertex(_line->end);
}

Line::Line(Vertex* _start, Vertex* _end)
{
	start->setVertex(_start);
	end->setVertex(_end);
}

void Line::setStart(Vertex * _start)
{
	start->setVertex(_start);
}

void Line::setEnd(Vertex * _end)
{
	end->setVertex(_end);
}

Vertex* Line::getStart()
{
	return start;
}

Vertex* Line::getEnd()
{
	return end;
}

void Line::setLine(Line * _line)
{
	setStart(_line->start);
	setEnd(_line->end);
}

double Line::getLength()
{
	return sqrt((end->getX() - start->getX())*(end->getX() - start->getX()) + (end->getY() - start->getY)*(end->getY() - start->getY));
}


//Window
Window::Window()
{
}

Window::Window( Wall * _wall, Line * _line):Line(_line)
{
	parent = _wall;
}

Wall* Window::getParent()
{
	return parent;
}

void Window::setParent(Wall * _wall, Line * _line)
{
	parent = _wall;
	setLine(_line);
}

//Door
Door::Door()
{
}

Door::Door(Wall * _wall, Line * _line):Line(_line)
{
	parent = _wall;

}

void Door::setParent(Wall * _wall, Line * _line)
{
	parent = _wall;
	setLine(_line);
}

//Wall
Wall::Wall()
{
}

Wall::Wall(Line * _line):Line(_line)
{
}

Wall::Wall(Vertex * _start, Vertex * _end):Line(_start,_end)
{
}

Wall::Wall(Line * _line, vector<Window*> _windows):Line(_line)
{
	for (Window* window : _windows) {
		windows.push_back(window);
	}
}

Wall::Wall(Line * _line, vector<Door*> _doors):Line(_line)
{
	for (Door* door : _doors) {
		doors.push_back(door);
	}
}

vector<Window*> Wall::getWindows()
{
	return windows;
}

vector<Door*> Wall::getDoors()
{
	return doors;
}

void Wall::setWindows(vector<Window*> _windows)
{
	windows.assign();
}

void Wall::addDoor(Door * _door)
{
	doors.push_back(_door);
}

void Wall::addWindow(Window * _window)
{
	windows.push_back(_window);
}

void Wall::deleteDoor(Door * _door)
{
	vector<Door*>::iterator it = find(doors.begin(), doors.end(), _door);
	if (it != doors.end())
		doors.erase(it);
}

void Wall::deleteWindow(Window * _window)
{
	vector<Window*>::iterator it = find(windows.begin(), windows.end(), _window);
	if (it != windows.end())
		windows.erase(it);
}

bool Wall::isEmptyDoor()
{
	bool isEmpty = false;
	if (doors.empty()) isEmpty = true;
	return isEmpty;
}

//Polygon
Polygon::Polygon()
{
}

void Polygon::addLine(Line * _line)
{
	vecLine.push_back(_line);
}

void Polygon::addVecLine(vector<Line*> _vecLine)
{
	for (Line * line : _vecLine) {
		vecLine.push_back(line);
	}
}

void Polygon::deleteLine(Line * _line)
{
	vector<Line*>::iterator it = find(vecLine.begin(), vecLine.end(), _line);
	if (it != vecLine.end())
		vecLine.erase(it);
}

void Polygon::setVecLine(vector<Line*> _vecLine)
{
	vecLine = _vecLine;
}

vector<Line*> Polygon::getVecLine()
{
	return vecLine;
}

//Room
Room::Room()
{
}

Room::Room(vector<Wall*>& _vecLine)
{
	for (Wall* wall : _vecLine) {
		vecLine.push_back((Line*)wall);
	}
}

bool Room::checkClosure()
{
	bool closure = true;
	for (Line* wall : vecLine) {
		if (!(((Wall*)wall)->isEmptyDoor())) {
			closure = false;
			break;
		}
	}

	return closure;
}

//Furniture
Furniture::Furniture()
{
}