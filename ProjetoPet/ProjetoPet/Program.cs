using System;

namespace ProjetoPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Armazena um espaço na memória Heap para um novo Objeto do tipo "Tutor" e aponta para variável "primeiroTutor" para este novo espaço de memória
            // O valor padrão do tipo de dado "int" no C# é "zero"
            // O valor padrão do tipo de dado "string no C# é "null
            // Por isso, inicialmente, Id = 0, Nome = null, Sobrenome = null
            Tutor primeiroTutor = new Tutor();

            // A atribuição dos valores desejados para as propriedade acontece nas três linhas a seguir
            primeiroTutor.Id = 1;
            primeiroTutor.Nome = "Giovanna";
            primeiroTutor.Sobrenome = "Marques";
            primeiroTutor.DataDeNascimento = new DateTime(1999,10,12);
            primeiroTutor.Sexo = "Feminino";
            primeiroTutor.CEP = "04750-120";
            primeiroTutor.NumeroDaCasa = 123;


            // Aqui nós estamos reservando um novo espaço na memória Heap para um novo Objeto do tipo "Tutor" 
            // Este novo objeto é independente do primeiro que foi criado na linha 13!!
            // Nós criamos uma variável chamada "segundoTutor" que irá apontar para o novo Objeto criado
            // Inicialmente os valores das propriedades deste objeto são Id = 0, Nome = null, Sobrenome = null
            Tutor segundoTutor = new Tutor();

            // A atribuição dos valores desejados para as propriedade acontece nas três linhas a seguir
            segundoTutor.Id = 2;
            segundoTutor.Nome = "Matheus";
            segundoTutor.Sobrenome = "Campanini";
            segundoTutor.DataDeNascimento = new DateTime(1995,06,08);
            segundoTutor.Sexo = "Masculino";
            segundoTutor.CEP = "08940-090";
            segundoTutor.NumeroDaCasa = 70;

            Pet pet = new Pet();

            pet.IdPet = 1;
            pet.NomePet = "Mel";
            pet.DataDeNascimentoPet = new DateTime(2010,04,01);
            pet.Especie = "Yorkshire";
            pet.IdTutor = 1;


        }
    }
}
