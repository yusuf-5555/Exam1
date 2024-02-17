
void Fibonacci(int n)
{
    int fib1 = 0;
    int fib2 = 1;
    for(int i=0;i<n;i++){
        int next = fib1+fib2;
        fib1 = fib2;
        fib2 = next;
    }
    System.Console.WriteLine(fib1);
}
int a = Convert.ToInt32(Console.ReadLine());
Fibonacci(a);