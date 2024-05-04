using System.Text.RegularExpressions;
using W4G.Extensions.documents;

namespace W4G.Extensions.Test.documents;

[TestClass]
public class CnpjTest
{
    [TestMethod]
    public void CnpjFormat()
    {
        Assert.AreEqual("89.539.598/0001-03", "89539598000103".CnpjFormat());
        Assert.ThrowsException<ArgumentException>(() => "89539598000104".CnpjFormat());
    }

    [TestMethod]
    public void CnpjIsValid()
    {
        Assert.AreEqual(true, "89.539.598/0001-03".CnpjIsValid());
        Assert.AreEqual(true, "89539598000103".CnpjIsValid());
        Assert.AreEqual(false, "89539598000104".CnpjIsValid());
        Assert.AreEqual(false, "999999999999".CnpjIsValid());
        Assert.AreEqual(false, "89539598000103A".CnpjIsValid());
    }

    [TestMethod]
    public void CnpjCorrect()
    {
        Assert.AreEqual("89539598000103", "89539598000103".CnpjCorrect());
        Assert.AreEqual("89539598000103", "89.539.598/0001-03".CnpjCorrect());
        Assert.AreEqual("89539598000103", "89539598000104".CnpjCorrect());
        Assert.AreEqual("89539598000103", "89539598000103A".CnpjCorrect());
    }
}