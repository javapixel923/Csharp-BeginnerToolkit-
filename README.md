BeginnerToolkit

A simple C# console toolkit for beginners to practice core programming concepts.  
Built with C# and .NET’s safety and productivity guarantees.

---

  Features
- Calculate averages of integer arrays
- Reverse strings
- Square numbers
- Check if a number is even
- Simple console output for quick feedback
- Multiple run modes (Demo, Test, Production) via launch profiles

---

  Requirements
Operating System: Windows, macOS, Linux, or Android (via Termux/Acode)  
Minimum RAM: 2 GB  

         REQUIRED TOOLS 
   - .NET SDK (6.0 LTS or 8.0)  
   - Code editor (VS Code, Rider, or Acode for Android)  
   - Git (optional, for version control) 

        DEPENDENCIES 
   - xUnit (for testing)  
   - Microsoft.NET.Test.Sdk  

- .NET SDK (6.0 LTS or 8.0 recommended)  
- Editor: Acode (Android), VS Code, or Rider  
  

Check your installed version:
`bash
dotnet --version
`

---

  Setup Instructions

Clone this repository:
`bash
git clone https://github.com/Nikita-ai-tech/Csharp-BeginnerToolkit-.git
cd Csharp-BeginnerToolkit-
`

Build and run the app:
`bash
dotnet build Csharp-BeginnerToolkit.csproj
dotnet run --project Csharp-BeginnerToolkit.csproj --launch-profile BeginnerToolkit-Demo
`

---

  Run Modes (Launch Profiles)

The toolkit supports multiple modes via launchSettings.json:

`bash

Demo mode (sample outputs)
dotnet run --project Csharp-BeginnerToolkit.csproj --launch-profile BeginnerToolkit-Demo

Test mode (runs ToolkitTests)
dotnet run --project Csharp-BeginnerToolkit.csproj --launch-profile BeginnerToolkit-Test

Production mode (placeholder for real logic)
dotnet run --project Csharp-BeginnerToolkit.csproj --launch-profile BeginnerToolkit-Production
`

---

   Curriculum Links
- Microsoft Learn: C# Fundamentals
- FreeCodeCamp C# Basics
- Dotnet CLI Documentation

---

  Examples of Toolkit Usage

Average Calculation
`csharp
int[] numbers = { 5, 10, 15 };
double avg = Toolkit.CalculateAverage(numbers);
Console.WriteLine($"Average of [5,10,15] = {avg}");
`
Output:
`
Average of [5,10,15] = 10
`

Reverse String
`csharp
string reversed = Toolkit.ReverseString("hello");
Console.WriteLine($"Reversed 'hello' = {reversed}");
`
Output:
`
Reversed 'hello' = olleh
`

Square Number
`csharp
Console.WriteLine($"Square of 7 = {Toolkit.SquareNumber(7)}");
`
Output:
`
Square of 7 = 49
`

Check Even Number
`csharp
Console.WriteLine($"Is 10 even? {Toolkit.IsEven(10)}");
Console.WriteLine($"Is 11 even? {Toolkit.IsEven(11)}");
`
Output:
`
Is 10 even? True
Is 11 even? False
`

---

🛠 Toolkit Function Examples

`markdown
| Function         | Example Input | Example Code                                    | Expected Output |
|------------------|---------------|-------------------------------------------------|-----------------|
| CalculateAverage | { 5, 10, 15 } | Toolkit.CalculateAverage(new int[]{5,10,15})    | 10              |
| ReverseString    | "hello"       | Toolkit.ReverseString("hello")                  | olleh           |
| SquareNumber     | 7             | Toolkit.SquareNumber(7)                         | 49              |
| IsEven           | 10            | Toolkit.IsEven(10)                              | True            |
| IsEven           | 11            | Toolkit.IsEven(11)                              | False           |
`

---

  Launch Profile Outputs

`markdown
| Mode        | Command                                                                 | Expected Console Output                                                                 |
|-------------|-------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|
| Demo        | dotnet run --launch-profile BeginnerToolkit-Demo                        | Welcome to the Beginner’s C# Toolkit!<br>[Demo] Average of [5,10,15] = 10<br>[Demo] Reversed 'hello' = olleh |
| Test        | dotnet run --launch-profile BeginnerToolkit-Test                        | Welcome to the Beginner’s C# Toolkit!<br>Running Toolkit Tests...<br>Average of [2,4,6] = 4<br>Reverse of 'world' = dlrow<br>Square of 7 = 49<br>Is 10 even? True<br>Is 11 even? False |
| Production  | dotnet run --launch-profile BeginnerToolkit-Production                  | Welcome to the Beginner’s C# Toolkit!<br>[Production] Toolkit is running in production mode. |
`

---

  Common Issues & Fixes

`markdown
| Issue                          | Cause                                               | Fix                                                        |
|--------------------------------|-----------------------------------------------------|-------------------------------------------------------------|
| Toolkit not found              | Missing using BeginnerToolkit; or wrong namespace | Ensure namespace matches across files                      |
| Unhandled exception            | Empty array passed to CalculateAverage            | Add check: return 0 if array length = 0                    |
| Upload error on GitHub mobile  | File already exists (README.md)                     | Use Edit file instead of Create new file            |
| “Something went wrong” upload  | Unsupported file type or network glitch             | Use Create new file and paste code manually             |
| dotnet: command not found    | .NET SDK not installed                              | Use dotnetfiddle.net for testing |
`

---

📚 References
- Official .NET Documentation
- C# Programming Guide
- Dotnetfiddle Online Compiler
- Rextester Online Compiler
- Helpful Blog: C# Basics for Beginners

---

  License
This project is licensed under the MIT License — feel free to use, modify, and share.

---

  Author
BeginnerToolkit created by Nikita, as part of her journey in building practical, educational C# projects for youth and community empowerment.
