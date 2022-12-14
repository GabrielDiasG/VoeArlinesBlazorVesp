using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voearlinesblazorvesp.Data
{
    public class Aeronave//um conjunto de objetos
    {
        //propriedade automática
        public string? Modelo{get;set;}
        public string? Codigo { get; set; }
        public string? Fabricante { get; set; }
        //construtor
        public Aeronave(string? modelo, string? codigo, string? fabricante)
        {
            Modelo = modelo;
            Codigo = codigo;
            Fabricante = fabricante;
        }
    }
}
//Cada linguagem tem sua gramática - ortográfia
/*class ---> pascalcase
propriedades(automáticas)--->pascalcase
variáveis-->---camelcase
"_"--->variáveis de imnjeção de dependência para diferenciar das propriedades automáticas.
método
fabricarTomate()---java javascript php c c++
FabricarTomate()---C#
*/