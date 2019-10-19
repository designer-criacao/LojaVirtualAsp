namespace Loja.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        // public Produto(int id, string nome, string descricao, decimal valor)
        // {
        //     this.Id = id;
        //     this.Nome = nome;
        //     this.Descricao = descricao;
        //     this.Valor = valor;

        // }
    }
}