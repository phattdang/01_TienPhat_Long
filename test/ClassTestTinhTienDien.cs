using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _01_TienPhat_Long;

[TestClass]
public class ClassTestTinhTienDien
{
    private static IWebDriver? driver;
    private static MethodLibrary.MethodLibrary methodLibrary;

    [ClassInitialize]
    public static void Setup(TestContext context)
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("file:///D:/IUH/NAM4/KI1/KTPM/baitaplon/01_TienPhat_Long/view/test.html");
        methodLibrary = new MethodLibrary.MethodLibrary();
        Thread.Sleep(3000);
    }

    [TestMethod]
    public void TinhTienDien()
    {
        TestCase01();
        TestCase02();
    }

    private void TestCase01()
    {
        int chiSoCu = 1;
        int chiSoMoi = 31;
        double expectedResult = 48972.00000000001;

        driver.FindElement(By.Id("chiSoCu")).Clear();
        driver.FindElement(By.Id("chiSoCu")).SendKeys(chiSoCu.ToString());
        driver.FindElement(By.Id("chiSoMoi")).Clear();
        driver.FindElement(By.Id("chiSoMoi")).SendKeys(chiSoMoi.ToString());

        driver.FindElement(By.Id("submitButton")).Click();
        Thread.Sleep(1000);

        double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);
        driver.FindElement(By.Id("result")).Clear();
        driver.FindElement(By.Id("result")).SendKeys(actualResult.ToString());
        Assert.AreEqual(expectedResult, actualResult);

        Thread.Sleep(3000);
    }

    private void TestCase02()
    {
        int chiSoCu = 1;
        int chiSoMoi = 81;
        double expectedResult = 132209;

        driver.FindElement(By.Id("chiSoCu")).Clear();
        driver.FindElement(By.Id("chiSoCu")).SendKeys(chiSoCu.ToString());
        driver.FindElement(By.Id("chiSoMoi")).Clear();
        driver.FindElement(By.Id("chiSoMoi")).SendKeys(chiSoMoi.ToString());

        driver.FindElement(By.Id("submitButton")).Click();
        Thread.Sleep(1000);

        double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);
        driver.FindElement(By.Id("result")).Clear();
        driver.FindElement(By.Id("result")).SendKeys(actualResult.ToString());
        Assert.AreEqual(expectedResult, actualResult);

        Thread.Sleep(3000);
    }


    [ClassCleanup]
    public static void TearDown()
    {
        driver?.Quit();
    }
}
