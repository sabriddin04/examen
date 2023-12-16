int n=Convert.ToInt32(Console.ReadLine());

int Sum(int n){
    int sum1=0;
    while(n>0){
        sum1+=n%10;
        n/=10;

    }
    return sum1;
}
System.Console.Write("The sum of the digits of the number " +n+" is : "+Sum(n));
