using System;

namespace BeepBeep
{
    public class MainClass
    {
        public static int ChooseFreq(){
            
            int freq;
            Console.Write("Escolha a frequência do beep (hertz): ");
            string freqS = Console.ReadLine();

            if (!Int32.TryParse(freqS, out freq)){ //TryParse retorna um valor boleano dizendo se a tentativa de alterar a string para numero foi verdadeira ou falsa.
            
                return 800;
            }
            else{
            
                return freq;
            }
        }

        public static int ChooseDur(){
            int dur;
            Console.Write("Escolha a duração do beep (milissegundos): ");
            string durS = Console.ReadLine();

            if (!Int32.TryParse(durS, out dur)){
                return 200;
            }
            else{

                return dur;
            }
        }

        public static void ConstantMode(int freq, int dur){

            Console.WriteLine("Pressione CTRL + C para sair...");

            while (true){

                Console.Beep(freq, dur);
            }
        }

        public static void TouchMode(int freq, int dur){

            Console.WriteLine("Pressione X ou CTRL + C para sair...");
            ConsoleKeyInfo keyinfo;
            do{

                keyinfo = Console.ReadKey();
                Console.Beep(freq, dur);
            }
            while (keyinfo.Key != ConsoleKey.X);
        }

        public static void Main(){

            string version = "1.1";
            string choose;
            int freq, dur;

            Console.WriteLine("=======================================");
            Console.WriteLine("Beep: O programa que bipa! - Versão " + version);
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Escolha o modo do programa:");
            Console.WriteLine("---------------------------");
            Console.WriteLine("(1) Modo Toque - Bipa quando tecla for pressionada");
            Console.WriteLine("(2) Modo Constante - Bipa constantemente até o programa ser fechado\n");
            Console.Write("Escolha o modo (qualquer outra opção para sair): ");
            choose = Console.ReadLine();

            if (choose == "1"){

                freq = ChooseFreq();
                dur = ChooseDur();
                TouchMode(freq, dur);
            }
            else if (choose == "2"){

                freq = ChooseFreq();
                dur = ChooseDur();
                ConstantMode(freq, dur);
            }
            else{

                Console.WriteLine("Saindo...");
            }
        }
    }
}