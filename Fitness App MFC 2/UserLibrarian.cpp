#include "pch.h"
#include "UserLibrarian.h"
#include "CNewAccountDlg.h"

#include <fstream>

UserLibrarian::UserLibrarian(void)
{

}

UserLibrarian::~UserLibrarian(void)
{
}


//Saves the userHeightVar to a file
void UserLibrarian::recordStats(string sumCalIntake, string sumHoursSlept, string sumCupsWater,
	string piHeight, string piHeightInch, string piWeight, string piGender, string piAge, string piWeeklyGoal,
	string tdToDo, string tdToDo2, string tdToDo3, string tdToDo4, string tdToDo5, string tdNewHoursSlept,
	string wlCalMonday, string wlCalTuesday, string wlCalWednesday, string wlCalThursday, string wlCalFriday, string wlCalSaturday, string wlCalSunday, string wlCalTotalBurned, string wlCalWeeklyGoal, string wlCalPercentGoal)
{
	ofstream outFile;
	//outFile.open("User.txt"); //name of the file you want to open
	outFile.open(usernameTXT);

	outFile << sumCalIntake << "\n";
	outFile << sumHoursSlept << "\n";
	outFile << sumCupsWater << "\n";

	outFile << piHeight << "\n";
	outFile << piHeightInch << "\n";
	outFile << piWeight << "\n";
	outFile << piGender << "\n";
	outFile << piAge << "\n";
	outFile << piWeeklyGoal << "\n";

	outFile << tdToDo << "\n";
	outFile << tdToDo2 << "\n";
	outFile << tdToDo3 << "\n";
	outFile << tdToDo4 << "\n";
	outFile << tdToDo5 << "\n";
	outFile << tdNewHoursSlept << "\n";

	outFile << wlCalMonday << "\n";
	outFile << wlCalTuesday << "\n";
	outFile << wlCalWednesday << "\n";
	outFile << wlCalThursday << "\n";
	outFile << wlCalFriday << "\n";
	outFile << wlCalSaturday << "\n";
	outFile << wlCalSunday << "\n";
	outFile << wlCalTotalBurned << "\n";
	outFile << wlCalWeeklyGoal << "\n";
	outFile << wlCalPercentGoal << "\n";

	outFile.close();
}
