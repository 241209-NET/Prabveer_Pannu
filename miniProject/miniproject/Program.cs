namespace miniproject;
﻿using DailyTasks.Util;

class Program
{
    static void Main(string[] args)
    {
   string saveFile = "tasksave.json";

        List<int> myNums = Utilities.LoadTasks(saveFile);
        
        while(true)
        {
            Console.WriteLine("1. Add A Number");
            Console.WriteLine("2. Display All Number");
            Console.WriteLine("3. Multiply All Number By A Given Value");
            Console.WriteLine("4. Exit");

            int userChoice = Utilities.UserChoice(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    int x = 0;
                    Console.Write("Number: ");
                    string? newNumber = Console.ReadLine();
                    if(Int32.TryParse(newNumber, out int num))
                        x = num;
                    else
                        x = 0;
                    myNums.Add(x);
                    break;
                case 2:
                    foreach(var a in myNums)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                case 3:
                    Console.Write("Give Number To Multiple By: ");
                    int val = 0;
                    string? multi = Console.ReadLine();
                    if(Int32.TryParse(multi, out num))
                        val = num;
                    else
                        val = 2;
                    Console.Write("Numbers After Multiplication");
                    for(int i = 0; i < myNums.Count; i++)
                        myNums[i] *= val;
                    break;
                case 4:
                    Utilities.SaveTasks(myNums, saveFile);
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
