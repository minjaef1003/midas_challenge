#pragma once
#include <vector>
#include <string>

using namespace std;

class Vertex;
class Line;
class Openings;
class Polygon;
class Room;
class Object;

//Vertex
class Vertex
{
private:
	double x;
	double y;
public:
	Vertex();
	Vertex(double, double);
	~Vertex();
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
	~Line();
	void moveStart(Vertex*);
	void moveEnd(Vertex*);
	void addOpenings(Openings*);
};

//Wall
class Wall
{
private:
	vector<Openings*> openings;
public:
	Wall();
	~Wall();
};

//Openings
class Openings
{
private:
	
public:
	Openings();
	~Openings();
};

//Window

//Door

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
};

//object
class Object : public Polygon
{
private:
	string imageAddress;
	string lable;
public:
	Object();
	~Object();
};

