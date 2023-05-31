using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web411017470.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }


    public class StudentMetadata
    {
        public int Id
        {
            get; set;

        }
        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(5,MinimumLength =2,ErrorMessage ="請輸入2~5個字")]

        public string Name
        {
            get; set;
        }
        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "請輸入2~5個字")]
        public string Number
        {
            get; set;
        }
        [Required(ErrorMessage = "請填寫 Email")]
        [Display(Name = "Email")]
        [StringLength(5, MinimumLength = 2, ErrorMessage = "請輸入2~5個字")]
        public string Email
        {
            get; set;
        }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "是否註冊")]
        public string IsActive
        {
        get; set;
        }
           
    }
}