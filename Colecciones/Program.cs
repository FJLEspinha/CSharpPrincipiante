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

            // Curso de genericos ejemplos
            // List<Song> songs = new List<Song>();
            //List<int>

            // Inciso
            // List<int> numbers = new List<int>();

            ListExplanation();

            // Pilas. son pilas de objetos
            StackExplanation();

            // Cola
            QueueExplanation();

            Console.ReadKey();

        }

        private static void ListExplanation()
        {
            List<int> numbers = new List<int>();
            numbers.Add(0);
            //numbers.Count();
            
        }
        private static void StackExplanation()
        {
            Stack<Song> salesSongs = new Stack<Song>();
            // Metodo LIFO último entra primero sale
            // Esto añade una cancion a la pila
            salesSongs.Push(new Song());
            salesSongs.Push(new Song()); // sale

            // Para extaer de la Pila. Al hacerlo nos sacaría la marcada en el comentario
            Song song = salesSongs.Pop();
        }
        private static void QueueExplanation()
        {
            // Metodo FIFO el primero entra primero sale
            Queue<int> queueNumbers = new Queue<int>();

            // Con esto encolamos, es decir, añadir
            queueNumbers.Enqueue(1);
            // Nos devuelve el que tiene que salir
            queueNumbers.Dequeue();
        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine($"{prefix} {data} {suffix}");
        }
        
    }
  
}