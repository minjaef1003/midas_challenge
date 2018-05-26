#include "geometry.h"



Openings::Openings()
{
}

Openings::Openings(Line * _line, double _length)
{
	line = line;
	length = _length;
}

void Openings::moveOpening(Line * _line)
{
	line = _line;
}

void Openings::setLength(double _length)
{
	length = _length;
}
