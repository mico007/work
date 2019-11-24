using System;
using System.Collections.Generic;
using System.Text;
namespace bank
{
	class Program
	{
		static string[] a_num = new string[5];
		static double[] amount = new double[5];
		//checking
		static int place(ref string a_n)
		{
			int p = 0;
			int flag = -1;
			for (int i = 0; i < 5; i++)
			{
				if (a_n == a_num[i])
					flag = i;
			}
			p = flag;
			return p;
		}
		//for deposite
		static void acc(ref string ac_no, ref double amt, ref int p)
		{
			try
			{
				Console.WriteLine("");
				amount[p] = amount[p] + amt;
				Console.WriteLine("Account number: " +ac_no);
				Console.WriteLine("Deposited amount: " +amt);
				Console.WriteLine("Balance: " +amount[p]);
				Console.WriteLine("");
			}
			catch (Exception e)
			{
			}
		}
		//for withdraw
		static void acc(ref string ac_no, ref double amt, ref int p1, ref int a)
		{
			if (amount[p1] == 100 || amt >= amount[p1])
				Console.WriteLine("Amount can not be withdrawn");
			else
			{
				amount[p1] = ((amount[p1]) - (amt));
				Console.WriteLine("Account number: " +ac_no);
				Console.WriteLine("Withdrawn amount: " +amt);
				Console.WriteLine("Balance: " +amount[p1]);
				Console.WriteLine("");
			}
		}
		//for transfer
		static void acc(ref double amt, ref int p1, ref int p2)
		{
			if (amount[p1] == 100 || amt >= amount[p1])
				Console.WriteLine("Amount can not be tranfered");
			else
			{
				amount[p2] = amount[p2] + amt;
				amount[p1] = amount[p1] - amt;
				Console.WriteLine("Account number: " +a_num[p1]);
				Console.WriteLine("Balance: " +amount[p1]);
				Console.WriteLine("");
				Console.WriteLine("Account number: " +a_num[p2]);
				Console.WriteLine("Balance: " +amount[p2]);
				Console.WriteLine("");
			}
		}
		//main
		static void Main(string[] args)
		{
			a_num[0] = "AB101"; a_num[1] = "AB102"; a_num[2] = "AB103";
			a_num[3] = "AB104"; a_num[4] = "AB105";
			for (int j = 0; j < 5; j++)
				amount[j] = 500;
			int ch, plc;
			char c = 'y';
			string acc_no1, acc_no2, acc_no;
			double amt;
			while (c == 'y' || c == 'Y')
{
				Console.WriteLine("");
				Console.WriteLine("\t\tWELCOME TO Your BANK");
				Console.WriteLine("");
				Console.WriteLine("Enter your choice");
				Console.WriteLine("Enter(1) for deposite") ;
				Console.WriteLine("Enter(2) for withdraw") ;
				Console.WriteLine("Enter(3) for transfer") ;
				Console.WriteLine("Enter(4) for EXIT") ;
				Console.WriteLine("");
				Console.WriteLine("Choice: -");
			lab: ch = int.Parse(Console.ReadLine());
				if (ch == 1)
				{
					Console.WriteLine("Account number: - ");
					acc_no = Console.ReadLine();
					plc = place(ref acc_no);
					if (plc != -1)
					{
						Console.WriteLine("Amount to be deposited: - ");
						amt = double.Parse(Console.ReadLine());
						acc(ref acc_no, ref amt, ref plc);
					}
					else
						Console.WriteLine("\tInvalid Account Number");
				}
				else if (ch == 2)
				{
					int x = 0;
					Console.WriteLine("Account number: - ");
					acc_no = Console.ReadLine();
					plc = place(ref acc_no);
					if (plc != -1)
					{
						Console.WriteLine("Amount to be withdraw: - ");
						amt = double.Parse(Console.ReadLine());
						acc(ref acc_no, ref amt, ref plc, ref x);
					}
					else
						Console.WriteLine("\tInvalid Account Number");
				}
				else if (ch == 3)
				{
					int pl1, pl2;
					Console.WriteLine("Sender Account number: - ");
					acc_no1 = Console.ReadLine();
					pl1 = place(ref acc_no1);
					Console.WriteLine("Reciever Account number: - ");
					acc_no2 = Console.ReadLine();
					pl2 = place(ref acc_no2);
					if (pl1 != -1 && pl2 != -1)
					{
						Console.WriteLine("Amount to be transfered: - ");
						amt = double.Parse(Console.ReadLine());
						acc(ref amt, ref pl1, ref pl2);
					}
					else
						Console.WriteLine("\tInvalid Account Number");
				}
				else if (ch == 4)
				{
					break;
				}
				else
				{
					Console.WriteLine("\tPlease enter correct choice");
					goto lab;
				}
				Console.WriteLine("Do you wish to continue?(Y / N) :");
				c = char.Parse(Console.ReadLine());
			}
			Console.WriteLine("\t\tTHANK YOU!");
		}
	}
}
