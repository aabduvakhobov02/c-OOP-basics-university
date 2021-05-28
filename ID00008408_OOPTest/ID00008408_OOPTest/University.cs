using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID00008408_OOPTest
{
    public class University  //Collection Class
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        //Generated Constructor for University Class
        public University()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        private static University LFCUniversity;

        //Singleton 
        public static University GetUniversity()
        {
            if (LFCUniversity == null)
            {
                LFCUniversity = new University();
            }
            return LFCUniversity;
        }

        //List of students and courses to display
        public void PopulateUniversityForTest()
        {
            University LFC = GetUniversity();
            Course c1 = new Course()
            {
                Name = "BIS"
            };
            LFC.Courses.Add(c1);
            Course c2 = new Course()
            {
                Name = "BA"
            };
            LFC.Courses.Add(c2);
            Course c3 = new Course()
            {
                Name = "Law"
            };
            LFC.Courses.Add(c3);
            Course c4 = new Course()
            {
                Name = "Eco"
            };
            LFC.Courses.Add(c4);

            Student st1 = new OfflineStudent("First1", "Last1", DateTime.Parse("2/2/1996"), "Qoraqamish", "AA1111111", "aaaa@gmail.com", 2016, c1, PaymentStatus.Paid);
            LFC.Students.Add(st1);
            Student st2 = new OfflineStudent("First1", "Last1", DateTime.Parse("2/2/1997"), "Qoraqamish", "AA1111111", "aaaa@gmail.com", 2017, c2, PaymentStatus.Unpaid);
            LFC.Students.Add(st2);
            Student st3 = new DistanceLearningStudent("First1", "Last1", DateTime.Parse("2/2/1996"), "Qoraqamish", "AA1111111", "aaaa@gmail.com", 2016, c3, PaymentStatus.Paid);
            LFC.Students.Add(st3);
            Student st4 = new DistanceLearningStudent("First1", "Last1", DateTime.Parse("2/2/2000"), "Qoraqamish", "AA1111111", "aaaa@gmail.com", 2017, c4, PaymentStatus.Unpaid);
            LFC.Students.Add(st4);
        }
   
    }

}
