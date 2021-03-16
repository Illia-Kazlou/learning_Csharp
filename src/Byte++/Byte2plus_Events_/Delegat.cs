using System;
using System.Collections.Generic;
using System.Text;

namespace Byte2plus_Events_
{
    public delegate void EventDelegate();

    public class MyDelegate
    {
        public event EventDelegate eventDelegate = null;
    }
}
