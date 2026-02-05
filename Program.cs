namespace ConsoleApp1test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("enter your fav num?");
            //    int FavNum = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"No really!! {FavNum} is my fav num ");

            //int[] SchoolArr = [1, 2, 3];
            //Console.WriteLine($"your array is : {SchoolArr[0]}");
            //Console.WriteLine($"your array is : {SchoolArr[1]}");
            //Console.WriteLine($"your array is : {SchoolArr[2]}");
            //SchoolArr[0] = 99;
            //Console.WriteLine($"you changed the first number to {SchoolArr[0]}");

            //int[] = Convert.ToInt32( Console.ReadLine());

            string[] studentarray = ["ahmed", "sara", "Mona"];
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add(studentarray[0], "active"); 
            keyValuePairs.Add(studentarray[1], "non active"); 
            keyValuePairs.Add(studentarray[2], "active");
            Console.WriteLine(keyValuePairs[studentarray[0]);
            Console.WriteLine(keyValuePairs[1]);
            Console.WriteLine(keyValuePairs[2]);

        

        }
    }
}
