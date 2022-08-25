using System.Collections.Generic;

public class Person {
    
}


public class Program 
{
    
    
    public static void Main() {
        
        var myList = new List<string>{"hi", "hello", "goodbye"};
        
        IEnumerable<string> hello = from word in myList 
                                    where word.Length > 2 
                                    where word[0] == 'g' 
                                    select word;
        
        foreach (string word in hello) {
            Console.WriteLine(word);
        } 
        
        }
}
