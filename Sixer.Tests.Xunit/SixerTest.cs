using Xunit;

public class SixerTest
{
    [Fact]
    public void ComputeSix_ShouldReturn_6() => Assert.Equal(6, Sixer.ComputeSix());
}
