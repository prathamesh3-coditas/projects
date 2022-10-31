using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assign_0408_File_Info
{
    public class Operations
    {
        public List<object> FileNames = new List<object>();

        public List<object> Sizes = new List<object>();

        public List<object> CreationDate = new List<object>();

        public List<object> ModificationDate = new List<object>();


        void getFiles_Name(string path)
        {
            string[] files = Directory.GetFiles(path);
            int size = 0;
            foreach (var file in files)
            {
                FileNames.Add(Path.GetFileName(file));

            }
        }
        public void GetName(string path)
        {

            getFiles_Name(path);

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs) 
            {
                //Console.WriteLine(Path.GetFileName(file));
                string srcPath = Path.Combine(path, dir);
                getFiles_Name(srcPath);
            }
        }
//==========================================================================

        FileInfo fi;
        void getFiles_Size(string path)
        {
            string[] files = Directory.GetFiles(path);
            int size = 0;
            foreach (var file in files)
            {
                fi = new FileInfo(file);
                size = ((int)(fi.Length) / 1024) + 1;
                //Console.WriteLine(size);
                Sizes.Add(size);
            }
        }
        public void GetSize(string path)
        {

            getFiles_Size(path);

            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                string srcPath = Path.Combine(path, dir);
                getFiles_Size(srcPath);
            }
        }
//==========================================================================


        void getFiles_TimeOfCreation(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                fi = new FileInfo(file);
                DateTime dt = fi.CreationTime;
                CreationDate.Add(dt);
            }
        }
        public void getTimeOfCreation(string path)
        {
            //string[] files = Directory.GetFiles(path);
            //foreach (var file in files)
            //{
            //    fi = new FileInfo(file);
            //    DateTime dt = fi.CreationTime;
            //    //Console.WriteLine(dt);
            //    CreationDate.Add(dt);

            //}
            getFiles_TimeOfCreation(path);
            
            string[] dirs = Directory.GetDirectories(path);

            foreach (var dir in dirs)
            {
                string srchPath = Path.Combine(path, dir);
                getFiles_TimeOfCreation(srchPath);
            }
        }
//=================================================================

        void getFiles_getDateOfModification(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                fi = new FileInfo(file);
                DateTime dt = fi.LastWriteTime;
                ModificationDate.Add(dt);
            }
        }

        public void getDateOfModification(string path)
        {

            getFiles_getDateOfModification(path);

            string[] dirs = Directory.GetDirectories(path);

            foreach (var dir in dirs)
            {
                string srcPath = Path.Combine(path, dir);
                getFiles_getDateOfModification(srcPath);
            }
            //string[] files = Directory.GetFiles(path);
            //foreach (var file in files)
            //{
            //    fi = new FileInfo(file);
            //    DateTime dt = fi.LastWriteTime;
            //    //Console.WriteLine(dt);
            //    ModificationDate.Add(dt);
            //}
        }
    }
}
