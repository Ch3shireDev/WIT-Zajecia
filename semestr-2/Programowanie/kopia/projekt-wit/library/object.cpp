#include "object.h"

#include <algorithm>
#include <vector>
using namespace std;

vector<Object*> Objects = vector<Object*>();

bool sort_by_z(Object* a, Object* b)
{
	return (a)->z_index > (b)->z_index;
}

void register_object(Object* object)
{
	Objects.push_back(object);

	sort(Objects.begin(), Objects.end(), sort_by_z);
}

void unregister_object(Object* object)
{
	vector<Object*>::iterator it;
	for (it = Objects.begin(); it != Objects.end(); ++it)
	{
		if ((*it) != object)
			continue;

		Objects.erase(it);
		return;
	}
}

vector<Object*>& get_all_objects()
{
	return Objects;
}
