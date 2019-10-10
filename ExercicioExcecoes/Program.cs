using System;
using ExercicioExcecoes.Entidades;

namespace ExercicioExcecoes {
    class Program {
        static void Main(string[] args) {
            Console.Write("Numero do Quarto: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data de Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn) {
                Console.WriteLine("Erro na reserva: Data de Check-out deve ser posterior a Data de Check-In");
            }
            else {
                Reserva reserva = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                Console.Write("Data de Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now) {
                    Console.WriteLine("Erro: As datas da reserva para atualizar devem ser futuras: ");
                }
                else if (checkOut <= checkIn) {
                    Console.WriteLine("Erro na reserva: Data de Check-out deve ser posterior a Data de Check-In");
                }
                else {
                    reserva.AtualizarDatas(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reserva);
                }
            }
        }
    }
}
