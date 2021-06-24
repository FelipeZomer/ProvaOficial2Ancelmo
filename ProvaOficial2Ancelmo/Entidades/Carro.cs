using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaOficial2Ancelmo.Entidades
{
    public class Carro
    {
        public Carro(string modelo, string marca)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public float Quilometragem { get; private set; }

        public void AtualizarDados(string modelo, string marca)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }
    }
}

