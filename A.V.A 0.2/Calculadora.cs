using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.V.A_0._2
{
    public class Calculadora
    {
        public static string Solver(string expression)
        {
            string[] parts = expression.Split(' ');

            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[2]);
            double z = 0.0;

            switch (parts[1])
            {
                case "Vezes":
                    z = x * y;

                    break;
                case "mais":
                    z = x + y;

                    break;
                case "Menos":
                    z = x - y;

                    break;
                case "Por":
                    z = x / y;

                    break;

            }
            return z.ToString();
        }
    }
}
