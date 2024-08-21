using CsvHelper.Configuration;
using ProjetoONG;

namespace ProjetoONG
{
    public sealed class DoadoresMap : ClassMap<Doadores>
    {
        public DoadoresMap()
        {
            Map(m => m.ID).Name("ID");
            Map(m => m.Doador).Name("Doador");
            Map(m => m.Endereco).Name("Endereco");
            Map(m => m.Telefone).Name("Telefone");
            Map(m => m.CPF).Name("CPF");
            Map(m => m.CNPJ).Name("CNPJ");
            Map(m => m.TipoDePessoa).Name("TipoDePessoa");
        }
    }
}
