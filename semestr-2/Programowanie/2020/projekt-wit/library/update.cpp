#include "update.h"
#include "object.h"

#include <chrono>
using namespace std::chrono;

/// <summary>
/// Skrótowiec zwracający aktualną liczbę milisekund.
/// </summary>
/// <returns></returns>
int64_t get_time()
{
	return std::chrono::duration_cast<milliseconds>(system_clock::now().time_since_epoch()).count();
}

int64_t t0 = get_time();

/// <summary>
/// Aktualizuje stan gry. Funkcja przebiega po wszystkich zerejestrowanych obiektach i kolejno wywołuje ich metody update.
/// </summary>
void update()
{
	int64_t t1 = get_time();
	double dt = (t1 - t0) / 1000.;
	t0 = t1;

	std::vector<Object*> objects = get_all_objects();
	for (auto it = objects.begin(); it != objects.end(); ++it)
	{
		(*it)->update(dt);
	}
}
