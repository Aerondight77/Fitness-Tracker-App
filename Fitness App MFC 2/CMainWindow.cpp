// CMainWindow.cpp : implementation file
//

#include "pch.h"
#include "Fitness App MFC 2.h"
#include "Fitness App MFC 2Dlg.h"
#include "CNewAccountDlg.h"
#include "CMainWindow.h"
#include "afxdialogex.h"

// added after project creation
#include <ctime>
#include <string>
#include "UserLibrarian.h"
#include <fstream>

using namespace std;


// CMainWindow dialog

IMPLEMENT_DYNAMIC(CMainWindow, CDialogEx)

CMainWindow::CMainWindow(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MAINWINDOW_DLG, pParent)
	, userHeightVar(_T(""))
	, userHeightInchVar(_T(""))
	, userWeightVar(_T(""))
	, userGenderVar(_T(""))
	, userAgeVar(_T(""))
	, userWeeklyGoalVar(_T(""))
	, toDo1Var(_T(""))
	, toDo2Var(_T(""))
	, toDo3Var(_T(""))
	, toDo4Var(_T(""))
	, toDo5Var(_T(""))
	, hoursSleptVar(_T(""))
	, calMondayVar(_T(""))
	, calTuesdayVar(_T(""))
	, calWednesdayVar(_T(""))
	, calThursdayVar(_T(""))
	, calFridayVar(_T(""))
	, calSaturdayVar(_T(""))
	, calSundayVar(_T(""))
	, calTotalBurnedVar(_T(""))
	, calWeeklyGoalVar(_T(""))
	, calPercentGoalVar(_T(""))
	, summaryCalIntakeVar(_T(""))
	, summaryHoursSleptVar(_T(""))
	, summaryCupsWaterVar(_T(""))
{

}

CMainWindow::~CMainWindow()
{
}

void CMainWindow::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, txtUserHeightFeet, userHeightVar);
	DDX_Text(pDX, txtUserHeightInch, userHeightInchVar);
	DDX_Text(pDX, txtUserWeight, userWeightVar);
	DDX_Text(pDX, txtUserGender, userGenderVar);
	DDX_Text(pDX, txtUserAge, userAgeVar);
	DDX_Text(pDX, txtUserWeeklyGoal, userWeeklyGoalVar);
	DDX_Text(pDX, txtToDo1, toDo1Var);
	DDX_Text(pDX, txtToDo2, toDo2Var);
	DDX_Text(pDX, txtToDo3, toDo3Var);
	DDX_Text(pDX, txtToDo4, toDo4Var);
	DDX_Text(pDX, txtToDo5, toDo5Var);
	DDX_Text(pDX, txtHoursSlept, hoursSleptVar);
	DDX_Text(pDX, txtMondayCals, calMondayVar);
	DDX_Text(pDX, txtTuesdayCals, calTuesdayVar);
	DDX_Text(pDX, txtWednesdayCals, calWednesdayVar);
	DDX_Text(pDX, txtThursdayCals, calThursdayVar);
	DDX_Text(pDX, txtFridayCals, calFridayVar);
	DDX_Text(pDX, txtSaturdayCals, calSaturdayVar);
	DDX_Text(pDX, txtSundayCals, calSundayVar);
	DDX_Text(pDX, txtTotalWeekCals, calTotalBurnedVar);
	DDX_Text(pDX, txtWeeklyGoal, calWeeklyGoalVar);
	DDX_Text(pDX, txtPercentGoal, calPercentGoalVar);
	DDX_Text(pDX, txtSummaryIntake, summaryCalIntakeVar);
	DDX_Text(pDX, txtSummaryHoursSlept, summaryHoursSleptVar);
	DDX_Text(pDX, txtSummaryCupsWater, summaryCupsWaterVar);
}


