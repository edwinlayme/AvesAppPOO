using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public enum Grupo
    {
        Aves,
        Peces, 
        Anfibios, 
        Reptiles, 
        Mamíferos
    }
     public class Animal
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double peso { get; set; }
        public Grupo grupo { get; set; }

        public Animal()
        {

        }
    }
}
