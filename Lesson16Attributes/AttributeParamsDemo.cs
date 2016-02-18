using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Lesson16Attributes
{
    /// <summary>
    /// Attributes often have parameters that enable customization.
    /// There are two types of parameters that can be used on attributes, positional and named. 
    /// Positional parameters are used when the attribute creator wishes the parameters to be required.
    /// However, this is not a hard and fast rule 
    /// because the ObsoleteAttribute attribute has a second positional parameter 
    /// named error of type bool that we can omit.
    /// 
    /// 
    /// </summary>
    class AttributeParamsDemo
    {
        [DllImport("User32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);
    }
}
