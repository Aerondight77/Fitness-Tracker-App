
// Fitness App MFC 2Dlg.cpp : implementation file
//

#include "pch.h"
#include "framework.h"
#include "Fitness App MFC 2.h"
#include "Fitness App MFC 2Dlg.h"
#include "afxdialogex.h"
#include ".\Fitness App MFC 2Dlg.h"
#include "CNewAccountDlg.h"
#include <stdio.h>
#include <string>

// Includes for Main Window
#include "CMainWindow.h" //for the Login button to go to Main Window

#ifdef _DEBUG
#define new DEBUG_NEW
#endif



// CFitnessAppMFC2Dlg dialog



CFitnessAppMFC2Dlg::CFitnessAppMFC2Dlg(CWnd* pParent /*=nullptr*/)
	: CDialog(IDD_FITNESSAPPMFC2_DIALOG, pParent)
	, m_Username(_T(""))
	, m_Password(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CFitnessAppMFC2Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, txtUser, m_EditUsername);
	DDX_Text(pDX, txtUser, m_Username);
	DDX_Text(pDX, txtPassword, m_Password);
}

BEGIN_MESSAGE_MAP(CFitnessAppMFC2Dlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(btnRegister, &CFitnessAppMFC2Dlg::OnBnClickedbtnregister)
	ON_BN_CLICKED(btnLogin, &CFitnessAppMFC2Dlg::OnBnClickedbtnlogin)
END_MESSAGE_MAP()


// CFitnessAppMFC2Dlg message handlers

BOOL CFitnessAppMFC2Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

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

void CFitnessAppMFC2Dlg::OnPaint()
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
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CFitnessAppMFC2Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CFitnessAppMFC2Dlg::OnBnClickedbtnregister()
{
	// TODO: Add your control notification handler code here
	CNewAccountDlg Dlg;

	Dlg.DoModal();
}


void CFitnessAppMFC2Dlg::OnBnClickedbtnlogin()
{
	// TODO: Add your control notification handler code here
	UpdateData();

	char UsernameFromFile[20], PasswordFromFile[20];
	FILE* fleCredentials;
	bool ValidLogin = false;

	if (m_Username == "")
	{
		AfxMessageBox(_T("You must provide a username and a password or click Cancel"));
		return;
	}
	if (m_Password == "")
	{
		AfxMessageBox(_T("Invalid Login"));
		return;
	}

	try {
		// Open the file for reading
		fleCredentials = fopen("credentials.txt", "r");

		// Scan the file from beginning to end
		while (!feof(fleCredentials))
		{
			// Read a username
			fscanf(fleCredentials, "%s", UsernameFromFile);

			// Compare the typed username with the username from the file
			CT2A ascii(m_Username);
			CT2CA fileName(m_Username);
			usernameTXT = fileName + ".txt";
			if (strcmp(ascii, UsernameFromFile) == 0)
			{
				// With the current username, retrieve the corresponding password
				fscanf(fleCredentials, "%s", PasswordFromFile);

				// Compare the typed password with the one on file
				CT2A ascii2(m_Password);
				if (strcmp(ascii2, PasswordFromFile) == 0)
				{
					ValidLogin = true;
					ShowWindow(SW_HIDE);  // THIS WILL HIDE THE LOGIN WINDOW WHEN MAIN WINDOW OPENS
					CMainWindow mainWindowDialog;	// MOVE THESE TWO LINES TO LINK BUTTON TO MAIN WINDOW
					mainWindowDialog.DoModal();		// MOVE THESE TWO LINES TO LINK BUTTON TO MAIN WINDOW	
					EndDialog(0);   // THIS WILL HIDE THE LOGIN WINDOW WHEN MAIN WINDOW OPENS
					break; //ADDED BREAK, OR ELSE IT OPENS MULTIPLE MAIN WINDOWS FOR EACH LINE
				}
				else
					ValidLogin = false;
			}
		}
		if (ValidLogin == true)
			OnOK();
		else
		{
			AfxMessageBox(_T("Invalid Credentials. Please try again"));
			this->m_EditUsername.SetFocus();
		}
		fclose(fleCredentials);
	}
	catch (...)
	{
		AfxMessageBox(_T("Could not validate the credentials"));
	}
	UpdateData(FALSE);
}


