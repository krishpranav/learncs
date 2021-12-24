## structure

- using struct you can store various data types

- example:
```csharp
struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};
```

final:
```csharp
using System;

struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class testStructure {
   public static void Main(string[] args) {
      Books Book1;   
      Books Book2;  

      Book1.title = "Some";
      Book1.author = "Some"; 
      Book1.subject = "Some";
      Book1.book_id = 123456;

      Book2.title = "SomeOne";
      Book2.author = "SomeOne";
      Book2.subject =  "SomeOne";
      Book2.book_id = 78901;

      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);       
   }
}
```