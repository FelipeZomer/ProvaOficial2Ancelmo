using ProvaOficial2Ancelmo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaOficial2Ancelmo.Entidades;

namespace ProvaOficial2Ancelmo.Historias.Carro
{
    public class ConsultarCarro
    {
        private readonly CarroRepository _carroRepository;

        public ConsultarCarro(CarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public async Task<Entidades.Carro> Consultar(int id)
        {
            return await _carroRepository.Consultar(id);
        }

        public async Task<IEnumerable<Entidades.Carro>> ListarTodosCarros()
        {
            return await _carroRepository.ListarTodosCarros();
        }
        public async Task<Entidades.Carro> ConsultarMarcaModelo(string Modelo, string Marca)
        {
            return await _carroRepository.ConsultarMarcaModelo(Modelo, Marca);
        }
    }
}
