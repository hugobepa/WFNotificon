using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNotificonV03241018
{
    class CheqeoDatos
    {
        logs logs = new logs();
        //CheqeoDatos cd = new CheqeoDatos();
        string s;
        int? inte = 10;
        decimal? dec;
        DateTime? date;
        Type tipo;
        object obj;

        public string obtenerTipo(object o)
        {
            //https://stackoverflow.com/questions/51320491/how-to-check-an-empty-object
            //https://stackoverflow.com/questions/14958124/check-whether-an-object-is-empty-or-null
            //https://stackoverflow.com/questions/9323580/how-to-check-object-is-null-or-empty-in-c-net-3-5

            string s = o?.ToString() ?? "";
            string[] tipoFormato = new string[2];
            Console.WriteLine("s: {0}", s);



            if (!String.IsNullOrEmpty(s))
            {
                Type tipo = o.GetType();
                string convertido = String.Format(tipo.ToString().Trim());
                tipoFormato = convertido.Split('.');
            }
            else
            {
                tipoFormato[1] = "object";
            }


            return tipoFormato[1];
        }

        public string conversorStr(object o)
        {
            string tipo = obtenerTipo(o);

            string converso = null;
            switch (tipo)
            {
                case "Int32":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Double":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Decimal":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Boolean":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "DateTime":
                    converso = String.Format("{0:ddMMyyHHmm}", o).Trim().ToUpper();
                    break;
                case "Single":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "object":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "String":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                default:
                    break;


            }

            return converso;
        }


        public string conversorStr2(object o, string tipo)
        {


            string converso = null;

            switch (tipo)
            {
                case "Int32":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Double":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Decimal":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "Boolean":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "DateTime":
                    converso = String.Format("{0:ddMMyyHHmm}", o).Trim().ToUpper();
                    break;
                case "Single":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "String":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                case "object":
                    converso = o.ToString().Trim().ToUpper();
                    break;
                default:
                    break;
            }



            return converso;
        }

        public bool IsnullEmpty(object o)
        {


            string tipo = obtenerTipo(o);
            string str = conversorStr2(o, tipo);

            bool b = String.IsNullOrEmpty(str);



            if (b)
            {
                logs.crearLog(String.Format("{0} estaVacioNulo", str));
                o = null;
            }
            else
            {
                logs.crearLog(String.Format("{0} NoNuloVacio", str));
            }


            return b;
        }



        public bool IsLetter(object o)
        {

            string tipo = obtenerTipo(o);
            string str = null;


            str = conversorStr2(o, tipo);
            bool bol = false;
            bool bo = String.IsNullOrEmpty(str);


            if (bo)
            {
                logs.crearLog(String.Format("{0} estaVacioNulo", str));
                o = null;
            }
            else
            {
                char[] arrayChar = str.ToCharArray();
                bol = arrayChar.All(char.IsLetter);
                if (bol)
                {
                    logs.crearLog(String.Format("{0} Son letras", str));
                }
                else
                {
                    logs.crearLog(String.Format("{0} No solamente letras", str));
                }

            }

            return bol;
        }

        public bool IsDigit(object o)
        {

            string tipo = obtenerTipo(o);
            string str = null;


            str = conversorStr2(o, tipo);
            bool bol = false;
            bool bo = String.IsNullOrEmpty(str);


            if (bo)
            {
                logs.crearLog(String.Format("{0} estaVacioNulo", str));
                o = null;
            }
            else
            {
                char[] arrayChar = str.ToCharArray();
                bol = arrayChar.All(char.IsDigit);
                if (bol)
                {
                    logs.crearLog(String.Format("{0} Son numeros", str));
                }
                else
                {
                    logs.crearLog(String.Format("{0} No solamente numeros", str));
                }

            }

            return bol;
        }

        public bool IsAlfaNumerico(object o)
        {

            string tipo = obtenerTipo(o);
            string str = null;


            str = conversorStr2(o, tipo);
            bool bol = false;
            bool bo = String.IsNullOrEmpty(str);


            if (bo)
            {
                logs.crearLog(String.Format("{0} estaVacioNulo", str));
                o = null;
            }
            else
            {
                char[] arrayChar = str.ToCharArray();
                bol = arrayChar.All(char.IsLetterOrDigit);
                if (bol)
                {
                    logs.crearLog(String.Format("{0} Son AlfaNumericos", str));
                }
                else
                {
                    logs.crearLog(String.Format("{0} No solamente Alfanumericos", str));
                }

            }

            return bol;
        }
    }
}
