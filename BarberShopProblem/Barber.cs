using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BarberShopProblem
{
    public class Barber
    {
        Semaphore barberListo;
        Semaphore sentarseEspera;
        Semaphore clienteListo;
        int asientosLibresEspera;
        public Barber(int numAsientos)
        {
            barberListo = new Semaphore(0, numAsientos);
            sentarseEspera = new Semaphore(numAsientos, numAsientos);
            clienteListo = new Semaphore(0,numAsientos);
            asientosLibresEspera = numAsientos;
        }
        public void Barbers()
        {
            while (true)
            {
                if (asientosLibresEspera != 0)
                {
                    clienteListo.WaitOne();
               }
               else
                { 
                    sentarseEspera.WaitOne();
                    asientosLibresEspera++;
                    barberListo.Release();
                    sentarseEspera.Release();
                    Console.WriteLine("Cortando Pelo");
                }
            }
        }
        public void Clientes(int cliente)
        {
                sentarseEspera.WaitOne();
                if (asientosLibresEspera > 0)
                {
                    asientosLibresEspera--;
                    clienteListo.Release();
                    sentarseEspera.Release();
                    barberListo.WaitOne();
                    Console.WriteLine("Se ha cortado el pelo del cliente # " + cliente); 
                    Thread.Sleep(1000);
                }
                else
                {
                    sentarseEspera.Release();
                    Console.WriteLine("No se ha cortado el pelo del cliente # " + cliente + " se fue");
                    Thread.Sleep(1000);
                }
        }
    }

}
