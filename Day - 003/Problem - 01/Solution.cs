using System;
public class Test
{
public static bool AnagramChecker(string strInput1, string strInput2)
{
if (strInput1.Length != strInput2.Length)
{
return false;
}
int[] nLettersCount1 = new int[26];
int[] nLettersCount2 = new int[26];
foreach (char c in strInput1)
{
int index = char.ToLower(c) - 'a';
if (index >= 0 && index < 26)
{
nLettersCount1[index]++;
}
}
foreach (char c in strInput2)
{
int index = char.ToLower(c) - 'a';
if (index >= 0 && index < 26)
{
nLettersCount2[index]++;
}
}
for (int i = 0; i < 26; i++)
{
if (nLettersCount1[i] != nLettersCount2[i])
{
return false;
}
}
return true;
}
public static void Main()
{
string strInput1 = "silent";
string strInput2 = "listen";

bool result = AnagramChecker(strInput1, strInput2);
Console.WriteLine(result ? "Yes" : "No");
}
}