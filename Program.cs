namespace ConsoleApp1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int readResult;
            Console.WriteLine("Input number of elements to be contained in the array");
            int myArrayLength = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[myArrayLength+1]; 
            for( i = 0; i < myArrayLength; i++)
            {

                Console.WriteLine("Insert " + (i + 1) +  " element of the array");

                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the values stored are: ");
            for (i = 0; i < myArrayLength; i++)
            {

                Console.WriteLine(myArray[i]);

       
            }
            Console.WriteLine("the values stored in reverse are: ");
            for (i = myArrayLength - 1; i >= 0; i--)
            {

                Console.WriteLine(myArray[i]);


            }

        }
    }
}
