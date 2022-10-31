// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

String str = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny. The character—also known by the code number 007 (pronounced double-O-seven)—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale(a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";



//number of words
int count = 1;
for (int i = 0; i < str.Length-1; i++)
{
    if (str[i]==' ' && Char.IsLetter(str[i + 1]))
    {
        count++;
    }
}
Console.WriteLine("Number of words:");
Console.WriteLine(count);


//Number of sentences
count = 1;
for (int i = 0; i < str.Length-2; i++)
{
    
    if (str[i]=='.' && str[i+1]==' ' && Char.IsLetter(str[i + 2]))
    {
        count++;
    }
}
Console.WriteLine("Number of senteces:");
Console.WriteLine(count);


//UpperCase of each letter
/*Console.WriteLine("\n");
count = 0;
String str_temp = str.ToLower();
str_temp = 'T' + str_temp;
str_temp=str.Remove(1,0);
String s = "abcdefghijklmnopqrstuvwxyz";
String s1 = "";

for (int i = 0; i < str_temp.Length-1; i++)
{
    
    if (str_temp[i]==' ' && s.Contains(str_temp[i + 1].ToString()))
    {
           s1=s1+ " " + str_temp[i + 1].ToString().ToUpper();
            i++;

    }
    else
    {
        s1 = s1 + str_temp[i];
    }
}
Console.Write(s1);*/

//---------------------------------------------------------

//UpperCase of each letter
String[] str1 = str.Split(' ');

String sample;
foreach (String s in str1)
{
    sample = String.Empty;

    if (Char.IsLetter(s[0]) && (int)s[0] >= 97 && (int)s[0] <= 122)
    {
        int a = s[0] - 32;
        char c = (char)a;

        sample = sample + c;

        for (int i = 1; i < s.Length; i++)
        {
            sample = sample + s[i];
        }
        sample += " ";
    }
    else
    {
        sample = s + " ";
    }

    Console.Write(sample);

}



//---------------------------------------------------------

//Special char
Console.WriteLine("\n");
String chars = " abcdefghijklmnopqrstuvwxyz1234567890";
String temp = str.ToLower();

count = 0;
for (int i = 0; i < temp.Length; i++)
{
    if (!chars.Contains(temp[i].ToString()))
    {
        count++;
    }
}
Console.WriteLine("Number of special chars are:");
Console.WriteLine(count);


//blank spaces
Console.WriteLine("\n");
count = 0;
for (int i = 0; i < str.Length; i++)
{
    if (str[i]==' ')
    {
        count++;
    }
}
Console.WriteLine("Blank spaces are:");
Console.WriteLine(count);


//Indexes of digits
Console.WriteLine("\n");
String temp1 = "0123456789";
Console.WriteLine("indexes of digits are:");
for (int i = 0; i < str.Length; i++)
{
    if (temp1.Contains(str[i]))
    {
        Console.Write($"{str[i]} is at {i} \n");
    }
}

