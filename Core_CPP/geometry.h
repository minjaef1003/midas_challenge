#pragma once
#include <vector>
#include <string>

using namespace std;

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
	vector<Openings*> openings;
public:
	Line();
	Line(Vertex*, Vertex*);
	~Line();
	void moveStart(Vertex*);
	void moveEnd(Vertex*);
	
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

class Openings
{
private:

public:
	Openings();
	~Openings();
};


