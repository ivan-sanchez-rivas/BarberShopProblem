using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BarberShopProblem
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Barber buf = new Barber(5);
            Random ran = new Random();
            
                var c1 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c2 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c3 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c4 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c5 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c6 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c7 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c8 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c9 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c10 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c11 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });
                var c12 = new Thread(() =>
                {
                    while (true)
                    {
                        int r = ran.Next(1, 100);
                        buf.Clientes(r);
                        Thread.Sleep(1000);
                    }
                });

                var b1 = new Thread(() =>
                {
                    while (true)
                    {
                        buf.Barbers();
                        Thread.Sleep(1000);
                    }
                });
                c1.Start();
                c2.Start();
                c3.Start();
                c4.Start();
                c5.Start();
                c6.Start();
                c7.Start();
                c8.Start();
                c9.Start();
                c10.Start();
                c11.Start();
                c12.Start();
                b1.Start();
            Console.ReadLine();
        }
    }
}
