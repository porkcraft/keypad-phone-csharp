class OldPhoneKeypad {
    public static string OldPhonePad(string input) {

        string theOutput = "";
        char lastPressed = '\0';
        int pressCount = 0;

        // Mapping of the keypad
        Dictionary<char, string> keypad = new Dictionary<char, string>() {
            { '1', "!@&()?"},
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
        // Loop over each character in the input
        foreach (char c in input) {
            // Handle the Send button
            if (c == '#') {
                if (lastPressed != '\0') {
                    theOutput += getChar(keypad, lastPressed, pressCount);
                }
                break;
            }
            // If the character is a number between 2 & 9
            else if (keypad.ContainsKey(c)) {
                if (lastPressed == c)
                {
                    pressCount++;
                }
                else {
                    if (lastPressed != '\0') {
                        theOutput += getChar(keypad, lastPressed, pressCount);
                    }
                    lastPressed = c;
                    pressCount = 1;
                }
            }
            // Handle the pause between letters
            else if (c == ' ') {
                if (lastPressed != '\0') {
                    theOutput += getChar(keypad, lastPressed, pressCount);
                    lastPressed = '\0';
                    pressCount = 0;
                }
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
    // Get characters from keypad (refactored)
    private static string getChar(Dictionary<char, string> keypad, char lastPressed, int pressCount) {
        string index = keypad[lastPressed];
        return index[(pressCount - 1) % index.Length].ToString();
    }
    // Testing of the examples
    static void Main(string[] args) {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));

        Console.WriteLine(OldPhonePad("44666902777330999666881*111111#")); // Space & Special Characters
        // More tests can be placed from here.
    }
}
