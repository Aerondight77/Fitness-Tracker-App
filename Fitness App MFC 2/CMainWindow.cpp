// CMainWindow.cpp : implementation file
//

#include "pch.h"
#include "Fitness App MFC 2.h"
#include "CMainWindow.h"
#include "afxdialogex.h"


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
END_MESSAGE_MAP()


// CMainWindow message handlers
