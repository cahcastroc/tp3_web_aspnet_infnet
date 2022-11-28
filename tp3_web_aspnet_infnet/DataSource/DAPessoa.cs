using tp3_web_aspnet_infnet.Models;

namespace tp3_web_aspnet_infnet.DataSource
{
    public static class DAPessoa
    {
        public static List<Pessoa> Pessoas { get; set; } =  new List<Pessoa>
            {
                new Pessoa
                {
                Id = 1,
                Nome = "Camila",
                Sobrenome = "Castro",
                Aniversario = "19/06/1990"
                }
            };

        
        public static List<Pessoa> ListaTodos() {
            return Pessoas;
        }
        
        public static Pessoa BuscaPessoaPorId(int id)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);
            return pessoa;
        }

        public static void AdicionarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }


        public static List<Pessoa> BuscaPessoaNome(string nome)
        {
            var lista = Pessoas.Where(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
            return lista;
        }

        public static void EditaPessoa(Pessoa pessoa)
        {
            var pessoaEdit = BuscaPessoaPorId(pessoa.Id);
            if (pessoaEdit != null)
            {
                pessoaEdit.Nome = pessoa.Nome;
                pessoaEdit.Sobrenome = pessoa.Sobrenome;
                pessoaEdit.Aniversario = pessoa.Aniversario;
            }
        }
        
        public static void DeletaPessoa(int id)
        {
            var pessoaDelete = BuscaPessoaPorId(id);        
            Pessoas.Remove(pessoaDelete);
            
        }

    }
}