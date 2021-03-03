using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project_Bravo

{
   
    class Program
    {
        static List<string> information = new List<string>();

        static void addInfo()
        {
            string fName, lName;
            int num;
            Console.WriteLine("==========Add Information==========");
            Console.WriteLine("How many employees are there");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the fisrt name of employee: " + (i + 1));
                fName = Console.ReadLine();
                Console.WriteLine("Enter the last name of employee: " + (i + 1));
                lName = Console.ReadLine();
                information.Add(fName + " " + lName);
            }
        }

        static void displayInfo()
        {
            Console.WriteLine("This names stored are: ");
            for (int i = 0; i < information.Count; i++)
            {
                Console.WriteLine(i + " " + information[i]);
            }
        }

        static void delInfo()
        {
            Console.WriteLine("==========Delete Information==========");
            Console.WriteLine("List of employee names");
            displayInfo();
            Console.WriteLine("What number on the list would you like to delete?");
            int loc = Convert.ToInt32(Console.ReadLine());
            information.RemoveAt(loc);
            Console.WriteLine("The name was deleted");
            Console.WriteLine("New list of employees");
            displayInfo();
        }

        static void insInfo()
        {
            Console.WriteLine("==========Insert Information==========");
            Console.WriteLine("Enter the location on the list you want to insert the information");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first name of the employee you want to add:");
            string newfName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the employee you want to add:");
            string newlName = Console.ReadLine();
            information.Insert(loc, (newfName + " " + newlName));
            displayInfo();
        }

        static void searchInfo()
        {
            Console.WriteLine("==========Search Information==========");
            Console.WriteLine("Enter the first name you would like to search for");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter the last name you would like to search for");
            string lName = Console.ReadLine();
            string name = (fName + " " + lName);

            if (information.Contains(name))
            {
                Console.WriteLine(name + " is at number:" + information.IndexOf(name) + " on the list of employee's");
            }

            else
            {
                Console.WriteLine("There is no employee on the list wwith that name. Please type another name");
            }
        }

        static void updateInfo()
        {
            Console.WriteLine("==========Update Information==========");
            Console.WriteLine("List of employees:");
            displayInfo();
            Console.WriteLine("Enter the number on list you would like to update:");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new first name of employee:" + (loc));
            string fName = Console.ReadLine();
            Console.WriteLine("Enter the new last name of employee: " + (loc));
            string lName = Console.ReadLine();
            information[loc] = (fName + " " + lName);
            Console.WriteLine("New list of employees:");
            displayInfo();
        }
        static void Main(string[] args)
        {
            char c;
            do
            {
                Console.Clear();
                Console.WriteLine("==========Employee Information==========");
                Console.WriteLine("Press 1 to add employee information \nPress 2 to insert employee information" +
                    " \nPress 3 to Update the employee information \nPress 4 to delete the employee information \nPress 5 to search for employee" +
                    " infomration \nPress 6 to Display the employee information");
                int choice = Convert.ToInt32(Console.ReadLine());
                char ch;

                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            addInfo();
                            Console.WriteLine("Do you want to add more employee's?: Press 'y' for Yes");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            displayInfo();
                            insInfo();
                            Console.WriteLine("Do you want to add more employee's?: Press 'y' for Yes");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case 3:
                        do
                        {
                            Console.Clear();
                            updateInfo();
                            Console.WriteLine("Do you want to update any more names?: Press 'y' for Yes");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case 4:
                        do
                        {
                            Console.Clear();
                            delInfo();
                            Console.WriteLine("Do you want to delete any more employees?: Press 'y' for Yes");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case 5:
                        do
                        {
                            Console.Clear();
                            searchInfo();
                            Console.WriteLine("Do you want to search for another employee?: Press 'y' for Yes");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("==========Display Information==========");
                        displayInfo();
                        break;

                    default:
                        Console.WriteLine("Please enter a Number from 1-6");
                        break;
                }

                Console.WriteLine("Do you want to return to the main menu: Press 'y' for Yes");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
            Console.ReadKey();
        }
    }
}