﻿using Udemy_Ex05.Entities.Enums;

namespace Udemy_Ex05.Entities
{
    abstract class Figura
    {
        public Cor Cor { get; set; }

        
        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
