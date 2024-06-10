using RdrOleDll4;
using System.Diagnostics.Metrics;
using System.Diagnostics;

namespace RdrOleDll4_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Sunrise");
            RdrOleDll4.IOleReaderServer readerServer;
            RdrOleDll4.IOleInstrument instrument;

            readerServer = new RdrOleDll4.ReaderServer();
            readerServer.InstrumentName = "Sunrise";
            readerServer.CommType = 1; // 1 == Simulate instrument (this only works, if simulation is available)
            instrument = readerServer.CreateInstrumentObject();
            Debug.Assert((instrument as Object) != null);

            Console.WriteLine($"Name={instrument.InstrumentName}");
            Console.WriteLine($"Serial number={instrument.SerialNumber}");
            
            Console.ReadLine();
        }
    }
}
