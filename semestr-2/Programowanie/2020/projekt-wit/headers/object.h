#pragma once
#include <vector>
#include <cmath>

class Object;

/// <summary>
/// Rejestrowanie obiektu na liście obiektów do wyświetlania.
/// </summary>
/// <param name="object"></param>
void register_object(Object* object);

/// <summary>
/// Wyrejestrowanie obiektu z listy obiektów do wyświetlania.
/// </summary>
/// <param name="object"></param>
void unregister_object(Object* object);

/// <summary>
/// Zwraca listę wszystkich zarejestrowanych obiektów.
/// </summary>
/// <returns></returns>
std::vector<Object*>& get_all_objects();

/// <summary>
/// Struktura pomocnicza wektora - zawiera współrzędne x,y.
/// </summary>
struct Vec
{
	double x = 0;
	double y = 0;

	Vec()
	{
	}

	Vec(double x, double y) : x(x), y(y)
	{
	}
};

/// <summary>
/// Klasa bazowa wszystkich elementów gry.
/// </summary>
class Object
{
protected:
	Vec position = Vec();
	double velocity_x = 0;
	double velocity_y = 0;
	double force_x = 0;
	double force_y = 0;

public:
	double rotation = 0;

	double width = 2;
	double height = 4;

	bool is_visible = true;
	bool is_static = false;

	int z_index = 0;

	Object(double x = 0, double y = 0)
	{
		position.x = x;
		position.y = y;
		register_object(this);
	}

	virtual ~Object()
	{
		unregister_object(this);
	}

	virtual void update(double dt)
	{
	}

	Vec get_position()
	{
		return position;
	}

	double distance(double x, double y)
	{
		double dx = x - position.x;
		double dy = y - position.y;
		return sqrt(dx * dx + dy * dy);
	}

	virtual bool is_pixel_visible(double x, double y)
	{
		if (!is_visible)return false;

		double dx = position.x - x;
		double dy = position.y - y;

		double dx2 = cos(rotation) * dx - sin(rotation) * dy;
		double dy2 = sin(rotation) * dx + cos(rotation) * dy;

		if (abs(dx2) > width / 2)return false;
		if (abs(dy2) > height / 2)return false;
		return true;
	}

	virtual char get_pixel_type(double x, double y) { return '*'; }

	virtual int get_pixel_color(double x, double y) { return 0x0008; }
};
