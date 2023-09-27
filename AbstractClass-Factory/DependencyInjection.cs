using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Factory
{

    internal class DependOn
    {
        public string Name {  get; set; }
        public DependOn(string name)
        {
            this.Name = name;
         }
    }


    internal class DependencyInjection
    {
        private DependOn _DependOnMember = null;
        public DependOn DependOnMember{get;}
        public DependencyInjection()
        {
            this._DependOnMember = new DependOn("John");
        }
    }

    //Si DependOn cambia o puede cambiar, estamos en problemas
    //Además DependencyInjection debe saber cómo contruir la clase y los parámetros que requiere
    //lo que supone un problema

    //Solución, Clases Abstractas o "Interfaces", además que debe recibir el objeto en el constructor
    //no crearlo en su propio código...

}
