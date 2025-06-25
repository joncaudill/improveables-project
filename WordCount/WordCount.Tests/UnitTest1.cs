namespace WordCountApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestWordCountForCorrectAnswer()
    {
        //Arrange
        var currentDirectory = Directory.GetCurrentDirectory();
        var solutionRoot = Directory.GetParent(currentDirectory)?.Parent?.Parent?.Parent?.FullName;
        var filePath = Path.Combine(solutionRoot!, "WordCount.Texts", "poe-fall-of-the-house-of-usher.txt");
        //Act
        var result = Utilities.WordCount(filePath);
        //Assert
        Assert.Equal("# of words: 10141", result);
    }
}
