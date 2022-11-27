using tp3_web_aspnet_infnet.Models;

namespace tp3_web_aspnet_infnet.DataSource
{
    public class DAPessoa
    {
        public List<Pessoa> pessoas { get; set; }

        public DAPessoa()
        {
            pessoas = new List<Pessoa>();

            var pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Camila",
                Sobrenome = "Castro",
                Aniversario = "19/06/1990"
            };
            pessoas.Add(pessoa);                      


        }
        
    }
}