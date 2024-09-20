# Old keypad phone simulation in C#
This project simulates typing on an old keypad phone where each number on the keypad represents multiple letters. The input is processed according to how many times a key is pressed to produce the corresponding letter. Additionally, the `*` key functions as a backspace and `#` is used to act as `Ener` key at the end of the input.

## Features
- Simulates pressing buttons on an old phone keypad.
- The `*` key works as a backspace to delete the last character.
- The `#` key ends the put and returns the final result.
- Supports character input like the keypad phone texting where pressing the same key multiple times cycles through the corresponding letter.

## Key Mapping
```
1 -> ! @ & ( ) ?
2 -> A B C
3 -> D E F
4 -> G H I
5 -> J K L
6 -> M N O
7 -> P Q R S
8 -> T U V
9 -> W X Y Z
0 -> Space
* -> Backspace
# -> End of input
```

## How to run
### Prerequisites
Make sure you have .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).

### Steps
1. Clone the repository or copy the code from `Program.cs` into a directory.
2. Open the directory in VS Code.
3. In the terminal, navigate to the directory and create a new console app:
	```powershell
	dotnet new console
	```
4. Replace the content of `Program.cs` with the code from this project.
5. Run the program by executing the following command in the terminal.
	```powershell
	dotnet run
	```

### Example Usage
Here are some example inputs and their expected outputs.

