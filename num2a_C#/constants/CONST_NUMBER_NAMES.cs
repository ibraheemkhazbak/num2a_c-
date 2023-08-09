using num2a_C_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num2a_C_.constants
{
    public class CONST_NUMBER_NAMES
    {
        public static readonly List<NumberName> ONE_NAMES =
            new List<NumberName>{new NumberName(false, 1, "واحد", "واحدة", null, null, "واحد", "إحدى"), new NumberName(false, 2, "عشرة", "عشر", "عشر", "عشرة"),
            new NumberName(true, 3, "مئة"),new NumberName(true, 4, "ألف"),new NumberName(false, 5, "عشرة ألاف", "عشر آلاف", "عشر ألف", "عشرة ألف"), new NumberName(true, 6, "مئة ألف"),
            new NumberName(true, 7, "مليون"), new NumberName(false, 8, "عشرة ملايين", "عشر ملايين", "عشر مليون", "عشرة مليون"),new NumberName(true, 9, "مئة مليون"), new NumberName(true, 10, "مليار"),
            new NumberName(false, 11, "عشرة مليارات", "عشر مليارات", "عشر مليار", "عشرة مليار"), new NumberName(true, 12, "مئة مليار"),   new NumberName(true, 13, "ترليون"),
            new NumberName(false, 14, "عشرة ترليونات", "عشر ترليونات", "عشر ترليون", "عشرة ترليون"),new NumberName(true, 15, "مئة ترليون"),new NumberName(true, 16, "كوادريليون")};
        
        public static readonly List<NumberName> TWO_NAMES = new List<NumberName>{new NumberName(false, 1, "اثنان", "اثنتان", null, null, "اثنان", "اثنتان"), new NumberName(true, 2, "عشرون"),new NumberName(true, 3, "مئتان"),new NumberName(true, 4, "ألفان"),
            new NumberName(true, 5, "عشرون ألف"), new NumberName(true, 6, "مئتا ألف"),new NumberName(true, 7, "مليونان"),new NumberName(true, 8, "عشرون مليون"),new NumberName(true, 9, "مئتا مليون"), new NumberName(true, 10, "ملياران"),
            new NumberName(true, 11, "عشرون مليار"), new NumberName(true, 12, "مئتا مليار"),    new NumberName(true, 13, "تريليونان"), new NumberName(true, 14, "عشرون تريليون"),new NumberName(true, 15, "مئتا تريليون"),new NumberName(true, 16, "كوادريليونان")};
        public static readonly List<NumberName> THREE_NAMES = new List<NumberName>{new NumberName(false, 1, "ثلاثة", "ثلاث", null, null, "ثلاثة", "ثلاث"), new NumberName(true, 2, "ثلاثون"),new NumberName(true, 3, "ثلاثمئة"),new NumberName(false, 4, "ثلاثة آلاف", "ثلاث آلاف"),
            new NumberName(true, 5, "ثلاثون ألف"), new NumberName(true, 6, "ثلاثمئة ألف"),new NumberName(false, 7, "ثلاثة ملايين", "ثلاث ملايين"),new NumberName(true, 8, "ثلاثون مليون"),new NumberName(true, 9, "ثلاثمئة مليون"), new NumberName(false, 10, "ثلاثة مليارات", "ثلاث مليارات"),
            new NumberName(true, 11, "ثلاثون مليار"), new NumberName(true, 12, "ثلاثمئة مليار"),    new NumberName(false, 13, "ثلاثة تريليونات", "ثلاث تريليونات"), new NumberName(true, 14, "ثلاثون تريليون"),new NumberName(true, 15, "ثلاثمئة تريليون"),new NumberName(false, 16, "ثلاثة كوادريليونات", "ثلاث كوادريليونات")};
        public static readonly List<NumberName> FOUR_NAMES =
                new List<NumberName>{new NumberName(false, 1, "أربعة", "أربع", null, null, "أربعة", "أربع"), new NumberName(true, 2, "أربعون"),new NumberName(true, 3, "أربعمئة"),new NumberName(false, 4, "أربعة آلاف", "أربع آلاف"),
            new NumberName(true, 5, "أربعون ألف"), new NumberName(true, 6, "أربعمئة ألف"),new NumberName(false, 7, "أربعة ملايين", "أربع ملايين"),new NumberName(true, 8, "أربعون مليون"),new NumberName(true, 9, "أربعمئة مليون"), new NumberName(false, 10, "أربعة مليارات", "أربع مليارات"),
            new NumberName(true, 11, "أربعون مليار"), new NumberName(true, 12, "أربعمئة مليار"),    new NumberName(false, 13, "أربعة تريليونات", "أربع تريليونات"), new NumberName(true, 14, "أربعون تريليون"),new NumberName(true, 15, "أربعمئة تريليون"),new NumberName(false, 16, "أربعة كوادريليونات", "أربع كوادريليونات")};
        public static readonly List<NumberName> FIVE_NAMES =
                new List<NumberName>{new NumberName(false, 1, "خمسة", "خمس", null, null, "خمسة", "خمس"), new NumberName(true, 2, "خمسون"),new NumberName(true, 3, "خمسمئة"),new NumberName(false, 4, "خمسة آلاف", "خمس آلاف"),
            new NumberName(true, 5, "خمسون ألف"), new NumberName(true, 6, "خمسمئة ألف"),new NumberName(false, 7, "خمسة ملايين", "خمس ملايين"),new NumberName(true, 8, "خمسون مليون"),new NumberName(true, 9, "خمسمئة مليون"), new NumberName(false, 10, "خمسة مليارات", "خمس مليارات"),
            new NumberName(true, 11, "خمسون مليار"), new NumberName(true, 12, "خمسمئة مليار"),  new NumberName(false, 13, "خمسة تريليونات", "خمس تريليونات"), new NumberName(true, 14, "خمسون تريليون"),new NumberName(true, 15, "خمسمئة تريليون"),new NumberName(false, 16, "خمسة كوادريليونات", "خمس كوادريليونات")};
        public static readonly List<NumberName> SIX_NAMES =
                new List<NumberName>{new NumberName(false, 1, "ستة", "ست", null, null, "ستة", "ست"), new NumberName(true, 2, "ستون"),new NumberName(true, 3, "ستمئة"),new NumberName(false, 4, "ستة آلاف", "ست آلاف"),
            new NumberName(true, 5, "ستون ألف"), new NumberName(true, 6, "ستمئة ألف"),new NumberName(false, 7, "ستة ملايين", "ست ملايين"),new NumberName(true, 8, "ستون مليون"),new NumberName(true, 9, "ستمئة مليون"), new NumberName(false, 10, "ستة مليارات", "ست مليارات"),
            new NumberName(true, 11, "ستون مليار"), new NumberName(true, 12, "ستمئة مليار"),    new NumberName(false, 13, "ستة تريليونات", "ست تريليونات"), new NumberName(true, 14, "ستون تريليون"),new NumberName(true, 15, "ستمئة تريليون"),new NumberName(false, 16, "ستة كوادريليونات", "ست كوادريليونات")};
        public static readonly List<NumberName> SEVEN_NAMES =
                new List<NumberName>{new NumberName(false, 1, "سبعة", "سبع", null, null, "سبعة", "سبع"), new NumberName(true, 2, "سبعون"),new NumberName(true, 3, "سبعمئة"),new NumberName(false, 4, "سبعة آلاف", "سبع آلاف"),
            new NumberName(true, 5, "سبعون ألف"), new NumberName(true, 6, "سبعمئة ألف"),new NumberName(false, 7, "سبعة ملايين", "سبع ملايين"),new NumberName(true, 8, "سبعون مليون"),new NumberName(true, 9, "سبعمئة مليون"), new NumberName(false, 10, "سبعة مليارات", "سبع مليارات"),
            new NumberName(true, 11, "سبعون مليار"), new NumberName(true, 12, "سبعمئة مليار"),  new NumberName(false, 13, "سبعة تريليونات", "سبع تريليونات"), new NumberName(true, 14, "سبعون تريليون"),new NumberName(true, 15, "سبعمئة تريليون"),new NumberName(false, 16, "سبعة كوادريليونات", "سبع كوادريليونات")};
        public static readonly List<NumberName> EIGHT_NAMES =
                new List<NumberName>{new NumberName(false, 1, "ثمانية", "ثمان", null, null, "ثمانية", "ثمان"), new NumberName(true, 2, "ثمانون"),new NumberName(true, 3, "ثمانمئة"),new NumberName(false, 4, "ثمانية آلاف", "ثمان آلاف"),
            new NumberName(true, 5, "ثمانون ألف"), new NumberName(true, 6, "ثمانمئة ألف"),new NumberName(false, 7, "ثمانية ملايين", "ثمان ملايين"),new NumberName(true, 8, "ثمانون مليون"),new NumberName(true, 9, "ثمانمئة مليون"), new NumberName(false, 10, "ثمانية مليارات", "ثمان مليارات"),
            new NumberName(true, 11, "ثمانون مليار"), new NumberName(true, 12, "ثمانمئة مليار"),    new NumberName(false, 13, "ثمانية تريليونات", "ثمان تريليونات"), new NumberName(true, 14, "ثمانون تريليون"),new NumberName(true, 15, "ثمانمئة تريليون"),new NumberName(false, 16, "ثمانية كوادريليونات", "ثمان كوادريليونات")};
        public static readonly List<NumberName> NINE_NAMES =
                new List<NumberName>{new NumberName(false, 1, "تسعة", "تسع", null, null, "تسعة", "تسع"), new NumberName(true, 2, "تسعون"),new NumberName(true, 3, "تسعمئة"),new NumberName(false, 4, "تسعة آلاف", "تسع آلاف"),
            new NumberName(true, 5, "تسعون ألف"), new NumberName(true, 6, "تسعمئة ألف"),new NumberName(false, 7, "تسعة ملايين", "تسع ملايين"),new NumberName(true, 8, "تسعون مليون"),new NumberName(true, 9, "تسعمئة مليون"), new NumberName(false, 10, "تسعة مليارات", "تسع مليارات"),
            new NumberName(true, 11, "تسعون مليار"), new NumberName(true, 12, "تسعمئة مليار"),  new NumberName(false, 13, "تسعة تريليونات", "تسع تريليونات"), new NumberName(true, 14, "تسعون تريليون"),new NumberName(true, 15, "تسعمئة تريليون"),new NumberName(false, 16, "تسعة كوادريليونات", "تسع كوادريليونات")};

    }
}
