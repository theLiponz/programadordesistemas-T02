using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace logica13
    {
    internal class Carro
    {
       //propriedade pública: pode ser acessada e modificada fora da classe
       public string Marca { get; set; } //publica a propriedade marca

        //propriedade privada: não pode ser acessada fora da classe
        private string Modelo { get; set; } //privada a propriedade modelo

        //propriedade privada com um campo privado e um método getter e setter pesonalizados
        private int ano; //campo privado

        public int Ano //propriedade pública com getter e setter personalizados
        {
            get { return ano; } //Getter, para acessar o valor do campo privado
            set 
            { 
                if (value > 1900 && value <= DateTime.Now.Year) //verifica se o ano é válido
                {
                    ano = value; //atribui o valor ao campo ano
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }

        //Método pblico para exibir informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"marca: {Marca}");
            Console.WriteLine($"modelo: {Modelo}");//Acesso ao modelo é restrito por ser privado
            Console.WriteLine($"marca: {Ano}");
        }

        //método para calcular a idade do carro
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual- Ano;
        }
        //Método para definir o modelo do carro(com exemplo de uso de propriedade privada)
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; //Acessando a propriedade privada dentro da classe
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                //criando um objeto da classe carro
                Carro meuCarro = new Carro();

                //
                meuCarro.Marca = "Toyota"; //Acesso à propriedade pública
                meuCarro.DefinirModelo("Corolla"); //Definindo o modelo usando o método público
                meuCarro.Ano = 2020; //A propriedade Ano é pública, mas com uma validação interna

                //Exibindo as informações do carro
                meuCarro.ExibirInformacoes(); //Exibindo informações do carro

                //calculando e exibindo a idade do carro
                int idadeCarro = meuCarro.CalcularIdade();
                Console.WriteLine($"Idade do carro: {idadeCarro} anos");

                //mantendo o console aberto
                Console.ReadLine();
            }
        }





















    }

}