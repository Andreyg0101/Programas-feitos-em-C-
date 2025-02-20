using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Case.Junto.Com.Telinha.No.Prompt
{
    internal class Program
    {
        static void Main(string[] args)
        {
       voltar:
           Console.Clear();
           string empresa = @" _    _   _   _   _____   __  __   ______    _____ 
| |  | | | \ | | |_   _| |  \/  | |  ____|  / ____|
| |  | | |  \| |   | |   | \  / | | |__    | (___  
| |  | | | . ` |   | |   | |\/| | |  __|    \___ \ 
| |__| | | |\  |  _| |_  | |  | | | |____   ____) |
 \____/  |_| \_| |_____| |_|  |_| |______| |_____/ ";
           Console.ForegroundColor = ConsoleColor.DarkRed;
           Console.WriteLine(empresa); 
           Console.ForegroundColor = ConsoleColor.Blue;
           Console.SetCursorPosition(7,10);
           Console.WriteLine("╔═══════════════════════════════╗");
           Console.SetCursorPosition(7, 11);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 12);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 13);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 14);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 15);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 16);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 17);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 18);
           Console.WriteLine("║                               ║");
           Console.SetCursorPosition(7, 19);
           Console.WriteLine("╚═══════════════════════════════╝");
           Console.ForegroundColor= ConsoleColor.Red;
           Console.SetCursorPosition(12, 11);
           Console.WriteLine("MENU - UNIMES");
           Console.SetCursorPosition(11, 13);
           Console.WriteLine("1 - CADASTRO");
           Console.SetCursorPosition(11, 14);
           Console.WriteLine("2 - ALTERAR");
           Console.SetCursorPosition(11, 15);
           Console.WriteLine("3 - EXCLUIR");
           Console.SetCursorPosition(11, 16);
           Console.WriteLine("4 - SAIR");
           Console.SetCursorPosition(25, 18);
           Console.WriteLine("[ ]");
           Console.SetCursorPosition(26, 18);
           Console.ForegroundColor = ConsoleColor.Yellow;
           int op = Convert.ToInt32(Console.ReadLine());
           Console.ResetColor();
           Console.Clear();
           switch (op)
           {
               case 1:
                   Console.WriteLine("Cadastro!");
                   break;
               case 2:
                   Console.WriteLine("Alterar!");
                   break;
               case 3:
                   Console.WriteLine("Excluir!");
                   break;
               case 4:
                   Console.WriteLine("Press. qualquer tecla!");
                   break;
               default:
                   Console.WriteLine("Comando não cadastrado!");
                   Console.ReadKey();
                   goto voltar;
               }
           Console.ReadKey();
        }
    }
}
