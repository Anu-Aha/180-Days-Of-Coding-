using System;

public class ReverseString
{
    public static string StringReverse(string strInput)
    {
        string nReversedString = "";
        
        for(int i=strInput.Length-1;i>=0;i--)
        {
            if(i==strInput.Length-1){
                nReversedString += strInput[i].ToString().ToUpper();
            }
            else{
                nReversedString += strInput[i].ToString().ToLower();
            }
            
           
        }
        
        
        return nReversedString;
    }
    public static void Main(string[] args)
    {
        string strInput="Apple";
        
        string strResult = StringReverse(strInput);
        
        Console.WriteLine(strResult);
    }
}