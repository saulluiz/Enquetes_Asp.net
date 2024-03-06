using System.ComponentModel.DataAnnotations;

namespace Enquetes_Asp.net.Models{
    public class Resposta{

[Required (ErrorMessage ="O campo nome precisa ser preenchido")]
        public string? Nome {get;set;}
[Required (ErrorMessage ="O campo Email precisa ser preenchido")]  
        public string? Email {get;set;}
[Required (ErrorMessage ="O campo resposta deve ser preenchido")]
        public bool? Sim {get;set;}
    }
}