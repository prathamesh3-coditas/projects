string srcPath = @"C:\Users\Coditas\Desktop\Ass_0408_srcFolder";
string destPath = @"C:\Users\Coditas\Desktop\DestFolder";

string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";


string[] dirs = Directory.GetDirectories(srcPath);
string[] fileArray = Directory.GetFiles(srcPath);

foreach (string file in fileArray)
{
    string fileName = Path.GetFileName(file);//Extracting file name from path
    string final = Path.Combine(destPath, fileName);//giving file name in destination folder
    File.Copy(file, final, true);//copying from source to destination and allowed overwriting
}


//Function to copy file from one directory to another
static void myFunc(string srcPath, string destPath)
{
    string[] fileArray = Directory.GetFiles(srcPath);

    foreach (string file in fileArray)
    {
        string fileName = Path.GetFileName(file);
        string final = Path.Combine(destPath, fileName);
        File.Copy(file, final, true);
    }
}




foreach (string dir in dirs)
{

    FileInfo fi = new FileInfo(dir);
    string dirName = fi.Name;//extracting directory name from path

    string finalSrcPath = Path.Combine(srcPath, dirName);
    string finalDestPath = Path.Combine(destPath, dirName);

    Directory.CreateDirectory(finalDestPath);//created same sub-directory in destination directory
    myFunc(finalSrcPath, finalDestPath);

}


