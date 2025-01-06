
namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota <= 0)
        { 
            Nota = 0; 
        }
        else if(nota >= 10)
        {
            Nota = 10;
        }
        else
        {
            Nota = nota;
        }
    }

    public int Nota { get; }

    public static Avaliacao Parse(string text)
    {
        return new Avaliacao(int.Parse(text));
    }
}
