using System.Globalization;

int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int b = -99999;
int c = 99999;
for(int i=0;i<a;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
    if(arr[i]>b)b=i;
}
for(int i=0;i<a;i++)
{
    if(arr[i]<c)c=i;
}
if(c>b)
{
    for(int i=c;i>=b;i--)
    {
        System.Console.Write(arr[i]);
    }
}
if(c<b)
{
    for(int i=c;i<=b;i++)
    {
        System.Console.Write(arr[i]);
    }
}