using System;

namespace challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // islam has a carpet cleaning service 
            // charges
            // 25$ per small carpet 
            // 35$ per Large carpet 
            //sales tax rate us 6% 
            //est are valid for 30 days 

            //prompt the user for the numbers of small and large roons they would like cleaned and provide an est such as 

            //est for carpet cleaning service 
            //number of small carpet is 3
            //number of large carpet is 1
            //price for small carpet is 25$ 
            //price for large carpet is 35$ 
            //cost = $110
            //tax = $6.6 

            //total est price is 116.6
            //this est is valid for 30 days 



            // main task 

            int smallCarpetPrice = 25;
            int largeCarpetPrice = 35;
            double taxRate = 6.6;

            Console.WriteLine("Enter the number of small carpets you would like to clean: ");
            int smallCarpetNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of large carpets you would like to clean: ");
            int largeCarpetNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You Asked to clean {smallCarpetNum} Small Carpet");
            Console.WriteLine($"You Asked to clean {largeCarpetNum} Large Carpet");

            int smallPrice = Convert.ToInt32(smallCarpetPrice * smallCarpetNum);
            Console.WriteLine($"The Price for Small carpet is : {smallPrice}$ ");

            int largPrice = Convert.ToInt32(largeCarpetPrice * largeCarpetNum);
            Console.WriteLine($"The Price for Large carpet is : {largPrice}$ ");

            Console.WriteLine($"The Taxs is : {taxRate}$ ");

            int cost = (smallPrice) + (largPrice);
            double finalTax = (cost + taxRate);

            Console.WriteLine($"your Total Cost is : {finalTax}$");
            Console.WriteLine("Please be informed this est is valid for 30 days");
            Console.WriteLine("Happy to serve you from EreaSoft :)");


            // sreach task 

            int a = 5;
            int s = 10;
            Console.WriteLine($"Equation: {a} + {s} = {a + s:c} EGP");




        }
    }
}
