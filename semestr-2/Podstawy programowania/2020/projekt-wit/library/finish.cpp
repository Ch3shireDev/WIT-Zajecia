#include "finish.h"

/// <summary>
/// Naprawdę nie chciało mi się tego ładować z png.
/// </summary>
const char flag[23][80] = {
	"**                                                                           **",
	"** ************************************************************************* **",
	"** ********       *********        *********       *********        ******** **",
	"** ********       *********        *********       *********        ******** **",
	"**         *******         ********        *********        ********         **",
	"**         *******         ********        *********        ********         **",
	"**         *******         ********        *********        ********         **",
	"** ********       *********        *********       *********        ******** **",
	"** ********       *********        *********       *********        ******** **",
	"** ********       *********        *********       *********        ******** **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **",
	"**                                                                           **"
};

bool FinishLine::is_pixel_visible(double x, double y)
{
	if (!is_visible)return false;

	double x0 = x - position.x;
	double y0 = y - position.y;

	if (x0 > 0 && x0 < 160 && y0 > 0 && y0 < 100)return true;
	return false;
}

char FinishLine::get_pixel_type(double x, double y)
{
	double x0 = (x - position.x) * 2;
	double y0 = y - position.y;

	int xx = static_cast<int>(x0);
	int yy = static_cast<int>(y0);

	if (xx < 0 || xx > 79 || yy < 0 || yy > 22)return ' ';
	return flag[22 - yy][xx];
}
