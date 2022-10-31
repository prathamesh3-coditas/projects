using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_FirstFile.Operations
{
    public class FileOperation
    {
        public void CreateFile(string directory , string file)
        {

            string fileName = directory + @"\" + file;
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }

                string sub = fileName.Substring(fileName.Length-3,3);

                if (sub.Equals("txt"))
                {
                    FileStream fs = File.Create(fileName);
                    Console.WriteLine("The File is created successfully");
                    // Close the file so that the handle can be released
                    // and the file is accessible fr other operations
                    fs.Close();
                    fs.Dispose();
                }
                else
                {
                    throw new Exception("Extension is not txt"); 
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void WriteFile(string directory,string file, string contents)
        {
            string fileName = directory + @"\" + file;
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }

                string sub = fileName.Substring(fileName.Length - 3, 3);

                if (sub.Equals("txt"))
                {
                    File.WriteAllText(fileName, contents);
                    Console.WriteLine("Contents are written to the File");
                }
                else
                {
                    throw new Exception("Extension is not txt");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public void WriteFile(string fileName, string[] contents)
        //{
        //    try
        //    {
        //        if (fileName == string.Empty)
        //        {
        //            throw new Exception("File Name Cannot be Empty");
        //        }

        //        string sub = fileName.Substring(fileName.Length - 3, 3);

        //        if (sub.Equals("txt"))
        //        {
        //            File.WriteAllLines(fileName, contents);
        //            Console.WriteLine("Contents are written to the File");
        //        }
        //        else
        //        {
        //            throw new Exception("Extension is not txt");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public string ReadFile(string directory,string file,out string contents)
        {

           string fileName = directory + @"\" + file;
            try
            {
                //string contents = string.Empty;
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                string sub = fileName.Substring(fileName.Length - 3, 3);


                if (sub.Equals("txt"))
                {
                    contents = File.ReadAllText(fileName);
                    return contents;

                }
                else
                {
                    throw new Exception("Extension is not txt");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AppendFile(string directory,string file, string contents)
        {
            string fileName = directory + @"\" + file;
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                string sub = fileName.Substring(fileName.Length - 3, 3);

                if (sub.Equals("txt"))
                {
                    File.AppendAllText(fileName, contents);
                }
                else
                {
                    throw new Exception("Extension is not txt");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MoveFile(string srcFileName, string destFileName)
        {
            if (srcFileName == string.Empty || destFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }


            string subSource = srcFileName.Substring(srcFileName.Length - 3, 3);
            string subDest = destFileName.Substring(destFileName.Length - 3, 3);

            if (subSource.Equals("txt") && subDest.Equals("txt"))
            {
                File.Move(srcFileName, destFileName);
            }
            else
            {
                throw new Exception("Extension of either source or destination is not txt");
            }

        }
        public void AppendFile(string directory,string file,string[] contents)
        {

            string fileName = directory + @"\" + file;
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }

                string sub = fileName.Substring(fileName.Length - 3, 3);

                if (sub.Equals("txt"))
                {
                    
                    File.AppendAllLines(fileName, contents);
                }
                else
                {
                    throw new Exception("Extension is not txt");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        
        public void MakeCopy(string srcFileName, string destFileName)
        {
            if (srcFileName == string.Empty || destFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }


            string subSource = srcFileName.Substring(srcFileName.Length - 3, 3);
            string subDest = destFileName.Substring(destFileName.Length - 3,3);

            if (subSource.Equals("txt") && subDest.Equals("txt"))
            {
                File.Copy(srcFileName, destFileName);
            }
            else
            {
                throw new Exception("Extension of either source or destination is not txt");
            }
    
        }

        public void encryption(string fileName)
        {
            File.Encrypt(fileName);
            Console.WriteLine("File encrypted");
        }

        public void decryption(string fileName)
        {
            File.Decrypt(fileName);
            Console.WriteLine("File Decrypted");
        }
    }
}