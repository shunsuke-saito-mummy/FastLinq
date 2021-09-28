namespace DetailResearchOfLinq.Data
{
    public sealed class Pet
    {
        public string Name;
        
        public Person Owner;

        public override string ToString()
        {
            return $"{Name}(Owner: {Owner.Name})";
        }
    }
}