#pragma once


// CMainWindow dialog

class CMainWindow : public CDialogEx
{
	DECLARE_DYNAMIC(CMainWindow)

public:
	CMainWindow(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CMainWindow();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MAINWINDOW_DLG };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
	afx_msg void OnBnClickedbtnupdate();
	CString userHeightVar;
	afx_msg void OnBnClickedbtnsavetofile();
	CString userHeightInchVar;
	CString userWeightVar;
	CString userGenderVar;
	CString userAgeVar;
	CString userWeeklyGoalVar;
	CString toDo1Var;
	CString toDo2Var;
	CString toDo3Var;
	CString toDo4Var;
	CString toDo5Var;
	CString hoursSleptVar;
	CString calMondayVar;
	CString calTuesdayVar;
	CString calWednesdayVar;
	CString calThursdayVar;
	CString calFridayVar;
	CString calSaturdayVar;
	CString calSundayVar;
	CString calTotalBurnedVar;
	CString calWeeklyGoalVar;
	CString calPercentGoalVar;
	CString summaryCalIntakeVar;
	CString summaryHoursSleptVar;
	CString summaryCupsWaterVar;
};
