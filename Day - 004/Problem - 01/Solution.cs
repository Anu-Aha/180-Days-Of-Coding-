using System;
public class Test
{
public static int Factorial(int nInput){
    
    int nResult = 1;
    
    for(int i=1;i<=nInput;i++){
        
        nResult *= i;
    }
    
    return nResult;
}
public static void Main()
{
int nInput = 6;

int FactNumber = Factorial(nInput);
Console.WriteLine(FactNumber);
}
}