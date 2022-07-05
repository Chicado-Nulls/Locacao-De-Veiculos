using Locadora.Dominio.Compartilhado;
using Locadora.Dominio.ModuloGrupoDeVeiculo;
using Locadora.Dominio.ModuloVeiculo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Dominio.ModuloCarro
{
    public class Veiculo : EntidadeBase<Veiculo>
    {
       

        public Veiculo(string modelo, string placa, string marca, string cor, decimal? capacidadeTanque, decimal? kmPercorrido, EnumTipoDeCombustivel tipoDeCombustivel)
        {
            Modelo = modelo;
            Placa = placa;
            Marca = marca;
            Cor = cor;
            CapacidadeTanque = capacidadeTanque;
            KmPercorrido = kmPercorrido;
            TipoDeCombustivel = tipoDeCombustivel;
        }
        public Veiculo()
        {

        }

        public override void Atualizar(Veiculo registro)
        {
            Modelo=registro.Modelo;
            Placa=registro.Placa;   
            Marca=registro.Marca;
            Cor=registro.Cor;   
            CapacidadeTanque=registro.CapacidadeTanque;
            KmPercorrido=registro.KmPercorrido;
            TipoDeCombustivel=registro.TipoDeCombustivel;
            GrupoDeVeiculo=registro.GrupoDeVeiculo;
        }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public decimal? CapacidadeTanque { get; set; }

        public decimal? KmPercorrido{ get; set; }

        public EnumTipoDeCombustivel TipoDeCombustivel { get; set; }

        public GrupoVeiculo  GrupoDeVeiculo { get; set; }

        public Byte[] Foto { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Veiculo veiculo &&
                  Modelo == veiculo.Modelo &&
                  Placa == veiculo.Placa &&
                  Marca == veiculo.Marca &&
                  Cor == veiculo.Cor &&
                  CapacidadeTanque == veiculo.CapacidadeTanque &&
                  KmPercorrido == veiculo.KmPercorrido &&
                  TipoDeCombustivel == veiculo.TipoDeCombustivel;
        }
        public void converterFoto(string caminhoFoto)
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            Foto=foto;
        }
    }
}
