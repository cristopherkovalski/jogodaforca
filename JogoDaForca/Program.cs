namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo da Forca!");
            Console.WriteLine("Tema: Animais");
            List<string> animais = new List<string>
        {
            "LEÃO", "ELEFANTE", "GIRRAFA", "MACACO", "CACHORRO",
            "GATO", "TIGRE", "ZEBRA", "HIPOPÓTAMO", "GORILA",
            "URSO", "PATO", "COBRA", "LAGARTO", "RINOCERONTE",
            "PINGUIM", "PANDA", "CROCODILO", "CORUJA", "CAMELO"
        };

            Random random = new Random();
            string palavraChave = animais[random.Next(animais.Count)];
            JogoDF jogo = new JogoDF(palavraChave);

            do
            {
                Console.Write("Digite uma letra: ");
                char letra = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Adiciona uma linha em branco para melhorar a legibilidade

                jogo.Jogar(letra);

            } while (!jogo.PalavraCompleta() && jogo.TentativasRestantes > 0);

            Console.ReadLine(); // Aguarda a tecla Enter antes de fechar o console
        }
    }
}
