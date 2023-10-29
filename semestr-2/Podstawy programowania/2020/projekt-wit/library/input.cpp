#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <winuser.h>
#include "input.h"

unsigned int key_bytes;

/// <summary>
/// Funkcja zwraca informację o stanie przyciśniecia podanego klawisza.
/// </summary>
/// <param name="key"></param>
/// <returns></returns>
bool get_input(InputEnum key)
{
	// Użyłem tu czarnej magii z przesunieciami bitowymi której tak naprawdę nie rozumiem.
	return (key_bytes >> (static_cast<int>(key) - 1)) & 0x1;
}

/// <summary>
/// Funkcja sprawdza które klawisze są przyciśnięte i zapamiętuje je w zmiennej.
/// </summary>
void input()
{
	key_bytes = 0;
	if (GetKeyState(VK_UP) & 0x8000 || GetKeyState('W') & 0x8000)
	{
		key_bytes |= 0x1;
	}
	if (GetKeyState(VK_DOWN) & 0x8000 || GetKeyState('S') & 0x8000)
	{
		key_bytes |= 0x2;
	}
	if (GetKeyState(VK_LEFT) & 0x8000 || GetKeyState('A') & 0x8000)
	{
		key_bytes |= 0x4;
	}
	if (GetKeyState(VK_RIGHT) & 0x8000 || GetKeyState('D') & 0x8000)
	{
		key_bytes |= 0x8;
	}
}
