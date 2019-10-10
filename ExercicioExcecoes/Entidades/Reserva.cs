using System;
namespace ExercicioExcecoes.Entidades {
    class Reserva {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut) {
            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        //metodo de duração das diarias, 
        public int Duracao() {
            //diferença entre os dois é a duração da diaria
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            //como o TotalDays é um double, precisamos fazer um casting 
            //para converter ele em inteiro e assim saber a quantidade
            //de dias que ficou hospedado.
            return (int)duracao.TotalDays;
        }
        //metodo para atualizar as dadas da diaria. MUDAMOS DE VOID PARA STRING o tipo do METODO
        public string AtualizarDatas(DateTime checkIn, DateTime checkOut) {

            //alem disso passamos a logica de verificação das datas dentro do nosso metodo. 

            DateTime now = DateTime.Now;
            //se a data de checkIn for menor que agora e checkOut for menor que agora irá retornar o erro 
            //que descrevemos
            if (checkIn < now || checkOut < now) {
                 return "Erro: As datas da reserva para atualizar devem ser futuras: ";
            }
            //se a data de checkcOut for menor que a data de checkIn irá retornar o erro
            //que descrevemos abaixo
            if (checkOut <= checkIn) {
                return "Erro na reserva: Data de Check-out deve ser posterior a Data de Check-In";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            //aqui vamos retornar nulo caso a função não encontrar nenhum erro. 
            return null;
        }

        public override string ToString() {
            return "Quarto: "
                + NumeroQuarto
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duracao()
                + " Noites";
        }
    }
}
