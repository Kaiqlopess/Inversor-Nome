using NameInverter.CasoDeUso;
using NameInverter.Menu;
using NameInverter.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AdicionarNome : IAdicionarNome
    {
        private Repository _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();

        public AdicionarNome(Repository repositorio)
        {
            this._repositorio = repositorio;
        }
        
        public void Adicionar()
        {
            Console.Clear();
            _menuExibirOperacao.MenuAdicionar();
            string nome = Console.ReadLine();

            if (TratamentoString.TratarString(nome))
            {
                return;
            }

            this._repositorio.Add(nome);
        }

    
    }
}
