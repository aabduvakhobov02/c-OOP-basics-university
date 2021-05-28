using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID00008408_OOPTest
{
    public class Course
    {
        //Implementing Encapsulation for id
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name { get; set; }
        
    }
}
