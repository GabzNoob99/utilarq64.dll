# utilarq64

![.NET](https://img.shields.io/badge/.NET-6.0+-blue)
![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![License](https://img.shields.io/badge/License-MIT-green)

A lightweight .NET utility library for file management, ZIP compression, process execution, and common system operations.

## ✨ Features

- 📁 File and directory management
- 🗜️ ZIP compression and extraction
- 🚀 Open files, folders, and URLs
- ⚙️ Process execution utilities
- 🖥️ Windows-focused helper functions

---
## 📚 API Reference

### 📁 Arq

File management utilities.

| Method | Description |
|----------|-------------|
| `Arq.Exist(path)` | Checks whether a file exists. |
| `Arq.read(path)` | Reads the contents of a file. |
| `Arq.write(path, content)` | Writes content to a file. |
| `Arq.remove(path)` | Deletes a file. |
| `Arq.Copy(source, destination)` | Copies a file. |
| `Arq.Move(source, destination)` | Moves a file. |

Example:

```csharp
if (Arq.Exist("test.txt"))
{
    string text = Arq.read("test.txt");
}

Arq.write("test.txt", "Hello World");
Arq.Copy("test.txt", "backup.txt");
Arq.Move("backup.txt", "folder\\backup.txt");
Arq.remove("test.txt");
```
## 🗜️ Zip

ZIP compression and extraction utilities.

| Method | Description |
|----------|-------------|
| `Zip.Zip(folder, zipFile)` | Compresses a folder into a ZIP archive. |
| `Zip.Extract(zipFile, destination)` | Extracts a ZIP archive. |

Example:

```csharp
Zip.Zip("Project", "Project.zip");
Zip.Extract("Project.zip", "Output");
```

---

## 📊 Show

Directory information utilities.

| Method | Description |
|----------|-------------|
| `Show.FileCount(path)` | Returns the number of files in a directory. |
| `Show.Size(path)` | Returns the total size of a directory. |

Example:

```csharp
Console.WriteLine($"Files: {Show.FileCount("C:\\")}");
Console.WriteLine($"Size: {Show.Size("C:\\")}");
```

---

## 🚀 Open

Open files, folders, applications, and URLs.

| Method | Description |
|----------|-------------|
| `Open.Open(fileOrProgram)` | Opens a file or executable. |
| `Open.Openl(folder)` | Opens a folder in File Explorer. |
| `Open.OpenURL(url)` | Opens a URL in the default browser. |

Example:

```csharp
Open.Open("notepad.exe");
Open.Openl("C:\\");
Open.OpenURL("https://google.com");
```
---
## 🚀 Getting Started

### 1. Add the Library

Add `UtilArq64.dll` to your project references.

### 2. Import the Namespace

```csharp
// C#
using UtilsArq64;
```

### 3. Start Using the Library

```csharp
// C#
using UtilsArq64;

class Program
{
    static void Main()
    {
        Arq.write("example.txt", "Hello World");
    }
}
```

---

## 🌐 Multi-Language Support

UtilArq64 is built on the .NET platform and can be used from multiple programming languages, including:

- C#
- VB.NET
- F#
- PowerShell
- Python (via Python.NET)

---

## Using with Python

Python support is provided through **Python.NET** (`pythonnet`), which allows Python applications to load and interact with .NET assemblies.

Install Python.NET:

```bash
pip install pythonnet
```

Example:

```python
from clr import AddReference

AddReference("UtilArq64")

from UtilsArq64 import Arq

Arq.Create("example.txt")
```

> Note: Python.NET must be installed and a compatible .NET runtime must be available on your system.

---

## Notes

- UtilArq64 is designed primarily for Windows environments.
- Some features may depend on Windows-specific APIs.
- Python support requires Python.NET (`pythonnet`).
- Ensure that `UtilArq64.dll` is accessible by your application at runtime.

---

## About the Project

UtilArq64 was created to provide a simple and lightweight collection of utilities for file management, ZIP operations, process execution, and other common tasks in .NET applications.

The goal of this project is to offer a straightforward API that helps developers build applications faster while keeping their code clean, maintainable, and easy to understand.

## ⭐ Support the Project

If UtilArq64 helped you, please consider giving this repository a star.

Every contribution, bug report, feature request, or pull request helps make the project better for everyone.

Thank you for your support and happy coding! 🚀

— Gabriel Huber Scarpin