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
	Vertex(Vertex*);
	
	void setX(int _x);
	void setY(int _y);
	int getX();
	int getY();
	
	void setVertex(Vertex*);
};

//Line
class Line
{
protected:
	Vertex * start;
	Vertex * end;
	double length;
public:
	Line();
	Line(Line*);
	Line(Vertex*, Vertex*);
	
	void setStart(Vertex*);
	void setEnd(Vertex*);
	Vertex* getStart();
	Vertex* getEnd();
	
	void setLine(Line*);
	double getLength();
};

//Window
class Window : public Line
{
private:
	Wall * parent;
public:
	Window();
	Window(Wall*, Line*);
	
	Wall* getParent();
	void setParent(Wall*, Line*);
};

//Door
class Door : public Line
{
	//문은 항상 왼쪽으로 열린다.
private:
	Wall * parent;
public:
	Door();
	Door(Wall*, Line*);

	void setParent(Wall*, Line*);
};

//Wall
class Wall : public Line
{
private:
	vector<Window*> windows;
	vector<Door*> doors;
public:
	Wall();
	Wall(Line*);
	Wall(Vertex*, Vertex*);
	Wall(Line*, vector<Window*>);
	Wall(Line*, vector<Door*>);

	vector<Window*> getWindows();
	vector<Door*> getDoors();
	void setWindows(vector<Window*>);
	void setDoors(vector<Door*>);

	void addDoor(Door*);
	void addWindow(Window*);
	void deleteDoor(Door*);
	void deleteWindow(Window*);
	bool isEmptyDoor();
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
	void deleteLine(Line*);
	void setVecLine(vector<Line*>);
	vector<Line*> getVecLine();

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

