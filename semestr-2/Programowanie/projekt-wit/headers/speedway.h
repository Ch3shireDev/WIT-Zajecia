#pragma once
#include "object.h"

/// <summary>
/// Klasa toru wyścigowego.
/// </summary>
class Speedway : public Object
{
	double get_r2(double x, double y);
	double get_r(double x, double y);
public:
	double r1 = 50;
	double r2 = 100;

	bool is_pixel_visible(double x, double y) override;
	char get_pixel_type(double x, double y) override;

	Speedway(double x, double y, double r1, double dr2);

	/// <summary>
	/// Pozwala na sprawdzenie czy dana pozycja należy do toru.
	/// </summary>
	/// <param name="position"></param>
	/// <returns></returns>
	int is_on_track(Vec position);
};
