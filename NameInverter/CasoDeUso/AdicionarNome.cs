using NameInverter.CasoDeUso;
using NameInverter.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AdicionarNome : IAdicionarNome
    {
        private Repositorio _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao;

        public AdicionarNome(Repositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        
        public void Adicionar()
        {
            Console.Clear();
            _menuExibirOperacao.MenuAdicionar();
            string nome = LerNome.LerAdicionar();
            this._repositorio.Add(nome);
        }

    
    }
}
