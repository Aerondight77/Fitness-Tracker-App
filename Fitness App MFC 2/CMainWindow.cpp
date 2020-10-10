// CMainWindow.cpp : implementation file
//

#include "pch.h"
#include "Fitness App MFC 2.h"
#include "Fitness App MFC 2Dlg.h"
#include "CMainWindow.h"
#include "afxdialogex.h"

#include <ctime>
#include <string>

using namespace std;


// CMainWindow dialog

IMPLEMENT_DYNAMIC(CMainWindow, CDialogEx)

CMainWindow::CMainWindow(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_MAINWINDOW_DLG, pParent)
{

}

CMainWindow::~CMainWindow()
{
}

void CMainWindow::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}


BEGIN_MESSAGE_MAP(CMainWindow, CDialogEx)
	ON_BN_CLICKED(btnUpdate, &CMainWindow::OnBnClickedbtnupdate)
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
