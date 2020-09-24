
// Fitness App MFC 1.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'pch.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// CFitnessAppMFC1App:
// See Fitness App MFC 1.cpp for the implementation of this class
//

class CFitnessAppMFC1App : public CWinApp
{
public:
	CFitnessAppMFC1App();

// Overrides
public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern CFitnessAppMFC1App theApp;
