using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class BonecoForca
    {
        private int partesDoCorpo;
        private readonly string[] desenhos =
        {
        "  +---+\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        "  |   |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        " /|   |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        "      |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        " /    |\n" +
        "      |\n" +
        "      |\n" +
        "=========",

        "  +---+\n" +
        "  O   |\n" +
        " /|\\  |\n" +
        " / \\  |\n" +
        "      |\n" +
        "      |\n" +
        "========="
    };

        public BonecoForca()
        {
            partesDoCorpo = 0;
        }

        public void AdicionarParteDoCorpo()
        {
            partesDoCorpo++;
        }

        public void ImprimirBoneco()
        {
            if (partesDoCorpo < desenhos.Length)
            {
                Console.WriteLine(desenhos[partesDoCorpo]);
            }
        }
    }

}

