using Mictorios.Banheiro;
using Mictorios.Interface;
using Mictorios.Mictorios;

namespace Mictorios;

public class ControladorBanheiro
{

    public bool[] Controlar(int quantidadeMijoes)
    {
        var banheiro = new bool[4];


        for (int i = 0; i < quantidadeMijoes; i++)
        {
            var mijaoEscolheu = MictorioQueMijaoEscolheu(banheiro.Length);

            if (banheiro[mijaoEscolheu]) return banheiro;

            if (mijaoEscolheu == 0 && banheiro[1] == false)
            {
                banheiro[0] = true;
            }
            else if (mijaoEscolheu == 1 && banheiro[0] == false && banheiro[2] == false)
            {
                banheiro[mijaoEscolheu] = true;
            }
            else if (mijaoEscolheu == 2 && banheiro[1] == false && banheiro[3] == false)
            {
                banheiro[mijaoEscolheu] = true;
            }
            else if (mijaoEscolheu == 3 && banheiro[2] == false)
            {
                banheiro[mijaoEscolheu] = true;
            }
        }
       
        return banheiro;
    }

    private int MictorioQueMijaoEscolheu(int banheiro)
    {
        return new Random().Next(0, banheiro -1);
    }
}
