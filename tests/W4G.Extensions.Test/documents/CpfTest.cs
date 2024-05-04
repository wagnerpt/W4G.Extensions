using System.Text.RegularExpressions;
using W4G.Extensions.documents;

namespace W4G.Extensions.Test.documents;

[TestClass]
public class CpfTest
{
    [TestMethod]
    public void CpfFormat()
    {
        Assert.AreEqual("265.308.318-35", "26530831835".CpfFormat());
        Assert.ThrowsException<ArgumentException>(() => "26530831836".CpfFormat());
    }

    [TestMethod]
    public void CpfIsValid()
    {
        Assert.AreEqual(true, "265.308.318-35".CpfIsValid());
        Assert.AreEqual(true, "26530831835".CpfIsValid());
        Assert.AreEqual(false, "26530831836".CpfIsValid());
        Assert.AreEqual(false, "999999999999".CpfIsValid());
        Assert.AreEqual(false, "26530831835A".CpfIsValid());
    }

    [TestMethod]
    public void CpfCorrect()
    {
        Assert.AreEqual("26530831835", "26530831835".CpfCorrect());
        Assert.AreEqual("26530831835", "265.308.318-35".CpfCorrect());
        Assert.AreEqual("26530831835", "26530831836".CpfCorrect());
        Assert.AreEqual("26530831835", "26530831835A".CpfCorrect());
    }
}