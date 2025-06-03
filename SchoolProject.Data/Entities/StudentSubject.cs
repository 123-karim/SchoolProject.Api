using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
   public  class StudentSubject
    {
        [Key]
        public int StudSubID { get; set; }
        public int StudID { get; set; }
        public int SubID { get; set; }

        public virtual Student Students { get; set; }
        public virtual Subjects Subjects { get; set; }

    }
}
