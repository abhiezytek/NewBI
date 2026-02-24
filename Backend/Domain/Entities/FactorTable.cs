namespace Backend.Domain.Entities
{
    public class FactorTable
    {
        public int Id { get; set; }
        public string FactorName { get; set; }
        public decimal FactorValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public FactorTable() {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}