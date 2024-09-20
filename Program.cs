class OldPhoneKeypad {
    public static string OldPhonePad(string input) {

        string theOutput = "";
        char lastPressed = '\0';
        int pressCount = 0;

        // Mapping of the keypad
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

        // Loop over each character in the input string
        foreach (char c in input) {

            // If the character is a number between 2 & 9
            if (keypad.ContainsKey(c)) {
                if (lastPressed == c)
                {
                    pressCount++;
                }
                else {
                    if (lastPressed != '\0') {
                        string index = keypad[lastPressed];
                        theOutput += index[(pressCount - 1) % index.Length];
                    }
                    lastPressed = c;
                    pressCount = 1;
                }
            }
            // Handle the pause between letters
            else if (c == ' ') {
                if (lastPressed != '\0') {
                    string index = keypad[lastPressed];
                    theOutput += index[(pressCount - 1) % index.Length];
                    lastPressed = '\0';
                    pressCount = 0;
                }
            }
            // Handle the Send button
            else if (c == '#') {
                if (lastPressed != '\0') {
                    string index = keypad[lastPressed];
                    theOutput += index[(pressCount - 1) % index.Length];
                }
                break;
            }
            // Handle the Backspace button
            else if (c == '*') {
                if (theOutput.Length > 0) {
                    theOutput = theOutput.Remove(theOutput.Length);
                }
                lastPressed = '\0';
                pressCount = 0;
            }
        }
        return theOutput;
    }

    // Testing of the examples
    static void Main(string[] args) {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
    }
}
