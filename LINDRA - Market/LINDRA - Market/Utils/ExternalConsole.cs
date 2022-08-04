using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketOffsets;

namespace LINDRA___Market.Utils
{
    public class ExternalConsole
    {

        #region Variable Declarations
        private static byte[] cbuf_addtext_wrapper = new byte[] {
        0x55,
        0x8B, 0xEC,
        0x83, 0xEC, 0x8,
        0xC7, 0x45, 0xF8, 0x0, 0x0, 0x0, 0x0,
        0xC7, 0x45, 0xFC, 0x0, 0x0, 0x0, 0x0,
        0xFF, 0x75, 0xF8,
        0x6A, 0x0,
        0xFF, 0x55, 0xFC,
        0x83, 0xC4, 0x8,
        0x8B, 0xE5,
        0x5D,
        0xC3
    };
        static IntPtr ProcessHandle = IntPtr.Zero;
        static int ProcessID = -1;
        static int nop_address;
        static byte[] callbytes;
        static IntPtr cbuf_addtext_alloc = IntPtr.Zero;
        static byte[] commandbytes;
        static IntPtr commandaddress;
        static byte[] nopBytes = { 0x90, 0x90 };
        static Trainer t = new Trainer();

        #endregion

        public static void Send(string commands)
        {

            try
            {
                if (COD.checkGame() && commands != String.Empty)
                {
                    dynamic cod = COD.Game();
                    t.Process_Handle(COD.GameName());
                    callbytes = BitConverter.GetBytes(cod.GetType().GetProperty("cbuf_addtext").GetValue(cod));
                    nop_address = cod.GetType().GetProperty("nop_address").GetValue(cod);
                    t.WriteNOP(nop_address, nopBytes);
                    cbuf_addtext_alloc = t.MemoryAllocation(cbuf_addtext_wrapper);
                    commandbytes = Encoding.ASCII.GetBytes(commands);
                    commandaddress = t.MemoryAllocation(commandbytes);
                    t.WriteBytes(commandaddress, commandbytes);
                    Array.Copy(BitConverter.GetBytes(commandaddress.ToInt64()), 0, cbuf_addtext_wrapper, 9, 4);
                    Array.Copy(callbytes, 0, cbuf_addtext_wrapper, 16, 4); // callbytes
                    t.WriteBytes(cbuf_addtext_alloc, cbuf_addtext_wrapper);
                    t.CreateRemoteThread(cbuf_addtext_alloc);
                    t.FreeMemomryAllocation(cbuf_addtext_alloc, cbuf_addtext_wrapper);
                    t.FreeMemomryAllocation(commandaddress, commandbytes);
                    cbuf_addtext_alloc = IntPtr.Zero;
                }
                else if (commands == String.Empty)
                    MessageBox.Show("Please type in a command before pressing Send button", "Error", MessageBoxButtons.OK);
                else if (!COD.checkGame())
                    MessageBox.Show("No game detected", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
    }
}
