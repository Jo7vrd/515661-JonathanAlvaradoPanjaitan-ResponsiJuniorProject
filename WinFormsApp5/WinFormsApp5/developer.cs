// Parent class
public class Developer
{
    protected int idDev;
    protected string namaDev;
    protected int idProyek;

    public int IdDev { get => idDev; set => idDev = value; }
    public string NamaDev { get => namaDev; set => namaDev = value; }
    public int IdProyek { get => idProyek; set => idProyek = value; }
}

// Child class - Freelance
public class FreelanceDev : Developer
{
    private int fiturSelesai;
    private int jumlahBug;

    public int FiturSelesai { get => fiturSelesai; set => fiturSelesai = value; }
    public int JumlahBug { get => jumlahBug; set => jumlahBug = value; }
}

// Child class - Full Time
public class FullTimeDev : Developer
{
    private int fiturSelesai;
    private int jumlahBug;

    public int FiturSelesai { get => fiturSelesai; set => fiturSelesai = value; }
    public int JumlahBug { get => jumlahBug; set => jumlahBug = value; }
}