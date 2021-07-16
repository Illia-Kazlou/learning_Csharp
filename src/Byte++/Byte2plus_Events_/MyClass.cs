using System;
using System.Collections.Generic;
using System.Text;

namespace Byte2plus_Events_
{
    public delegate void EventDelegate(); 

    public class MyClass // для создания события нам необходим класс делегат
    {
        public event EventDelegate myEvent = null; //определение ивента, к делегату уже отношения не имеет
    
        public void InvokeEvent() // вызов события
        {
            myEvent.Invoke(); //это нужно дл ятого что бы мы могли из других классов запускать наши события
        }
    }
}
