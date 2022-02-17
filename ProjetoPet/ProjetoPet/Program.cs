using System;
using System.Collections.Generic;

namespace ProjetoPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bem vindo à plataforma");

            //FluxoCriarPet(tutorCriado.Id);

            #region Exemplos De Lista
            // Criar uma lista para armazenar nomes
            List<string> listaNomes = new List<string>();

            // Adicionar o nome Giovanna na Lista
            listaNomes.Add("Giovanna");

            // Adicionar o nome Matheus na Lista
            listaNomes.Add("Matheus");

            // Adicionar o nome da Duda na lista
            listaNomes.Add("Duda");

            // Acessar o primeiro nome da Lista - Giovanna.
            string primeiroNomeDaLista = listaNomes[0];
          //  Console.WriteLine($"{primeiroNomeDaLista}");

            // Acessar o segundo nome da Lista 
            string segundoNomeDaLista = listaNomes[1];
         //   Console.WriteLine(segundoNomeDaLista);

            // Contar o número de elementos/itens da Lista
            int numeroDeItensNaLista = listaNomes.Count;

            // Mostrar na tela todos os nomes da Lista
            int contador = 0;

            while (contador < listaNomes.Count)
            {
                Console.WriteLine(listaNomes[contador]);
                contador = contador + 1;
            }

            #endregion

            AcessoDadosFake dadosFake = new AcessoDadosFake();

            Tutor tutorCriado = FluxoCriarTutor();
            dadosFake.SalvarTutor(tutorCriado);

            Tutor segundoTutorCriado = FluxoCriarTutor();
            dadosFake.SalvarTutor(segundoTutorCriado);

            List<Tutor> tutoresRegistradosNaClinica = dadosFake.ObterTodosOsTutores();
            int contadorTutor = 0;

            Console.WriteLine("A seguir é mostrado a lista de Tutores Cadastrados:");

            while (contadorTutor < tutoresRegistradosNaClinica.Count)
            {
                Console.WriteLine(tutoresRegistradosNaClinica[contadorTutor].Nome);
                contadorTutor = contadorTutor + 1;
            }

        }


        static Tutor FluxoCriarTutor()
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

            //estudaaar
            return tutor;
        }

        //Id (ex: 1800) 
        //Nome(ex: Meg)
        //Data de nascimento(ex: 15/08/2016)
        //Espécie(ex: Cão)
        //IdTutor(ex: 1555)

        static void FluxoCriarPet(Guid tutorID)
        {
            Console.WriteLine("Digite o nome do Pet");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do pet");
            string datadeNascimento = Console.ReadLine();
            DateTime datadeNascimentodDataTime = Convert.ToDateTime(datadeNascimento);

            Console.WriteLine("Digite a espécie");
            string especie = Console.ReadLine();

            Pet pet = new Pet();
            pet.Nome = nome;
            pet.DataDeNascimento = datadeNascimentodDataTime;
            pet.Especie = especie;
            pet.IdTutor = tutorID;
           

            Console.ReadLine();


        }

    }
}
