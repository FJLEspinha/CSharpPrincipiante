// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using AsyncAndAwait;
using ColeccionesDiccionarios;
using MetodosExtension;
using SysteReflectionGeneralidades;

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

            // Async and Await

            DownloadSong();

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

            // Diccionarios
            DictionaryExplanation();

            Console.ReadKey();

        }
        
        private static void DownloadSong()
        {
            DownloadService downloadService = new DownloadService();
            byte[] song = downloadService.Download("Dark side of the moon");
        }

        // Con la palabra reservada async le indicamos que es una tarea asyc
        // Más sencillo que el Thread
        private async void DownloadSongAsync()
        {
            DownloadService downloadService = new DownloadService();
            byte[] futureSong = await downloadService.DownloadAsync("Dark side of the moon");
            // otra forma que funciona sin poner await después del = NO RECOMENDABLE POR EL LENGUAJE INTERMEDIO QUE PONE EL COMPILADOR
            // Task<byte[]> futureSong =  downloadService.DownloadAsync("Dark side of the moon");


            // COMO ANOTACIÓN
            // Para crear una tarea en linea usaremos la clase Task con el parámetro Run
            /*Task.Run(() =>
            {
                downloadService.DownloadAsync........
            });*/

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
        private static void DictionaryExplanation()
        {
            Dictionary<string, Client> clients = new Dictionary<string, Client>();
            clients.Add("00000000D", new Client() { Name = "Fran J" });
            

            if (!clients.ContainsKey("00000000D"))
            {
                clients.Add("00000000D", new Client() { Name = "Fran J" });
            }
            clients["00000000D"] = new Client();

            Client myClient = clients["00000000D"];
            // Devuelve un booleano si la clave existe o no
            //clients.TryGetValue()

            // A modo informativo acceder al siguiente espacio de nombre
            // System.Collections.Generic.
            // podemos ver mas colecciones que las vimos

            // Recorrer el diccionario
            /*  foreach(KeyValuePair<string,Client> keyValue in clients)
              {

              }*/

            // Metodos de extension usando la case creada Utils
            var elements = new List<KeyValuePair<string, Client>>();
            elements.Add(new KeyValuePair<string, Client>("0001", new Client()));
            elements.Add(new KeyValuePair<string, Client>("0002", new Client()));
            // Esto agregaria nuestros clientes a nuestro diccionario con el metodo
            // creado en Utils.
            // creado en Utils.
            // PODEMOS HACER ESTO MÁS ELEGANTE Y FUNCIONAL DONDE ENTRAN LOS MÉTODOS DE EXTENSIÓN

           // Comentamos el metodo que sigue para ver como se usaría el metodo de extension
            // Utils.AddRangeDictionary(clients, elements);

            // Con Metodo de Extensión
            clients.AddRange(elements); // muchísimo más elegante y fácil

        }

        // Vamos a añadir constrains a este metodo.
        // Se hace parecido a una clase
        // Vemos que el tipo data va a heredar los valores de Media
        static void WriteLineSpecial<T>(T data, string prefix, string suffix) where T : Media
        {
            Console.WriteLine($"{prefix} {data.Title} {suffix}");
        }
        // Añadir constrain para poder instanciar un generico
        static void WriteLineSpecial2<T>(T data, string prefix, string suffix) where T : new()
        {
            T myNewType = new T();
            Console.WriteLine($"{prefix} {data} {suffix}");
        }

    }
  
}