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
        //metodo para atualizar as dadas da diaria.
        public void AtualizarDatas(DateTime checkIn, DateTime checkOut) {
            CheckIn = checkIn;
            CheckOut = checkOut;
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
