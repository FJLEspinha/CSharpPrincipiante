using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    // Esta clase creada para el tema Async and Await
    internal class DownloadService
    {
        public byte[] Download(string songName)
        {
            // El Sleep pausa un hilo o proceso
            Thread.Sleep(1000);
            return new byte[] { };
        }
        // Con lo anterior no estaría del todo bien
        // Vamos a hacerlo con patron Async and Await
        // Reconcomendable. Poner sufico ASYNC
        // Vamos ha hacerlo concurrente
        // Usamos el Task para hacer como un generico es como una promesa.
        public Task<byte[]> DownloadAsync(String songName)
        {
            Thread.Sleep(1000);
            return Task.FromResult(new byte[] { });
        }
    }
}
