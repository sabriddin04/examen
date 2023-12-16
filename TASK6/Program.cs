int n=Convert.ToInt32(Console.ReadLine());
void fib(int n){
   int first=0;
   int second =1;
   int t=first+second;
   if(n>2){
    System.Console.Write(first+" "+second+" ");
   while(n-2>0){
    System.Console.Write(t+" ");
   first=second;
   second=t;
   t=first+second;
    
    n--;

   }
   }
}
fib(n);
