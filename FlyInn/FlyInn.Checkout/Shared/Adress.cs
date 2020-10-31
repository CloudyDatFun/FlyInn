namespace FlyInn.Checkout.Shared
{
    public class Address
    {
        public int PostCode { get; set; }

        public string City { get; set; }

        public string StreetName { get; set; }

        public int Number { get; set; }

        public string NumberAddOn { get; set; }

        public string Name { get; set; }

        public Address(int postCode, string city, string streetName, int number, string name)
        {
            this.PostCode = postCode;
            this.City = city;
            this.StreetName = streetName;
            this.Number = number;
            this.Name = name;
        }

        public Address(int postCode, string city, string streetName, string numberAddOn, int number, string name)
        {
            this.PostCode = postCode;
            this.City = city;
            this.StreetName = streetName;
            this.NumberAddOn = numberAddOn;
            this.Number = number;
            this.Name = name;
        }
    }
}