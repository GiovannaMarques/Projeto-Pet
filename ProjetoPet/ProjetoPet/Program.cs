using System;

namespace ProjetoPet
{
    internal class Program
    {
        static AcessoDadosFake dadosFake;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Clínica vet - Tela principal \n");

                Console.WriteLine("Selecione 1 para cadastrar um tutor");
                Console.WriteLine("Selecione 2 para obter a lista de todos os tutores");

                var respostaUsuario = Console.ReadLine();

                if (respostaUsuario == "1")
                {
                    FluxoCriarTutor();
                }
                else if(respostaUsuario == "2")
                {
                    MostrarTodosOsTutoresNaTela();
                }
            }
        }

        static void MostrarTodosOsTutoresNaTela()
        {
            // Obter os tutores cadastrados
            // Mostrar o nome e sobrenome de cada tutor de cada tutor na tela
            // Mostrar a frase "Pressione qualquer tecla para voltar à tela principal"
        }

        static Tutor FluxoCriarTutor()
        {
            Console.Clear();
            Console.WriteLine("Clínica vet - Tela de cadastro de tutor");

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

            dadosFake.SalvarTutor(tutor);
            
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
