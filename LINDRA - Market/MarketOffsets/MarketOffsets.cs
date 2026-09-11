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
    {                           //    cod4,  mw2  ,   mw3  ,     bo1   , bo2 zombie  
        static string[] games = {  "iw3mp","iw4mp", "iw5mp", "BlackOpsMP", "t6zm" };
        static Type CallofDuty;
        static string gameName;

        /// <summary>
        /// True when the currently attached game is running as a 64-bit process.
        /// 64-bit games expose their addresses as RVA from <see cref="ModuleBase"/>
        /// and store their dvar pointers as 8 bytes.
        /// </summary>
        public static bool Is64Bit { get; private set; }

        /// <summary>
        /// Base address of the currently attached game module (0 for 32-bit games,
        /// whose offsets are already absolute).
        /// </summary>
        public static long ModuleBase { get; private set; }

        public static bool checkGame()
        {

            foreach (string game in games)
            {
                if (new Trainer().Process_Handle(game))
                {
                    gameName = game;
                    Is64Bit = Trainer.Is64BitProcess(game);
                    ModuleBase = Is64Bit ? Trainer.ModuleBase(game) : 0;

                    // 64-bit builds have their own offset class : iw4mp -> iw4mp64
                    string className = Is64Bit ? game + "64" : game;
                    CallofDuty = Type.GetType("MarketOffsets.Offsets" + "." + className);

                    if (CallofDuty == null)
                    {
                        // No 64-bit offsets yet for this game, fall back to the 32-bit class
                        Is64Bit = false;
                        ModuleBase = 0;
                        CallofDuty = Type.GetType("MarketOffsets.Offsets" + "." + game);
                    }
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
