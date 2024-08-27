using ExtensionMethods.Extentions;

namespace ExtensionMethods
{
    internal class Program
    {
        /*Vamos criar umextensionmethod chamado "ElapsedTime()" no struct
 DateTime para apresentar um objeto DateTime na forma de tempo
 decorrido, podendo ser emhoras (semenor que24h) ouemdias caso
 contrário.Porexemplo:
 DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
 Console.WriteLine(dt.ElapsedTime());
 "4.5 hours"
 "3.2 days"
*/
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 8, 25, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
