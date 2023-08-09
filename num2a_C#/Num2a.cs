using num2a_C_.constants;
using num2a_C_.Models;
using System;
using System.IO;
using System.Text;

namespace num2a_C_
{
    public class Num2a : INum2a
    {
        public string GetNumberName(NumberName np, bool itemGender, bool isCombined, bool isAdded)
        {
            if (np is null)
                return null;
            if (np.HasOneName)
                return np.MaleName;
            if (isCombined)
                return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? np.CombinedMaleName : np.CombinedFemaleName;
            if (isAdded)
                return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? np.AddedMaleName : np.AddedFemaleName;
            return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? np.MaleName : np.FemaleName;

        }

        public string CorrectTwoName(int power)
        {
            List<NumberName> twoNamesCorrection = new List<NumberName> {
                new NumberName(true,3,"مئتا"),
                new NumberName(true, 4, "ألفا"), 
                new NumberName(true, 7, "مليونا"),
                new NumberName(true, 10, "مليارا"),
                new NumberName(true, 13, "تريليونا"), 
                new NumberName(true, 16, "كوادريليونا")
            };

            int idx = 0;
            for (idx = 0; idx < CONST_NUMBERS.MAX_TWO_CORRECTION_ARRAY; idx++)
            {
                if (twoNamesCorrection[idx].Place == power)
                {
                    return twoNamesCorrection[idx].MaleName;
                }
            }

            return null;
        }

        public List<NumberName> GetDigitArray(int digit)
        {
            if (digit == 1)
                return CONST_NUMBER_NAMES.ONE_NAMES;
            if (digit == 2)
                return CONST_NUMBER_NAMES.TWO_NAMES;
            if (digit == 3)
                return CONST_NUMBER_NAMES.THREE_NAMES;
            if (digit == 4)
                return CONST_NUMBER_NAMES.FOUR_NAMES;
            if (digit == 5)
                return CONST_NUMBER_NAMES.FIVE_NAMES;
            if (digit == 6)
                return CONST_NUMBER_NAMES.SIX_NAMES;
            if (digit == 7)
                return CONST_NUMBER_NAMES.SEVEN_NAMES;
            if (digit == 8)
                return CONST_NUMBER_NAMES.EIGHT_NAMES;
            if (digit == 9)
                return CONST_NUMBER_NAMES.NINE_NAMES;
            return null;
        }

        public string AddDigitTanween(string text)
        {
            if (!string.IsNullOrEmpty(text))
                return text;
            StringBuilder builder = new StringBuilder(text);
            builder.Append(CONST_NUMBERS.STR_TANWEEN_NASEB);

            return builder.ToString();
        }
        public string GetDigitString(int digit, char masterDigit, int power, bool isCombined, bool isMaster, bool isFinal, bool useThirdIdx, bool isDigitsToRight, string itemName, string dualItemname, string pluralItemName, bool itemGender)
        {
            List<NumberName> numberNames;
            string numberNameString;
            StringBuilder finalStringBuilder = new StringBuilder();
            int length = 0;



            numberNames = GetDigitArray(digit);

            if ((power > (CONST_NUMBERS.MAX_DIG_ARRAY_SIZE - 1)) || power < 0)
                return null;
            if (numberNames is null)
                return null;
            if (!isCombined)
            {
                if (isFinal)
                {
                    numberNameString = GetNumberName(numberNames[power], itemGender, isMaster, isCombined);
                    switch (digit)
                    {
                        case 1:
                            finalStringBuilder.Append(itemName);
                            finalStringBuilder.Append(CONST_NUMBERS.STR_SPACE);
                            finalStringBuilder.Append(numberNames);

                            return finalStringBuilder.ToString();
                        case 2:

                            finalStringBuilder.Append(dualItemname);
                            finalStringBuilder.Append(CONST_NUMBERS.STR_SPACE);
                            finalStringBuilder.Append(numberNames);

                            return finalStringBuilder.ToString();
                        default:
                            finalStringBuilder.Append(numberNames);
                            finalStringBuilder.Append(CONST_NUMBERS.STR_SPACE);
                            finalStringBuilder.Append(pluralItemName);

                            return finalStringBuilder.ToString();
                    }

                }
                else
                {
                    if (useThirdIdx)
                        return GetNumberName(numberNames[2], itemGender, isMaster, isCombined);
                    else
                    {

                        if (digit == 2 && power > 0 && (power == 2 || power % 3 == 0) && !isDigitsToRight)
                            return CorrectTwoName(power + 1);
                        else
                            return GetNumberName(numberNames[power], itemGender, isMaster, isCombined);
                    }
                }
            }
            else
            {
                if (masterDigit == '\0')
                    return null;

                switch (digit)
                {
                    case 1:
                        if (masterDigit == '1')
                            return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? "أحد" : "إحدى";
                        else
                            return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? "واحد" : "إحدى";
                    case 2:
                        if (masterDigit == '1')
                            return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? "اثنا" : "اثنتا";
                        else
                            return (itemGender == CONST_ITEM_GENDER.IG_MALE) ? "اثنان" : "اثنتان";
                    default:
                        return GetNumberName(numberNames[0], itemGender, isMaster, isCombined));
                }
            }

        }
        public bool hasDigitToRight(string numbers, int idx)
        {
            if (idx <= numbers.Length - 1 && idx > 0)
            {
                for (int i = idx; i > 0;i--)
                {
                    if (numbers[i] != '0')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public double GetFractionalPart(double num, int decimalPlace, int leadingZeros)
        {
            
        }



        public string ProcessNumW(double num, string itemName, string itemNameTanween, string dualItemName, string pluralItemName, bool itemGender, bool isFractionalOnly)
        {
            throw new NotImplementedException();
        }
    }
}