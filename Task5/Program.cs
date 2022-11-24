class Program
{
    static void Main(string[] args)
    {
        TransformToElephant();
        Console.WriteLine("Муха");

        Console.WriteLine("Какой то посторонний код ...");
        Console.ReadKey();
    }

    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        Console.SetOut(new OtherWriter());

        //Второй способоб (необходимо разрешить unsafe в проекте)
        //unsafe
        //{
        //    ReadOnlySpan<char> newWord = "Слон";
        //    fixed (char* ptr = "Муха")
        //    {
        //        newWord.CopyTo(new Span<char>(ptr, 4));
        //    }
        //}
    }

    class OtherWriter : StringWriter
    {
        TextWriter consoleTextWriter = Console.Out;
        public override void WriteLine(string? value) => Console.SetOut(consoleTextWriter);
    }
}