BEGIN_MESSAGE_MAP(CMainWindow, CDialogEx)
	ON_BN_CLICKED(btnUpdate, &CMainWindow::OnBnClickedbtnupdate)
	ON_BN_CLICKED(btnSaveToFile, &CMainWindow::OnBnClickedbtnsavetofile)
	ON_BN_CLICKED(btnLoadFromFile, &CMainWindow::OnBnClickedbtnloadfromfile)
END_MESSAGE_MAP()


// CMainWindow message handlers


void CMainWindow::OnBnClickedbtnupdate()
{
	// TODO: Add your control notification handler code here
	CString textInput;

	// ============ TODAY'S SUMMARY SECTION =============
	// Get Weekly Goals
	GetDlgItemText(txtUserWeeklyGoal, textInput);
	double dUserWeeklyGoal = _ttof(textInput);

	// ============ PERSONAL INFO SECTION =============

	// ============ TO-DO LIST SECTION =============

	// ============ HOUR'S SLEPT SECTION =============

	// ============ WORKOUT LOG SECTION =============
	GetDlgItemText(txtMondayCals, textInput);
	double dMondayCals = _ttof(textInput);
	GetDlgItemText(txtTuesdayCals, textInput);
	double dTuesdayCals = _ttof(textInput);
	GetDlgItemText(txtWednesdayCals, textInput);
	double dWednesdayCals = _ttof(textInput);
	GetDlgItemText(txtThursdayCals, textInput);
	double dThursdayCals = _ttof(textInput);
	GetDlgItemText(txtFridayCals, textInput);
	double dFridayCals = _ttof(textInput);
	GetDlgItemText(txtSaturdayCals, textInput);
	double dSaturdayCals = _ttof(textInput);
	GetDlgItemText(txtSundayCals, textInput);
	double dSundayCals = _ttof(textInput);

	// Add up the week's calories burned
	double dUserWeeklyCalTotal = dMondayCals + dTuesdayCals + dWednesdayCals + dThursdayCals + dFridayCals + dSaturdayCals + dSundayCals;

	string strWeeklyCalGoal = to_string(dUserWeeklyCalTotal);
	CString userCalGoal(strWeeklyCalGoal.c_str());
	SetDlgItemText(txtTotalWeekCals, userCalGoal);
	// Weekly Goal from Personal Info section
	string strWeeklyGoal = to_string(dUserWeeklyGoal);
	CString totalWeeklyGoal(strWeeklyGoal.c_str());
	SetDlgItemText(txtWeeklyGoal, totalWeeklyGoal);

	// % from Goal calculation
	double dPercentFromGoal = dUserWeeklyCalTotal / dUserWeeklyGoal * 100;
	string strPercentFromGoal = to_string(dPercentFromGoal);
	CString percentFromGoal(strPercentFromGoal.c_str());
	SetDlgItemText(txtPercentGoal, percentFromGoal);
}

