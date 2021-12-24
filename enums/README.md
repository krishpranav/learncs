## Enums:

- group of constants is known as enums

## Tutorial:

- enum
```csharp
enum Language {
	Python,
	Rust,
	CSharp
}
```

- final:
```csharp
using System;

namespace EnumsTutorial {
	class Program {
		enum ProgrammingLanguage {
			Python,
			Rust,
			CSharp
		}

		static void Main(string[] args)
		{
			ProgrammingLanguage myLanguage = ProgrammingLanguage.CSharp;
			Console.WriteLine(myLanguage);
		}
	}
}
```