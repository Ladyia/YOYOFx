﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinHost
{
    class Program
    {
        static void Main(string[] args)
        {


            using (Microsoft.Owin.Hosting.WebApp.Start<YOYOFxMvcDemo.Startup>("http://localhost:9001"))
            {
                Console.WriteLine("Press [enter] to quit......");
                Console.ReadLine();
            }


        }
    }
}
