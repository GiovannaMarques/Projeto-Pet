﻿using System;

namespace ProjetoPet
{
    public class Pet
    {
        // colocar propriedades Pet
        public Guid Id = Guid.NewGuid();
        public string Nome;
        public DateTime DataDeNascimento;
        public string Especie;
        public Guid IdTutor;


        //Id (ex: 1800)
        //Nome(ex: Meg)
        //Data de nascimento(ex: 15/08/2016)
        //Espécie(ex: Cão)
        //IdTutor(ex: 1555)

    }
}
