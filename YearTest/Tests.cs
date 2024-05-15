using System;
using NUnit.Framework;


namespace YearTest
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(DateTime.Now.Year, Current.Current.GetYear());
      Assert.AreEqual(DateTime.Now.Year, TuCurrent.Current.GetYear());

    }
  }
}