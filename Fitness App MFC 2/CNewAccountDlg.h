#pragma once

#include <string>
extern std::string usernameTXT;

// CNewAccountDlg dialog

class CNewAccountDlg : public CDialog
{
	DECLARE_DYNAMIC(CNewAccountDlg)

public:
	CNewAccountDlg(CWnd* pParent = nullptr);   // standard constructor
	virtual ~CNewAccountDlg();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_NEWACCOUNT_DLG };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()
public:
	CEdit m_EditUsername;
	CString m_Username;
	CEdit m_EditPassword;
	CString m_Password;
	CString m_ConfirmPassword;
	afx_msg void OnBnClickedbtncreateaccount();
};
