using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenVietDiep.Models
{
    [Table("Class1s")]
    public class Class1
    {
        [Key]
        public int MyProperty { get; set; }
    }
}