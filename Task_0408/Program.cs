using CS_Stream;
// See https://aka.ms/new-console-template for more information
FileStreamOperation operation = new FileStreamOperation();
try
{

    string str = operation.ReadFile();

    Console.WriteLine(str);

    Console.WriteLine("Enter start and count");
    int start = Convert.ToInt32(Console.ReadLine());
    int count = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(operation.charCount(start,count));
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    operation.Dispose();
}
Console.ReadLine();