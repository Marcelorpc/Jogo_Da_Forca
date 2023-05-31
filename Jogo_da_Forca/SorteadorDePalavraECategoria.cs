using Jogo_da_Forca.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class SorteadorDePalavraECategoria
    {
        public string NomeCategoria { get; private set; }
        public string Palavra { get; private set; }
        public string Dica { get; private set; }
        private GerenciarCategorias gerenciadorCategorias;
        public SorteadorDePalavraECategoria(GerenciarCategorias GerenciadorCategorias)
        {
            gerenciadorCategorias = GerenciadorCategorias;
            NomeCategoria = string.Empty;
            Palavra = string.Empty;
            Dica = string.Empty;
        }
        public void Sortear()
        {
            Random random = new Random();

            int sorteioCategoria = random.Next(gerenciadorCategorias.categoriasAtivas.Count);
            NomeCategoria = gerenciadorCategorias.categoriasAtivas.ElementAt(sorteioCategoria).Key;
            Dictionary<string, string> categoriaSorteada = gerenciadorCategorias.categoriasAtivas.ElementAt(sorteioCategoria).Value;

            int sorteioPalavra = random.Next(categoriaSorteada.Count);
            Palavra = categoriaSorteada.ElementAt(sorteioPalavra).Key;
            Dica = categoriaSorteada.ElementAt(sorteioPalavra).Value;
        }
    }
}
