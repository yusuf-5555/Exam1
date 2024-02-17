void IncrementArrayElements(ref int[] arr, ref int n)
{
    
    for(int i=0;i<n;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int b= Convert.ToInt32(Console.ReadLine());
for(int i=0;i<n;i++)
{
    System.Console.WriteLine(arr[i]+b);
}
}
int[] arr = new int[]{};
int a = Convert.ToInt32(Console.ReadLine());
IncrementArrayElements(ref arr,ref a);
