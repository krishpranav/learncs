## File Read:

- read contents in the file:

```csharp
string readText = File.ReadAllText("test.txt");
Console.WriteLine(readText);
```

- final:
```csharp
using System;
using System.IO;

namespace FileRead {
    class Read {
        static void Main(string[] args) {
            string readText = File.ReadAllText("test.txt");
            Console.WriteLine(readText);
        }
    }
}
```