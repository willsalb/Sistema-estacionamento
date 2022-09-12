using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_estacionamento_dotnet.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private string placa;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdcionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            placa = (Console.ReadLine());
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veívulo para remover: ");
            string placaRemover = Console.ReadLine();

            //Verificar se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemover))
                {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");
                string qtHora = Console.ReadLine();
                int horas = Convert.ToInt32(qtHora);
                decimal valor = precoInicial + precoPorHora * horas;

                veiculos.Remove(placaRemover);

                Console.WriteLine($"O veículo {placaRemover} foi removido, preço inicial R${precoInicial}, mais o valor de horas {precoPorHora}. O preço total foi de: R${valor}");
            } else
            {
                Console.WriteLine("Esssa placa não existe. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados: ");
                foreach(string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados!");
            }
        }
    }
}
