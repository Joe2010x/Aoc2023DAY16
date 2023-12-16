namespace A23D16;

class Program
{
    static void Main(string[] args)
    {

        var lines = FileReader.ReadFile("test6.txt");
        Console.WriteLine(lines.Count);
        var map = new Map(lines);
        Console.WriteLine("Aoc2023 Day 16 part 1 : "+map.CalculateWithStartingPosition(0,0,1));
        Console.WriteLine("Aoc2023 Day 16 part 2 : "+map.CalculateStartFromAllEdges());
    }
}
