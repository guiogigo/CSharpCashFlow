using CashFlow.Domain.Security.Cryptography;
using Moq;

namespace CommonTestUtilities.Cryptography;
public class PasswordEncripterBuilder
{
    public static IPasswordEncripter Build()
    {
        var mock = new Mock<IPasswordEncripter>();
        mock.Setup(passwordEncripter => passwordEncripter.Encrypt(It.IsAny<string>())).Returns("!asd2d3asf1$@sdf");

        return mock.Object;
    }
}
