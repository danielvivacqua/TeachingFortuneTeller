using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFortuneTeller
{
    class Program
    {
            static void Main(string[] args)
            {
                //This is an example of the project you were assigned over the weekend.
                //In this version of the project, we're doing all of the "work" here in the
                //Main method of our Program class.

                //Using this project, we are going to talk about Object Oriented Programming.
                //We will be building classes and talking about all that goes along with 
                //building a class. For now, check out the project as it exists here in the
                //Main method. We will be re-working the Main method of the Program class
                //to show how using Classes can make this process more efficient.

                Console.WriteLine("Fortune Teller App\n");

            //See how my text goes off the screen, and we have to scroll over to read it?
            //What do you think of that? What else could I have done to make this code
            //more readable?
                Console.WriteLine("Let me see into your future. \nEnter information below to help me predict your future. \n\nYou can Quit at anytime by entering \"Quit\". \nYou can restart at anytime by entering \"Restart\".\n\n");
                string playAgain = "";
                do
                {
                    Console.WriteLine("Enter Your First Name: ");
                    string firstName = Console.ReadLine();
                    string firstNameLower = firstName.ToLower();

                    if (firstNameLower == "quit")
                    {
                        //This is an example of a method. The QuitProgram() method exists somewhere
                        //outside of the Main method. Hmm ... I wonder where ...
                        QuitProgram();
                        break;
                    }
                    else if (firstNameLower == "restart")
                    {
                        Main(args);
                        break;
                    }

                    Console.WriteLine("Enter Your Last Name: ");
                    string lastName = Console.ReadLine();
                    string lastNameLower = lastName.ToLower();

                    if (lastNameLower == "quit")
                    {
                        QuitProgram();
                        break;
                    }
                    else if (lastNameLower == "restart")
                    {
                        Main(args);
                        break;
                    }

                    string fullName = firstNameLower + lastNameLower;

                    Console.WriteLine("Enter Your Age: ");
                    string userAge = Console.ReadLine().ToLower();

                    if (userAge == "quit")
                    {
                        QuitProgram();
                        break;
                    }
                    else if (userAge == "restart")
                    {
                        Main(args);
                        break;
                    }

                    int userAgeInt = int.Parse(userAge);

                    //age if else conditional
                    string retireYears;
                    if (userAgeInt % 2 == 0)
                    {
                        retireYears = 10.ToString();
                    }
                    else
                    {
                        retireYears = 25.ToString();
                    }

                    Console.WriteLine("Enter Your Birth Month (the word, not the number): ");
                    string birthMonth = Console.ReadLine().ToLower();

                    if (birthMonth == "quit")
                    {
                        QuitProgram();
                        break;
                    }
                    else if (birthMonth == "restart")
                    {
                        Main(args);
                        break;
                    }

                    string transportation = null;
                    string color;
                //Check out this giant do-while loop!!
                    do
                    {
                        Console.WriteLine("Enter Your Favorite ROYGBIV Color (If you do not know ROYGBIV, enter \"Help\" to show a list of ROYGBIV colors):");
                        color = Console.ReadLine().ToLower();

                        if (color == "quit")
                        {
                            QuitProgram();
                            break;
                        }
                        else if (color == "restart")
                        {
                            Main(args);
                            break;
                        }

                        //ROYGBIV Switch Case conditional
                        transportation = "";

                        if (color == "help")
                        {
                        //See how my text goes off the screen, and we have to scroll over to read it?
                        //What do you think of that? What else could I have done to make this code
                        //more readable?
                            Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color. \nPlease type in the full name of the color, not the ROYGBIV letter: ");
                            color = Console.ReadLine().ToLower();
                        }

                        //Why does it make sense to use switch case here? Would it make more sense
                        //to use "if", "else if", and "else"?
                        switch (color)
                        {
                            case "red":
                                transportation = "Electric Car";
                                break;
                            case "orange":
                                transportation = "Bike";
                                break;
                            case "yellow":
                                transportation = "SUV";
                                break;
                            case "green":
                                transportation = "Toyota Prius";
                                break;
                            case "blue":
                                transportation = "Scooter";
                                break;
                            case "indigo":
                                transportation = "Private Jet";
                                break;
                            case "violet":
                                transportation = "Yacht";
                                break;
                            default:
                                transportation = "A Matchbox hand-me-down";
                                break;
                        }
                    } while (color == "help");
                    Console.WriteLine("Enter the # of Siblings You Have: ");
                    string sibNum = Console.ReadLine();

                    if (sibNum == "quit")
                    {
                        QuitProgram();
                        break;
                    }
                    else if (sibNum == "restart")
                    {
                        Main(args);
                        break;
                    }

                    int sibNumInt = int.Parse(sibNum);

                    // sibling sequenced if else conditional
                    // Why didn't I use switch case below? Could I have used it?
                    string sibFortune = "";
                    if (sibNumInt == 0)
                    {
                        sibFortune = "Toyko";
                    }
                    else if (sibNumInt == 1)
                    {
                        sibFortune = "Washington DC";
                    }
                    else if (sibNumInt == 2)
                    {
                        sibFortune = "Tanzania";
                    }
                    else if (sibNumInt == 3)
                    {
                        sibFortune = "a cardboard box in New York City";
                    }
                    else if (sibNumInt > 3)
                    {
                        sibFortune = "South Beach Miami";
                    }
                    else
                    {
                        sibFortune = "your ex's basement";
                    }
                    double bankRoll = 500000;

                    for (int i = 0; i < fullName.Length; i++)
                    {
                        if (birthMonth[0] == fullName[i])
                        {
                            bankRoll += 1000000.00;

                        }
                        if (birthMonth[1] == fullName[i])
                        {
                            bankRoll += 2000000.00;
                        }
                        if (birthMonth[2] == fullName[i])
                        {
                            bankRoll += 3000000.00;
                        }
                    }

                    Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, retireYears, bankRoll, sibFortune, transportation);
                    Console.WriteLine("Would you like to play again? Enter Y for Yes or N for No");
                    playAgain = Console.ReadLine().ToUpper();

                    if (playAgain == "QUIT")
                    {
                        QuitProgram();
                        break;
                    }
                    else if (playAgain == "RESTART")
                    {
                        Main(args);
                        break;
                    }
                }
                while (playAgain == "Y");
            }

            static void QuitProgram()
            {
                Console.Write("\n Nobody likes a quitter ... \n Press any key to Quit \n");
                Console.ReadKey();
            }
        }
    }
