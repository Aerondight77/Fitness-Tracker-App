// CNewAccountDlg.cpp : implementation file
//
#include "pch.h"
#include "framework.h"
#include "Fitness App MFC 2.h"
#include "Fitness App MFC 2Dlg.h"
#include "CNewAccountDlg.h"
#include "afxdialogex.h"
#include "afxwin.h"
#include <string>

std::string usernameTXT = "User.txt";
// CNewAccountDlg dialog

IMPLEMENT_DYNAMIC(CNewAccountDlg, CDialog)

CNewAccountDlg::CNewAccountDlg(CWnd* pParent /*=nullptr*/)
	: CDialog(IDD_NEWACCOUNT_DLG, pParent)
	, m_Username(_T(""))
	, m_Password(_T(""))
	, m_ConfirmPassword(_T(""))
{

}

CNewAccountDlg::~CNewAccountDlg()
{
}

void CNewAccountDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, txtNewUser, m_EditUsername);
	DDX_Text(pDX, txtNewUser, m_Username);
	DDX_Control(pDX, txtNewPass, m_EditPassword);
	DDX_Text(pDX, txtNewPass, m_Password);
	DDX_Text(pDX, txtNewPassConfirm, m_ConfirmPassword);
}


BEGIN_MESSAGE_MAP(CNewAccountDlg, CDialog)
	ON_BN_CLICKED(btnCreateAccount, &CNewAccountDlg::OnBnClickedbtncreateaccount)
END_MESSAGE_MAP()


// CNewAccountDlg message handlers


void CNewAccountDlg::OnBnClickedbtncreateaccount()
{
	// TODO: Add your control notification handler code here
	UpdateData();

	// Make sure the user provided a username
	if (m_Username == "")
	{
		AfxMessageBox(_T("You must provide a username"));
		m_EditUsername.SetFocus();
		return;
	}

	// Don't allow a blank password
	if (m_Password == "")
	{
		AfxMessageBox(_T("Blank passwords are not allowed\n"
			"Please provide a password"));
		m_EditPassword.SetFocus();
		return;
	}

	// The password and the blank password must be the same
	if (m_ConfirmPassword != m_Password)
	{
		AfxMessageBox(_T("The passwords you provided are not the same"));
		m_EditPassword.SetFocus();
		return;
	}

	FILE* fleCredentials;
	FILE* fleCredentials2;

	try {
		CT2CA usernameTXTFile(m_Username);
		std::string fileName = usernameTXTFile + ".txt";
		usernameTXT = fileName;  // GLOBAL VARIABLE
		// Create a new file or open the existing one
		fleCredentials2 = fopen("credentials.txt", "a+");
		fleCredentials = fopen(fileName.c_str(), "a+");
		// Add the username to the file
		fprintf(fleCredentials2, "%ls ", (LPCTSTR)m_Username);
		//fprintf(fleCredentials, "%ls ", (LPCTSTR)m_Username);
		// Add the password to the file
		fprintf(fleCredentials2, "%ls\n", (LPCTSTR)m_Password);
		//fprintf(fleCredentials, "%ls\n", (LPCTSTR)m_Password);

		// After using it, close the file
		fclose(fleCredentials);
		fclose(fleCredentials2);
	}
	catch (...)
	{
		// Did something go wrong???
		AfxMessageBox(_T("Could not validate the credentials"));
	}

	UpdateData(FALSE);
	OnOK();
}
