using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_Inheritence.Models;

namespace CS_Inheritance.Logic
{
    public class TechnicianLogic : StaffLogic
    {

        Dictionary<int, Technician> Technicians = new Dictionary<int, Technician>();
        TechnicianLogic techLogic;
        public Dictionary<int, Technician> RegisterTechnician(Technician technician)
        {
            Technicians.Add(technician.TechId,technician);
            return Technicians;
        }

        public Dictionary<int, Technician> UpdateTechnicianInfo(int id, Technician technician)
        {

            foreach (var item in Technicians)
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
                                foreach (var record in Technicians.Values)
                                {
                                    if (record.TechId == id)
                                    {
                                        record.StaffName = newName;
                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine("Enter updated mail");
                                String newMail = Console.ReadLine();
                                foreach (var record in Technicians.Values)
                                {
                                    if (record.TechId == id)
                                    {
                                        record.Email = newMail;
                                    }

                                }
                                // item.Email = newMail;
                                break;

                            case 4:
                                Console.WriteLine("Enter updated department");
                                String newDept = Console.ReadLine();
                                foreach (var record in Technicians.Values)
                                {
                                    if (record.TechId == id)
                                    {
                                        record.DeptName = newDept;
                                    }

                                }
                                //item.DeptName = newDept;
                                break;


                            case 5:
                                Console.WriteLine("Enter updated education");
                                String newEdu = Console.ReadLine();
                                foreach (var record in Technicians.Values)
                                {
                                    if (record.TechId == id)
                                    {
                                        record.Education = newEdu;
                                    }
                                }
                                break;
                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }
   
            }
            return Technicians;
        }



        int searched;
        public Dictionary<int, Technician> DeleteTechnician(int idDelete)
        {

            bool deleted = true;
            foreach (var item in Technicians.Keys)
            {
                if (item == idDelete)
                {
                    Technicians.Remove(idDelete);

                    break;
                }
            }

            //Doctors.Remove(searched);

            return Technicians;
        }

        public Dictionary<int, Technician> GetTechnician()
        {
            return Technicians;
        }
    }
}
