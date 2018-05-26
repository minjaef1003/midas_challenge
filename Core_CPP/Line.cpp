#include "geometry.h"

Line::Line()
{
}

Line::Line(Vertex* _start, Vertex* _end)
{
	start->setVertex(_start);
	end->setVertex(_end);
}


Line::~Line()
{
}


void Line::moveStart(Vertex* _start) {
	start->setVertex(_start);
}
void Line::moveEnd(Vertex* _end) {
	end->setVertex(_end);
}
