using CaveCat.Interpreter;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        try
        {
            var code = File.ReadAllText(args[0]);
            Console.WriteLine("Read successfully");
            var engine = new Engine();
            engine.Execute(code.ReplaceLineEndings("\n"));
        }
        catch (Exception ex)
        {
        }
    }
}
