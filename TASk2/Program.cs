int n=Convert.ToInt32(Console.ReadLine());
int []arr=new int[n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int k=Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if(i==k){
        for (int j = i; j<n-1; j++)
        {
            arr[j]=arr[j+1];
        }
    }
}
for (int i = 0; i < n-1; i++)
{
   System.Console.Write(arr[i]+" ");
}