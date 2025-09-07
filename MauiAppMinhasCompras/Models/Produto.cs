using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {

        string _descricao;
        Double _quantidade;
        Double _preco;

        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Descricao { 
            get => _descricao;
            set
            {
                if(value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }              
                }

        public Double Quantidade { 
            get => _quantidade;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, digite um número");
                }
                _quantidade = value;
            }
        }

        public Double Preco {
            get => _preco;
            set
            {
                if (value == 0)
                {
                    throw new Exception("Por favor, digite um número");
                }
                _preco = value;
            }
        }

        public Double Total { get => Quantidade * Preco; }

    }
}
