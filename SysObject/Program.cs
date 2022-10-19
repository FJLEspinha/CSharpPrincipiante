// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace ClasesInterStruc
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();
            song.Title = "Dark side of moon";
            song.Seconds = 500;
            song.Position = new ShelvePosition(0, 0);
            song.Play();

            Song song2 = new Song();
            song.Title = "Dark side of moon";
            song.Seconds = 350;
            song.Position = new ShelvePosition(1, 0);

           // if(song == song2)
            //{

            //}
            Console.WriteLine(song2.ToString());


            // ejecutar este codigo
            // Ponemos el ReadKey porque sino se abre y cierra la consola
            // y no daría tiempo a verlo.
            Console.ReadKey(); 
        }
    }
  
}