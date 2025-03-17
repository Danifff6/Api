namespace ApiDanielLucas.Models
{
    public class professor {
        public int id { get; set; }
        public string? nome { get; set; }
        public int matricula { get; set; }
        public string? pai { get; set; }
        public string? mae { get; set; }
        public string? rma { get; set; }
        public DateTime data_nascimento { get; set; }
        public escola? escola { get; set; }
        public string? componente_curricular { get; set; }

    }
}
