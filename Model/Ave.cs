using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Ave : Animal, IFamilia, IEspecie
    {
        //Propiedades
        public int codigo{ get; set;}
        /*Solucion de Herencia Multiple, implementando Interfaces
          Implementacion Familia de aves*/
        public tipoEspecie especie { get; set; }

        //Implementacion Especie de aves
        public tipoFamilia familia { get; set; }

        public Ave(int codAve,string nomAve,int edadAve,double pesoAve,
            Grupo grupoVertebrado ,tipoEspecie especieAve,tipoFamilia familiaAve)
        {
            codigo = codAve;
            nombre = nomAve;
            edad = edadAve;
            peso = pesoAve;
            grupo = grupoVertebrado;
            especie = especieAve;
            familia = familiaAve;
        }
    }
}
