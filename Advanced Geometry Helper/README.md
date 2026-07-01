# Project 02: Advanced Geometry Helper

A C# console application focused on using the built-in `System.Math` class and types to perform geometric calculations on a circle.

## 💡 Features & Logic
The program takes the radius of a circle from the user and performs the following operations:
1. **Circumference:** Calculates the perimeter using the formula $2 \times \pi \times r$ by utilizing the precise `Math.PI` constant.
2. **Area:** Computes the area using $\pi \times r^2$ ($Math.PI \times radius \times radius$).
3. **Square Root:** Finds the square root of the given radius using the `Math.Sqrt()` method.
4. **Power / Cube:** Raises the radius to the power of 3 using `Math.Pow(radius, 3)`.

## 🛠️ Concepts Covered
- Input conversion using `Convert.ToDouble()`.
- Advanced mathematical operations via `Math.PI`, `Math.Sqrt()`, and `Math.Pow()`.
- High-precision formatting using string interpolation with the `:F2` specifier (limiting outputs to two decimal places).

## 🏃 How to Run
Run the following command inside this project folder:
```bash
dotnet run