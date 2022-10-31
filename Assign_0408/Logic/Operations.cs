using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assign_0408.Entity;

namespace Assign_0408.Logic
{
    public class Operations
    {

        StaffLogic sl = new StaffLogic();
        Doctor drObj = new Doctor();
        Nurse nrObj = new Nurse();
        Driver drvobj = new Driver();

        public string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";
        string newPath = @"C:\.net Training\Solution\Employee data\Whole_DataNew.txt";


        public void RegisterStaff()
        {

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);


            StreamWriter sw = new StreamWriter(fs);

            foreach (var item in sl)
            {
                if (item.StaffCatagory == "Doctor")
                {
                    var dr = (Doctor)item;
                    sw.WriteLine($"Id:{dr.Id} Name:{dr.Name} Basic-Pay:{dr.BasicPay} Staff-Catagory:{dr.StaffCatagory} Patients-handelled:{dr.MaxPatientsPerDay} " +
                        $"Eductaion:{dr.Education} Specialization:{dr.Specialization}");
                }
                else if (item.StaffCatagory == "Nurse")
                {
                    var nr = (Nurse)item;
                    sw.WriteLine($"Id:{nr.Id} Name:{nr.Name} Basic-Pay:{nr.BasicPay} Staff-Catagory:{nr.StaffCatagory} Extra hours:{nr.ExtraHours} " +
                        $"Experience:{nr.Experience}");
                }
                else if (item.StaffCatagory == "Driver")
                {
                    var drv = (Driver)item;
                    sw.WriteLine($"Id:{drv.Id} Name:{drv.Name} Basic-Pay:{drv.BasicPay} Staff-Catagory:{drv.StaffCatagory} Bonus:{drv.Bonus} " +
                        $"Vehicle Type:{drv.Vehicletype}");
                }
            }
            sw.Close();
            fs.Close();
        }


        public void GetDetailsByCatagory(string Catagory)
        {
            //string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";

            FileInfo fi = new FileInfo(path);

            StreamReader sr = fi.OpenText();
            string str = string.Empty;
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(Catagory))
                {
                    Console.WriteLine(str);
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }

