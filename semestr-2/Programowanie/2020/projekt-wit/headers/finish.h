#pragma once
#include "object.h"

/// <summary>
/// Klasa obiektu mety. Wyświetla rysunek flagi końcowej.
/// </summary>
class FinishLine : public Object
{
public:
	FinishLine(double x, double y)
	{
		position = Vec(x, y);
	}

	bool is_pixel_visible(double x, double y) override;
	char get_pixel_type(double x, double y) override;
	int get_pixel_color(double x, double y) override { return 0x0008; }
};
