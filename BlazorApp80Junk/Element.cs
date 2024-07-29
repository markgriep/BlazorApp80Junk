using System.Text.Json.Serialization;

namespace BlazorApp80Junk
{
    public class Element
    {
        public string? Group { get; set; }
        public int Position { get; set; }
        public string? Name { get; set; }
        public int Number { get; set; }

        [JsonPropertyName("small")]
        public string? Sign { get; set; }
        public double Molar { get; set; }
        public IList<int>? Electrons { get; set; }

        public override string ToString()
        {
            return $"{Sign} - {Name}";
        }

        public static IEnumerable<Element> GetElements()
        {
            return new List<Element>
            {
                new Element
                {
                    Group = "Noble Gases",
                    Position = 1,
                    Name = "Helium",
                    Number = 2,
                    Sign = "He",
                    Molar = 4.0026,
                    Electrons = new List<int> { 2 }
                },
                new Element
                {
                    Group = "Alkali Metals",
                    Position = 2,
                    Name = "Lithium",
                    Number = 3,
                    Sign = "Li",
                    Molar = 6.94,
                    Electrons = new List<int> { 2, 1 }
                },
                new Element
                {
                    Group = "Alkaline Earth Metals",
                    Position = 3,
                    Name = "Beryllium",
                    Number = 4,
                    Sign = "Be",
                    Molar = 9.0122,
                    Electrons = new List<int> { 2, 2 }
                },
                new Element
                {
                    Group = "Noble Gases",
                    Position = 4,
                    Name = "Neon",
                    Number = 10,
                    Sign = "Ne",
                    Molar = 20.1797,
                    Electrons = new List<int> { 2, 8 }
                },
                new Element
                {
                    Group = "Alkali Metals",
                    Position = 5,
                    Name = "Sodium",
                    Number = 11,
                    Sign = "Na",
                    Molar = 22.9897,
                    Electrons = new List<int> { 2, 8, 1 }
                },
                new Element
                {
                    Group = "Alkaline Earth Metals",
                    Position = 6,
                    Name = "Magnesium",
                    Number = 12,
                    Sign = "Mg",
                    Molar = 24.305,
                    Electrons = new List<int> { 2, 8, 2 }
                },
                new Element
                {
                    Group = "Noble Gases",
                    Position = 7,
                    Name = "Argon",
                    Number = 18,
                    Sign = "Ar",
                    Molar = 39.948,
                    Electrons = new List<int> { 2, 8, 8 }
                },
                new Element
                {
                    Group = "Alkali Metals",
                    Position = 8,
                    Name = "Potassium",
                    Number = 19,
                    Sign = "K",
                    Molar = 39.0983,
                    Electrons = new List<int> { 2, 8, 8, 1 }
                },
                new Element
                {
                    Group = "Alkaline Earth Metals",
                    Position = 9,
                    Name = "Calcium",
                    Number = 20,
                    Sign = "Ca",
                    Molar = 40.078,
                    Electrons = new List<int> { 2, 8, 8, 2 }
                },
                new Element
                {
                    Group = "Transition Metals",
                    Position = 10,
                    Name = "Scandium",
                    Number = 21,
                    Sign = "Sc",
                    Molar = 44.9559,
                    Electrons = new List<int> { 2, 8, 9, 2 }
                }
            };
        }
    }




}
