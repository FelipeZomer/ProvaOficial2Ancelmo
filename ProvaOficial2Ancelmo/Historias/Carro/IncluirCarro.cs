using ProvaOficial2Ancelmo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Historias.Carro
{
    public class IncluirCarro
    {
        private readonly CarroRepository _carroRepository;

        public IncluirCarro(CarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public async Task Executar(Entidades.Carro carro)
        {
            await _carroRepository.Incluir(carro);
        }
    }
}
