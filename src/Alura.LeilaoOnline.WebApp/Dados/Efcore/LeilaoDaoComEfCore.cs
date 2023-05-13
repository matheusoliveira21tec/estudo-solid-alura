using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.Efcore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {
        AppDbContext _context;

        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }
        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes.Include(x => x.Categoria).ToList();
        }
        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(x => x.Id == id);
        }
        public void Incluir(Leilao Leilao)
        {
            _context.Leiloes.Add(Leilao);
            _context.SaveChanges();
        }
        public void Alterar(Leilao Leilao)
        {
            _context.Leiloes.Update(Leilao);
            _context.SaveChanges();
        }
        public void Excluir(Leilao Leilao)
        {
            _context.Leiloes.Remove(Leilao);
            _context.SaveChanges();
        }
    }
}
