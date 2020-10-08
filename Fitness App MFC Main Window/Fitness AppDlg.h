
// Fitness AppDlg.h : header file
//

#pragma once


// CFitnessAppDlg dialog
class CFitnessAppDlg : public CDialogEx
{
// Construction
public:
	CFitnessAppDlg(CWnd* pParent = nullptr);	// standard constructor

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_FITNESSAPP_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnEnChangeEdit3();
	afx_msg void OnDtnDatetimechangedtpdate(NMHDR* pNMHDR, LRESULT* pResult);
	afx_msg void OnBnClickedbtnsave();
	afx_msg void OnEnChangetxtsummaryhoursslept();
	afx_msg void OnBnClickedbtnworkoutupdate();
};
