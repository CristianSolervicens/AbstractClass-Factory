using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Factory
{
    public abstract class AbstractClass
    {
        public abstract string Name { get; internal set; }
        public abstract string Description { get; internal set; }

        public abstract void WhoAmI();
    }

    public class FirstClass : AbstractClass
    {
        public override string Name { get; internal set; }
        public override string Description { get; internal set; }
        
        public FirstClass(string Name, string Description)
        {
            this.Name= Name;
            this.Description= Description;
        }

        public override void WhoAmI()
        {
            Console.WriteLine( $"{this.Name}: {this.Description} (First)" );

        }
    }

    public class SecondClass : AbstractClass
    {
        public override string Name { get; internal set; }
        public override string Description { get; internal set; }

        public SecondClass(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public override void WhoAmI()
        {
            Console.WriteLine($"Nombre: {this.Name}: Descripción: {this.Description} (Second)");

        }
    }


    public static class AbstractClassFactory
    {
        public static AbstractClass GetClass(string Nombre, string Descripcion, int condicion)
        {
            switch(condicion)
            {
                case 1:
                    return new FirstClass(Nombre, Descripcion);

                case 2:
                    return new SecondClass(Nombre, Descripcion);

                default:
                    throw new Exception($"AbstractClassFactory, Valor de Condición desconocido: {condicion}");
                    //return null;
            }
        }
    }


}