// Function to Save to File
void CMainWindow::OnBnClickedbtnsavetofile()
{
	UpdateData(); // VERY IMPORTANT!!

	// Grab Variables as C-Strings
		//Today's Summary Section
	CString summaryCalIntake = summaryCalIntakeVar;
	CString summaryHoursSlept = summaryHoursSleptVar;
	CString summaryCupsWater = summaryCupsWaterVar;
		//Personal Info Section
	CString newHeightFeet = userHeightVar;
	CString newHeightInch = userHeightInchVar;
	CString newWeight = userWeightVar;
	CString newGender = userGenderVar;
	CString newAge = userAgeVar;
	CString userWeeklyGoal = userWeeklyGoalVar;
		//To-Do List Section
	CString newToDo1 = toDo1Var;
	CString newToDo2 = toDo2Var;
	CString newToDo3 = toDo3Var;
	CString newToDo4 = toDo4Var;
	CString newToDo5 = toDo5Var;
		//Hours Slept Section
	CString newHoursSlept = hoursSleptVar;
		//Workout Log Section
	CString newCalMonday = calMondayVar;
	CString newCalTuesday = calTuesdayVar;
	CString newCalWednesday = calWednesdayVar;
	CString newCalThursday = calThursdayVar;
	CString newCalFriday = calFridayVar;
	CString newCalSaturday = calSaturdayVar;
	CString newCalSunday = calSundayVar;
	CString newCalTotalBurned = calTotalBurnedVar;
	CString newCalWeeklyGoal = calWeeklyGoalVar;
	CString newCalPercentGoal = calPercentGoalVar;


	// convert CString to string, User Height Feet
	CT2CA ct (newHeightFeet);
	string strNewHeightFeet(ct);
	// convert CString to string, User Height Inch
	CT2CA ct2 (newHeightInch);
	string strNewHeightInch(ct2);
	// convert CString to string, User Weight
	CT2CA ct3 (newWeight);
	string strNewWeight(ct3);
	// convert CString to string, User Gender
	CT2CA ct4 (newGender);
	string strNewGender(ct4);
	// convert CString to string, User Age
	CT2CA ct5(newAge);
	string strNewAge(ct5);
	// convert CString to string, Weekly Goal 
	CT2CA ct6(userWeeklyGoal);
	string strWeeklyGoal(ct6);
	// ...and so on

	CT2CA ct7(newToDo1);
	string strToDol(ct7);
	CT2CA ct8(newToDo2);
	string strToDo2(ct8);
	CT2CA ct9(newToDo3);
	string strToDo3(ct9);
	CT2CA ct10(newToDo4);
	string strToDo4(ct10);
	CT2CA ct11(newToDo5);
	string strToDo5(ct11);
	CT2CA ct12(newHoursSlept);
	string strNewHoursSlept(ct12);

	CT2CA ct13(newCalMonday);
	string strNewCalMonday(ct13);
	CT2CA ct14(newCalTuesday);
	string strNewCalTuesday(ct14);
	CT2CA ct15(newCalWednesday);
	string strNewCalWednesday(ct15);
	CT2CA ct16(newCalThursday);
	string strNewCalThursday(ct16);
	CT2CA ct17(newCalFriday);
	string strNewCalFriday(ct17);
	CT2CA ct18(newCalSaturday);
	string strNewCalSaturday(ct18);
	CT2CA ct19(newCalSunday);
	string strNewCalSunday(ct19);
	CT2CA ct20(newCalTotalBurned);
	string strNewCalTotalBurned(ct20);
	CT2CA ct21(newCalWeeklyGoal);
	string strNewCalWeeklyGoal(ct21);
	CT2CA ct22(newCalPercentGoal);
	string strNewCalPercentGoal(ct22);

	CT2CA ct23(summaryCalIntake);
	string strNewSummaryCalIntake(ct23);
	CT2CA ct24(summaryHoursSlept);
	string strNewSummaryHoursSlept(ct24);
	CT2CA ct25(summaryCupsWater);
	string strNewSummaryCupsWater(ct25);

	//send to the file
	UserLibrarian user1;
	user1.recordStats(strNewSummaryCalIntake, strNewSummaryHoursSlept, strNewSummaryCupsWater,
		strNewHeightFeet, strNewHeightInch, strNewWeight, strNewGender, strNewAge, strWeeklyGoal,
		strToDol, strToDo2, strToDo3, strToDo4, strToDo5, strNewHoursSlept,
		strNewCalMonday, strNewCalTuesday, strNewCalWednesday, strNewCalThursday, strNewCalFriday, strNewCalSaturday, strNewCalSunday, strNewCalTotalBurned, strNewCalWeeklyGoal, strNewCalPercentGoal);

}


