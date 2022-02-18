using BankApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApp
{
    public delegate void adddelegate();
    class Saving
    {

        public void deposit(int amt)
        {
            try
            {
                if (amt > 100000)
                {
                    throw new Exception();
                }

                Console.WriteLine("You have  deposited " + amt + "in your savings acc ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max accounrt limit is 100000" + e);
            }
        }
    }




    class current
    {

        public void deposit(int curramt)
        {
            try
            {
                if (curramt > 200000)
                {
                    throw new Exception();
                }

                Console.WriteLine("You have deposited" + curramt + "in your current acc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max account limit is 200000" + e);
            }
        }
    }
    class child
    {

        public void deposit(int childamt)
        {
            try
            {
                if (childamt > 50000)
                {
                    throw new Exception();
                }
                Console.WriteLine("You have deposited" + childamt + "in your childcare acc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Max account limit is 50000" + e);
            }
        }
    }
    class CustomerDetails
    {
        String name;
        int accno;
        string Bankbranch;
        public void CustomerInput()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your accno");
            accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your bankbranch");
            Bankbranch = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------");
        }
        public void info()
        {
            Console.WriteLine("Your Deatils is " + name + " " + accno + " " + Bankbranch);
            Console.WriteLine("Thank you for entering your details");
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        public void atm()
        {

            Console.WriteLine("Enter the money to credit in atm");
            int avlbal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Credited amount in your acc is " + avlbal);
            Console.WriteLine("Thank you, your money has been credited successfully");
            Console.WriteLine("Do you have any other choice!!");
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("Enter You Choice: 1------->Withdrawl   2------>CheckBal    3-------->Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 1)

                {
                    Console.WriteLine("Enter the amt to withdraw");
                    int withdrawlamt = Convert.ToInt32(Console.ReadLine());
                    if (avlbal >= withdrawlamt)
                    {
                        Console.WriteLine("Amt has been withdrawn successfully");
                        // int Rembal;
                        avlbal = avlbal - withdrawlamt;
                        Console.WriteLine("Remaianing bal in your account is" + avlbal);
                    }

                    else
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    if (i >= 3)
                    {
                        Console.WriteLine("Limit Exceeds");
                        int deduct = avlbal - 500;
                        Console.WriteLine("You have exhausted your limit, so 500 has been deducted,available bal is" + deduct);
                    }

                }

                if (Choice == 2)

                {

                    Console.WriteLine("Your available bal is " + avlbal);
                }

                if (Choice == 3)
                {
                    Console.WriteLine("Thank for visiting our branch");
                    Environment.Exit(0);
                    Console.ReadKey();
                }

            }
        }
    }
    class List
    {
        public class customerInfo
        {
            public int age
            {
                get; set;
            }
            public string name
            {
                get;
                set;
            }
            public int accno
            {
                get;
                set;
            }
            public string bankbranch
            {
                get;
                set;
            }
            public int totamt
            {
                get;
                set;
            }
        };



        class cd
        {
            public void customerList()
            {
                customerInfo ci1 = new customerInfo()
                {
                    age = 32,
                    name = "Banu",
                    accno = 34567697,
                    bankbranch = "hdfc",
                    totamt = 45000

                };
                customerInfo ci2 = new customerInfo()
                {
                    age = 35,
                    name = "Bala",
                    accno = 98765676,
                    bankbranch = "hdfc",
                    totamt = 100000

                };
                customerInfo ci3 = new customerInfo()
                {
                    age = 27,
                    name = "Saai",
                    accno = 80945679,
                    bankbranch = "hdfc",
                    totamt = 300000
                };
                customerInfo ci4 = new customerInfo()
                {
                    age = 25,
                    name = "Vara",
                    accno = 12345678,
                    bankbranch = "hdfc",
                    totamt = 10000

                };
                customerInfo ci5 = new customerInfo()
                {
                    age = 28,
                    name = " Mala",
                    accno = 23456907,
                    bankbranch = "hdfc",
                    totamt = 40000
                };
                List<customerInfo> cu = new List<customerInfo>();

                cu.Add(ci1);
                cu.Add(ci2);
                cu.Add(ci3);
                cu.Add(ci4);
                cu.Add(ci5);
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Retrieving the customer data ");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Name ||  Age  ||  Accno  || b.branch||totamt");
                string filepath = "C:\\customer";
                StreamWriter sw = new StreamWriter(filepath);
                foreach (customerInfo c in cu)
                {
                    sw.WriteLine(c.name + "\t");
                    sw.WriteLine(c.age + "\t");
                    sw.WriteLine(c.accno + "\t");
                    sw.WriteLine(c.bankbranch + "\t");
                    sw.WriteLine(c.totamt + "\n");
                    sw.WriteLine("------------------------------------");
                }
                sw.Close();
                foreach (customerInfo c in cu)
                {
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine(c.name + " ||  " + c.age + " ||  " + c.accno + "  ||  " + c.bankbranch + " || " + c.totamt);

                }
            }



            class Bank
            {
                public void bankInput()
                {
                    Console.WriteLine("Welcome to bank");
                    Console.WriteLine("Press 1 ------->Savings Account");
                    Console.WriteLine("Press 2-------->Current Account");
                    Console.WriteLine("Press 3-------->ChildCare Account");
                    Console.WriteLine("Press Any other number----->stop");

                    Console.WriteLine("Enter you Choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Thank you for choosing saving account");
                            Console.WriteLine("Your account limit is 100000");
                            Console.WriteLine("Please enter your details");
                            CustomerDetails cd1 = new CustomerDetails();
                            cd1.CustomerInput();
                            cd1.info();
                            Saving s = new Saving();
                            Console.WriteLine("Enter amount to be deposited in savings acc");
                            int amt = Convert.ToInt32(Console.ReadLine());
                            s.deposit(amt);
                            cd1.atm();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Thank you for choosing current account");
                            Console.WriteLine("Your account limit is 200000");
                            Console.WriteLine("Please enter your details");
                            CustomerDetails cd2 = new CustomerDetails();
                            cd2.CustomerInput();
                            cd2.info();
                            current c = new current();
                            Console.WriteLine("Enter amount to be deposited in currentacc");
                            int curramt = Convert.ToInt32(Console.ReadLine());
                            c.deposit(curramt);
                            cd2.atm();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Thank you for choosing ChildCare account");
                            Console.WriteLine("Your account limit is 50000");
                            Console.WriteLine("Please enter your details");
                            CustomerDetails cd3 = new CustomerDetails();
                            cd3.CustomerInput();
                            cd3.info();
                            child ch = new child();
                            Console.WriteLine("Enter amount to be deposit in childcare acc");
                            int childamt = Convert.ToInt32(Console.ReadLine());
                            ch.deposit(childamt);
                            cd3.atm();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Sorry,You have choosen an invalid account");
                            Console.ReadKey();
                            break;
                    }
                }

                class Program
                {
                    static void Main(string[] args)
                    {
                        Bank b = new Bank();
                        b.bankInput();
                        cd c = new cd();
                        c.customerList();

                        Console.ReadKey();
                    }
                }


            }
        }
    }
}



