using System;

namespace ProjetoPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à plataforma");

            FluxoCriarTutor();

            FluxoCriarPet();
            
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

            //

            Console.ReadLine();

        }

        //Id (ex: 1800)
        //Nome(ex: Meg)
        //Data de nascimento(ex: 15/08/2016)
        //Espécie(ex: Cão)
        //IdTutor(ex: 1555)

        static void FluxoCriarPet()
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

            Console.ReadLine();


        }

    }
}
