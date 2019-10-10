using System;
using ExercicioExcecoes.Entidades.Exceptions;
namespace ExercicioExcecoes.Entidades {
    class Reserva {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut) {

            //se a data de checkIn for menor que agora e checkOut for menor que agora, vamos "lançar"
            //uma nova exceção com o a Classe ExcecaoDeDominio dando como atributo a frase entre ().
            if (checkOut <= checkIn) {
                throw new ExcecaoDeDominio(" Data de Check-out deve ser posterior a Data de Check-In");
            }

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
        //metodo volta a ser VOID para apenas atualizar os dados. 
        public void AtualizarDatas(DateTime checkIn, DateTime checkOut) {

            //alem disso passamos a logica de verificação das datas dentro do nosso metodo. 

            DateTime now = DateTime.Now;
            //se a data de checkIn for menor que agora e checkOut for menor que agora, vamos "lançar"
            //uma nova exceção com o a Classe ExcecaoDeDominio dando como atributo a frase entre ().
            if (checkIn < now || checkOut < now) {
                 throw new ExcecaoDeDominio(" As datas da reserva para atualizar devem ser futuras: ");
            }
            //se a data de checkIn for menor que agora e checkOut for menor que agora, vamos "lançar"
            //uma nova exceção com o a Classe ExcecaoDeDominio dando como atributo a frase entre ().
            if (checkOut <= checkIn) {
                throw new ExcecaoDeDominio(" Data de Check-out deve ser posterior a Data de Check-In");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            //e não precisamos retornar mais nada devido ao tipo VOID
            //return null;
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
