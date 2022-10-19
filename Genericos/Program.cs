// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Genericos;

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

            Song song2 = new Song();
            song2.Title = "Dark side of moon";
            song2.Seconds = 500;
            song2.Position= new ShelvePosition(1, 0);

            // ejecutar este codigo
            // Ponemos el ReadKey porque sino se abre y cierra la consola
            // y no daría tiempo a verlo.
            //Console.ReadKey();

            PlayList<Song> playListSongs = new PlayList<Song>();

            playListSongs.Add(song);
            playListSongs.Add(song2);

            //Podriamos omitir dentro de los diamonds el tipo Song por inferencia
            WriteLineSpecial<Song>(song, "Start with", "enjoy");

            Console.WriteLine(song2.ToString());

            Tuple<int,string, Song> tuple = new Tuple<int,string,Song>(0,"Hola",song);
            

            Console.ReadKey();

        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine($"{prefix} {data} {suffix}");
        }
        
    }
  
}