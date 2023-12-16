int [] arr=new int []{1,2,3,4,5};
int b=Convert.ToInt32(Console.ReadLine());
 void sabr( ref int [] arr,int b){
    for(int i=0;i<5;i++){
        arr[i]+=b;
    }
    System.Console.Write("{");
    for(int i=0;i<5;i++){
       
        if(i==4) System.Console.Write(arr[i]);
        else System.Console.Write(arr[i]+",");
    }

    System.Console.Write("}");

}
sabr( ref arr,b);