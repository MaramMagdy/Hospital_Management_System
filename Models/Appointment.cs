using Hospital_Management_System.Enums;

namespace Hospital_Management_System.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public string PatientId { get; set; }
        public ApplicationUser Patient { get; set; }

        public DateTime StartAt { get; set; }   
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
    }

}