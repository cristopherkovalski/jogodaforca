using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    public class JogoDF
    {
        private string palavraChave;
        private char[] letrasDescobertas;
        private int tentativasRestantes;
        private const int maxTentativas = 6; // Máximo de tentativas permitidas
        private BonecoForca boneco;

        public int TentativasRestantes { get => tentativasRestantes; set => tentativasRestantes = value; }
        public char[] LetrasDescobertas { get => letrasDescobertas; set => letrasDescobertas = value; }

        public JogoDF(string palavra)
        {
            palavraChave = palavra.ToUpper();
            letrasDescobertas = new char[palavraChave.Length];
            tentativasRestantes = maxTentativas;
            boneco = new BonecoForca();
            // Inicializa o array de letras descobertas com '_' (underline)
            for (int i = 0; i < letrasDescobertas.Length; i++)
            {
                letrasDescobertas[i] = '_';
            }
        }

        public void Jogar(char letra)
        {
            letra = Char.ToUpper(letra);

            if (LetraJaDigitada(letra))
            {
                Console.WriteLine("Você já digitou essa letra. Tente outra.");
                return;
            }

            if (LetraExisteNaPalavraChave(letra))
            {
                AtualizarLetrasDescobertas(letra);
            }
            else
            {
                tentativasRestantes--;
                boneco.AdicionarParteDoCorpo();
                Console.WriteLine("A letra digitada não existe na palavra-chave.");
                Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
            }

            ImprimirStatusJogo();
        }

        protected bool LetraJaDigitada(char letra)
        {
            return Array.IndexOf(letrasDescobertas, letra) != -1;
        }

        protected bool LetraExisteNaPalavraChave(char letra)
        {
            return palavraChave.Contains(letra);
        }

        protected void AtualizarLetrasDescobertas(char letra)
        {
            for (int i = 0; i < palavraChave.Length; i++)
            {
                if (palavraChave[i] == letra)
                {
                    letrasDescobertas[i] = letra;
                }
            }
        }

        protected void ImprimirStatusJogo()
        {
            Console.WriteLine("Palavra: " + new string(letrasDescobertas));
            boneco.ImprimirBoneco();
            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");


            if (PalavraCompleta())
            {
                Console.WriteLine("Parabéns! Você acertou a palavra.");
            }
            else if (tentativasRestantes == 0)
            {
                Console.WriteLine("Game Over. A palavra-chave era: " + palavraChave);
            }
            else
            {
                Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade
            }
        }

        public bool PalavraCompleta()
        {
            return Array.IndexOf(letrasDescobertas, '_') == -1;
        }
    }

}
