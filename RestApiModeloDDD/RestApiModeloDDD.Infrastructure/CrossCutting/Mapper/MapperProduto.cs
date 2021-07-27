using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produto)
        {
            return new Produto
            {
                Id = produto.Id.Value,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            return new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(produto => 
                new ProdutoDto 
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Valor = produto.Valor
                });

            return dto;
        }
    }
}
