int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

void nechet (int a,int b){
    if(a%2!=0){
    if(a==b || a>b){
      System.Console.WriteLine(" ");
    }
    else{
       
        System.Console.Write(a+" ");
         nechet(a+2,b);
    } }
    else  {  if(a==b || a>b){
      System.Console.WriteLine(" ");
    }
    else{
       
        System.Console.Write(a+1+" ");
         nechet(a+2,b);
    } }
}



void chet (int a,int b){
    if(a%2==0){
    if(a==b || a>b){
      System.Console.WriteLine(" ");
    }
    else{
       
        System.Console.Write(a+" ");
         chet(a+2,b);
    } 
    }
    else
    {
    if(a==b || a>b){
      System.Console.WriteLine(" ");
    }
    else{
       
        System.Console.Write(a+1+" ");
         chet(a+2,b);
    } 
    }
}
chet(a,b);
nechet(a,b);