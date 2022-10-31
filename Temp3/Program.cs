using System.Drawing;

string path = @"C:\.net Training\NetELTP\profile image.png";

Image img = Image.FromFile(path);

byte[] ByteArray(Image img)
{
    using (MemoryStream ms = new MemoryStream())
    {
        img.Save(ms,img.RawFormat);
        return ms.ToArray();
    }
}

var arr = ByteArray(img);

foreach (var item in arr)
{
    Console.Write(item+"    ");
}


MemoryStream ms = new MemoryStream();
ms.Write(arr,0,arr.Length); 
Image img2 = Image.FromStream(ms);
img2.Save(@"C:\.net Training\NetELTP\Copied image.png");
