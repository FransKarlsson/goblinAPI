namespace goblinAPI.models
{
    public class Goblin
    {
        public int id { get; set; } = 0;
        public string Name { get; set; } = "Gurbgla";
        public int Wealth { get; set; } = 0;
        public GoblinJob Job { get; set; } = GoblinJob.Beggar;   
    }
}