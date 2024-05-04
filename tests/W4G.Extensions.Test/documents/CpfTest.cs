using System.Text.RegularExpressions;
using W4G.Extensions.documents;

namespace W4G.Extensions.Test.documents;

[TestClass]
public class CpfTest
{
    [TestMethod]
    public void CpfFormat()
    {
        Assert.AreEqual("704.676.250-34", "70467625034".CpfFormat());
        Assert.ThrowsException<ArgumentException>(() => "70467625035".CpfFormat());
    }

    [TestMethod]
    public void CpfIsValid()
    {
        Assert.AreEqual(true, "704.676.250-34".CpfIsValid());
        Assert.AreEqual(true, "70467625034".CpfIsValid());
        Assert.AreEqual(false, "70467625035".CpfIsValid());
        Assert.AreEqual(false, "999999999999".CpfIsValid());
        Assert.AreEqual(false, "70467625034A".CpfIsValid());
    }

    [TestMethod]
    public void CpfCorrect()
    {
        Assert.AreEqual("70467625034", "70467625034".CpfCorrect());
        Assert.AreEqual("70467625034", "704.676.250-34".CpfCorrect());
        Assert.AreEqual("70467625034", "70467625035".CpfCorrect());
        Assert.AreEqual("70467625034", "70467625034A".CpfCorrect());
    }
}