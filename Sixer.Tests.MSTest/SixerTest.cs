using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SixerTest
{
    [TestMethod]
    public void ComputeSix_ShouldReturn_6() => Assert.AreEqual(6, Sixer.ComputeSix());
}
