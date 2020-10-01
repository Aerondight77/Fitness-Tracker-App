
// Fitness App MFC 2.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'pch.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CFitnessAppMFC2App:
// See Fitness App MFC 2.cpp for the implementation of this class
//

class CFitnessAppMFC2App : public CWinApp
{
public:
	CFitnessAppMFC2App();

// Overrides
public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CFitnessAppMFC2App theApp;
