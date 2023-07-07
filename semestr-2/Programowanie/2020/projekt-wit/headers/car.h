#pragma once
#include "object.h"

class AiCar;
class Speedway;

/// <summary>
/// Klasa samochodu gracza. Sterowany bezpośrednio.
/// </summary>
class Car : public Object
{
	Speedway* speedway = nullptr;
	//Car* collider = nullptr;
	double velocity = 0;
	std::vector<Car*> colliders = std::vector<Car*>();
public:
	Car(double x, double y, double width = 3, double height = 5);
	void update(double dt) override;
	char get_pixel_type(double x, double y) override { return '*'; }
	int get_pixel_color(double x, double y) override { return 0x0004; }
	void set_speedway(Speedway* speedway);
	void add_collider(Car* ai_car);
};
