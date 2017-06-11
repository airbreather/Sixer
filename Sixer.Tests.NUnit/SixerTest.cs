using NUnit.Framework;

[TestFixture]
public class SixerTest
{
    [Test]
    public void ComputeSix_ShouldReturn_6() => Assert.AreEqual(6, Sixer.ComputeSix());
}
