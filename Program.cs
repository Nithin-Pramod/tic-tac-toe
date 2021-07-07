using System;
using test;

namespace test
{

    class Program
    {
    
        static void Main(string[] args)
        {
            string[] arr = {"1","2","3","4","5","6","7","8","9"};
            board obj1 = new board();
            System.Console.WriteLine("Welcome to tic-tak-toe game!!");
            int checkcount =0;
            while(true)
            {
                System.Console.WriteLine("Enter the number");
                try{
                    string userstring = Console.ReadLine();
                    int userNum = Int32.Parse(userstring);
                    if(userNum>0 && userNum<10 && obj1.checkbox(arr,userNum)==0)
                    {
                        checkcount++;
                        if(checkcount%2==1) arr[userNum-1]="X";
                        else arr[userNum-1]="O";

                        obj1.printboard(arr);
                        System.Threading.Thread.Sleep(500);
                        if(obj1.checkxwin(arr)==1)
                        {
                            System.Console.WriteLine("X wins");
                            break;
                        }
                        if(obj1.checkOwin(arr)==1)
                        {
                            System.Console.WriteLine("O wins");
                            break;
                        }
                        if(checkcount==9 && obj1.checkxwin(arr)==0 && obj1.checkOwin(arr)==0)
                        {
                            System.Console.WriteLine("Game Tied!! Nobody wins");
                            break;
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Enter a valid nunber");
                        Console.Clear();
                        obj1.printboard(arr);

                    }
                }
                catch(Exception)
                {
                    System.Console.WriteLine("Enter a valid nunber");
                    Console.Clear();
                    obj1.printboard(arr);
                }
            }
            




        }
    }
}
