using ProvaOficial2Ancelmo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Historias.Carro
{
    public class ExcluirCarro
    {
        private readonly CarroRepository _carroRepository;

        public ExcluirCarro(CarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public async Task Executar(int id)
        {
            await _carroRepository.Remover(id);
        }
    }
}
