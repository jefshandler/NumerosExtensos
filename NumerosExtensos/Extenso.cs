using NumerosExtensos.Enums;
using NumerosExtensos.Options;
using NumerosExtensos.Tipos;
using System;

namespace NumerosExtensos
{
    /// <summary>
    /// Classe para definir qual tipo de escrita deverá ser utilizado.
    /// </summary>
    public class Extenso
    {
        /// <summary>
        /// Método para instanciar uma classe do tipo de numeral definido.
        /// </summary>
        /// <param name="extenso">Opções prédefinidas que devem ser passadas para retornar o tipo de numeral que deverá ser escrito.</param>
        public Escrita Escrever(ExtensoOptions extenso)
        {
            
            Escrita escrita = default;

            switch (extenso.Tipo)
            {
                case TipoNumerais.Cardinais:
                    escrita = new Tipos.Cardinal.Escrever(extenso.NumeraisOptions);
                    break;
                case TipoNumerais.Ordinais:
                    escrita = new Tipos.Ordinal.Escrever(extenso.NumeraisOptions);
                    break;
                case TipoNumerais.Multiplicativos:
                    throw new NotSupportedException();
                    break;
                case TipoNumerais.Fracionarios:
                    throw new NotSupportedException();
                    break;
                case TipoNumerais.Coletivos:
                    throw new NotSupportedException();
                    break;
                case TipoNumerais.Romanos:
                    escrita = new Tipos.Romano.Escrever();
                    break;
                default: throw new NotSupportedException();

            }
            return escrita;
        }
    }
}
