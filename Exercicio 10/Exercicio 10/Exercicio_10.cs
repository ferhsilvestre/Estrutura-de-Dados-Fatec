﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Exercicio_10
    {
        const int MAX = 20;

        static void Insere(char[] p, ref int t, char v)
        {
            p[t] = v;
            t = t + 1;
        }

        static char Remove(char[] p, ref int t)
        {
            t = t - 1;
            return (p[t]);
        }

        static bool EstaVazia(int t)
        {
            if (t == 0)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int t)
        {
            if (t == MAX)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            char[] pilha = new char[MAX];
            int topo = 0, i = 0;
            string frase, novafrase = "";

            Console.WriteLine("Insira uma frase: ");
            frase = Console.ReadLine();
            int tam = frase.Length;

            while (i < tam)
            {
                while (i < tam && frase[i] != ' ')
                {
                    Insere(pilha, ref topo, frase[i]);
                    i++;
                }
                while (EstaVazia(topo) == false)
                {
                    novafrase += Remove(pilha, ref topo);
                }
                
                novafrase += " ";
                i++;

            }
            Console.WriteLine(novafrase);
            Console.ReadKey();


        }
    }
}
