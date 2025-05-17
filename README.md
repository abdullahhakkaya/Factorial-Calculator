
# Factorial Calculator (Console App)

## Introduction

This is a simple C# console application that calculates the factorial of a positive number entered by the user. It demonstrates basic control structures, input/output handling, and looping in C#.

---

## Installation

1. Clone or download this repository to your local machine.
2. Open the project folder in your preferred C# IDE (e.g., Visual Studio or Visual Studio Code).
3. Build the project using the IDE or with the `dotnet` CLI:

   ```bash
   dotnet build
   ```

## Usage

Run the application from your terminal or IDE. It will prompt you to enter a positive number and then output the factorial of that number.

### Running via CLI:

```bash
dotnet run
```

### Example Output:

```
Please enter a positive number to calculate its factorial : 5
Calculation result : 120
```

## Features

* Accepts positive integer input from the user.
* Calculates factorial using a simple `for` loop.
* Handles invalid input (e.g., non-positive numbers).

## Dependencies

* .NET SDK (version compatible with your development environment)

## Examples

| Input | Output        |
| ----- | ------------- |
| 0     | Invalid input |
| 3     | 6             |
| 5     | 120           |

## Troubleshooting

* **Issue:** Program crashes with format exceptions.

  * **Solution:** Ensure the input is a valid positive integer.
* **Issue:** Console window closes immediately after execution.

  * **Solution:** Make sure `Console.ReadLine()` is at the end of `Main()` to keep the console window open.


