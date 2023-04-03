namespace decomposicao_primos;

public class Decompor
{
    private int _numeroCalcular;
    private int _index;
    private List<int> _mumerosDecompostos;
    private static readonly List<int> NumerosPrimos = new() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

        public Decompor(int numeroCalcular)
	{
        _numeroCalcular = numeroCalcular;
        _index = 0;
        _mumerosDecompostos = new();
    }

    public List<int> Calcular()
    {
        if (_numeroCalcular == 1)
            return _mumerosDecompostos;
        else if (_numeroCalcular % NumerosPrimos[_index]  == 0 )
        {
            _numeroCalcular =  _numeroCalcular / NumerosPrimos[_index];
            _mumerosDecompostos.Add(NumerosPrimos[_index]);
            Calcular();
        }
        else
        {
            _index++;
            Calcular();
        }        

        return _mumerosDecompostos;
    }
}
