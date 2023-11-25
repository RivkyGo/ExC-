using System;

namespace fanctionsHadasim
{
    class Fanction
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Exercise 1\nA function that accepts a number and tells if it is a prime number.");
                var res1 = IsPrimeNumber();
                if (res1)
                    Console.WriteLine("The number is a prime number");
                else
                    Console.WriteLine("The number is not a prime number");
                


                Console.WriteLine("Exercise 2\nA function that accepts numbers and returns the largest value.");
                var res2 = BigestNum();
                if (res2 != -1)
                    Console.WriteLine("the largest number: " + res2);
                else
                    Console.WriteLine("No number entered.");



                Console.WriteLine("Exercise 3\nA function that accepts a number and returns the Fibonacci sequence up to the entered number.");
                var res3 = Fibonacci();
                Console.WriteLine("Fibonacci series: " + res3);



                Console.WriteLine("Exercise 4\nA function that returns the largest of the three numbers.");
                var res4 = ThreeBigestNum();
                Console.WriteLine("The sequence with the three largest numbers: " + res4);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //Exercise 1 
        static bool IsPrimeNumber()
        {
            Console.WriteLine("enter a number: ");
            var number = Console.ReadLine();
            if (int.TryParse(number, out int num))
            {
                if (num <= 1)
                {
                    return false;
                }
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            else
            {
                throw new Exception("The value is invalid");
            }
        }

        //Exercise 2
        static int BigestNum()
        {
            Console.WriteLine("enter numbers, to finish insert -1 ");
            int bigestNum = -1;
            int number;
            do
            {
                var num = Console.ReadLine();
                if (int.TryParse(num, out number))
                {
                    if (number > bigestNum)
                        bigestNum = number;
                }
                else
                {
                    throw new Exception("The value is invalid");
                }
            } while (number != -1);
            return bigestNum;
        }

        //Exercise 3
        static string Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            string series = "0";
            Console.WriteLine("enter a number.");
            var newNumber = Console.ReadLine();
            if (int.TryParse(newNumber, out int number))
            {
                if(number < 0 )
                {
                    throw new Exception("The value is invalid");
                }
                while (num1 + num2 <= number)
                {

                    series += ", " + num2;
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3;
                }
                if (num2 <= number)
                    series += ", " + num2;
                return series;
            }
            else
            {
                throw new Exception("The value is invalid");
            }
        }

        //Exercise 4
        static string ThreeBigestNum()
        {
            int num1;
            int num2;
            int num3;
            int sum1;
            int sum2;
            string threeNums;
            string input;
            int [] numArry = new int[3];

            Console.WriteLine("enter numbers, to finish insert -1.");
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number == -1)
                        throw new Exception("You need to enter at least 3 numbers.");
                }
                else
                    throw new Exception("The value is invalid");
                
                numArry[i] = number;
            }



            sum1 = numArry[0] + numArry[1] + numArry[2];

            
            threeNums = numArry[0] + "," + numArry[1] + "," + numArry[2];


            num1 = numArry[0];
            num2 = numArry[1];
            num3 = numArry[2];

            input = Console.ReadLine();
            if (int.TryParse(input, out int num))
            {
                while (num != -1) 
                {
                    sum2 = sum1 + num - num1;
                    if (sum1 < sum2)
                        threeNums = num2 + "," + num3 + "," + num;
                    num1 = num2;
                    num2 = num3;
                    num3 = num;
                    sum1 = sum2;
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int newNum))
                        num = newNum;
                    else
                        throw new Exception("The value is invalid");
                }
                return threeNums;
            }
            else
                throw new Exception("The value is invalid");
        }
    }
}
