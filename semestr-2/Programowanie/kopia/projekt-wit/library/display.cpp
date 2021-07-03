#include "display.h"
#include "object.h"
#include <string>
#include "game.h"
#include <ctime>
#include <iostream>
#include <windows.h>

#include "camera.h"

using namespace std;

void ShowConsoleCursor(bool);
void show_screen(Camera* camera);

void show(Camera* camera)
{
	ShowConsoleCursor(false);
	show_screen(camera);
}

/// <summary>
/// Funkcja pomocnicza do schowania mrygającego kursora.
/// </summary>
/// <param name="showFlag"></param>
void ShowConsoleCursor(bool showFlag)
{
	HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO cursorInfo;
	GetConsoleCursorInfo(out, &cursorInfo);
	cursorInfo.bVisible = showFlag;
	SetConsoleCursorInfo(out, &cursorInfo);
}

char get_pixel_symbol_on_pos(vector<Object*>, double, double);
int get_pixel_color_on_pos(const vector<Object*>& vector, double x, double y);

int frames = 0;
int fps = 0;
time_t last_time = 0;


auto hOutput = static_cast<HANDLE>(GetStdHandle(STD_OUTPUT_HANDLE));

const int SCREEN_WIDTH = 120;
const int SCREEN_HEIGHT = 30;

COORD dwBufferSize = {SCREEN_WIDTH, SCREEN_HEIGHT};
COORD dwBufferCoord = {0, 0};
SMALL_RECT rcRegion = {0, 0, SCREEN_WIDTH - 1, SCREEN_HEIGHT - 1};
CHAR_INFO buffer[SCREEN_HEIGHT][SCREEN_WIDTH];

/// <summary>
/// Funkcja główna wyświetlania na ekranie. Dzieje się tu dużo czarnej magii, ale fundamentalnie aktualizowany i wyświetlany jest bufor znaków razem z ich kolorami.
/// </summary>
/// <param name="camera">Obiekt kamery - pozwala na ustalenie zakresu i pozycji wyświetlania.</param>
void show_screen(Camera* camera)
{
	// (nie wiem co to robi, ale przyspiesza wyświetlanie)
	ios_base::sync_with_stdio(false);

	auto objects = get_all_objects();

	ReadConsoleOutput(hOutput, reinterpret_cast<CHAR_INFO*>(buffer), dwBufferSize,
	                  dwBufferCoord, &rcRegion);

	Vec pos = camera->get_position();
	//string buff2;

	// Parametry rozmiaru ekranu. Ponieważ znaki ascii różnią się wysokością i szerokością, dobrałem parametry do odpowiedniego przedstawiania pola gry.
	double width_unit = 5 / camera->camera_scale;
	double height_unit = 12 / camera->camera_scale;


	// Uzupełnianie bufora.
	for (int i = 0; i < SCREEN_HEIGHT; i++)
	{
		double y = pos.y + height_unit * (SCREEN_HEIGHT * 1. - i * 1.) - height_unit * SCREEN_HEIGHT / 2.;
		for (int j = 0; j < SCREEN_WIDTH; j++)
		{
			double x = pos.x + j * width_unit - width_unit * SCREEN_WIDTH / 2;
			char pixel = get_pixel_symbol_on_pos(objects, x, y);
			int color = get_pixel_color_on_pos(objects, x, y);
			//buff2 += pixel;
			buffer[i][j].Char.AsciiChar = pixel;
			buffer[i][j].Attributes = color;
		}
		//buff2 += '\n';
	}

	//frames += 1;
	//time_t t = time(nullptr);
	//if (t - last_time > 0)
	//{
	//	fps = frames;
	//	frames = 0;
	//	last_time = t;
	//}

	//string fps_str = to_string(fps);
	////buff2[(SCREEN_HEIGHT - 1) * (SCREEN_WIDTH + 1)] = fps_str[0];
	////if (fps_str.length() > 1)
	////{
	////	buff2[(SCREEN_HEIGHT - 1) * (SCREEN_WIDTH + 1) + 1] = fps_str[1];
	////}

	//buffer[SCREEN_HEIGHT - 1][0].Char.AsciiChar = fps_str[0];
	//if (fps_str.length() > 1)
	//	buffer[SCREEN_HEIGHT - 1][1].Char.AsciiChar = fps_str[1];

	//fwrite(buff2.c_str(), buff2.length(), 1, stderr);

	if (game_end())
	{
		for (int i = 0; i < SCREEN_HEIGHT; i++)
		{
			for (int j = 0; j < SCREEN_WIDTH; j++)
			{
				buffer[i][j].Char.AsciiChar = ' ';
				buffer[i][j].Attributes = 0x000007;
			}
		}
		string message;
		if (get_win() && !get_defeat()) message = "WYGRANA! GRATULACJE!";
		else message = "PRZEGRANA! SPROBUJ JESZCZE RAZ!";

		for (int i = 0; i < message.length(); i++)
		{
			buffer[15][60 - message.length() / 2 + i].Char.AsciiChar = message[i];
		}
	}


	WriteConsoleOutput(hOutput, reinterpret_cast<CHAR_INFO*>(buffer), dwBufferSize, dwBufferCoord, &rcRegion);
}

/// <summary>
/// Zwraca rodzaj piksela na danej pozycji.
/// </summary>
/// <param name="objects"></param>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
char get_pixel_symbol_on_pos(vector<Object*> objects, double x, double y)
{
	for (auto it = objects.begin(); it != objects.end(); ++it)
	{
		if ((*it)->is_pixel_visible(x, y))
		{
			return (*it)->get_pixel_type(x, y);
		}
	}
	return ' ';
}

/// <summary>
/// Zwraca kolor piksela na danej pozycji.
/// </summary>
/// <param name="objects"></param>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
int get_pixel_color_on_pos(const vector<Object*>& objects, double x, double y)
{
	for (auto it = objects.begin(); it != objects.end(); ++it)
	{
		if ((*it)->is_pixel_visible(x, y))
		{
			//return 0;
			return (*it)->get_pixel_color(x, y);
		}
	}
	return 0;
}
