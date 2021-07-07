using System;

namespace test
{
    class board
    {
        public void printboard(string[] arr)
        {
            Console.WriteLine("{0} | {1} | {2}",arr[0],arr[1],arr[2]);
            Console.WriteLine("---------");

            Console.WriteLine("{0} | {1} | {2}",arr[3],arr[4],arr[5]);
            Console.WriteLine("---------");

            Console.WriteLine("{0} | {1} | {2}",arr[6],arr[7],arr[8]);
        }

        public int checkxwin(string[] arr)
        {
            if((arr[0]=="X" && arr[1]=="X" && arr[2]=="X")
            ||(arr[3]=="X" && arr[4]=="X" && arr[5]=="X")
            ||(arr[6]=="X" && arr[7]=="X" && arr[8]=="X")
            ||(arr[0]=="X" && arr[4]=="X" && arr[8]=="X")
            ||(arr[2]=="X" && arr[4]=="X" && arr[6]=="X")
            ||(arr[0]=="X" && arr[3]=="X" && arr[6]=="X")
            ||(arr[1]=="X" && arr[4]=="X" && arr[7]=="X")
            ||(arr[2]=="X" && arr[5]=="X" && arr[8]=="X"))
            {
                return 1;
            }
            else return 0;
        }

        public int checkOwin(string[] arr)
        {
            if((arr[0]=="O" && arr[1]=="O" && arr[2]=="O")
            ||(arr[3]=="O" && arr[4]=="O" && arr[5]=="O")
            ||(arr[6]=="O" && arr[7]=="O" && arr[8]=="O")
            ||(arr[0]=="O" && arr[4]=="O" && arr[8]=="O")
            ||(arr[2]=="O" && arr[4]=="O" && arr[6]=="O")
            ||(arr[0]=="O" && arr[3]=="O" && arr[6]=="O")
            ||(arr[1]=="O" && arr[4]=="O" && arr[7]=="O")
            ||(arr[2]=="O" && arr[5]=="O" && arr[8]=="O"))
            {
                return 1;
            }
            else return 0;
        }
        public int checkbox(string[] arr,int n)
        {
            if(arr[n-1]=="X" || arr[n-1]=="O") return 1;
            else return 0;
        }
    }
}