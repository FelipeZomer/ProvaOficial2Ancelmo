using Microsoft.AspNetCore.Mvc;
using ProvaOficial2Ancelmo.Factory;
using ProvaOficial2Ancelmo.Historias.Carro;
using ProvaOficial2Ancelmo.Models;
using ProvaOficial2Ancelmo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Controllers
{
    [Route("api/carro")]
    public class CarroController : ControllerBase
    {
        private readonly IncluirCarro _incluirCarro;
        private readonly AtualizarCarro _atualizarCarro;
        private readonly ExcluirCarro _excluirCarro;
        private readonly ConsultarCarro _consultarCarro;

        public CarroController(CarroRepository carroRepository)
        {
            _incluirCarro = new IncluirCarro(carroRepository);
            _atualizarCarro = new AtualizarCarro(carroRepository);
            _excluirCarro = new ExcluirCarro(carroRepository);
            _consultarCarro = new ConsultarCarro(carroRepository);
        }

        [HttpPost("incluircarro")]
        public async Task<IActionResult> Criar([FromBody] CarroViewModel carroViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O Campo é Obrigatório" });
            }

            var carro = CarroFactory.MapearCarro(carroViewModel);

            await _incluirCarro.Executar(carro);

            return Ok(new { mensagem = "Carro Incluido" });
        }

        [HttpPut("atulizarcarro")]
        public async Task<IActionResult> Atualizar([FromBody] CarroViewModel carroViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O Campo é Obrigatório" });
            }

            try
            {
                var carro = CarroFactory.MapearCarro(carroViewModel);

                await _atualizarCarro.Executar(carroViewModel.Id, carro);

                return Ok(new { mensagem = "Carro Atualizado" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao Alterar o Carro" });
            }

        }
        [HttpDelete("excluircarro{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                await _excluirCarro.Executar(id);
                return Ok(new { mensagem = "Carro Excluido" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao excluir" });
            }

        }
        [HttpGet("buscarcarro/{id}")]
        public async Task<CarroViewModel> Buscar(int id)
        {
            var carro = await _consultarCarro.Consultar(id);

            if (carro == null)
            {
                return null;
            }

            var carroViewModel = CarroFactory.MapearCarroViewModel(carro);

            return carroViewModel;
        }
    }    
}
