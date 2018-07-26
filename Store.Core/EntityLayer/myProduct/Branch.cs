using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Core.EntityLayer.myProduct
{
    public class Branch
    {
        public Branch()
        {
        }

        public String branch_code { get; set; }
        public String branch_desc { get; set; }
        public String branch_name { get; set; }
        public String area_code { get; set; }
        public String area_desc { get; set; }
        public String state { get; set; }
        public String business_unit_code { get; set; }
        public String business_unit_desc { get; set; }
        public String business_unit_group { get; set; }
    }
}


//using System;

//namespace Store.Core.EntityLayer.HumanResources
//{
//    public class Employee : IAuditableEntity
//    {
//        public Employee()
//        {
//        }

//        public Employee(Int32? employeeID)
//        {
//            EmployeeID = employeeID;
//        }

//        public Int32? EmployeeID { get; set; }

//        public String FirstName { get; set; }

//        public String MiddleName { get; set; }

//        public String LastName { get; set; }

//        public DateTime? BirthDate { get; set; }

//        public String CreationUser { get; set; }

//        public DateTime? CreationDateTime { get; set; }

//        public String LastUpdateUser { get; set; }

//        public DateTime? LastUpdateDateTime { get; set; }

//        public Byte[] Timestamp { get; set; }
//    }
//}
