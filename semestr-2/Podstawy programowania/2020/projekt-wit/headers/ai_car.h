#pragma once
#include "car.h"

/// <summary>
/// Klasa samochodu AI.
/// </summary>
class AiCar : public Car
{
	bool allow_defeat = false;
	double t = 0;
	double init_x, init_y;
	double T = 12;
	int color = 0x0006;
	double R = 1020;
public:
	/// <summary>
	/// Czy samochód jest aktywny?
	/// </summary>
	bool is_active = false;

	/// <summary>
	/// Konstruktor samochodu.
	/// </summary>
	/// <param name="x">Położenie początkowe x.</param>
	/// <param name="y">Położenie początkowe y.</param>
	/// <param name="T">Okres ruchu po okręgu.</param>
	/// <param name="color">Kolor samochodu.</param>
	/// <param name="R">Promień koła ruchu samochodu.</param>
	/// <returns></returns>
	AiCar(double x, double y,double T=12, int color=0x0006, double R=1020): Car(x, y)
	{
		this->R = R;
		this->T = T;
		this->color = color;
		init_x = x;
		init_y = y;
	}

	/// <summary>
	/// Funkcja aktualizująca stan samochodu.
	/// </summary>
	/// <param name="dt"></param>
	void update(double dt) override;

	/// <summary>
	/// Funkcja barwy samochodu.
	/// </summary>
	/// <param name="x">Współrzędna x.</param>
	/// <param name="y">Współrzędna y.</param>
	/// <returns></returns>
	int get_pixel_color(double x, double y) override { return color; }
};
