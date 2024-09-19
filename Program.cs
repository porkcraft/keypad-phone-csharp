class OldPhoneKeypad {
    public static string OldPhonePad(string input) {

        string theOutput = "";
        char lastPressed = '\0';
        int count = 0;

        Dictionary<char, string> keypad = new Dictionary<char, string>() {
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " "}
        };

        foreach (char c in input) {

            if (keypad.ContainsKey(c)) {
                if (lastPressed == c)
                {
                    count++;
                }
                else {
                    if (lastPressed != '\0') {
                        string index = keypad[lastPressed];
                        theOutput += index[(count - 1) % index.Length];
                    }
                    lastPressed = c;
                    count = 1;
                }
            }
            else if (c == ' ') {
                if (lastPressed != '\0') {
                    string index = keypad[lastPressed];
                    theOutput += index[(count - 1) % index.Length];
                    lastPressed = '\0';
                    count = 0;
                }
            }
            else if (c == '#') {
                if (lastPressed != '\0') {
                    string index = keypad[lastPressed];
                    theOutput += index[(count - 1) % index.Length];
                }
                break;
            }
            else if (c == '*') {
                if (theOutput.Length > 0) {
                    theOutput = theOutput.Substring(0, theOutput.Length);
                }
                lastPressed = '\0';
                count = 0;
            }
        }
        return theOutput;
    }

    static void Main(string[] args) {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        Console.WriteLine(OldPhonePad("77702#"));
    }
}
