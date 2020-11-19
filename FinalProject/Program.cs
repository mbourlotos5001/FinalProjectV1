
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "password";
            string userNameAttempt;
            string passwordAttempt;
            int loginAttempt = 0;
            int continueMenu = 1;
            List<Tenant> tenantList = new List<Tenant>();
           


            WriteLine("Welcome to the space rent tracker!");
            for (int i = 0; i < 5; i++)
            {
                WriteLine("Enter Username");
                userNameAttempt = Convert.ToString(ReadLine());
                WriteLine("Enter Password");
                passwordAttempt = Convert.ToString(ReadLine());

                if (userNameAttempt != username || passwordAttempt != password)
                    loginAttempt++;
                else
                    break;
            }
            if (loginAttempt > 4)
                Environment.Exit(0);
            else
                WriteLine("Login correct!");
            while (continueMenu == 1)
            {
                WriteLine("Please make a selection...");
                WriteLine("(1) View Tenant List (2) ADD Tenant/s (3) Modify Tenant Information (4) Show Amount Left To Be Collected");
                int menuChoice = Convert.ToInt32(ReadLine());
                switch (menuChoice)
                {
                    case 1:
                        viewTennants(ref tenantList);
                        break;
                    case 2:
                        WriteLine("How many tenants would you like to add?");
                        int tenNum = Convert.ToInt32(ReadLine());
                        for (int x = 0; x < tenNum; x++)
                        {
                        PopulateTenant(ref tenantList);
                        }
                        break;
                    case 3:
                        WriteLine("Select Tenant");
                        for (int i = 0; i < tenantList.Count; i++ )
                        {
                            WriteLine("{0,20}{1,20}{2,20}", i + 1, tenantList[i].PersonId, tenantList[i].PersonName);
                        }
                        int input = Convert.ToInt32(ReadLine());

                        ModifyTenant(ref tenantList, input - 1);

                        break;
                    case 4:

                        break;
                    default:
                        WriteLine("Invalid Selection");
                        break;
                }
                WriteLine("Enter (1) to continue or (2) to Exit");
                continueMenu = Convert.ToInt32(ReadLine());
            }
        }







        static void viewTennants(ref List<Tenant> tenantList)
        {
            foreach (Tenant x in tenantList)
            {
                WriteLine("{0,20}{1,20}{2,20}{3,20}{4,20}{5,20}", x.PersonId, x.PersonName, x.PersonPhone, x.PersonPaid, x.RoomType, x.RentAmount);
            }
           
        }
        static void PopulateTenant(ref List<Tenant> tenantList)
        {
            Write("Please enter tenant ID number. ");
            int tenId = Convert.ToInt32(ReadLine());
            Write("Please enter tenant name. ");
            string tenName = ReadLine();
            Write("Please enter phone number. ");
            int tenPhone = Convert.ToInt32(ReadLine());
            WriteLine("Has the tenant paid rent?");
            WriteLine("Enter (1) for Paid or (2) for not paid");
            int yesNo = Convert.ToInt32(ReadLine());
            bool tenPaid = false;
            switch (yesNo)
            {
                case 1:
                    tenPaid = true;
                    break;
                case 2:
                    
                    break;
                default:
                    WriteLine("Invalid Selection");
                    break;
            }
            Write("What type of the room does the tenant rent?");
            string roomType = Convert.ToString(ReadLine());
            Write("Enter rent amount");
            double rentAmount = Convert.ToDouble(ReadLine());

            tenantList.Add(new Tenant(tenId, tenName, tenPhone, tenPaid, roomType, rentAmount));
        }
        static void ModifyTenant(ref List<Tenant> tenantList,int t)
        {
            WriteLine("What would you like to modify?");
            WriteLine("(1) ID Number (2) Name (3) Phone Number (4) Mark Tenant As Paid (5) Room Type (6) Rent");
            int input = Convert.ToInt32(ReadLine());
            if(input == 1)
            {
                WriteLine("Enter new ID");
                int newId = Convert.ToInt32(ReadLine());
                tenantList[t].PersonId = newId;
            }
           else if(input == 2)
            {
                WriteLine("Enter new Name");
                string newName = Convert.ToString(ReadLine());
                tenantList[t].PersonName = newName;
            }
            else if (input == 3)
            {
                WriteLine("Enter new Phone Number");
                int newNum = Convert.ToInt32(ReadLine());
                tenantList[t].PersonId = newNum;
            }
            else if (input == 4)
            {
                WriteLine("Enter (1) for Paid or (2) for not paid");
                int yesNo = Convert.ToInt32(ReadLine());
                switch (yesNo)
                {
                    case 1:
                        tenantList[t].PersonPaid = true;
                        break;
                    case 2:
                        tenantList[t].PersonPaid = false;
                        break;
                    default:
                        WriteLine("Invalid Selection");
                        break;
                }

            }
            else if (input == 5)
            {
                WriteLine("Enter new Room Type");
                string roomType = Convert.ToString(ReadLine());
                tenantList[t].RoomType = roomType;
            }
            else if (input == 6)
            {
                WriteLine("Enter new Rent amount");
                double rentA = Convert.ToDouble(ReadLine());
                tenantList[t].RentAmount = rentA;
            }


        }
    }
}
