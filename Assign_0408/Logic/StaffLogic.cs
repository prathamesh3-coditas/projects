using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_0408.Entity;

namespace Assign_0408.Logic
{
    public class StaffLogic : List<Staff>
    {
        public StaffLogic()
        {
            Add(new Doctor() { Id = 1001, Name = "YashodaNandan" ,BasicPay = 8300,StaffCatagory = "Doctor",MaxPatientsPerDay = 15,Education="mbbs",Specialization="eye"});
            Add(new Doctor() { Id = 1002, Name = "DevkiNandan",BasicPay = 6500, StaffCatagory = "Doctor", MaxPatientsPerDay = 12, Education = "bams", Specialization = "heart" });
            Add(new Doctor() { Id = 1003, Name = "RadheShyam",BasicPay = 9600, StaffCatagory = "Doctor", MaxPatientsPerDay = 10, Education = "bhms", Specialization = "eye" });
            Add(new Doctor() { Id = 1004, Name = "Gopal",BasicPay = 6700, StaffCatagory = "Doctor", MaxPatientsPerDay = 9, Education = "md", Specialization = "general" });
            Add(new Doctor() { Id = 1005, Name = "Govind",BasicPay = 7600, StaffCatagory = "Doctor", MaxPatientsPerDay = 11, Education = "bds", Specialization = "dentist" });
            Add(new Doctor() { Id = 1006, Name = "Mohan",BasicPay = 5400, StaffCatagory = "Doctor", MaxPatientsPerDay = 13, Education = "mbbs", Specialization = "general" });
            Add(new Doctor() { Id = 1007, Name = "Madhav",BasicPay = 7000, StaffCatagory = "Doctor", MaxPatientsPerDay = 16, Education = "bhms", Specialization = "heart" });
            Add(new Doctor() { Id = 1008, Name = "Milind",BasicPay = 6200, StaffCatagory = "Doctor", MaxPatientsPerDay = 19, Education = "bds", Specialization = "dentist" });
            Add(new Doctor() { Id = 1009, Name = "Vasudev",BasicPay = 5100, StaffCatagory = "Doctor", MaxPatientsPerDay = 12, Education = "md", Specialization = "eye" });
            Add(new Doctor() { Id = 1010, Name = "Shridhar",BasicPay = 7120, StaffCatagory = "Doctor", MaxPatientsPerDay = 8, Education = "mbbs", Specialization = "heart" });
            Add(new Doctor() { Id = 1011, Name = "Yash", BasicPay = 5900, StaffCatagory = "Doctor", MaxPatientsPerDay = 18, Education = "bhms", Specialization = "organs" });
            Add(new Doctor() { Id = 1012, Name = "Dev",BasicPay = 6200, StaffCatagory = "Doctor", MaxPatientsPerDay = 10, Education = "bams", Specialization = "eye" });
            Add(new Doctor() { Id = 1013, Name = "Radhe",BasicPay = 9000, StaffCatagory = "Doctor", MaxPatientsPerDay = 11, Education = "bds", Specialization = "organs" });
            Add(new Doctor() { Id = 1014, Name = "Gopalswami",BasicPay = 8000, StaffCatagory = "Doctor", MaxPatientsPerDay = 21, Education = "md", Specialization = "general" });
            Add(new Doctor() { Id = 1015, Name = "Govindkumar",BasicPay = 7100, StaffCatagory = "Doctor", MaxPatientsPerDay = 20, Education = "bds", Specialization = "dentist" });
            Add(new Doctor() { Id = 1016, Name = "ManMohan", BasicPay =8200, StaffCatagory = "Doctor", MaxPatientsPerDay = 23 , Education = "bhms", Specialization = "eye" });
            Add(new Doctor() { Id = 1017, Name = "Madhavan", BasicPay =9000, StaffCatagory = "Doctor", MaxPatientsPerDay = 14, Education = "md", Specialization = "heart" });
            Add(new Doctor() { Id = 1018, Name = "Manshu", BasicPay = 8100, StaffCatagory = "Doctor",MaxPatientsPerDay = 17, Education = "bhms", Specialization = "general" });
            Add(new Doctor() { Id = 1019, Name = "Vasu", BasicPay =6300, StaffCatagory = "Doctor",MaxPatientsPerDay = 13, Education = "bams", Specialization = "heart" });
            Add(new Doctor() { Id = 1020, Name = "Shriram", BasicPay =4890, StaffCatagory = "Doctor",MaxPatientsPerDay = 15, Education = "bhms", Specialization = "eye" });
            Add(new Nurse() { Id = 1021, Name = "Nandan", BasicPay =5120, StaffCatagory = "Nurse" ,ExtraHours=3,Experience=4});
            Add(new Nurse() { Id = 1022, Name = "Devika", BasicPay =7600, StaffCatagory = "Nurse", ExtraHours = 1, Experience = 4 });
            Add(new Nurse() { Id = 1023, Name = "Shyam", BasicPay =4200, StaffCatagory = "Nurse", ExtraHours = 7, Experience = 2 });
            Add(new Nurse() { Id = 1024, Name = "Geet", BasicPay =7800, StaffCatagory = "Nurse", ExtraHours = 9, Experience = 3});
            Add(new Nurse() { Id = 1025, Name = "Ganesh", BasicPay =4500, StaffCatagory = "Nurse", ExtraHours = 11, Experience = 1 });
            Add(new Nurse() { Id = 1026, Name = "Neeti", BasicPay =6120, StaffCatagory = "Nurse" , ExtraHours = 9, Experience = 4 });
            Add(new Nurse() { Id = 1027, Name = "Shakti", BasicPay =8940, StaffCatagory = "Nurse" , ExtraHours = 4, Experience = 9 });
            Add(new Nurse() { Id = 1028, Name = "Mukesh", BasicPay =7560, StaffCatagory = "Nurse" , ExtraHours = 12, Experience = 1 });
            Add(new Nurse() { Id = 1029, Name = "Vasa", BasicPay =9870, StaffCatagory = "Nurse" , ExtraHours = 10, Experience = 10 });
            Add(new Nurse() { Id = 1030, Name = "Shivam", BasicPay =6890, StaffCatagory = "Nurse" , ExtraHours = 6, Experience = 7 });
            Add(new Nurse() { Id = 1031, Name = "yatharth", BasicPay =9230, StaffCatagory = "Nurse" , ExtraHours = 5, Experience = 7 });
            Add(new Nurse() { Id = 1032, Name = "Divyanshi", BasicPay =8760, StaffCatagory = "Nurse" , ExtraHours = 13, Experience = 3 });
            Add(new Nurse() { Id = 1033, Name = "Rahul", BasicPay =6740, StaffCatagory = "Nurse" , ExtraHours = 12, Experience = 9 });
            Add(new Nurse() { Id = 1034, Name = "gautam", BasicPay =8090, StaffCatagory = "Nurse" , ExtraHours = 9, Experience = 4 });
            Add(new Nurse() { Id = 1035, Name = "Gyani", BasicPay =4560, StaffCatagory = "Nurse" , ExtraHours = 8, Experience = 2 });
            Add(new Nurse() { Id = 1036, Name = "Mohit", BasicPay =6320, StaffCatagory = "Nurse" , ExtraHours = 7, Experience = 1 });
            Add(new Nurse() { Id = 1037, Name = "Milu", BasicPay =5630, StaffCatagory = "Nurse",ExtraHours=3, Experience = 4 });
            Add(new Nurse() { Id = 1038, Name = "pawan", BasicPay =7230, StaffCatagory = "Nurse", ExtraHours = 1, Experience = 7 });
            Add(new Nurse() { Id = 1039, Name = "divyesh", BasicPay =4210, StaffCatagory = "Nurse", ExtraHours = 2, Experience = 11 });
            Add(new Nurse() { Id = 1040, Name = "roshani", BasicPay =8340, StaffCatagory = "Nurse", ExtraHours = 3, Experience = 10 });
            Add(new Driver() { Id = 1041, Name = "sahil", BasicPay =5210, StaffCatagory = "Driver",Bonus=1500,Vehicletype="car"});
            Add(new Driver() { Id = 1042, Name = "pari", BasicPay =6900, StaffCatagory = "Driver", Bonus = 1300, Vehicletype = "truck" });
            Add(new Driver() { Id = 1043, Name = "Rathore", BasicPay =5060, StaffCatagory = "Driver", Bonus = 1250, Vehicletype = "bike" });
            Add(new Driver() { Id = 1044, Name = "Nikhilesh", BasicPay =8300, StaffCatagory = "Driver", Bonus = 500, Vehicletype = "suv" });
            Add(new Driver() { Id = 1045, Name = "Tribhuvan", BasicPay =7190, StaffCatagory = "Driver", Bonus = 2500, Vehicletype = "suv" });
            Add(new Driver() { Id = 1046, Name = "Mohit", BasicPay =6420, StaffCatagory = "Driver", Bonus = 1900, Vehicletype = "car" });
            Add(new Driver() { Id = 1047, Name = "charu", BasicPay =8150, StaffCatagory = "Driver", Bonus = 1170, Vehicletype = "truck" });
            Add(new Driver() { Id = 1048, Name = "NIkita", BasicPay =8350, StaffCatagory = "Driver", Bonus = 1560, Vehicletype = "truck" });
            Add(new Driver() { Id = 1049, Name = "Himanshu", BasicPay =6710, StaffCatagory = "Driver", Bonus = 1190, Vehicletype = "suv" });
            Add(new Driver() { Id = 1050, Name = "bhuresh", BasicPay =8290, StaffCatagory = "Driver", Bonus = 1940, Vehicletype = "bike" });
            Add(new Driver() { Id = 1051, Name = "Santosh", BasicPay =4280, StaffCatagory = "Driver", Bonus = 1690, Vehicletype = "truck" });
            Add(new Driver() { Id = 1052, Name = "Ifham", BasicPay =5960, StaffCatagory = "Driver", Bonus = 1070, Vehicletype = "truck" });
            Add(new Driver() { Id = 1053, Name = "Akshat", BasicPay =8080, StaffCatagory = "Driver", Bonus = 1100, Vehicletype = "car" });
            Add(new Driver() { Id = 1054, Name = "nishi", BasicPay =7090, StaffCatagory = "Driver", Bonus = 1790, Vehicletype = "suv" });
            Add(new Driver() { Id = 1055, Name = "Nidhi", BasicPay =9100, StaffCatagory = "Driver", Bonus = 1080, Vehicletype = "car" });
            Add(new Driver() { Id = 1056, Name = "Yukta", BasicPay =6600, StaffCatagory = "Driver", Bonus = 1180, Vehicletype = "car" });
            Add(new Driver() { Id = 1057, Name = "AAshi", BasicPay =7770, StaffCatagory = "Driver", Bonus = 1840, Vehicletype = "suv" });
            Add(new Driver() { Id = 1058, Name = "Yogyata", BasicPay =7500, StaffCatagory = "Driver", Bonus = 1430, Vehicletype = "bike" });
            Add(new Driver() { Id = 1059, Name = "Falguni", BasicPay =9500, StaffCatagory = "Driver", Bonus = 1290, Vehicletype = "bike" });
            Add(new Driver() { Id = 1060, Name = "Princee", BasicPay =7870, StaffCatagory = "Driver", Bonus = 1500, Vehicletype = "car" });
        }


    }
}
