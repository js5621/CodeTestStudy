/*
// See https://aka.ms/new-console-template for more information
string input = Console.ReadLine();
int Check=0;
int i_Fq=0;
int i_Thq=0;
//int i_result;
//int i_temp2=0;
Check = Int32.Parse(input);
i_Fq=Check/5;
while(Check>0)
{
    if(Check%5==0)
    {
        i_Fq= Check/5;
        break;
    }
    
    Check-=3;
    i_Thq++;

}

if(Check>=0)
    Console.WriteLine(""+(i_Fq+i_Thq));
else
    Console.WriteLine("-1");
*/
//11399번 문제 
//
using System.Collections;
string  i_Count = Console.ReadLine();// 숫자 
int i_row_count = Int32.Parse(i_Count);
int i_totalSum=0;
ArrayList numbers = new ArrayList();
int[] i_perTime =new int[i_row_count];

        Console.WriteLine("5개의 숫자를 입력하세요 (공백으로 구분):");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ');

        foreach (string num in inputArray)
        {
            if (int.TryParse(num, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("올바른 숫자 형식이 아닙니다: " + num);
            }
        }

        numbers.Sort();
        int tmp=0;
        
        for(int i=0; i<i_row_count;i++)
        {
            i_totalSum+=(int)numbers[i];

            i_perTime[i]= i_totalSum; 

        }

        
        Console.WriteLine(i_perTime.Sum());
        
