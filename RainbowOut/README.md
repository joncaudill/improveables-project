# Rainbow Console App

A simple C# console application that displays text in rainbow colors.

## Features

- **Rainbow Text Output**: Display any text with colorful rainbow effects
- **Cross-Platform**: Runs on Windows, macOS, and Linux

## Prerequisites

Before running this project, ensure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- A terminal/command prompt that supports console colors

## Getting Started

### Working Locally

If you're working with this project locally, navigate to the project directory:

```bash
cd temp-cli-net
```

### Build the Project

To build the entire solution:

```bash
dotnet build
```

Or to build just the console app:

```bash
cd RainbowOut
dotnet build
```

### Run the Application

To run the application:

```bash
cd RainbowOut
dotnet run
```
With no parameters passed it will use the default text "Hello World!"

With additional parameters passed, it will use the first parameter.
If the text to be printed consists of multiple words or contains line or parameter terminators, it needs to be passed inside quotation marks.

Example (single word):
```bash
dotnet run Hello!
```

Example (multi-word):
```bash
dotnet run "Hello and welcome to the world of rainbows!"
```


## Project Structure

```
temp-cli-net/
├── temp-cli-net.sln          # Solution file
├── RainbowOut/
│   ├── RainbowOut.csproj   # Project file
│   ├── Program.cs            # Main application code
└── README.md                 # This file
```


