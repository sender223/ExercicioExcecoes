using System;


namespace ExercicioExcecoes.Entidades.Exceptions {
    class ExcecaoDeDominio : ApplicationException {

        public ExcecaoDeDominio(string message) : base(message) {

        }
    }
}
