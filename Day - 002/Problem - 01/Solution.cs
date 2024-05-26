using System;

public class Test
{
    public static String InsertString(string strInputString,string strNewString,int nIndex){
        
        String strReplacedString = "";
        
        for(int i=0; i<strInputString.Length ;i++){
            
            if(i == nIndex)
            {
                
               strReplacedString += strNewString +strInputString[i];
                
                
            }
            
            else
            {
                strReplacedString += strInputString[i];
            }
        }
        
        return strReplacedString;
    }
	public static void Main(string[] args)
	{
	    string strInputString = "Orange";
	    string strNewString = "Apple";
	    int nIndex = 3;
	    
	    string strResult = InsertString(strInputString,strNewString,nIndex);
	    
	    Console.WriteLine(strResult);
		
	}
}
