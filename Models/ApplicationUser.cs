using Hospital_Management_System.Enums;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
    public Gender Gender { get; set; } = Gender.Unknown;
    public string MedicalHistory { get; set; }
    public Doctor? DoctorProfile { get; set; }
    public ICollection<Appointment> PatientAppointments { get; set; } = new List<Appointment>();
}