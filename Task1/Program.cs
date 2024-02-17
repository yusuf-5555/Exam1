int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int cnt=1;
for(int i=0;i<a;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a-1;i++)
{
    if(arr[i+1]-arr[i]!=0){
        cnt++;
    }
}
System.Console.WriteLine(cnt);