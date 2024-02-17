int SumOfDigits(int n)
{
    int sum = 0;
    for(int i=n;i>0;i/=10)
    {
        sum = sum + i%10;
    }
    System.Console.Write("The sum of the digits of the number 1234 is : ");
    return sum;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumOfDigits(a));