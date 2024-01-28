using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataValidation
{
    public class Employee
    {
        //[Required(DisallowAllDefaultValues = true)]
        public Guid Id { get; set; }
    }
}
