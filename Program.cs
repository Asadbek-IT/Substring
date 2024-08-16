var longString = "This guy is very strongman";
Console.WriteLine(longString.Replace("is", "IS"));
Console.WriteLine(longString.Replace("iS", "IS", StringComparison.CurrentCultureIgnoreCase)); // ignoring up case

string[] words = {"Apple", "Android", "Windows"};
string result = string.Join("-", words);
Console.WriteLine(result);

string[] items = {"book", "pen", "notebook"};
string result1 = string.Join("|", items);
Console.WriteLine(result1);

string tekst = "hello";
int index = tekst.IndexOf("o");
Console.WriteLine(index);

string tekst2 = "THe quick brown fox jumps over the lazy dog";
int index2 = tekst2.IndexOf("quick");
Console.WriteLine(index2);

string tekst3 = "Hello";
string result3 = tekst3.Remove(5);
Console.WriteLine(result3);

string tekst4 = "Hello";
string result4 = tekst4.PadLeft(10);
Console.WriteLine(result4);

string tekst5 = "Hello";
string result5 = tekst5.PadRight(10);
Console.WriteLine(result5);

string tekst6 = "Hello";
char[] charArray = tekst6.ToCharArray();
foreach(char c in charArray)
{
    Console.WriteLine(c);
}

string tekst7 = "Hello World";
int result7 = tekst7.LastIndexOf("o");
Console.WriteLine(result7);

