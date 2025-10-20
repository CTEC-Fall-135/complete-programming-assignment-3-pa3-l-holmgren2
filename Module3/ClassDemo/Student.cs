using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Student
    {
        private String studentName;
        private String studentAddress;
        private int studentID;

        #region accessors and mutators
        public String GetName()
        {
            return studentName;
        }

        public void SetName(String name)
        {
            studentName = name;
        }
        
        public String Address
        {
            get { return studentAddress; }
            set { studentAddress = value; }
        }

        public int ID { get; set; }

        #endregion

        #region constructors
        //default constructor
        public Student()
            : this("", "", 0) {}

        public Student(String studentName)
            : this(studentName, "", 0) {}

        //primary constructor
        public Student (String studentName, String studentAddress, int studentID)
        {
            this.studentName = studentName;
            this.Address = studentAddress;
            this.ID = studentID;
        }
        #endregion

        #region methods
        public void PrintState()
        {
            Console.WriteLine($"\nStudent object state\nName:\t\t{studentName}\nAddress:\t{studentAddress}\nID:\t\t{studentID}\n");
        }
        #endregion
    }
}
