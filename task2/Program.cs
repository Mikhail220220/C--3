Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void Current(int number)
{
int number1 = 1;
//int result = 1;


while (number1 <= number)
{
    double result = Math.Pow(number1,3);
    Console.Write(result + " ," );
    number1 ++;
}
}
Current (number);