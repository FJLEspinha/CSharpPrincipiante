using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activator. Clase estatica poder instanciar clases sin tener conocimiento al uso de ella
            new MySampleFromReflection();
        }
        // Uso del Activator
        static void DoSomethingWithMyClass<T>() where T : new()
        {
            Activator.CreateInstance<T>(); //Nos devuelve una instacia de esa clase mejor que con new esto nos permite añadir parametros

        }
        static void SampleWithAttributes()
        {
            MySampleFromReflection sample = new MySampleFromReflection();
            MyAttribute attr = (MyAttribute) sample.GetType().GetCustomAttributes(false).FirstOrDefault();

            sample.GetType();
        }
    }
}