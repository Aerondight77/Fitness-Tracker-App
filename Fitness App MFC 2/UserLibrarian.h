#pragma once
#include <string>
using namespace std;

class UserLibrarian
{
public:
	UserLibrarian(void);
	~UserLibrarian(void);

	void recordStats(string sumCalIntake, string sumHoursSlept, string sumCupsWater,
		string piHeight, string piHeightInch, string piWeight, string piGender, string piAge, string piWeeklyGoal,
		string tdToDo, string tdToDo2, string tdToDo3, string tdToDo4, string tdToDo5, string tdNewHoursSlept,
		string wlCalMonday, string wlCalTuesday, string wlCalWednesday, string wlCalThursday, string wlCalFriday, string wlCalSaturday, string wlCalSunday, string wlCalTotalBurned, string wlCalWeeklyGoal, string wlCalPercentGoal);
};

