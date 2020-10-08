
// Fitness AppDlg.cpp : implementation file
//

#include "pch.h"
#include "framework.h"
#include "Fitness App.h"
#include "Fitness AppDlg.h"
#include "afxdialogex.h"

#include <ctime>
#include <string>

using namespace std;

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CFitnessAppDlg dialog



CFitnessAppDlg::CFitnessAppDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_FITNESSAPP_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CFitnessAppDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CFitnessAppDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(btnSave, &CFitnessAppDlg::OnBnClickedbtnsave)
	ON_EN_CHANGE(txtSummaryHoursSlept, &CFitnessAppDlg::OnEnChangetxtsummaryhoursslept)
	ON_BN_CLICKED(btnWorkOutUpdate, &CFitnessAppDlg::OnBnClickedbtnworkoutupdate)
END_MESSAGE_MAP()


// CFitnessAppDlg message handlers

BOOL CFitnessAppDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CFitnessAppDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CFitnessAppDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CFitnessAppDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CFitnessAppDlg::OnEnChangeEdit3()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CFitnessAppDlg::OnDtnDatetimechangedtpdate(NMHDR* pNMHDR, LRESULT* pResult)
{
	LPNMDATETIMECHANGE pDTChange = reinterpret_cast<LPNMDATETIMECHANGE>(pNMHDR);
	// TODO: Add your control notification handler code here
	*pResult = 0;
}


void CFitnessAppDlg::OnBnClickedbtnsave()
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
	SetDlgItemText(txtGoalPercent, percentFromGoal);
}


void CFitnessAppDlg::OnEnChangetxtsummaryhoursslept()
{
	// TODO:  If this is a RICHEDIT control, the control will not
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Add your control notification handler code here
}


void CFitnessAppDlg::OnBnClickedbtnworkoutupdate()
{
	// TODO: Add your control notification handler code here
}
