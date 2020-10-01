
// Fitness App MFC 2Dlg.h : header file
//

#pragma once


// CFitnessAppMFC2Dlg dialog
class CFitnessAppMFC2Dlg : public CDialog
{
// Construction
public:
	CFitnessAppMFC2Dlg(CWnd* pParent = nullptr);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_FITNESSAPPMFC2_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CEdit m_EditUsername;
	CString m_Username;
	CString m_Password;
	afx_msg void OnBnClickedbtnregister();
	afx_msg void OnBnClickedbtnlogin();
};
