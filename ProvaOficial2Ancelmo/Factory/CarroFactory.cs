using ProvaOficial2Ancelmo.Entidades;
using ProvaOficial2Ancelmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Factory
{
    public static class CarroFactory
    {
        public static Carro MapearCarro(CarroViewModel carroViewModel)
        {
            return new Carro(carroViewModel.Modelo, carroViewModel.Marca);
        }

        public static CarroViewModel MapearCarroViewModel(Carro carro)
        {
            return new CarroViewModel() { Id = carro.Id, Modelo = carro.Modelo, Marca = carro.Marca };
        }

        public static IEnumerable<CarroViewModel> MapearListaCarroViewModel(IEnumerable<Carro> lista)
        {
            var listaCarroViewModel = new List<CarroViewModel>();
            CarroViewModel cursoVm;

            foreach (var item in lista)
            {
                cursoVm = new CarroViewModel
                {
                    Id = item.Id,
                    Modelo = item.Modelo,
                    Marca = item.Marca
                };

                listaCarroViewModel.Add(cursoVm);
            }

            return listaCarroViewModel;
        }
    }
}
