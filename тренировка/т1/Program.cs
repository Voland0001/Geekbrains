// See https://aka.ms/new-console-template for more information
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
             + "ежели бы вас послали вместо нашего милого Винценгероде,"
             + "вы бы взяли приступом согласие прусского короля."
             + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string tex, char oldValue, char newValue)
{
    string result = String.Empty;
    int length= tex.Length;
    for(int i=0; i<length; i++)
    {
         if(tex[i] == oldValue) result = result + $"{newValue}";
         else result = result + $"{tex[i]}"; 
    } 
    return result;
}
string NewReplase = Replace(text, ' ', '|');
// Console.WriteLine (NewReplase);
// Console.WriteLine ();
NewReplase = Replace(NewReplase, 'к', 'К');
NewReplase = Replace(NewReplase, 'с', 'С');
Console.WriteLine (NewReplase);