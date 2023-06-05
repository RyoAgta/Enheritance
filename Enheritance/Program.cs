using Enheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.Name = "Ryo Agata ";
        person1.Age = 20;
        person1.InfoPerson();

        //Inheritance
        Karyawan karyawan1 = new Karyawan();
        karyawan1.KaryawanID = 22114831;
        karyawan1.Subject = "Ryo Agata Prasetyo";
        karyawan1.InfoKaryawan();

        Karyawan karyawan2 = new Karyawan("Direktur Utama");
    }
}