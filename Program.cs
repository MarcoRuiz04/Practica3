using System;

namespace Practica3
{
    class Program
    {

        static int LeerInt(string msj)
        {
            Console.Write(msj + " ");
            int op = Int32.Parse(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            string menu = "Práctica  - UTN\n" +
                "1. Rectalgulo\n" +
                "2. Cuadrado\n" +
                "3. Triangulo\n" +
                "4. Circulo\n" +
                "5. Articulo\n" +
                "6. Salir";

            Operaciones ope = new Operaciones();

            while (true)
            {
                Console.WriteLine(menu);
                Console.Write("Seleccione una opción: ");
                int op = Int32.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 1 )
                {
                    int n1 = LeerInt("Digite la Base: ");
                    int n2 = LeerInt("Digite la Altura: ");
                    string o = "*";
                    double result = ope.Calcular(n1, n2, op);
                    string res = String.Format("\nEl area del rectangulo es  {0} {1} {2} = {3}\n", n1, o, n2, Math.Round(result, 2));
                    Console.WriteLine(res);
                }
                else if (op == 2)
                {
                    int n1 = LeerInt("Digite el lado: ");
                    int n2 = n1;
                    string o = "*";
                    double result = ope.Calcular(n1, n2, op);
                    string res = String.Format("\nEl area del Cuadrado es  {0} {1} {2} = {3}\n", n1, o, n2, Math.Round(result, 2));
                    Console.WriteLine(res);
                }
                else if (op == 3)
                {
                    int n1 = LeerInt("Digite la Base: ");
                    int n2 = LeerInt("Digite la Altura: ");
                    string o = "*";
                    double result = ope.Calcular(n1, n2, op);
                    string res = String.Format("\nEl area del Triangulo es  {0} {1} {2} / 2 = {3}\n", n1, o, n2, Math.Round(result, 2));
                    Console.WriteLine(res);
                }
                else if (op == 4)
                {
                    int n1 = LeerInt("Digite el Radio: ");
                    string o = "*";
                    double result = ope.CalcularRadio(n1);
                    string res = String.Format("\nEl area del circulo es  Pi {0} {1} elevado a la dos = {2}\n", o, n1, Math.Round(result, 2));
                    Console.WriteLine(res);
                }
                else if (op == 5)
                {
                    Articulo art = new Articulo("Arroz", 0, 0, 0)
                    {
                        Descripcion = "Arroz",
                        Precio = 3000,
                        Descuento = 0.20,
                        Cantidad = 10
                    };
                    Console.WriteLine("El {0} tiene un precio de = {1}\n" +
                        "Su precio con decuento en de {2}\n" +
                        "Su precio final es {3}\n \n", art.Descripcion, art.Precio, art.CalcularPrecioDescuento(), art.CalcularIVA());

                }
                else if (op == 6)
                {
                    goto SALIDA;
                }
            }
            SALIDA:
            Console.WriteLine("Gracias por utilizar la aplicación!!");
            Console.ReadKey();


        }
    }
}
