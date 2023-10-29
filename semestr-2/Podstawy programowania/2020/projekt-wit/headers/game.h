#pragma once

/// <summary>
/// Ustawia zwycięstwo.
/// </summary>
void set_win();

/// <summary>
/// Pobiera informację o zwycięstwie.
/// </summary>
/// <returns></returns>
bool get_win();

/// <summary>
/// Ustawia porażkę.
/// </summary>
void set_defeat();

/// <summary>
/// Pobiera informację o porażce.
/// </summary>
/// <returns></returns>
bool get_defeat();

bool game_end();