public class Proyek
{
    // Encapsulation
    private int idProyek;
    private string namaProyek;
    private string client;
    private decimal budget;

    // Constructor
    public Proyek(int id, string nama, string client, decimal budget)
    {
        this.idProyek = id;
        this.namaProyek = nama;
        this.client = client;
        this.budget = budget;
    }

    // Getter & Setter
    public int IdProyek { get => idProyek; set => idProyek = value; }
    public string NamaProyek { get => namaProyek; set => namaProyek = value; }
    public string Client { get => client; set => client = value; }
    public decimal Budget { get => budget; set => budget = value; }
}