using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Part17_ADOdotNET.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{

    [TestMethod]
    public void TestDbConnection()
    {
        Program.TestDbConnection();
    }
}