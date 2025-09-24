Console.WriteLine("Type in the first number followed by Enter key: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by Enter key: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} + {1} = {2}", firstNumber,secondNumber,result);