namespace MethodsExercise
{
    public class Program
    {

        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            
            Console.WriteLine($"One day, {userName}, was walking through the woods while wearing a {favoriteColor} t-shirt. {userName} saw a {favoriteAnimal} listening to {favoriteBand}. ");
            
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            
            if (numTwo == 0)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            else
            {
                return numOne / numTwo;
            }
            return 0;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        
        public static void Main(string[] args)
        {
            MadLib();
            
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Subtract(2, 2));
            Console.WriteLine(Multiply(3, 4));
            Console.WriteLine(Divide(2,0));
            Console.WriteLine(Sum(2,4,2,4,6,1,1,1,1,1));
        }
        
        
    }
}
