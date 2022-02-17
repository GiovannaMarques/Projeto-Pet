using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPet
{
    public class AcessoDadosFake
    {
        // a veterinária irá precisar 
        // tela mostrando todos os tutores
        // tela mostrando 1 tutor com mais detalhes e lista dos pets do tutor em questão
        // botão adicionar novo tutor
        // botão adicionar um novo pet a esse tutor
        // ---- o pet só pode ser criado dentro do tutor -- pet não tem mais de 1 tutor

        List<Tutor> tutorLista = new List<Tutor>();


        // estudar e dúvidas

        public List<Tutor> ObterTodosOsTutores()
        {
            return tutorLista;

        }

        void GetDetalhesTutor()
        {

        }

        public void SalvarTutor(Tutor tutor)
        {
            tutorLista.Add(tutor);
        }

        void SalvarPet()
        {

        }

        void ObterDetalhesDoPet()
        {

        }


    }
}
