#include "Account.h"
#include <iostream>

using namespace std;

Account::Account()
{
	email = "";
	password = "";
}

Account::Account(string newEmail, string newPassword)
{
	email = newEmail;
	password = newPassword;
}

Account::~Account() {}