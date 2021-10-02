using System;

namespace FindingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat = "29535123p48723487597645723645";
            string resultat;
            string delavstring01;
            string delavstring02;
            long totalen = 0;

            for (int i = 0; i < inmatat.Length - 1; i++)
            {
                if (char.IsLetter(inmatat[i]))
                {
                    continue;
                }

                for (int j = i + 1; j < inmatat.Length; j++)
                {
                    if (char.IsLetter(inmatat[j]))
                    {
                        break;
                    }
                    else if (inmatat[i] == inmatat[j])
                    {
                        resultat = inmatat.Substring(i, j - i + 1);
                        delavstring01 = inmatat.Substring(0, i);
                        delavstring02 = inmatat.Substring(j + 1);
                        Console.Write(delavstring01);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(resultat);
                        Console.ResetColor();
                        Console.Write(delavstring02);
                        Console.WriteLine();
                        totalen += Convert.ToInt64(inmatat.Substring(i, j - i + 1));

                        break;

                    }

                }
            }
            Console.WriteLine("Totalen blir : {0} ", totalen);
        }
    }
}
