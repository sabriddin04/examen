int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int [n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if(arr[i]>0){
        arr[i]=0;
    }
}
for (int i = 0; i < n; i++)
{
    System.Console.Write(arr[i]+" ");
}
