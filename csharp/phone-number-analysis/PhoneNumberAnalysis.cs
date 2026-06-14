using System.Runtime.CompilerServices;
using System.Windows.Markup;
using Microsoft.VisualBasic;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] number = phoneNumber.Split("-");
        return (
            number[0] == "212",
            number[1] == "555",
            number[2]
        );
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
