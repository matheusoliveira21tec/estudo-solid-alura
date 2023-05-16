﻿using System;
using System.Collections.Generic;
using System.Linq;
using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class ArquivamentoAdminService : IAdminService
    {
        IAdminService _defaultService;
        public ArquivamentoAdminService(ILeilaoDao Leilaodao, ICategoriaDao CategoriaDao)
        {
            _defaultService = new DefaultAdminService(Leilaodao, CategoriaDao);
        }
        public void CadastraLeilao(Leilao leilao)
        {
            _defaultService.CadastraLeilao(leilao);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _defaultService.ConsultaCategorias();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _defaultService.ConsultaLeilaoPorId(id);
        }

        public IEnumerable<Leilao> Consultaleiloes()
        {
            return _defaultService.Consultaleiloes().Where(x => x.Situacao != SituacaoLeilao.Arquivado);
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            _defaultService.FinalizaPregaoDoLeilaoComId(id);
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            _defaultService.IniciaPregaoDoLeilaoComId(id);
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _defaultService.ModificaLeilao(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
           if(leilao == null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Arquivado;
                _defaultService.ModificaLeilao(leilao);
            }
        }
    }
}
