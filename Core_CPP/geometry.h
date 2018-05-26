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
	int x;
	int y;
public:
	Vertex();
	Vertex(int _x, int _y);
	void setVertex(Vertex*);
	void moveX(int);
	void moveY(int);

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
	int length;
public:
	Openings();
	Openings(Line*, int);
	void moveOpening(Line*);
	void setLength(int);
};

//Window
class Window : Openings
{
private:

public:
	Window();
};

//Door
class Door : Openings
{
private:

public:
	Door();
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
	void addLine(Line*);
	void addVecLine(vector<Line*>&);
};

//Room
class Room : public Polygon
{
private:
	
public:
	Room();
	Room(vector<Line*>&);
	bool checkClosure();
};

//Furniture
class Furniture : Polygon
{
private:

public:
	Furniture();
};

