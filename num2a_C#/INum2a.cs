using num2a_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2a_C_
{
    public interface INum2a
    {
        string GetNumberName(NumberName np, bool itemGender, bool isCombined, bool isAdded);
        string CorrectTwoName(int power);
        List<NumberName> GetDigitArray(int digit);
        string AddDigitTanween(string pString);
        string GetDigitString(int digit, char masterDigit, int power, bool isCombined, bool isMaster, bool isFinal, bool useThirdIdx, bool isDigitsToRight, string itemName, string dualItemname, string pluralItemName, bool itemGender);
        bool HasDigitToRight(string numbers,int idx);
        double GetFractionalPart(double num);
        string ProcessNumW(double num, string itemName, string itemNameTanween, string dualItemName, string pluralItemName, bool itemGender, bool isFractionalOnly);
    }
}
