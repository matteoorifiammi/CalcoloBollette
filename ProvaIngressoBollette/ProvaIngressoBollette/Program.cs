using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIngressoBollette
{
    class Program
    {
        static void Main(string[] args)
        {
            string sceltaInput, kWhInput, smcInput;
            int sceltaConvertita;
            double kWhConvertiti, smcConvertiti;
            bool controlloInput;

            do
            {
                Console.WriteLine("Benvenuto! Questro programma ti aiuta a scegliere il miglior metodo di riscaldamento per te.\n" +
                    "Per iniziare seleziona il tuo attuale metodo di riscaldamento.\n" +
                    "1 Caldaia tradizionale\n" +
                    "2 Caldaia a condensazione\n" +
                    "3 Stufa elettrica\n" +
                    "4 Pompa di calore economica\n" +
                    "5 Pompa di calore fascia alta\n");
                sceltaInput = Convert.ToString(Console.ReadLine());
                controlloInput = int.TryParse(sceltaInput, out sceltaConvertita); //Verifico che l'input sia di tipo int, o che comunque sia possibile convertilo in tale
            } while (!controlloInput || 1 > sceltaConvertita || 5 < sceltaConvertita); //Verifico che il numero inserito corrisponda ad uno dei valori disponibili

            do
            {
                Console.WriteLine("\nInserisci i kWh che consumi mediamente in un anno");
                kWhInput = Convert.ToString(Console.ReadLine());
                controlloInput = double.TryParse(kWhInput, out kWhConvertiti); //Verifico che l'input sia di tipo double, o che comunque sia possibile convertilo in tale
            } while (!controlloInput || kWhConvertiti < 0); //Viene verificato il dato inserito sia valido

            do
            {
                Console.WriteLine("\nInserisci gli SMC annui medi consumati");
                smcInput = Convert.ToString(Console.ReadLine());
                controlloInput = double.TryParse(smcInput, out smcConvertiti); //Verifico che l'input sia di tipo double, o che comunque sia possibile convertilo in tale
            } while (!controlloInput || smcConvertiti < 0); //Viene verificato il dato inserito sia valido

        }
    }
}
