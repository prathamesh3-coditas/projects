using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic_Class
{
    public class StaffLogic
    {
 
        List<Staff> staffs = new List<Staff>();

   
        public List<Staff> RegisterNewStaff(Staff staff)
        {
            staffs.Add(staff);
            return staffs;
        }
        public List<Staff> UpdateStaffInfo(int id, Staff staff)
        {
            
            foreach (var item in staffs)
            {
                if (item.StaffId == id)
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

                                item.StaffName = newName;
                                break;

                            case 2:
                                Console.WriteLine("Enter updated mail");
                                String newMail = Console.ReadLine();

                                item.Email = newMail;
                                break;

                            case 3:
                                Console.WriteLine("Enter updated department");
                                String newDept = Console.ReadLine();

                                item.DeptName = newDept;
                                break;

                            case 4:
                                Console.WriteLine("Enter updated gender");
                                String newGender = Console.ReadLine();

                                item.Gender = newGender;
                                break;

                            case 5:
                                Console.WriteLine("Enter updated Birthdate");
                                DateTime newDOB = Convert.ToDateTime(Console.ReadLine());

                                item.DateOfBirth = newDOB;
                                break;

                            case 6:
                                Console.WriteLine("Enter updated catagory");
                                String newCatagory = Console.ReadLine();

                                item.StaffCategory = newCatagory;
                                break;

                            case 7:
                                Console.WriteLine("Enter updated education");
                                String newEdu = Console.ReadLine();

                                item.Education = newEdu;
                                break;

                            case 8:
                                Console.WriteLine("Enter updated contact");
                                int newContact = Convert.ToInt32(Console.ReadLine());

                                item.ContatNo = newContact;
                                break;
                        }

                        Console.WriteLine("Press \"y\" or \"Y\" to continue updating records");
                        wish = Console.ReadLine();
                    } while (wish == "y" || wish == "Y");

                }
                else
                {
                    Console.WriteLine("Record not found!! Please enter valid ID.");
                    break;

                }
            }
            return staffs;
        }
        
        
        public List<Staff> DeleteStaff(int idDelete)
        {
 
            Staff searched = null; bool deleted = true;int countObj = 0;
            foreach (var item in staffs)
            {
                if (item.StaffId == idDelete)
                {
                    searched = item;
                    deleted = false;
                    break;
                }
                else
                {
                    countObj++;
                }

                if (deleted && staffs.Count == countObj)
                {
                    Console.WriteLine("Record not found!! Enter valid ID");
                }
            }

            staffs.Remove(searched);

            return staffs;
        }
        public List<Staff> GetAllStaff()
        {
            Console.WriteLine("====================================================");
            return staffs;
        }
        public Staff GetStaffById(int id)
        {
            foreach (var item in staffs)
            {
                if (item.StaffId == id)
                {
                    
                    return item;
                }

            }

            return new Staff();
        }

        //public void GetStaffById(int id)
        //{
        //    foreach (var item in staffs)
        //    {
        //        if (item.StaffId == id)
        //        {
        //            staffnew = item;
        //            Console.WriteLine($"ID:{staffnew.StaffId} \n" +
        //                     $"Name:{staffnew.StaffName} \n" +
        //                     $"E-mail:{staffnew.Email} \n" +
        //                     $"Dept-Name:{staffnew.DeptName} \n" +
        //                     $"Gender:{staffnew.Gender} \n" +
        //                     $"DOB:{staffnew.DateOfBirth} \n" +
        //                     $"Catagory:{staffnew.StaffCategory} \n" +
        //                     $"Education:{staffnew.Education} \n" +
        //                     $"Contact number:{staffnew.ContatNo}");
        //        }

        //    }

        //}
    }
}