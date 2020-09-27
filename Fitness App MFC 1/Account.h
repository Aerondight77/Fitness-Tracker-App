#ifndef ACCOUNT_H
#define ACCOUNT_H

class Account 
{
public:
	Account();
	Account(string newEmail, string newPassword);
	~Account();
private:
	string email;
	string password;
};

#endif
