using System.ComponentModel.DataAnnotations;

namespace MNJ_CRUD_OPERATION_FINAL.Models
{
    public class EmployeeModel
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Employee Name")]
        public required string EmployeeName { get; set; }

        [Display(Name = "Employee Department")]
        public required string EmployeeDepartment { get; set; }

        [Display(Name = "Employee Salary")]
        public required string EmployeeSalary { get; set; }

        [Display(Name = "Father Name")]

        public required string FatherName { get; set; }

        [Display(Name = "Nationality")]
        public required string Nationality { get; set; }

        [Display(Name = "Social Security Number")]
        public required string Social_Security_Number { get; set; }

        [Display(Name = "Sex")]
        public required string sex { get; set; }

        [Display(Name = "Martial Status")]
        public required string Martial_Status { get; set; }

        [Display(Name = "Pan Card Number")]
        public required string Pan_card_number { get; set; }

        [Display(Name = "Date of birth")]
        public required string Date_of_Birth { get; set; }

        [Display(Name = "Place of Birth")]
        public required string Place_of_Birth { get; set; }

        [Display(Name = "Mationality")]
        public required string Nationality_2 { get; set; }


    }
}
