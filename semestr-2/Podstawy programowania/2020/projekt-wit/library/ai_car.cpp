#include "ai_car.h"
#include "game.h"

void AiCar::update(double dt)
{

	if (!is_active)return;

	if (position.x < -50 && position.y < -50) { allow_defeat = true; }
	if(allow_defeat && position.y < -40 && position.y>-50)
	{
		set_defeat();
	}
	
	t += dt;

	double x0 = -R + init_x;
	double y0 = init_y;
	//T -= 0.001 * dt;
	double t2 = t;

	double x = x0 + R * cos(t2 / T);
	double y = y0 + R * sin(t2 / T);

	this->position.x = x;
	this->position.y = y;

	this->rotation = -t2 / T;
}
