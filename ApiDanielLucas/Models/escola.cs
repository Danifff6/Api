namespace ApiDanielLucas.Models
{
    public class escola
    {
        public int id {  get; set; }
        public string? nome { get; set; }
        public string? cnpj { get; set; }
        public int aluno_id { get; set; }
        public int professor_id { get; set; }
    }
}
