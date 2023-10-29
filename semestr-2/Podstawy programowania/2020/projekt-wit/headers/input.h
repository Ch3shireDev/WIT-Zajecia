#pragma once

/// <summary>
/// Prosty enumerator po klawiszach. Stosowane są jednocześnie WSAD oraz strzałki.
/// </summary>
enum class InputEnum
{
	NONE,
	UP_ARROW,
	DOWN_ARROW,
	LEFT_ARROW,
	RIGHT_ARROW
};

/// <summary>
/// Funkcja pobierająca dane wejściowe (przyciśnięte klawisze) od gracza.
/// </summary>
void input();

/// <summary>
/// Funkcja zwracająca informację o stanie klawisza (przyciśnięty lub nie).
/// </summary>
/// <param name="key">Rodzaj klawisza.</param>
/// <returns>Czy klawisz jest przyciśnięty?</returns>
bool get_input(InputEnum key);
