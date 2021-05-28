using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID00008408_OOPTest
{
    public class DistanceLearningStudent : Student
    {
        //discount rate for dinstance learning students (5%)
        private double distanceLearningDiscount = 0.05;
        public int DistanceLearningFee { get; set; }

        //Generated Constructor for DistanceLearningStudent class
        public DistanceLearningStudent(string firstName, string lastName, DateTime dOB, string address, string passportNumber, string email, int enrolledYear, Course course, PaymentStatus paymentStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dOB;
            Address = address;
            PassportNumber = passportNumber;
            Email = email;
            EnrolledYear = enrolledYear;
            Course = course;
            PStatus = paymentStatus;

            // Applying discount rate(5%) to distance learning students
            DistanceLearningFee = TuitionFee - (TuitionFee * Convert.ToInt32(distanceLearningDiscount));
            RemainingFee = DistanceLearningFee;
        }
        

       
    }
}
