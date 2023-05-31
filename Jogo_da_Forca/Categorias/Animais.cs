using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Categorias
{
    public class Animais
    {
        public Dictionary<string, string> _palavras_e_dicas;
        public string Categoria = "Animais";
        public Animais()
        {
            _palavras_e_dicas = new Dictionary<string, string>();
            adicionarPalavras();
        }

        private void adicionarPalavras()
        {
            _palavras_e_dicas.Add("elefante", "É o maior mamífero terrestre.");
            _palavras_e_dicas.Add("girafa", "Possui um pescoço longo e pernas altas.");
            _palavras_e_dicas.Add("leao", "É considerado o rei da selva.");
            _palavras_e_dicas.Add("borboleta", "É um inseto conhecido por suas asas coloridas.");
            _palavras_e_dicas.Add("tubarao", "É um predador marinho temido.");
            _palavras_e_dicas.Add("canguru", "É um animal que vive na Austrália e possui uma bolsa.");
            _palavras_e_dicas.Add("coala", "É um animal que se alimenta principalmente de folhas de eucalipto.");
            _palavras_e_dicas.Add("tigre", "É um felino listrado conhecido por sua força e agilidade.");
            _palavras_e_dicas.Add("golfinho", "É um mamífero marinho inteligente e sociável.");
            _palavras_e_dicas.Add("pinguim", "É uma ave que vive principalmente em regiões de baixas temperaturas e é conhecida por sua habilidade de nadar.");
            _palavras_e_dicas.Add("gato", "É um animal de estimação comum conhecido por sua independência.");
            _palavras_e_dicas.Add("cachorro", "É considerado o melhor amigo do homem.");
            _palavras_e_dicas.Add("papagaio", "É uma ave exótica conhecida por imitar sons e falar algumas palavras.");
            _palavras_e_dicas.Add("abelha", "É um inseto polinizador que produz mel.");
            _palavras_e_dicas.Add("girassol", "É uma planta que tem uma flor grande e amarela que acompanha o movimento do sol.");
            _palavras_e_dicas.Add("sapo", "É um anfíbio que vive tanto na água quanto em terra.");
            _palavras_e_dicas.Add("urso", "É um mamífero que pode ser encontrado em diferentes habitats, desde florestas até regiões polares.");
            _palavras_e_dicas.Add("pomba", "É uma ave símbolo da paz, comum em áreas urbanas.");
            _palavras_e_dicas.Add("cavalo", "É um animal de grande porte utilizado como meio de transporte e para atividades esportivas.");
            _palavras_e_dicas.Add("macaco", "É um primata conhecido por sua agilidade e habilidade de escalar árvores.");
        }
    }
}
