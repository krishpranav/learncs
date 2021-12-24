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
			Console.WriteLine("Langauge used to build is: " + myLanguage);
		}
	}
}