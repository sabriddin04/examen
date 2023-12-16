int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int k=Convert.ToInt32(Console.ReadLine());
int cnt=0;
for (int i = 0; i < n; i++)
{
    if(arr[i]==k)
   {
    cnt++;
   }
}
System.Console.WriteLine(cnt);