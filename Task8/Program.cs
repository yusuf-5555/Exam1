void Swap(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
    System.Console.WriteLine("x = " + a);
    System.Console.WriteLine("y = " + b);

}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Swap(ref a, ref b);
