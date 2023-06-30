using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		private double balance = 0;

		public void Deposit(double mula)
		{
			balance += mula;
		}

		public void GetBalance()
		{
			Console.WriteLine($"Great, your balance on this account is {balance}. Have a great day!");
		}
	}
}

