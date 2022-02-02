using System.Media;

namespace ConsoleApplication1
{
    class MorseCode
    {
        const int time = 37;
        const string shrtBeep = @"/Code/MorseCode/Morse Code - Dot.WAV";
        const string lngBeep = @"/Code/MorseCode/Morse Code - Dash.WAV";

        
         private Queue<string> encrypted = new Queue<string>();
          
          public MorseCode(string decrypted) // build method
          {
            decrypted = decrypted.ToLower(); // standardise the input
            
            for(int i = 0; i < decrypted.Length; i++) // translator to morse
            {
                switch (decrypted[i])
                {
                    case  'a':
                        encrypted.Insert(".-");
                        break;
                    case 'b':
                        encrypted.Insert("-...");
                        break;
                    case 'c':
                        encrypted.Insert("-.-.");
                        break;
                    case 'd':
                        encrypted.Insert("-..");
                        break;
                    case 'e':
                        encrypted.Insert(".");
                        break;
                    case 'f':
                        encrypted.Insert("..-.");
                        break;
                    case 'g':
                        encrypted.Insert("--.");
                        break;
                    case 'h':
                        encrypted.Insert("....");
                        break;
                    case 'i':
                        encrypted.Insert("..");
                        break;
                    case 'j':
                        encrypted.Insert(".---");
                        break;
                    case 'k':
                        encrypted.Insert("-.-");
                        break;
                    case 'l':
                        encrypted.Insert(".-..");
                        break;
                    case 'm':
                        encrypted.Insert("--");
                        break;
                    case 'n':
                        encrypted.Insert("-.");
                        break;
                    case 'o':
                        encrypted.Insert("---");
                        break;
                    case 'p':
                        encrypted.Insert(".--.");
                        break;
                    case 'q':
                        encrypted.Insert("--.-");
                        break;
                    case 'r':
                        encrypted.Insert(".-.");
                        break;
                    case 's':
                        encrypted.Insert("...");
                        break;
                    case 't':
                        encrypted.Insert("-");
                        break;
                    case 'u':
                        encrypted.Insert("..-");
                        break;
                    case 'v':
                        encrypted.Insert("...-");
                        break;
                    case 'w':
                        encrypted.Insert(".--");
                        break;
                    case 'x':
                        encrypted.Insert("-..-");
                        break;
                    case 'y':
                        encrypted.Insert("-.--");
                        break;
                    case 'z':
                        encrypted.Insert("--..");
                        break;
                    case '1':
                        encrypted.Insert(".----");
                        break;
                    case '2':
                        encrypted.Insert("..---");
                        break;
                    case '3':
                        encrypted.Insert("...--");
                        break;
                    case '4':
                        encrypted.Insert("....-");
                        break;
                    case '5':
                        encrypted.Insert(".....");
                        break;
                    case '6':
                        encrypted.Insert("-....");
                        break;
                    case '7':
                        encrypted.Insert("--...");
                        break;
                    case '8':
                        encrypted.Insert("---..");
                        break;
                    case '9':
                        encrypted.Insert("----.");
                        break;
                    case '0':
                        encrypted.Insert("-----");
                        break;
                    case ' ':
                        encrypted.Insert("/");
                        break;
                    default: break;
                }
            }
          }
          public override string ToString() 
          {
            return encrypted.ToString();
          }
        public string Decrypt() // decryting function - does the oppisite of the build function
        {
            string output = ""; // output variable

            while (!encrypted.IsEmpty())
            {
                output = "";
                switch (encrypted.Head()) // translator
                {
                    case ".-":
                        output += 'a';
                        break;
                    case "-...":
                        output += 'b';
                        break;
                    case "-.-.":
                        output += 'c';
                        break;
                    case "-..":
                        output += 'd';
                        break;
                    case ".":
                        output += 'e';
                        break;
                    case "..-.":
                        output += 'f';
                        break;
                    case "--.":
                        output += 'g';
                        break;
                    case "....":
                        output += 'h';
                        break;
                    case "..":
                        output += 'i';
                        break;
                    case ".---":
                        output += 'j';
                        break;
                    case "-.-":
                        output += 'k';
                        break;
                    case ".-..":
                        output += 'l';
                        break;
                    case "--":
                        output += 'm';
                        break;
                    case "-.":
                        output += 'n';
                        break;
                    case "---":
                        output += 'o';
                        break;
                    case ".--.":
                        output += 'p';
                        break;
                    case "--.-":
                        output += 'q';
                        break;
                    case ".-.":
                        output += 'r';
                        break;
                    case "...":
                        output += ('s');
                        break;
                    case "-":
                        output += ('t');
                        break;
                    case "..-":
                        output += ('u');
                        break;
                    case "...-":
                        output += ('v');
                        break;
                    case ".--":
                        output += ('w');
                        break;
                    case "-..-":
                        output += ('x');
                        break;
                    case "-.--":
                        output += ('y');
                        break;
                    case "--..":
                        output += ('z');
                        break;
                    case ".----":
                        output += ('1');
                        break;
                    case "..---":
                        output += ('2');
                        break;
                    case "...--":
                        output += ('3');
                        break;
                    case "....-":
                        output += ('4');
                        break;
                    case ".....":
                        output += ('5');
                        break;
                    case "-....":
                        output += ('6');
                        break;
                    case "--...":
                        output += ('7');
                        break;
                    case "---..":
                        output += ('8');
                        break;
                    case "----.":
                        output += ('9');
                        break;
                    case "-----":
                        output += ('0');
                        break;
                    case " / ":
                        output += (' ');
                        break;
                    default: break;
                }

            }
            return output;
        }
        public void PlayCode()
        {
            SoundPlayer s = new SoundPlayer(); // new soundplayer
            Queue<string> temp = new Queue<string>();
            int i; // index
            string letter; // saves the current letter in morse code
            while(!encrypted.IsEmpty())
            {
                letter = encrypted.Head();
                for (i = 0; i < letter.Length; i++)
                {
                    if(letter[i] == '.')
                    {
                        s.SoundLocation = shrtBeep; s.PlaySync();
                        System.Threading.Thread.Sleep(time);
                    }
                    if (letter[i] == '-')
                    {
                        s.SoundLocation = lngBeep; s.PlaySync();
                        System.Threading.Thread.Sleep(time);
                    }
                    if (letter[i] == '/')
                    {
                        System.Threading.Thread.Sleep(4 * time);
                    }
                }
                System.Threading.Thread.Sleep(3 * time);
                temp.Insert(encrypted.Remove());
            }
            while (!temp.IsEmpty())
            {
                encrypted.Insert(temp.Remove());
            }
            System.Console.WriteLine("------ !Message Successfully Played! ------");
        }
        //public void TestPlay() // for testing purposes only
        //{
        //    SoundPlayer s = new SoundPlayer(shrtBeep);
        //    s.PlaySync(); s.PlaySync(); s.PlaySync(); s.PlaySync(); s.PlaySync(); s.PlaySync();
        //}
    }
}
