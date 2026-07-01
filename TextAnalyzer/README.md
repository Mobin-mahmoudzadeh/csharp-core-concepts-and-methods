# Project 01: Text Analyzer

A C# console application designed to practice fundamental string manipulation techniques and logic in .NET 10.0.

## 💡 Features & Logic
This application takes a string input from the user and performs the following operations:
1. **True Length Calculation:** Counts the characters in the string while intelligently ignoring spaces using `.Replace(" ", "").Length`.
2. **Case Transformation:** Converts the entire text to uppercase (`.ToUpper()`) and lowercase (`.ToLower()`).
3. **Substring Search:** Uses a boolean check via `.Contains("C#")` to determine if a specific keyword exists within the text.

## 🛠️ Concepts Covered
- `Console.ReadLine()` for text inputs.
- String methods: `.Replace()`, `.Length`, `.ToUpper()`, `.ToLower()`, and `.Contains()`.
- Data types: `string` and `bool`.

## 🏃 How to Run
Run the following command inside this project folder:
```bash
dotnet run