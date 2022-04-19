using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC_Working_With_Model_New.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Employee Id ")]
        public int empid { get; set; }


        [DisplayName("Employee name")]
        //[Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [MinLength(1)]
        [Required(ErrorMessage = "Name is Required")]
        public string empname { get; set; }


        [Required]
        [DisplayName("Employee Department")]
        [DataType(DataType.Text)]
        public string empDept { get; set; }


        [DisplayName("Employee Email Id")]
        //[Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [MinLength(1)]
        [Required(ErrorMessage = "Email Id is Required")]
        public string empEmailId { get; set; }

        //[Required]
        [MaxLength(10)]
        [Required(ErrorMessage = "Phine number is Required")]
        public string empPhoneNo { get; set; }

    }
}
