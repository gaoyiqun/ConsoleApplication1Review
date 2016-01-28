using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace ConsoleApplication1Review
{
    public class Student
    {
        // when you do not have a constructor, all the members are initiated too, but to their default values
        // every type has different default values
        // int =0;
        //string is null
        // class type is null;
        // bool  default value is False

        private int age;
        private string firstName;

        public string Name { get; set; }

        //proprities: all properties must be public. all properties must have get and set method
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
              
                if (value < 0)
                {
                    throw new Exception("Age Should not be less than 0"); //When execute does not throw exceptions...
                }
                age = value;
            }
        }

        public bool IsThisStudentOlderThan10()
        {
            /**
            bool isagegreaterthan10 = Age > 10;
            return isagegreaterthan10;
            **/
            return Age > 10;
        }
        public static void ConvertStudentName(string name)
        { 
            // you can not use an instance member Age
            var student = new Student();
            if (student.Age>0)
            { 
            }
        }

        public void UsingKeywordDemo()
        {
            using (Font font1 = new Font("Arial", 10.0f))
            {
                byte charset = font1.GdiCharSet;

                // at the end of using block, font1 is destroyed by using statement, not by garbage collector
                // it will call font1.close right here to free font1
                // because font1 is expensive, 
                
            }
            // this is bad example
            Font font2 = new Font("Arial", 10.0f);
            byte charset2 = font2.GdiCharSet;
            // font2 can be garbage collected but you donot know when, it could be minuts or hours


        }
    }
}
