using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Utils;
using MarketOffsets.Interfaces;

namespace MarketOffsets
{
    public class COD
    {                           //    mw2   ,   mw3   
        static string[] games = {  "iw4mp",  "iw5mp", };
        static Type CallofDuty;
        static string gameName;
        public static bool checkGame()
        {

            foreach (string game in games)
            {
                if (new Trainer().Process_Handle(game))
                {
                    CallofDuty = Type.GetType("MarketOffsets.Offsets" + "." + game);
                    gameName = game;
                    return true;
                }
            }
            return false;
        }

        public static object Game()
        {
            return Activator.CreateInstance(CallofDuty) as IFovAndFps;
        }

        public static string GameName()
        {
            return gameName;
        }

        public static string LongGameName()
        {
            switch (COD.GameName())
            {
                case "iw3mp":
                    return "Call of Duty 4 Modern Warfare - Multiplayer";
                case "iw4mp":
                    return "Call of Duty Modern Warfare 2 - Multiplayer";
                case "BlackOpsMP":
                    return "Call of Duty BlackOps - Multiplayer";

                case "iw5mp":
                    return "Call of Duty Modern Warfare 3 - Multiplayer";
                case "t6mp":
                    return "Call of Duty BlackOps 2 - Multiplayer";
                case "t6zm":
                    return "Call of Duty BlackOps 2 - Zombies";
                default:
                    return "No game detected";
            }
        }
    }
}
