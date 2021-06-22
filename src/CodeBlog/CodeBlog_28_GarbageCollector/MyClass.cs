using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog_28_GarbageCollector
{
    public class MyClass : IDisposable
    {
        public MyClass() // Создание конструктора
        {

        }

        ~MyClass() // Создание деструктора
        { 
            // Допустим при асинхронности используется для корректного закрытия потока
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
