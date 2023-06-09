﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;
namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        IEnumerable<Categoria> ConsultaCategorias();

        IEnumerable<Leilao> Consultaleiloes();

        Leilao ConsultaLeilaoPorId(int id);

        void CadastraLeilao (Leilao leilao);

        void ModificaLeilao(Leilao leilao);

        void RemoveLeilao(Leilao leilao);

        void IniciaPregaoDoLeilaoComId(int id);

        void FinalizaPregaoDoLeilaoComId(int id);
    }
}
