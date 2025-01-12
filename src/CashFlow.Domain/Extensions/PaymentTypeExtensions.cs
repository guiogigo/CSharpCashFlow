using CashFlow.Domain.Enums.PaymentType;

namespace CashFlow.Domain.Extensions;
public static class PaymentTypeExtensions
{
    public static string PaymentTypeToString(this PaymentType paymentType)
    {
        return paymentType switch
        {
            PaymentType.Cash => ResourcePaymentTypes.CASH,
            PaymentType.CreditCard => ResourcePaymentTypes.CREDIT_CARD,
            PaymentType.DebitCard => ResourcePaymentTypes.DEBIT_CARD,
            PaymentType.EletronicTransfer => ResourcePaymentTypes.ELETRONIC_TRANSFER,
            _ => string.Empty
        };
    }
}
