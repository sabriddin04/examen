System.Console.Write("x=");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("y=");
int b=Convert.ToInt32(Console.ReadLine());

void Swap(ref int a, ref int b)
{
   a=a+b;
   b=a-b;
   a=a-b;



}
Swap(ref a,ref b);
System.Console.Write("x=");
 System.Console.WriteLine(a);
 System.Console.Write("y=");
  System.Console.WriteLine(b);

