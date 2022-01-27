﻿using System;

namespace ProjetoPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à plataforma");

            FluxoCriarTutor();

            #region exemplos tutores pet

            // Armazena um espaço na memória Heap para um novo Objeto do tipo "Tutor" e aponta para variável "primeiroTutor" para este novo espaço de memória
            // O valor padrão do tipo de dado "int" no C# é "zero"
            // O valor padrão do tipo de dado "string no C# é "null
            // Por isso, inicialmente, Id = 0, Nome = null, Sobrenome = null
            Tutor primeiroTutor = new Tutor();

            // A atribuição dos valores desejados para as propriedade acontece nas três linhas a seguir
            primeiroTutor.Id = 1;
            primeiroTutor.Nome = "Giovanna";
            primeiroTutor.Sobrenome = "Marques";
            primeiroTutor.DataDeNascimento = new DateTime(1999, 10, 12);
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
            segundoTutor.DataDeNascimento = new DateTime(1995, 06, 08);
            segundoTutor.Sexo = "Masculino";
            segundoTutor.CEP = "08940-090";
            segundoTutor.NumeroDaCasa = 70;

            Pet pet = new Pet();

            pet.Id = 1;
            pet.Nome = "Mel";
            pet.DataDeNascimento = new DateTime(2010, 04, 01);
            pet.Especie = "Yorkshire";
            pet.IdTutor = 1;

            #endregion

        }

        static void FluxoCriarTutor()
        {
            // Capturar os dados do tutor e criar o objeto tutor 
            Console.WriteLine("Preencha os dados do tutor no formulário");

            Console.WriteLine("Digite o nome do tutor: ");
            string nomeTutor = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do tutor: ");
            string sobrenomeTutor = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do tutor: ");
            string dataNascimentoTutorString = Console.ReadLine();
            DateTime dataNascimentoTutorDateTime = Convert.ToDateTime(dataNascimentoTutorString); 

            Console.WriteLine("Digite o sexo do tutor: ");
            string sexoTutor = Console.ReadLine();

            Console.WriteLine("Digite o CEP do tutor:");
            string cepTutor = Console.ReadLine();

            Console.WriteLine("Digite o número da casa do tutor: ");
            string numeroDaCasa = Console.ReadLine();
            int numeroDaCasaInt = Convert.ToInt32(numeroDaCasa);

            Tutor tutor = new Tutor();
            tutor.Nome = nomeTutor;
            tutor.Sobrenome = sobrenomeTutor;
            tutor.DataDeNascimento = dataNascimentoTutorDateTime;
            tutor.Sexo = sexoTutor;
            tutor.CEP = cepTutor;
            tutor.NumeroDaCasa = numeroDaCasaInt;

            

            Console.ReadLine();

        }


    }
}
