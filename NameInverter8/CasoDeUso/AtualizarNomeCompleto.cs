using NameInverter.CasoDeUso.Serviços.Nome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso
{
    public class AtualizarNomeCompleto
    {
        private ListarNomeCompleto _listarNomeCompleto =  new ListarNomeCompleto();
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();
        private AtualizarSobrenome _atualizarSobrenome = new AtualizarSobrenome();
        private AtualizarNome _atualizarNome = new AtualizarNome();


        public void Atualizar()
        {
            _listarNomeCompleto.listar();

            _menuExibirOperacao.MenuAtualizar();

            Guid idDeletar;

            try
            {
                idDeletar = Guid.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um Guid válido.");
                return;
            }

            Console.Clear();
            _menuExibirOperacao.MenuNomeAtualizado();

            string nome = Console.ReadLine();
            string[] nomeCompleto = nome.Split(' ');

            if (TratamentoString.TratarString(nomeCompleto[0], nomeCompleto[1]))
            {
                return;
            }

            _atualizarSobrenome.Atualizar(nomeCompleto[1], idDeletar);

            _atualizarNome.Atualizar(nomeCompleto[0], idDeletar);



        }
    }
}
