#include "ai_car.h"
#include "display.h"
#include "input.h"
#include "update.h"
#include "car.h"
#include "camera.h"
#include "finish.h"
#include "speedway.h"

/// <summary>
/// Funkcja główna gry.
/// </summary>
/// <returns></returns>
int main()
{
	// Tworzę główny tor gry.
	// (Tworzenie każdego elementu potomnego Object powoduje zarejestrowanie go na liście obiektów).

	auto* speedway = new Speedway(-1000, 0, 1000, 30);
	// Tworzę samochód gracza.
	auto* car = new Car(6, 0);

	// Tworzę zestaw samochodów sterowanych przez komputer.
	// Parametry to - pozycja początkowa x,y, T - odwrotność funkcji prędkości, kolor, R - promień toru ruchu.
	auto* ai_car1 = new AiCar(18, 0, 11, 0x0001, 1020);
	auto* ai_car2 = new AiCar(18, 10, 12, 0x0002, 1020);
	auto* ai_car3 = new AiCar(6, 10, 13, 0x0003, 1020);
	auto* ai_car4 = new AiCar(18, 20, 12, 0x0006, 1020);
	auto* ai_car5 = new AiCar(6, 20, 13, 0x0005, 1000);

	// Samochód gracza jest zależny od położenia względem toru wyścigowego.
	car->set_speedway(speedway);

	// Dodaję kolizję z samochodami AI.
	car->add_collider(ai_car1);
	car->add_collider(ai_car2);
	car->add_collider(ai_car3);
	car->add_collider(ai_car4);
	car->add_collider(ai_car5);

	// Tworzę kamerę zorientowaną na gracza.
	auto* camera = new Camera(car, 10);

	// Tworzę element flagi finiszu.
	auto* finish = new FinishLine(-6, -55);

	// Główna pętla gry.
	while (true)
	{
		//Pobranie danych wejściowych od użytkownika.
		input();
		// Aktualizacja stanu gry.
		update();
		// Wyświetlenie gry na ekranie.
		show(camera);
	}
}
