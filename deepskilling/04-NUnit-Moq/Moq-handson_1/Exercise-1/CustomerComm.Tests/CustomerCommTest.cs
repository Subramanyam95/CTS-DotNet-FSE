using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerCommTests;

[TestFixture]
public class CustomerCommTest
{
    private Mock<IMailSender> mockMail;

    [OneTimeSetUp]
    public void Init()
    {
        mockMail = new Mock<IMailSender>();
    }

    [Test]
    public void TestSendMail()
    {
        mockMail.Setup(x => x.SendMail(It.IsAny<string>(),
                                       It.IsAny<string>()))
                .Returns(true);

        CustomerComm obj = new CustomerComm(mockMail.Object);

        bool result = obj.SendMailToCustomer();

        Assert.That(result, Is.True);
    }
}