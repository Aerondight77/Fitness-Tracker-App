
// Fitness App MFC 1Dlg.cpp : implementation file
//

#include "pch.h"
#include "framework.h"
#include "Fitness App MFC 1.h"
#include "Fitness App MFC 1Dlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CFitnessAppMFC1Dlg dialog



CFitnessAppMFC1Dlg::CFitnessAppMFC1Dlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_FITNESSAPPMFC1_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CFitnessAppMFC1Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CFitnessAppMFC1Dlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_LOGIN_BUTTON, &CFitnessAppMFC1Dlg::OnBnClickedLoginButton)
END_MESSAGE_MAP()


// CFitnessAppMFC1Dlg message handlers

BOOL CFitnessAppMFC1Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CFitnessAppMFC1Dlg::OnPaint()
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
HCURSOR CFitnessAppMFC1Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}






void CFitnessAppMFC1Dlg::OnBnClickedLoginButton()
{
	// TODO: Add your control notification handler code here
	CWnd* theText = GetDlgItem(IDC_LOGIN_TEXT);
	theText->SetWindowTextW(L"Oh yeah!");
}





