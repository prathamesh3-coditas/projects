//Func<string, int> method = Work;
//IAsyncResult cookie = method.BeginInvoke("abc",Done,method);
////
//// ... here's where we can do other work in parallel...
////
//int result = method.EndInvoke(cookie);
//Console.WriteLine("String length is: " + result);



//internal class SemaphoreS
//{
//}


string EncryptDecrypt(string str)
{
	char xorKey = 'd';
	string output = string.Empty;
	foreach (var c in str)
	{
		
		output += char.ToString((char)(c ^ xorKey));
	}


	return output;
}

string encrypted = EncryptDecrypt("password");
Console.WriteLine("encryption");
Console.WriteLine(encrypted);


Console.WriteLine("Decryption");
Console.WriteLine(EncryptDecrypt(encrypted));

