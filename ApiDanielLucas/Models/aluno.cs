namespace ApiDanielLucas.Models
{
    public class aluno
    {
        public int id {  get; set; }
        public string? nome { get; set; }
        public int matricula { get; set; }
        public string? pai { get; set; }
        public string? mae { get; set; }
        public string? rma { get; set; }
        public DateTime data_nascimento { get; set; }
        public int escola_id { get; set; }
        public int professor_id { get; set; }


    }
}
