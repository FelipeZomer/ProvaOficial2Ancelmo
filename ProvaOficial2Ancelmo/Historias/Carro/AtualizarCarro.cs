using ProvaOficial2Ancelmo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Historias.Carro
{
    public class AtualizarCarro
    {
        private readonly CarroRepository _carroRepository;

        public AtualizarCarro(CarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public async Task Executar(int id, Entidades.Carro carro)
        {
            var dadosDoCarro = await _carroRepository.Consultar(id);

            dadosDoCarro.AtualizarDados(carro.Modelo, carro.Marca);

            await _carroRepository.Atualizar(dadosDoCarro);
        }
    }
}
