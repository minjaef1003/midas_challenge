#pragma once
#include <vector>
#include <string>

using namespace std;

class Vertex;
class Line;
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
protected:
	Vertex * start;
	Vertex * end;
public:
	Line();
	Line(Line*);
	Line(Vertex*, Vertex*);
	void moveStart(Vertex*);
	void moveEnd(Vertex*);
	void setLine(Line*);
};

//Window
class Window : public Line
{
private:
	Wall * parent;
public:
	Window();
	Window(Wall*, Line*);
	void moveLine(Line*);
	void moveParent(Wall*, Line*);
};

//Door
class Door : public Line
{
private:
	Wall * parent;
public:
	Door();
	Door(Wall*, Line*);
	void moveLine(Line*);
	void moveParent(Wall*, Line*);
};

//Wall
class Wall : public Line
{
private:
	vector<Window*> windows;
	vector<Door*> doors;
public:
	Wall();
	void addDoor(Door*);
	void addWindow(Window*);
};

//Polygon
class Polygon
{
protected:
	vector<Line*> vecLine;
public:
	Polygon();
	void addLine(Line*);
	void addVecLine(vector<Line*>);
	vector<Line*> printVecLine();

};

//Room
class Room : public Polygon
{
private:
	
public:
	Room();
	Room(vector<Wall*>&);
	bool checkClosure();
};

//Furniture
class Furniture : public Polygon
{
private:

public:
	Furniture();
};

