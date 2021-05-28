using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID00008408_OOPTest
{
    public abstract class Student //Abstract Class 
    {

        //the encapsulation of ID
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string PassportNumber { get; set; }
        public string Email { get; set; }
        public int EnrolledYear {get; set;}
        public Course Course { get; set; }
        public PaymentStatus PStatus { get; set; }
       

        //The standart tuition fee is set to 39,9million soums
        protected static int TuitionFee  = 39999999;   

        //current remaining fee
        private int remainingFee = 39999999;   
        public int RemainingFee
        {
            get { return remainingFee; }
            set { remainingFee = value; }
        }

        //Method of checking whether student paid the fee or not. 
        //If the student's remaining fee is more than zero,
        //PaymentStatus will be Unpaid 
        public PaymentStatus CheckPaymentStatus()
        {
            if(RemainingFee > 0)
            {
                PStatus = PaymentStatus.Unpaid;
                return PStatus;
            }
            else
            {
                PStatus = PaymentStatus.Paid;
                return PStatus;
            }
        }

        // the function of Making payment
        // x is the money that is being paid by the student
        // if the student will pay full amount of fee 
        // remaining fee will be 0.
        public int MakePayment(int x)
        {
            RemainingFee = RemainingFee - x;
            return RemainingFee;
        }

       

        
    }

    //Enumirator for Payment Status
    public enum PaymentStatus
    {
        Paid,
        Unpaid
    }

}
