using System.IO;
using CS_FirstFile.Operations;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using Files");
try
{
    FileOperation operation = new FileOperation();


    string directory = @"C:\.net Training\Solution\file";
    string file = "InfoNew.txt";
    string file2 = "InfoNew2.txt";




    operation.CreateFile(directory,file);
    operation.CreateFile(directory, file2);


    string contents = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA ";
    operation.WriteFile(directory,file,contents);

    var dataFromFile = operation.ReadFile(directory,file,out contents);

    Console.WriteLine($"Initial Data = {dataFromFile}");

    operation.AppendFile(directory,file, "The Next Data for Append");

    dataFromFile = operation.ReadFile(directory,file,out contents);

    Console.WriteLine($"Data After Append = {dataFromFile}");

    string[] data = new string[] {
      "Line 1","Line 2","Line 3","Line 4"
    };
    operation.AppendFile(directory,file, data);

    dataFromFile = operation.ReadFile(directory,file,out contents);

    Console.WriteLine($"Data After Appending Array = " +
       $"{dataFromFile}");

    string fileName = directory + @"\" + file;
    operation.MakeCopy(fileName, @"C:\.net Training\Solution\File\CopyOfFile.txt");
    operation.MakeCopy(fileName, @"C:\.net Training\Solution\File\CopyOfFile2.txt");


    string destFolder = @"C:\.net Training\Solution\File\Destination\Moved file.txt";
    operation.MoveFile(fileName, destFolder);

    string fileForEncryption = @"C:\.net Training\Solution\File\CopyOfFile.txt";
    string fileForEncryption2 = @"C:\.net Training\Solution\File\CopyOfFile2.txt";

    operation.encryption(fileForEncryption);
    operation.encryption(fileForEncryption2);



    string fileForDecryption = @"C:\.net Training\Solution\File\CopyOfFile2.txt";

    operation.decryption(fileForDecryption);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadLine();