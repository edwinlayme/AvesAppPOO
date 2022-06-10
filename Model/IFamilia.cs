using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /* Familia de Aves
 ORDEN STRUTHIONIFORMES.
ORDEN TINAMIFORMES.
ORDEN PELECANIFORMES.
ORDEN PODICIPEDIFORMES.
ORDEN CICONIIFORMES.
ORDEN PHOENICOPTERIFORMES.
ORDEN FALCONIFORMES.*/
    public enum tipoFamilia
    {
        Struthioniforme,
        Tinamiforme,
        Podicipediforme,
        Ciconiforme,
        Phoenicopteriforme,
        Falconiforme,
    }
    interface IFamilia
    {
        tipoFamilia familia { get; set; }
    }
}
