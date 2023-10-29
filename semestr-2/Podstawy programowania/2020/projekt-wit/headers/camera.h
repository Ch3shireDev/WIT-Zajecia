#pragma once
#include "object.h"

/// <summary>
/// Obiekt kamery - nie jest nigdzie rysowany, jego zadaniem jest podążać za wybranym obiektem
/// i przekazywać informacje o wyświetlaniu do funkcji display.
/// </summary>
class Camera : public Object
{
	Object* object;
public:
	double camera_margin = 2;
	double camera_scale = 10;
	Camera(Object* object, double scale = 0.1);

	void update(double dt) override;
};
