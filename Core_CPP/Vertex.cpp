#include "geometry.h"

Vertex::Vertex()
{
}

Vertex::Vertex(double _x, double _y)
{
	x = _x;
	y = _y;
}

void Vertex::setVertex(Vertex* _vertex) {
	x = _vertex->x;
	y = _vertex->y;
}

void Vertex::moveX(double _x)
{
	x = _x;
}

void Vertex::moveY(double _y)
{
	y = _y;
}
