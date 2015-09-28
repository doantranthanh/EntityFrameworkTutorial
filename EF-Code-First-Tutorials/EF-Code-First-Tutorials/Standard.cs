using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Tutorials
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardID { get; set; }
        public string StandardName { get; set; }

        // Collection in navigation property
        public ICollection<Student> Students { get; set; }
    }
}
