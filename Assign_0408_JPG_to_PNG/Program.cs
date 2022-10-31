string path = @"C:\.net Training\Solution\Paint source\Paint image.jpg";

string dest = @"C:\.net Training\Solution\Paint dest";

try
{

    void JPGtoPNG(string src, string dest)
    {
        FileInfo fileInfo = new FileInfo(src);

        dest = Path.Combine(dest, fileInfo.Name);

        dest = Path.ChangeExtension(dest, ".png");

        fileInfo.CopyTo(dest, true);
    }
    JPGtoPNG(path, dest);
}
catch (Exception ex)
{

    throw new Exception(ex.Message);
}

