using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson16Attributes
{
    /// <summary>
    /// The reason attributes are necessary is because many of the services 
    /// they provide would be very difficult to accomplish with normal code. 
    /// You see, attributes add what is called metadata to your programs.
    /// </summary>
    class Program
    {
        /// <summary>
        /// 该程序在编译时会产生警告消息：警告 1 “Program.MethodA()”已过时:“Use MethodB instead” 。
        /// 
        /// 对于有不同版本的程序代码，obsolete attribute显得大有用武之地。
        /// 如果开发了一个新的方法，并且可以确定不再希望使用某方法，
        /// 那么就可以使用Obsolete attribute来修饰该方法，
        /// 编译代码后，按警告/错误提示信息逐一更正原来的代码。
        /// 在一个大型工程中，有助于协调不同的程序员所采用的方法。
        /// </summary>
        /// <param name="args"></param>




        /// <summary>
        /// You'll often see this attribute applied to the Main() method, 
        /// indicating that this C# program should communicate with unmanaged COM code 
        /// using the Single Threading Apartment. 
        /// It is generally safe to use this attribute all the time 
        /// because you never know when a 3rd party library you're using is going to be communicating with COM. 
        /// The following excerpt shows how to use the STAThreadAttribute attribute:
        /// </summary>
        /// <param name="args"></param>

        /**
    [STAThread]
    static void Main(string[] args)
    {
        BasicAttributeDemo attrDemo = new BasicAttributeDemo();

        
        attrDemo.MyFirstDeprecatedMethod();
        attrDemo.MySecondDeprecatedMethod();
        attrDemo.MyThirdDeprecatedMethod();

        Console.ReadLine();
    }
**/


        //    [DllImport("User32.dll", EntryPoint = "MessageBox")]
        //  static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);


        [assembly: CLSCompliant(true)]

        public class AttributeTargetDemo
        {
            public void NonClsCompliantMethod(uint nclsParam)
            {
                Console.WriteLine("Called NonClsCompliantMethod().");
            }


            [STAThread]
            static void Main(string[] args)
            {
                uint myUint = 0;

                AttributeTargetDemo tgtdemo = new AttributeTargetDemo();

                tgtdemo.NonClsCompliantMethod(myUint);

                Console.ReadLine();

                //AttributeParamsDemo.MessageDialog(0, "MessageDialog Called!", "DllImport Demo", 0);
            }

        }
    }
}