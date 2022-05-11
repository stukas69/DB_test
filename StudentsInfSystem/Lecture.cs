namespace StudentsInfSystem
{
    internal class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Departament> Departaments { get; set; } = new List<Departament>();


    }
}
