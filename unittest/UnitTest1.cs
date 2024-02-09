using Xunit;
public class ControllerTests
{
    private readonly Controller _controller;

    public ControllerTests()
    {
        _controller = new Controller();
    }

    [Theory]
    [InlineData("test", 1, "uftu")]
    [InlineData("hello", 2, "jgnnq")]
    public void Encrypt_ShouldWorkCorrectly(string input, int shift, string expected)
    {
        var result = _controller.Encrypt(input, shift);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("uftu", 1, "test")]
    [InlineData("jgnnq", 2, "hello")]
    public void Decrypt_ShouldWorkCorrectly(string input, int shift, string expected)
    {
        var result = _controller.Decrypt(input, shift);
        Assert.Equal(expected, result);
    }
}