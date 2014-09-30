namespace ShiftSchedule.Domain.Entities
{
    public class Team
    {
        //NOC,Support,...

        public Team(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}