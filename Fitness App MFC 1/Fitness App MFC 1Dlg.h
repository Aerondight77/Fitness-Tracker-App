
// Fitness App MFC 1Dlg.h : header file
//

#pragma once


// CFitnessAppMFC1Dlg dialog
class CFitnessAppMFC1Dlg : public CDialogEx
{
// Construction
public:
	CFitnessAppMFC1Dlg(CWnd* pParent = nullptr);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_FITNESSAPPMFC1_DIALOG };
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

	afx_msg void OnBnClickedLoginButton();
};
