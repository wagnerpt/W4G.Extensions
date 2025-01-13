using System.Text.RegularExpressions;
using W4G.Extensions.documents;

namespace W4G.Extensions.Test.documents;

[TestClass]
public class CnpjTest
{
    private bool CnpjAlfa = DateTime.Today >= new DateTime(2026, 7, 1);

    [TestMethod]
    public void CnpjFormat()
    {
        Assert.AreEqual("89.539.598/0001-03", "89539598000103".CnpjFormat());
        if (CnpjAlfa)
            Assert.AreEqual("12.ABC.345/01DE–35", "12ABC34501DE35".CnpjFormat());
        Assert.ThrowsException<ArgumentException>(() => "89539598000104".CnpjFormat());
        if (CnpjAlfa)
            Assert.ThrowsException<ArgumentException>(() => "12ABC34501DE36".CnpjFormat());
    }

    [TestMethod]
    public void CnpjIsValid()
    {
        Assert.AreEqual(true, "89.539.598/0001-03".CnpjIsValid());
        Assert.AreEqual(true, "89539598000103".CnpjIsValid());
        Assert.AreEqual(false, "89539598000104".CnpjIsValid());
        Assert.AreEqual(false, "999999999999".CnpjIsValid());
        Assert.AreEqual(false, "89539598000103A".CnpjIsValid());
        if (CnpjAlfa)
            Assert.AreEqual(!CnpjAlfa, "12ABC34501DE35".CnpjIsValid());
        Assert.AreEqual(false, "A2ABC34501DE35".CnpjIsValid());
    }

    [TestMethod]
    public void CnpjCorrect()
    {
        Assert.AreEqual("89539598000103", "89539598000103".CnpjCorrect());
        Assert.AreEqual("89539598000103", "89.539.598/0001-03".CnpjCorrect());
        Assert.AreEqual("89539598000103", "89539598000104".CnpjCorrect());
        if (CnpjAlfa)
            Assert.AreEqual("12ABC34501DE35", "12.ABC.345/01DE–35".CnpjCorrect());
        else
            Assert.AreNotEqual("12ABC34501DE35", "12.ABC.345/01DE–35".CnpjCorrect());
    }
}