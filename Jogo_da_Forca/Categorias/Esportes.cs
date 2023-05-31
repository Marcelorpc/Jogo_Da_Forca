using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Categorias
{
    public class Esportes
    {
        public Dictionary<string, string> _palavras_e_dicas;
        public string Categoria = "Esportes";

        public Esportes()
        {
            _palavras_e_dicas = new Dictionary<string, string>();
            adicionarPalavras();
        }

        private void adicionarPalavras()
        {
            _palavras_e_dicas.Add("futebol", "Esporte de equipe jogado com uma bola nos pés, onde o objetivo é marcar gols.");
            _palavras_e_dicas.Add("basquete", "Esporte jogado em uma quadra com o objetivo de arremessar a bola em uma cesta.");
            _palavras_e_dicas.Add("tenis", "Esporte em que os jogadores utilizam raquetes para rebater uma bola por cima da rede.");
            _palavras_e_dicas.Add("natacao", "Atividade esportiva em que os participantes nadam em piscinas ou águas abertas.");
            _palavras_e_dicas.Add("atletismo", "Conjunto de modalidades esportivas que envolvem corrida, saltos e lançamentos.");
            _palavras_e_dicas.Add("volei", "Esporte em que duas equipes se enfrentam, utilizando as mãos para passar e lançar uma bola sobre uma rede.");
            _palavras_e_dicas.Add("ginastica", "Prática esportiva que envolve movimentos acrobáticos, flexibilidade e coordenação motora.");
            _palavras_e_dicas.Add("boxe", "Esporte de combate em que dois adversários lutam entre si usando os punhos.");
            _palavras_e_dicas.Add("ciclismo", "Atividade esportiva realizada com bicicletas, seja em estradas ou em pistas específicas.");
            _palavras_e_dicas.Add("handebol", "Esporte em que duas equipes tentam marcar gols em uma baliza, utilizando as mãos para passar e arremessar a bola.");
            _palavras_e_dicas.Add("golfe", "Esporte em que os jogadores utilizam tacos para acertar uma bola em direção a um buraco.");
            _palavras_e_dicas.Add("surfe", "Atividade esportiva em que os praticantes deslizam sobre as ondas do mar utilizando pranchas.");
            _palavras_e_dicas.Add("rugby", "Esporte de equipe semelhante ao futebol, porém jogado com as mãos e uma bola oval.");
            _palavras_e_dicas.Add("esgrima", "Esporte de combate em que os competidores utilizam espadas para atacar e se defender.");
            _palavras_e_dicas.Add("skate", "Modalidade esportiva praticada com uma prancha montada sobre rodas, realizando manobras e saltos.");
            _palavras_e_dicas.Add("tenis de mesa", "Modalidade esportiva que envolve dois jogadores ou duas duplas, utilizando raquetes e uma pequena bola sobre uma mesa dividida por uma rede.");
            _palavras_e_dicas.Add("luta livre", "Esporte de combate em que os competidores buscam imobilizar o adversário através de técnicas de agarramento.");
            _palavras_e_dicas.Add("patinacao", "Atividade esportiva realizada sobre patins, podendo ser no gelo ou em superfícies planas.");
            _palavras_e_dicas.Add("ginastica ritmica", "Modalidade de ginástica que combina elementos de dança e movimentos corporais com o uso de aparelhos como bola, arco, fita e maças.");
            _palavras_e_dicas.Add("remo", "Esporte praticado em embarcações movidas por remos, onde os competidores buscam percorrer uma distância no menor tempo possível.");
        }
    }
}
