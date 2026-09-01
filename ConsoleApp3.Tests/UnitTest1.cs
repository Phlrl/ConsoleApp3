namespace ConsoleApp3.Tests;

public class ProgramTests
{
    // Test for single function
    [Fact]
    public void DisplayMaxTriesWarning_WritesExpectedText()
    {
        var originalOut = Console.Out;

        try
        {
            // Replace Console "Ausgaben" with a StringWriter to capture output
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Call the method to test
            Program.DisplayMaxTriesWarning();

            var expected = """
                +---------------------------+
                |       WARNING             |
                |   MAX. 3 VERSUCHE!        |
                +---------------------------+
                """ + Environment.NewLine;

            // Test if output is as expected
            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
}
