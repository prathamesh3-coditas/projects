using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_Stream
{
    public class FileStreamOperation : IDisposable
    {
        FileStream fs;
        string filePath = string.Empty;
        public FileStreamOperation()
        {
            filePath = @"C:\.net Training\Solution\Task_0408\Read op.txt";
        }

        //public void CreateFile()
        //{
        //    try 
        //    {
        //        fs = new FileStream(filePath, FileMode.CreateNew);
        //        fs.Close();
        //        // fs.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void WriteFile(string contents)
        //{
        //    try
        //    {
        //        fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
        //        StreamWriter sw = new StreamWriter(fs);
        //        sw.Write(contents);
        //        sw.Close();
        //        sw.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public string readLineByLine(int start , int end)
        {
            string str;
            try
            {
                fs = new FileStream(filePath,FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadLine();
                sr.Close();
                sr.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return str;
        }

        public string ReadFile()
        {
            string str = string.Empty;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                str = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return str;
        }

        public char[] charCount(int start,int count)
        {
            int count1;
            char[] chars = new char[count];
            fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            count = sr.ReadBlock(chars,start,count-1);

            sr.Close();
            sr.Dispose();

            return chars;
        }
        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}