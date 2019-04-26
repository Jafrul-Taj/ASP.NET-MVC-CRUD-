using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NetCoreCRUD.Models
{
    public class Employee
    {
        [Key,Required]
        public int EmployeeId { get; set; }

        [Required]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }



    }
}