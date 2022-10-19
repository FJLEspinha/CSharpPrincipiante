using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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


            // En esta nueva leccion vamos a empezar con más metodos del gettype
            PropertyInfo[] properties = sample.GetType().GetProperties();// recuperamos las propiedades de la clase 
            properties[0].SetValue(sample, "Fran");
            properties[0].GetValue(sample);

            MethodInfo[] methods = sample.GetType().GetMethods();
            MethodInfo doSomething =methods.FirstOrDefault(x => x.Name == "DoSomething");

            if(doSomething != null)
            {
                doSomething.Invoke(sample, null);
            }
            // Similar like GetProperty and PropertyInfo
            sample.GetType().GetFields();

            //Assembly.GetExecutingAssembly().GetManifestResourceNames(); A forma de uno de los muchos ejemplos.
        }
    }
}