            sr.Close();
            
        }


        public void getDetailsById(int id)
        {
            //string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";

            FileInfo fi = new FileInfo(path);

            StreamReader sr = fi.OpenText();

            string str = string.Empty;
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(id.ToString()))
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Console.WriteLine(str);
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                }
            }

            sr.Close();
        }


        public void getDetailsByCount(int count)
        {
            //string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";

            FileInfo fi = new FileInfo(path);

            StreamReader sr = fi.OpenText();

            for (int i = 0; i < count; i++)
            {
                string str = sr.ReadLine();
                Console.WriteLine(str);
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
            
            sr.Close();
            // char[] buffer = new char[1024];

            //sr.ReadBlock(buffer, 0, buffer.Length);

            // foreach (var item in buffer)
            // {
            //     Console.Write(item);
            // }
        }

        public void DeleteStaff(int id)
        {

            string id_string = id.ToString();

            //string path = @"C:\.net Training\Solution\Employee data\Whole_Data.txt";
            string newPath = @"C:\.net Training\Solution\Employee data\Whole_DataNew.txt";
            FileInfo fi = new FileInfo(path);

            StreamReader sr = fi.OpenText();

            string str = string.Empty;

            FileStream fs = new FileStream(newPath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(id_string))
                {
                    continue;
                }
                else
                {
                    sw.WriteLine(str);
                }
            }

            fs.Close();
            sr.Close();

            File.Delete(path);
            File.Move(newPath, path);//renaming the file

        }
        //////////// /////////////////////////////////////////////////////////////////////////////////////////
        //FileStream fs;
        //StreamWriter sw;
        //StreamReader sr;
        //public void fsOpen()
        //{
        //    fs = new FileStream(path,FileMode.Open,FileAccess.ReadWrite);
        //}

        //public void fsClose()
        //{
        //    fs.Close();
        //}

        //public void swOpen()
        //{
        //    sw = new StreamWriter(fs);
        //}

        //public void swClose()
        //{
        //    sw.Close();
        //}

        //public void srOpen()
        //{
        //    FileInfo fi = new FileInfo(path);
        //    sr = fi.OpenText();
        //}

        //public void srClose()
        //{
        //    sr.Close();
        //}
        public void UpdateByStaffId(int id)
        {
            string id_string = id.ToString();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string str = string.Empty;
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(id_string))
                {
                    if (str.Contains("Doctor") || str.Contains("doctor"))
                    {
                        string cont = "y";
                        do
                        {
                            Console.WriteLine("Enter 1 to update max patients handelled");
                            Console.WriteLine("Enter 2 to update Education");
                            Console.WriteLine("Enter 3 to update Specialization");
                            Console.WriteLine("Enter 4 to update name");
                            Console.WriteLine("Enter 5 to update Basic-Pay");
                            Console.WriteLine();
                            int choice = Convert.ToInt32(Console.ReadLine());

                            string cont1 = "y";
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter updated value for patients handelled per day");
                                    int patients_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var dr_type = drObj.GetType();
                                        if (Object.ReferenceEquals(item_type, dr_type))
                                        {
                                            var d = (Doctor)item;

                                            if (id == d.Id)
                                            {
                                                d.MaxPatientsPerDay = patients_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp = new StreamWriter(fsTemp);

                                    foreach (var dr in sl)
                                    {
                                        if (dr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)dr;
                                            swtemp.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)dr;
                                            swtemp.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)dr;
                                            swtemp.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp.Close();
                                    fsTemp.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);

                                    break;
                                //////////////////////////////////////////////////////////////
                                case 2:
                                    Console.WriteLine("Enter updated value for Education");
                                    string Education_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var dr_type = drObj.GetType();
                                        if (Object.ReferenceEquals(item_type, dr_type))
                                        {
                                            var d = (Doctor)item;

                                            if (id == d.Id)
                                            {
                                                d.Education = Education_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp2 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp2 = new StreamWriter(fsTemp2);

                                    foreach (var dr in sl)
                                    {
                                        if (dr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)dr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)dr;

                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)dr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp2.Close();
                                    fsTemp2.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                //////////////////////////////////////////////////////////////
                                case 3:
                                    Console.WriteLine("Enter updated value for Specialization");
                                    string Specialization_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var dr_type = drObj.GetType();
                                        if (Object.ReferenceEquals(item_type, dr_type))
                                        {
                                            var d = (Doctor)item;

                                            if (id == d.Id)
                                            {
                                                d.Specialization = Specialization_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp3 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp3 = new StreamWriter(fsTemp3);

                                    foreach (var dr in sl)
                                    {
                                        if (dr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)dr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)dr;

                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)dr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp3.Close();
                                    fsTemp3.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;

                                /////////////////////////////////////
                                case 4:
                                    Console.WriteLine("Enter updated value for Name");
                                    string Name_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var dr_type = drObj.GetType();
                                        if (Object.ReferenceEquals(item_type, dr_type))
                                        {
                                            var d = (Doctor)item;

                                            if (id == d.Id)
                                            {
                                                d.Name = Name_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp4 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp4 = new StreamWriter(fsTemp4);

                                    foreach (var dr in sl)
                                    {
                                        if (dr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)dr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)dr;

                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)dr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp4.Close();
                                    fsTemp4.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                ///////////////////////////////////////////// 
                                case 5:
                                    Console.WriteLine("Enter updated value for Basic Pay");
                                    int Basic_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var dr_type = drObj.GetType();
                                        if (Object.ReferenceEquals(item_type, dr_type))
                                        {
                                            var d = (Doctor)item;

                                            if (id == d.Id)
                                            {
                                                d.BasicPay = Basic_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp5 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp5 = new StreamWriter(fsTemp5);

                                    foreach (var dr in sl)
                                    {
                                        if (dr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)dr;
                                            swtemp5.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)dr;

                                            swtemp5.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (dr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)dr;
                                            swtemp5.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp5.Close();
                                    fsTemp5.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;

                            }
                            Console.WriteLine("Enter \"y\" or \"Y\" to continue updating doctor");
                            cont = Console.ReadLine();
                            Console.Clear();
                        } while (cont == "y" || cont == "Y");
                    }
                    else if (str.Contains("Nurse") || str.Contains("nurse"))
                    {


                        string cont = "y";
                        do
                        {

                            Console.WriteLine("Enter 1 to update extra hours");
                            Console.WriteLine("Enter 2 to update experience");
                            Console.WriteLine("Enter 3 to update name");
                            Console.WriteLine("Enter 4 to update Basic-Pay");
                            int choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter updated value for Extra hours");
                                    int ExtraHours_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var nr_type = nrObj.GetType();
                                        if (Object.ReferenceEquals(item_type, nr_type))
                                        {
                                            var n = (Nurse)item;

                                            if (id == n.Id)
                                            {
                                                n.ExtraHours = ExtraHours_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp1 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp1 = new StreamWriter(fsTemp1);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp1.Close();
                                    fsTemp1.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                ///////////////////////////////////////////////
                                case 2:
                                    Console.WriteLine("Enter updated value for Experience");
                                    int Exp_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var nr_type = nrObj.GetType();
                                        if (Object.ReferenceEquals(item_type, nr_type))
                                        {
                                            var n = (Nurse)item;

                                            if (id == n.Id)
                                            {
                                                n.Experience = Exp_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp2 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp2 = new StreamWriter(fsTemp2);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp2.Close();
                                    fsTemp2.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                ///////////////////////////////////////////////
                                case 3:
                                    Console.WriteLine("Enter updated value for Name");
                                    string Name_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var nr_type = nrObj.GetType();
                                        if (Object.ReferenceEquals(item_type, nr_type))
                                        {
                                            var n = (Nurse)item;

                                            if (id == n.Id)
                                            {
                                                n.Name = Name_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp3 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp3 = new StreamWriter(fsTemp3);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp3.Close();
                                    fsTemp3.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;

                                ////////////////////////////////////////////////
                                case 4:
                                    Console.WriteLine("Enter updated value for Basic pay");
                                    int Basic_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var nr_type = nrObj.GetType();
                                        if (Object.ReferenceEquals(item_type, nr_type))
                                        {
                                            var n = (Nurse)item;

                                            if (id == n.Id)
                                            {
                                                n.BasicPay = Basic_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp4 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp4 = new StreamWriter(fsTemp4);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp4.Close();
                                    fsTemp4.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                            }
                            Console.WriteLine("Enter \"y\" or \"Y\" to continue updating nurse");
                            cont = Console.ReadLine();
                            Console.Clear();
                        } while (cont == "y" || cont == "Y");
                    }
                    else if (str.Contains("Driver") || str.Contains("driver"))
                    {

                        string cont = "y";
                        do
                        {
                            Console.WriteLine("Enter 1 to update Bonus amount");
                            Console.WriteLine("Enter 2 to update vehicle type");
                            Console.WriteLine("Enter 3 to update name");
                            Console.WriteLine("Enter 4 to update Basic-Pay");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter updated value for Bonus amount");
                                    int Bonus_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var drv_type = drvobj.GetType();
                                        if (Object.ReferenceEquals(item_type, drv_type))
                                        {
                                            var n = (Driver)item;

                                            if (id == n.Id)
                                            {
                                                n.Bonus = Bonus_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp1 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp1 = new StreamWriter(fsTemp1);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp1.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp1.Close();
                                    fsTemp1.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                //////////////////////////////////////////////////
                                case 2:
                                    Console.WriteLine("Enter updated value for Vehicles type");
                                    string Vehicle_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var drv_type = drvobj.GetType();
                                        if (Object.ReferenceEquals(item_type, drv_type))
                                        {
                                            var n = (Driver)item;

                                            if (id == n.Id)
                                            {
                                                n.Vehicletype = Vehicle_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp2 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp2 = new StreamWriter(fsTemp2);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp2.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp2.Close();
                                    fsTemp2.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                ////////////////////////////////////////////////
                                case 3:
                                    Console.WriteLine("Enter updated value for Name");
                                    string Name_updated = Console.ReadLine();


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var drv_type = drvobj.GetType();
                                        if (Object.ReferenceEquals(item_type, drv_type))
                                        {
                                            var n = (Driver)item;

                                            if (id == n.Id)
                                            {
                                                n.Name = Name_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp3 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp3 = new StreamWriter(fsTemp3);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp3.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp3.Close();
                                    fsTemp3.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                                //////////////////////////////////////////////////
                                case 4:
                                    Console.WriteLine("Enter updated value for Basic Pay");
                                    int Basic_updated = Convert.ToInt32(Console.ReadLine());


                                    foreach (var item in sl)
                                    {
                                        var item_type = item.GetType();
                                        var drv_type = drvobj.GetType();
                                        if (Object.ReferenceEquals(item_type, drv_type))
                                        {
                                            var n = (Driver)item;

                                            if (id == n.Id)
                                            {
                                                n.BasicPay = Basic_updated;
                                                break;
                                            }

                                        }
                                    }
                                    FileStream fsTemp4 = new FileStream(newPath, FileMode.CreateNew, FileAccess.Write);
                                    StreamWriter swtemp4 = new StreamWriter(fsTemp4);

                                    foreach (var nr in sl)
                                    {
                                        if (nr.StaffCatagory.Equals("Doctor"))
                                        {
                                            var item = (Doctor)nr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Patients-handelled:{item.MaxPatientsPerDay} " +
                                $"Eductaion:{item.Education} Specialization:{item.Specialization}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Nurse"))
                                        {
                                            var item = (Nurse)nr;

                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Extra hours:{item.ExtraHours} " +
                            $"Experience:{item.Experience}");
                                        }
                                        else if (nr.StaffCatagory.Equals("Driver"))
                                        {
                                            var item = (Driver)nr;
                                            swtemp4.WriteLine($"Id:{item.Id} Name:{item.Name} Basic-Pay:{item.BasicPay} Staff-Catagory:{item.StaffCatagory} Bonus:{item.Bonus} " +
                            $"Vehicle Type:{item.Vehicletype}");
                                        }

                                    }

                                    swtemp4.Close();
                                    fsTemp4.Close();

                                    fs.Close();
                                    sr.Close();

                                    File.Delete(path);
                                    File.Move(newPath, path);

                                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                                    sr = new StreamReader(fs);
                                    break;
                            }
                            Console.WriteLine("Enter \"y\" or \"Y\" to continue updating driver");
                            cont = Console.ReadLine();
                            Console.Clear();
                        } while (cont == "y" || cont == "Y");
                    }



                }
                
                
            }

        }
    }
}
