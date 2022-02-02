using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_e_num_es_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri_binari = new int[8], numeri_binari_2 = new int[8], somma_terza = new int[9], somma_finale = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int somma_temp = 0;

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Inserire un numero binario nel primo array: ");
                do { } while ((int.TryParse(Console.ReadLine(), out numeri_binari[i]) && !(numeri_binari[i] == 0 || numeri_binari[i] == 1)));
            }
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Inserire un numero binario nel secondo array: ");
                do { } while ((int.TryParse(Console.ReadLine(), out numeri_binari_2[i]) && !(numeri_binari_2[i] == 0 || numeri_binari_2[i] == 1)));
            }
            for (int i = 0; i < 8; i++)
            {
                somma_temp = numeri_binari[i] + numeri_binari_2[i] + somma_terza[i];
                switch (somma_temp)
                {
                    case 0:
                        somma_finale[i] = somma_temp;
                        break;
                    case 1:
                        somma_finale[i] = somma_temp;
                        break;
                    case 2:
                        somma_finale[i] = 0;
                        if (i == 7)
                        {
                            somma_finale[8] = 1;
                            break;
                        }
                        somma_terza[i+1] = 1;
                        break;
                    case 3:
                        somma_finale[i] = 1;
                        if (i == 7)
                        {
                            somma_finale[8] = 1;
                            break;
                        }
                        somma_terza[i + 1] = 1;
                        break;
                    default:
                        break;
                }
            }
            foreach (var item in somma_finale)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
