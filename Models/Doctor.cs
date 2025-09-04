namespace Hospital_Management_System.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } 
        public string? Bio { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
