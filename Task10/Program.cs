using System.Reflection.Metadata.Ecma335;

int odd(int a,int b)
{
    if(a==b){
        return b;
    }
    else{
        if(a%2==0){
        return a + odd(a+1,b);
        }
        else
        {
            
            return a + odd(a+1,b);
        }
    }
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(odd(a,b));
