using System.Text;

namespace Translator2._0
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            string text = Clipboard.GetText();
            foreach(var ch in text)
            {
                char newCh = Chars.EngToRus.TryGetValue(ch, out char temp) 
                    ? temp 
                    : ch;
                sb.Append(newCh);
            }
            Clipboard.SetText(sb.ToString());
        }
    }
}