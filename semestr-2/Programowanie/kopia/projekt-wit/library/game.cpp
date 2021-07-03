#include "game.h"

bool win = false;
bool defeat = false;

void set_win()
{
	win = true;
}

bool get_win()
{
	return win;
}

void set_defeat()
{
	defeat = true;
}

bool get_defeat()
{
	return defeat;
}

bool game_end()
{
	return win;
}


