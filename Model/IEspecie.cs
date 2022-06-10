using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /* Especies de Aves
     Rapaces. 
     Pájaros.
     Corredoras. 
     Zancudas.
     Gallináceas. ...
     Anseriformes. ...
     Esfenisciformes.
     */
   public enum tipoEspecie
    {
        Rapaz,
        Pajaro,
        Corredor,
        Zancuda,
        Gallinacea,
        Anseriforme,
        Esfenisciforme
    }
    interface IEspecie
    {
        tipoEspecie especie { get; set; }
    }
}
