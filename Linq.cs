using Dumpify;

public class Linq{

    public void LearnLinq(){
        // LINQ - Language integrated Query
        // Feature in c# that provides a consistent, readable way to query and manipulate data 
        // from different data source, such as collections , DB and XML, etc.


        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        numbers .Dump();

        // Query syntax - similar to SQL
        var numbersEQ = from num in numbers
                        where num%2 == 0 //even
                        select num;
        numbersEQ.Dump();

        // Method syntax
        var numbersEM = numbers.Where(num => num%2 ==0);


        // Common LINQ methods
        // Select
        numbers.Select(n => n*2).Dump();
        // Where
        numbers.Where(n => n>4).Dump();
        // Order by
        numbers.OrderByDescending(n => n).Dump();
        // GroupBy
        numbers.GroupBy(n=>n%2 ==0 ? "Even" :"odd").Dump();

    }
}

