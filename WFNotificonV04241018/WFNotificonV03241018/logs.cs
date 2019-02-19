using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNotificonV03241018
{
    class logs
    {
        private string crearRuta()
        {
            string carpeta = @"C:\LOGS\";

            DateTime dt = DateTime.Now;
           
            string dataHoraStr = String.Format("{0:ddMMyy}", dt);
           
            string arxiu = String.Format("{0}log.txt", dataHoraStr);

            string ruta = System.IO.Path.Combine(carpeta, arxiu);

            return ruta;
        }    


        public void crearLog(string msj)
        {
            DateTime dt = DateTime.Now;
            string ruta = crearRuta();
            string horaStr = String.Format("{0:HH:mm}---{1}", dt, msj);
            string createText = horaStr + Environment.NewLine;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(createText);
            Debug.WriteLine(createText);
            File.AppendAllText(ruta, createText);
        }
    }
}