void CMainWindow::OnBnClickedbtnloadfromfile()
{
	// String to pick up getline from text
	string textToString;
	// Convert String back to Cstring
	
	// Open the file
	//ifstream ReadUserFile("User.txt");   // ADJUST FILE NAME HERE
	ifstream ReadUserFile(usernameTXT);

	// Begin filling fields, top to bottom
	// TODAY'S SUMMARY
	getline(ReadUserFile, textToString);
	CString cs1(textToString.c_str());
	SetDlgItemText(txtSummaryIntake, cs1);
	getline(ReadUserFile, textToString);
	CString cs2(textToString.c_str());
	SetDlgItemText(txtSummaryHoursSlept, cs2);
	getline(ReadUserFile, textToString);
	CString cs3(textToString.c_str());
	SetDlgItemText(txtSummaryCupsWater, cs3);
	// PERSONAL INFO
	getline(ReadUserFile, textToString);
	CString cs4(textToString.c_str());
	SetDlgItemText(txtUserHeightFeet, cs4);
	getline(ReadUserFile, textToString);
	CString cs5(textToString.c_str());
	SetDlgItemText(txtUserHeightInch, cs5);
	getline(ReadUserFile, textToString);
	CString cs6(textToString.c_str());
	SetDlgItemText(txtUserWeight, cs6);
	getline(ReadUserFile, textToString);
	CString cs7(textToString.c_str());
	SetDlgItemText(txtUserGender, cs7);
	getline(ReadUserFile, textToString);
	CString cs8(textToString.c_str());
	SetDlgItemText(txtUserAge, cs8);
	getline(ReadUserFile, textToString);
	CString cs9(textToString.c_str());
	SetDlgItemText(txtUserWeeklyGoal, cs9);
	// TO-DO LIST
	getline(ReadUserFile, textToString);
	CString cs10(textToString.c_str());
	SetDlgItemText(txtToDo1, cs10);
	getline(ReadUserFile, textToString);
	CString cs11(textToString.c_str());
	SetDlgItemText(txtToDo2, cs11);
	getline(ReadUserFile, textToString);
	CString cs12(textToString.c_str());
	SetDlgItemText(txtToDo3, cs12);
	getline(ReadUserFile, textToString);
	CString cs13(textToString.c_str());
	SetDlgItemText(txtToDo4, cs13);
	getline(ReadUserFile, textToString);
	CString cs14(textToString.c_str());
	SetDlgItemText(txtToDo5, cs14);
	// HOURS SLEPT
	getline(ReadUserFile, textToString);
	CString cs15(textToString.c_str());
	SetDlgItemText(txtHoursSlept, cs15);
	// WORKOUT LOG
	getline(ReadUserFile, textToString);
	CString cs16(textToString.c_str());
	SetDlgItemText(txtMondayCals, cs16);
	getline(ReadUserFile, textToString);
	CString cs17(textToString.c_str());
	SetDlgItemText(txtTuesdayCals, cs17);
	getline(ReadUserFile, textToString);
	CString cs18(textToString.c_str());
	SetDlgItemText(txtWednesdayCals, cs18);
	getline(ReadUserFile, textToString);
	CString cs19(textToString.c_str());
	SetDlgItemText(txtThursdayCals, cs19);
	getline(ReadUserFile, textToString);
	CString cs20(textToString.c_str());
	SetDlgItemText(txtFridayCals, cs20);
	getline(ReadUserFile, textToString);
	CString cs21(textToString.c_str());
	SetDlgItemText(txtSaturdayCals, cs21);
	getline(ReadUserFile, textToString);
	CString cs22(textToString.c_str());
	SetDlgItemText(txtSundayCals, cs22);
	getline(ReadUserFile, textToString);
	CString cs23(textToString.c_str());
	SetDlgItemText(txtTotalWeekCals, cs23);
	getline(ReadUserFile, textToString);
	CString cs24(textToString.c_str());
	SetDlgItemText(txtWeeklyGoal, cs24);
	getline(ReadUserFile, textToString);
	CString cs25(textToString.c_str());
	SetDlgItemText(txtPercentGoal, cs25);
	
	// Close the file
	ReadUserFile.close();
}
