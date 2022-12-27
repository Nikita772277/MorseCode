using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class MorseCode
    {
        public string Decode(string morseCode)
        {
            char[] chars = morseCode.ToCharArray();
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            string word = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != ' ')
                {
                    if (char.IsSeparator(chars[i]) || char.IsPunctuation(chars[i]))
                    {
                        counter = 0;
                        word += (chars[i]);
                    }
                }
                if (chars[i] == ' ' || i == chars.Length - 1)
                {
                    counter++;
                    switch (word)
                    {
                        case "....":
                            sb.Append('H');
                            break;
                        case ".":
                            sb.Append('E');
                            break;
                        case "-.--":
                            sb.Append('Y');
                            break;
                        case ".---":
                            sb.Append('J');
                            break;
                        case "..-":
                            sb.Append('U');
                            break;
                        case "-..":
                            sb.Append('D');
                            break;
                        case ".-":
                            sb.Append('A');
                            break;
                        case "--.":
                            sb.Append('G');
                            break;
                        case "--":
                            sb.Append('M');
                            break;
                        case "...":
                            sb.Append('S');
                            break;
                        case "-...":
                            sb.Append('B');
                            break;
                        case "-.":
                            sb.Append('N');
                            break;
                        case "-":
                            sb.Append('T');
                            break;
                        case "--..":
                            sb.Append('Z');
                            break;
                        case "-.-.":
                            sb.Append('C');
                            break;
                        case "..":
                            sb.Append('I');
                            break;
                        case "---":
                            sb.Append('O');
                            break;
                        case ".--.":
                            sb.Append('P');
                            break;
                        case "...-":
                            sb.Append('V');
                            break;
                        case "-.-":
                            sb.Append('K');
                            break;
                        case "--.-":
                            sb.Append('Q');
                            break;
                        case ".--":
                            sb.Append('W');
                            break;
                        case "..-.":
                            sb.Append('F');
                            break;
                        case ".-..":
                            sb.Append('L');
                            break;
                        case ".-.":
                            sb.Append('R');
                            break;
                        case "-..-":
                            sb.Append('X');
                            break;
                        case "-----":
                            sb.Append('0');
                            break;
                        case ".----":
                            sb.Append('1');
                            break;
                        case "..---":
                            sb.Append('2');
                            break;
                        case "...--":
                            sb.Append('3');
                            break;
                        case "....-":
                            sb.Append('4');
                            break;
                        case ".....":
                            sb.Append('5');
                            break;
                        case "-....":
                            sb.Append('6');
                            break;
                        case "--...":
                            sb.Append('7');
                            break;
                        case "---..":
                            sb.Append('8');
                            break;
                        case "----.":
                            sb.Append('9');
                            break;
                        case ".-.-.-":
                            sb.Append('.');
                            break;
                        case "-.--.":
                            sb.Append('(');
                            break;
                        case ".-.-.":
                            sb.Append('+');
                            break;
                        case "..-.-":
                            sb.Append('¿');
                            break;
                        case "--..--":
                            sb.Append(',');
                            break;
                        case "-.--.-":
                            sb.Append(')');
                            break;
                        case "-....-":
                            sb.Append('-');
                            break;
                        case "--...-":
                            sb.Append('¡');
                            break;
                        case "..--..":
                            sb.Append('?');
                            break;
                        case ".-...":
                            sb.Append('&');
                            break;
                        case "..--.-":
                            sb.Append('_');
                            break;
                        case "---...":
                            sb.Append(':');
                            break;
                        case ".-..-.":
                            sb.Append('"');
                            break;
                        case "-.-.--":
                            sb.Append('!');
                            break;
                        case "-.-.-.":
                            sb.Append(';');
                            break;
                        case "...-..-":
                            sb.Append('$');
                            break;
                        case "-..-.":
                            sb.Append('/');
                            break;
                        case "-...-":
                            sb.Append('=');
                            break;
                        case ".--.-.":
                            sb.Append('@');
                            break;
                    }
                    word = "";
                }
                if (counter == 3 && sb.Length > 0)
                {
                    sb.Append(' ');
                }
            }
            string f = sb.ToString();
            return f;
        }
        public string ToMorse(string englishStr)
        {
            if (englishStr == null)
            {
                return null;
            }
            else if (englishStr.Length > 0)
            {
                char[] chars = englishStr.ToCharArray();
                StringBuilder sb = new StringBuilder();
                int counter = 0;
                string word = "";
                for (int i = 0; i < chars.Length; i++)
                {
                    if (char.IsLetter(chars[i]) || chars[i] == ' ')
                    {
                        counter = 0;
                        word += (chars[i]);
                    }
                    if (word.Length == 1)
                    {
                        counter++;
                        switch (word)
                        {
                            case " ":
                                sb.Append("  ");
                                break;
                            case "H":
                                sb.Append(".... ");
                                break;
                            case "E":
                                sb.Append(". ");
                                break;
                            case "Y":
                                sb.Append("-.-- ");
                                break;
                            case "J":
                                sb.Append(".--- ");
                                break;
                            case "U":
                                sb.Append("..- ");
                                break;
                            case "D":
                                sb.Append("-.. ");
                                break;
                            case "A":
                                sb.Append(".- ");
                                break;
                            case "G":
                                sb.Append("--. ");
                                break;
                            case "M":
                                sb.Append("-- ");
                                break;
                            case "S":
                                sb.Append("... ");
                                break;
                            case "B":
                                sb.Append("-... ");
                                break;
                            case "N":
                                sb.Append("-. ");
                                break;
                            case "T":
                                sb.Append("- ");
                                break;
                            case "Z":
                                sb.Append("--.. ");
                                break;
                            case "C":
                                sb.Append("-.-. ");
                                break;
                            case "I":
                                sb.Append(".. ");
                                break;
                            case "O":
                                sb.Append("--- ");
                                break;
                            case "P":
                                sb.Append(".--. ");
                                break;
                            case "V":
                                sb.Append("...- ");
                                break;
                            case "K":
                                sb.Append("-.- ");
                                break;
                            case "Q":
                                sb.Append("--.- ");
                                break;
                            case "W":
                                sb.Append(".-- ");
                                break;
                            case "F":
                                sb.Append("..-. ");
                                break;
                            case "L":
                                sb.Append(".-.. ");
                                break;
                            case "R":
                                sb.Append(".-. ");
                                break;
                            case "X":
                                sb.Append("-..- ");
                                break;
                            case "0":
                                sb.Append("----- ");
                                break;
                            case "1":
                                sb.Append(".---- ");
                                break;
                            case "2":
                                sb.Append("..--- ");
                                break;
                            case "3":
                                sb.Append("...-- ");
                                break;
                            case "4":
                                sb.Append("....- ");
                                break;
                            case "5":
                                sb.Append("..... ");
                                break;
                            case "6":
                                sb.Append("-.... ");
                                break;
                            case "7":
                                sb.Append("--... ");
                                break;
                            case "8":
                                sb.Append("---.. ");
                                break;
                            case "9":
                                sb.Append("----. ");
                                break;
                            case "(":
                                sb.Append("-.--. ");
                                break;
                            case "+":
                                sb.Append(".-.-. ");
                                break;
                            case "¿":
                                sb.Append("..-.- ");
                                break;
                            case ",":
                                sb.Append("--..-- ");
                                break;
                            case ")":
                                sb.Append("-.--.- ");
                                break;
                            case "¡":
                                sb.Append("--...- ");
                                break;
                            case "..--..":
                                sb.Append("..--.. ");
                                break;
                            case "&":
                                sb.Append(".-... ");
                                break;
                            case "_":
                                sb.Append("..--.- ");
                                break;
                            case ":":
                                sb.Append("---... ");
                                break;
                            case "!":
                                sb.Append("-.-.-- ");
                                break;
                            case ";":
                                sb.Append("-.-.-. ");
                                break;
                            case "$":
                                sb.Append("...-..- ");
                                break;
                            case "/":
                                sb.Append("-..-. ");
                                break;
                            case "=":
                                sb.Append("-...- ");
                                break;
                            case "@":
                                sb.Append(".--.-. ");
                                break;
                        }
                        word = "";
                    }
                    if (counter == 3 && sb.Length > 0)
                    {
                        sb.Append(' ');
                    }
                }
                string f = sb.ToString();
                var x = f.Remove(f.Length - 1);
                return x;
            }
            return "";
        }

    }
}
