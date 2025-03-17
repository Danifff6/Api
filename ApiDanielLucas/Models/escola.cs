namespace ApiDanielLucas.Models
{
    public class escola
    {
        public int id_escola {  get; set; }
        public string? nome { get; set; }
        public string? cnpj { get; set; }
        public aluno? aluno { get; set; }
        public professor? professor { get; set; }
    }
}
