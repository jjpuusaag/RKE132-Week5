﻿

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if  ((math >= 90 && chemistry >= 90) ||( math >= 90 && biology >= 90) )
{
    Console.WriteLine("Congratulations! Your application has been submitted.");

}
else
{
    Console.WriteLine("Your application didn't meet the requirements.");    
}
