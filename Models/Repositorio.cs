namespace Enquetes_Asp.net.Models
{
    public static class Repositorio{


        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas {get{return respostas;}}
        //encapsula colecoes,pois a classe IEnumerable nao possui metodos de adicao ou exclusao, o que impede que a classe seja 
        //acessada de outra forma(No caso, temos somente o metodo adicionar respostas para fazzer isso)


        public static void AdicionarResposta(Resposta resposta){
            respostas.Add(resposta);
        }
    static Repositorio(){
        respostas.Add(new Resposta(){Nome="aaaaaa", Email="aaaaaaaa" ,Sim=true});
        respostas.Add(new Resposta(){Nome="bbbbbbb", Email="bbbbbbbbb" ,Sim=false});
        respostas.Add(new Resposta(){Nome="cccccccccccc", Email="cccccccccccccc" ,Sim=true});
    }
    }
    
}