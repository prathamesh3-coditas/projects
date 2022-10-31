using Assign_0408_File_Info;

//string srcPath = @"C:\Users\Coditas\Desktop\Ass_0408_srcFolder";
//string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";

string path = @"C:\Users\Coditas\Desktop\Ass_0408_srcFolder";

Operations op = new Operations();


op.GetName(path);

op.GetSize(path);

op.getDateOfModification(path);

op.getTimeOfCreation(path);

for (int i = 0; i < op.Sizes.Count; i++)
{
    Console.WriteLine($"File Name:{op.FileNames[i]}");
    Console.WriteLine($"File Size:{op.Sizes[i]}kb");
    Console.WriteLine($"File Creation Date:{op.CreationDate[i]}");
    Console.WriteLine($"Last Modications done:{op.ModificationDate[i]}");
    Console.WriteLine("--------------------------------------------------------------------------------");
}


