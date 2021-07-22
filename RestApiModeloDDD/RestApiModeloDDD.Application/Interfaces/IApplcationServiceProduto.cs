using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplcationServiceProduto
    {
        void Add(ProdutoDto cliente);
        void Update(ProdutoDto cliente);
        void Remove(ProdutoDto cliente);
        IEnumerable<ProdutoDto> GetAll();
        ProdutoDto GetById(int id);
    }
}
