using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();
        
        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarPorId(int id);

        void Incluir(Leilao Leilao);

        void Alterar(Leilao Leilao);

        void Excluir(Leilao Leilao);
    }
}
