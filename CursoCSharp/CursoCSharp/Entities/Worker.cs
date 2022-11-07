using CursoCSharp.Entities.Enum;

namespace CursoCSharp.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        // agora comeca a composicao de objetos
    }
}
