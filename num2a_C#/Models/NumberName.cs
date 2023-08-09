namespace num2a_C_.Models
{
    public class NumberName
    {
        public bool HasOneName { get; set; }
        public int Place { get; set; }
        public string MaleName { get; set; }
        public string FemaleName { get; set; }
        public string CombinedMaleName { get; set; }
        public string CombinedFemaleName { get; set; }
        public string AddedMaleName { get; set; }
        public string AddedFemaleName { get; set; }

        public NumberName(bool hasOneName, int place, string maleName)
        {
            HasOneName = hasOneName;
            Place = place;
            MaleName = maleName;
        }

        public NumberName(bool hasOneName, int place, string maleName, string femaleName, string combinedMaleName, string combinedFemaleName) : this(hasOneName, place, maleName)
        {
            FemaleName = femaleName;
            CombinedMaleName = combinedMaleName;
            CombinedFemaleName = combinedFemaleName;
        }

        public NumberName(bool hasOneName, int place, string maleName, string femaleName, string combinedMaleName, string combinedFemaleName, string addedMaleName, string addedFemaleName) : this(hasOneName, place, maleName, femaleName, combinedMaleName, combinedFemaleName)
        {
            AddedMaleName = addedMaleName;
            AddedFemaleName = addedFemaleName;
        }

        public NumberName(bool hasOneName, int place, string maleName, string femaleName) : this(hasOneName, place, maleName)
        {
            FemaleName = femaleName;
        }
    }
}
