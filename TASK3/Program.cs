int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int [n];
for (int i = 0; i < n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int max=arr[0];
int min=arr[0];
int indexmin=0;
int indexmax=0;
for (int i = 0; i < n; i++)
{
    if(min>arr[i]){
        min=arr[i];
        indexmin=i;
    }
    if(max<arr[i]){
        max=arr[i];
        indexmax=i;
    }
}
if(min<max){
    for(int i=indexmin;i<=indexmax;i++){
        System.Console.Write(arr[i]+" ");
    }
}
else if(min>max){
    for(int i=indexmax;i<=indexmin;i++){
        System.Console.Write(arr[i]+" ");
    }
}