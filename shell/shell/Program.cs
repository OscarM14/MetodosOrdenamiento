using System;

namespace shell
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion = '0';
            do
            {
                Console.Clear();
                Console.WriteLine("**************************************");
                Console.WriteLine("|       Selecciona una opción        |");
                Console.WriteLine("|____________________________________|");
                Console.WriteLine("|1.Ordenamiento Shell Enteros Manual |");
                Console.WriteLine("|2.Shell Enteros Aleatorios          |");
                Console.WriteLine("|3.Shell objetos Manual              |");
                Console.WriteLine("|4.Shell objetos Aleatorios          |");
                Console.WriteLine("|5. Salir                            |");
                Console.WriteLine("|************************************|");
                Console.WriteLine("|************************************|");
                Console.WriteLine("|************************************|");
                Console.WriteLine("**************************************");
                opcion = char.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case ('1'):
                        EnterosManual();
                        break;
                    case ('2'):
                        EnterosAleatorios();
                        break;
                    case ('3'):
                        ObjetosManual();
                        break;
                    case ('4'):
                        ObjetosAleatorios();
                        break;
                    case ('5'):
                        break;

                    default:
                        break;
                }
            } while (opcion != 5);
        }
        static void ObjetosManual()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tamaño del arreglo");
            int Tam = 0;
            Tam = int.Parse(Console.ReadLine());
            Estudiante[] array = new Estudiante[Tam];
            Random rand = new Random();

            for (int i = 0; i < Tam; i++)
            {
                Estudiante estudiante = new Estudiante();
                Console.WriteLine("Ingrese el numero de control");
                estudiante.NumeroControl = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre");
                estudiante.Nombre = Console.ReadLine();
                array[i] = estudiante;
            }
            Console.Clear();
            Console.WriteLine("Quieres imprimir el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
            }
            Console.WriteLine("Ordenando arreglo");
            Console.WriteLine("------------------");
            DateTime dtmHoraInicio = DateTime.Now;
            ShellSort(ref array);
            DateTime dtmHoraFin = DateTime.Now; TimeSpan tiempo = dtmHoraFin - dtmHoraInicio;
            Console.WriteLine("Tiempo en ordenar:" + tiempo.TotalMilliseconds + " ms."); Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Quieres mostrar el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
            }
            Console.ReadKey();

        }
        static void ObjetosAleatorios()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tamaño del arreglo");
            int Tam = 0;
            Tam = int.Parse(Console.ReadLine());
            Estudiante[] array = new Estudiante[Tam];
            Random rand = new Random();

            for (int i = 0; i < Tam; i++)
            {
                Estudiante estudiante = new Estudiante();
                estudiante.NumeroControl = rand.Next();
                estudiante.Nombre = Guid.NewGuid().ToString().Substring(0, rand.Next(5));
                array[i] = estudiante;
            }
            Console.Clear();
            Console.WriteLine("Quieres imprimir el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
            }
            Console.WriteLine("Ordenando arreglo");
            Console.WriteLine("------------------");
            DateTime dtmHoraInicio = DateTime.Now;
            ShellSort(ref array);
            DateTime dtmHoraFin = DateTime.Now; TimeSpan tiempo = dtmHoraFin - dtmHoraInicio;
            Console.WriteLine("Tiempo en ordenar:" + tiempo.TotalMilliseconds + " ms."); Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Quieres mostrar el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i].ToString());
                }
            }
            Console.ReadKey();

        }
        static void ShellSort(ref Estudiante[] array)
        {
            int salto = 0;
            int sw = 0;
            Estudiante auxi = new Estudiante();
            int e = 0;
            salto = array.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (array.Length - salto))
                    {
                        if (array[e - 1].CompareTo(array[(e - 1) + salto]) == 1)
                        {
                            auxi = array[(e - 1) + salto];
                            array[(e - 1) + salto] = array[e - 1];
                            array[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
        static void EnterosAleatorios()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tamaño del arreglo");
            int Tam = 0;
            Tam = int.Parse(Console.ReadLine());
            int[] array = new int[Tam];
            Random rand = new Random();

            for (int i = 0; i < Tam; i++)
            {
                array[i] = rand.Next();
            }
            Console.Clear();
            Console.WriteLine("Quieres imprimir el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("Ordenando arreglo");
            Console.WriteLine("------------------");
            DateTime dtmHoraInicio = DateTime.Now;
            ShellSort(ref array);
            DateTime dtmHoraFin = DateTime.Now; TimeSpan tiempo = dtmHoraFin - dtmHoraInicio;
            Console.WriteLine("Tiempo en ordenar:" + tiempo.TotalMilliseconds + " ms."); Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Quieres mostrar el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadKey();
        }
        static void EnterosManual()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el tamaño del arreglo");
            int Tam = 0;
            Tam = int.Parse(Console.ReadLine());
            int[] array = new int[Tam];
            for (int i = 0; i < Tam; i++)
            {
                Console.WriteLine("Ingrese el valor [" + i + "]");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Quieres imprimir el arreglo Si[S] No[N]");
            if (Console.ReadLine() == "S")
            {
                for (int i = 0; i < Tam; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("Ordenando arreglo");
            Console.WriteLine("------------------");
            DateTime dtmHoraInicio = DateTime.Now;
            ShellSort(ref array);
            DateTime dtmHoraFin = DateTime.Now; TimeSpan tiempo = dtmHoraFin - dtmHoraInicio;
            Console.WriteLine("Tiempo en ordenar:" + tiempo.TotalMilliseconds + " ms."); Console.WriteLine("Presiona cualquier tecla para continuar");
            for (int i = 0; i < Tam; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        static void ShellSort(ref int[] array)
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = array.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (array.Length - salto))
                    {
                        if (array[e - 1] < array[(e - 1) + salto])
                        {
                            auxi = array[(e - 1) + salto];
                            array[(e - 1) + salto] = array[e - 1];
                            array[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
    }
    class Estudiante : IComparable<Estudiante>
    {
        private int _intNumeroControl;

        public int NumeroControl
        {
            get { return _intNumeroControl; }
            set { _intNumeroControl = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public override string ToString()
        {
            return this.NumeroControl.ToString() + "--" + this.Nombre;
        }

        public int CompareTo(Estudiante estudiante)
        {
            if (this.NumeroControl < estudiante.NumeroControl)
            {
                return -1;
            }
            else if (this.NumeroControl > estudiante.NumeroControl)
            {
                return 1;
            }
            return 0;
        }
    }
}
