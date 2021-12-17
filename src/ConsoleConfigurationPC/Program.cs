using System;
using System.Management;

namespace ConsoleConfigurationPC
{
    /// <summary>
    /// https://www.youtube.com/watch?v=t35ji7wrDJQ
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            

            //ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\cimv2", "select * from win32_videocontroller");
            //ManagementObjectCollection moc = mos.Get();
            //Console.WriteLine(moc.ToString());

            //foreach (ManagementObject mo in moc)
            //{
            //    var prop = mo.GetPropertyValue("Name").ToString();
            //    Console.WriteLine(prop);
            //}

            foreach (var mo in new ManagementObjectSearcher("root\\cimv2", "select * from win32_videocontroller").Get())
            {
                foreach (var item in mo.Properties)
                {
                    if (item.Value == null )
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{item.Name} ---> {item.Value}" );
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
