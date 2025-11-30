using NameInverter.Nome.NomeConcreto;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Sobrenome
{
    public class DeletarSobrenome
    {
        private IRepositorySobrenome _repositorioSobrenome = new RepositorySobrenome();
        public void Deletar(Guid IdNome)
        {
            var sobrenomeDeletar = _repositorioSobrenome.Procurar(IdNome);

            if (sobrenomeDeletar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O Id do NOME!");
                Console.ReadLine();
                return;
            }

            _repositorioSobrenome.Remove((SobrenomeName)sobrenomeDeletar);
        }
    }
}
