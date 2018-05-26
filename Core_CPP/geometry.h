#pragma once
#include <vector>
#include <string>

using namespace std;

class Vertex;
class Line;
class Openings;
class Window;
class Door;
class Wall;
class Polygon;
class Room;
class Furniture;

//Vertex
class Vertex
{
private:
	double x;
	double y;
public:
	Vertex();
	Vertex(double, double);
	void setVertex(Vertex*);
	void moveX(double);
	void moveY(double);

};

//Line
class Line
{
private:
	Vertex * start;
	Vertex * end;
public:
	Line();
	Line(Vertex*, Vertex*);
	void moveStart(Vertex*);
	void moveEnd(Vertex*);
};

//Openings
class Openings
{
private:
	Line * line;
	double length;
public:
	Openings();
	Openings(Line*, double);
	void moveOpening(Line*);
	void setLength(double);
};

//Window
class Window : Openings
{
private:

public:
	Window();
	~Window();
};

//Door
class Door : Openings
{
private:

public:
	Door();
	~Door();
};

//Wall
class Wall
{
private:
	Line * line;
	vector<Openings*> windows;
	vector<Openings*> doors;
public:
	Wall();
	~Wall();
	void addDoor(Door*);
	void addWindow(Window*);
};

//Polygon
class Polygon
{
private:
	vector<Line*> vecLine;
public:
	Polygon();
	~Polygon();
};

//Room
class Room : public Polygon
{
private:
	
public:
	Room();
	~Room();
	bool checkClosure();
};

//Furniture
class Furniture : Polygon
{
private:

public:
	Furniture();
	~Furniture();
};

