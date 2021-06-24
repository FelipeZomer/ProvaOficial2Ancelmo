using ProvaOficial2Ancelmo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Repositories
{
    public interface CarroRepository
    {
        Task Incluir(Carro carro);

        Task Atualizar(Carro carro);

        Task Remover(int id);

        Task<Carro> Consultar(int id);
        Task<Carro> ConsultarMarcaModelo(string Marca, string Modelo);

        Task<IEnumerable<Carro>> ListarTodosCarros();
    }
}
