using System;
using ExercicioExcecoes.Entidades;
using ExercicioExcecoes.Entidades.Exceptions;

namespace ExercicioExcecoes {
    class Program {
        static void Main(string[] args) {
            //aqui tentamos executar o bloco de instruções
            try {

                Console.Write("Numero do Quarto: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Data de Check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reserva reserva = new Reserva(numero, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reserva);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva: ");
                Console.Write("Data de Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Reserva: " + reserva);

            }
            //caso falhe iremos capturar as excecoes e iremos exibir dentro desse bloco
            //catch que declaramos o tipo da nossa excecao.
            catch (ExcecaoDeDominio e) {
                Console.WriteLine("Erro na Reserva: " + e.Message);
            }
            //aqui pegamos falha de formatação para ser exibida o erro ao usuário.
            catch (FormatException e) {
                Console.WriteLine("Erro de Formato: " + e.Message);
            }
            //aqui colocamos uma tratativa de erro generico que pode pegar qualquer erro e tratar
            //para que o usuário veja de maneira mais amigavel o erro
            catch (Exception e) {
                Console.WriteLine("Erro Inesperado: " + e.Message);
            }
        }
    }
}
