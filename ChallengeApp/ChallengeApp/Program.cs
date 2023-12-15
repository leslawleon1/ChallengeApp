using System;

int[] grades = new int[365];
string[] dayOfWeeks = new string[7];
dayOfWeeks[0] = "poniedziałek";
dayOfWeeks[1] = "wtorek";
dayOfWeeks[2] = "środa";
dayOfWeeks[3] = "czwartek";
dayOfWeeks[4] = "piątek";
dayOfWeeks[5] = "sobota";
dayOfWeeks[6] = "niedziela";



for(var i=0; i<dayOfWeeks.Length; i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}
