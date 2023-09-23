using Microsoft.EntityFrameworkCore;
namespace MVCEFApp.Models
{
    public class RepositoryAppointment
    {
        public static List<Appointment>GetAppointments()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Appointments.ToList();
            return list;
        }
        public static Appointment GetAppointmentById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Appointment appointment = ctx.Appointments.Find();
            return appointment;
        }
        public static void MakeNewAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appointments.Add(appointment);
            ctx.SaveChanges();
        }
        public static void EditAppointment(Appointment appointment) 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appointment).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void DeleteAppointment(int id) 
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Appointment appointment = ctx.Appointments.Find(id);
            ctx.SaveChanges();
        }
    }
}
