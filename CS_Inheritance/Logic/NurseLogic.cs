using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;
using CS_Inheritance.Logic;
namespace CS_Inheritance.Logic
{
    public class NurseLogic : StaffLogic
    {
        Dictionary<int, Nurse> Nurses = new Dictionary<int, Nurse>();
        NurseLogic nurseLogic;

        public Dictionary<int,Nurse> Register(Nurse nurse)
        {
            Nurses.Add(nurse.NurseId,nurse);
            return Nurses;
        }

        public Dictionary<int, Nurse> UpdateNurseInfo(int id, Nurse nurse)
        {

            foreach (var item in Nurses)
            {
                if (item.Key == id)
                {

                    String wish = "y";

                    do
                    {
                        Console.WriteLine("====================================================");

                        Console.WriteLine("Press 1 to update name");
                        Console.WriteLine("Press 2 to update email");
                        Console.WriteLine("Press 3 to department");
                        Console.WriteLine("Press 4 to update gender");
                        Console.WriteLine("Press 5 to update DOB");
                        Console.WriteLine("Press 6 to update catagory");
                        Console.WriteLine("Press 7 to update education");
                        Console.WriteLine("Press 8 to update contact details");
                        int updatedChoice = Convert.ToInt32(Console.ReadLine());

                        switch (updatedChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter updated name");
                                String newName = Console.ReadLine();
                                foreach (var record in Nurses.Values)
                                {
                                    if (record.NurseId == id)
                                    {
                                        record.StaffName = newName;
                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine("Enter updated mail");
                                String newMail = Console.ReadLine();
                                foreach (var record in Nurses.Values)
                                {
                                    if (record.NurseId == id)
                                    {
                                        record.Email = newMail;
                                    }

                                }
                                // item.Email = newMail;
                                break;

                            case 4:
                                Console.WriteLine("Enter updated department");
                                String newDept = Console.ReadLine();
                                foreach (var record in Nurses.Values)
                                {
                                    if (record.NurseId == id)
                                    {
                                        record.DeptName = newDept;
                                    }

                                }
                                //item.DeptName = newDept;
                                break;


                            case 5:
                                Console.WriteLine("Enter updated education");
                                String newEdu = Console.ReadLine();
                                foreach (var record in Nurses.Values)
                                {
                                    if (record.NurseId == id)
                                    {
                                        record.Education = newEdu;
                                    }
                                }
                                // item.Education = newEdu;
                                break;
                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }
                //else
                //{
                //    while (item.Key != id)
                //    {
                //        Console.WriteLine("Record not found!! Please enter valid ID.");
                //        id = Convert.ToInt32(Console.ReadLine());
                //    }
                //    logic.UpdateDoctorInfo(id,Nurses);

                //}
            }
            return Nurses;
        }



        int searched;
        public Dictionary<int, Nurse> DeleteNurse(int idDelete)
        {

            bool deleted = true;
            foreach (var item in Nurses.Keys)
            {
                if (item == idDelete)
                {
                    Nurses.Remove(idDelete);
                    break;
                }
            }

            //Doctors.Remove(searched);

            return Nurses;
        }

        public Dictionary<int,Nurse> Getnurse()
        {
            return Nurses;
        }
    }
}
