using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic_Class
{
    /// <summary>
    /// Pure ENtity Class or DTO or VO
    /// </summary>
    public class Staff
    {
        // Private Data Members 
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
            {

                if (value < 0)
                {
                    while (value<0)
                    {
                        Console.WriteLine("Enter a valid staff id");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    _StaffId = value;
                }

                _StaffId = value;
            }
        }
       
       
        
        
        
        private string _StaffName = String.Empty;
        public bool validation(String name)
        {
            int countChar = 0;
            foreach (var character in name)
            {
                if (Char.IsLetter(character))
                {
                    countChar++;
                }
            }

            if (countChar == name.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string StaffName
        {
            get { return _StaffName; }
            set
            {


                while (validation(value) == false)
                {
                    Console.WriteLine("Enter valid name:");
                    value = Console.ReadLine();
                }

                _StaffName = value;
                //nameCount = 0;

                //foreach (var item in value)
                //{
                //    if (!validations.Contains(item))
                //    {

                //            Console.WriteLine("Enter a valid name.");
                //    }
                //    else
                //    {
                //        nameCount++;
                //    }
                //}
                //if (nameCount == value.Length)
                //{
                //    _StaffName = value;
                //}

            }
        }

       
        
        
        
        private string _Email = String.Empty;
        public string Email
        {
            get { return _Email; }
            set { 

                if (Char.IsLetter(value[0]))
                {
                    _Email = value;
                }
                else{
                    while (!Char.IsLetter(value[0]))
                    {
                        Console.WriteLine("E-mail id should start with character");
                        value = Console.ReadLine();
                    }
                }
                _Email = value;

            }
        }
       
        
        
        
       
        
        private string _DeptName = String.Empty;
        String[] deptName = { "cancer","heart","pathology","radiology","blood bank","organs","orthopedic","eye","dental"};
        public string DeptName
        {
            get { return _DeptName; }
            set
            {

                    value = value.ToLower();
                    while (!deptName.Contains(value))
                    {
                        Console.WriteLine("Dept is invalid!!\nPlease enter valid department name:");
                        value = Console.ReadLine().ToLower();

                    }

                        _DeptName = value;

            }
        }
       
        
        
       
        
        
        private string _Gender = String.Empty;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
            }
        }
        
        
        
      
        
        
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
            }
        }
        
        
        
        
        private string _StaffCategory = String.Empty;

        String[] staffCatagory = {"doctor","nurse","wardboy","brother","technician"};
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set {
  
                    value = value.ToLower(); 
                    while (!staffCatagory.Contains(value))
                    {
                        Console.WriteLine("Staff catagory is not present!!\nPlease provide valid catagory.");
                        value = Console.ReadLine().ToLower();
                    } 
                _StaffCategory = value;
            }
        }
        
        
        
        
        
        
        private string _Education = String.Empty;
        public string Education
        {
            get { return _Education; }
            set { _Education = value; }
        }



        
        private int _ContactNo;
        public int ContatNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }
    }



}
