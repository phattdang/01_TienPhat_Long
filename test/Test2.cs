using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _01_TienPhat_Long;

[TestClass]
public class Test2
{
    private IWebDriver? driver;

    [TestInitialize]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [TestMethod]
    public void TestMethod1()
    {
        try
        {
            // Mở file HTML cục bộ
            driver.Navigate().GoToUrl("file:///D:/IUH/NAM4/KI1/KTPM/baitaplon/01_TienPhat_Long/view/test.html");
            Thread.Sleep(3000); // Chờ 3 giây để quan sát
        }
        catch (WebDriverException ex)
        {
            Assert.Fail($"Test failed due to WebDriver exception: {ex.Message}");
        }
    }

    [TestCleanup]
    public void TearDown()
    {
        if (driver != null)
        {
            try
            {
                driver.Quit(); // Đóng driver một cách an toàn
            }
            catch (Exception)
            {
                // Bỏ qua lỗi nếu driver đã bị đóng
            }
        }
    }
}