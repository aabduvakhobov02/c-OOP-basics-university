using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID00008408_OOPTest
{
    public class OfflineStudent : Student
    {
        private double Markdiscount = 0.10;

        //Generated Constructor for Offline Student class
        public OfflineStudent(string firstName, string lastName, DateTime dOB, string address, string passportNumber, string email, int enrolledYear, Course course, PaymentStatus paymentStatus)
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
            
        }

        // Funcion that gives 0.10 (10%) discount for offline students
        // if offline student's mark is 70 or above
        // The function calculates discount from tuition fee,
        // then substracts calculated amount from Remaining fee
        public bool MarkDiscountApplied(int mark)
        {
            if(mark >= 70)
            {
                RemainingFee = RemainingFee - Convert.ToInt32(Markdiscount) * TuitionFee;
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
