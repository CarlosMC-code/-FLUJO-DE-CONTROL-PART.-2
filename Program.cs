namespace Carlos_Yunior_Mota_tarea_2
{
    using System;

    class Estudiante
    {
        public string Nombre;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public double Promedio;
        public string Estatus;
    }

    class calcularnotas
    {
        public double Calcularpromedio(double n1, double n2, double n3, double n4)
        {
            return (n1 + n2 + n3 + n4) / 4;
        }

        public string Estatus(double promedio)
        {
            if (promedio >= 70)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidad = int.Parse(Console.ReadLine());

            Estudiante[] estudiantes = new Estudiante[cantidad];
            calcularnotas calculadora = new calcularnotas();

            for (int i = 0; i < cantidad; i++)
            {
                estudiantes[i] = new Estudiante();

                Console.Write("\nNombre del estudiante: ");
                estudiantes[i].Nombre = Console.ReadLine();

                Console.Write("Nota 1: ");
                estudiantes[i].Nota1 = double.Parse(Console.ReadLine());

                Console.Write("Nota 2: ");
                estudiantes[i].Nota2 = double.Parse(Console.ReadLine());

                Console.Write("Nota 3: ");
                estudiantes[i].Nota3 = double.Parse(Console.ReadLine());

                Console.Write("Nota 4: ");
                estudiantes[i].Nota4 = double.Parse(Console.ReadLine());

                estudiantes[i].Promedio = calculadora.Calcularpromedio(
                    estudiantes[i].Nota1,
                    estudiantes[i].Nota2,
                    estudiantes[i].Nota3,
                    estudiantes[i].Nota4
                );

                estudiantes[i].Estatus = calculadora.Estatus(estudiantes[i].Promedio);
            }

            Console.WriteLine("\nRESULTADOS");

            Console.WriteLine("Estudiante\tNota1\tNota2\tNota3\tNota4\tPromedio\tEstatus");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(
                    estudiantes[i].Nombre + "\t" +
                    estudiantes[i].Nota1 + "\t" +
                    estudiantes[i].Nota2 + "\t" +
                    estudiantes[i].Nota3 + "\t" +
                    estudiantes[i].Nota4 + "\t" +
                    estudiantes[i].Promedio.ToString("F2") + "\t" +
                    estudiantes[i].Estatus
                );
            }
        }
    }
}
