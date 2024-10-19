using System.Net.Sockets;

class Word
{
    public int ChooseRandomWord(List<string> _words, Random _random)
    {
        int index;
        do
        {
            index = _random.Next(_words.Count);
        } while (_words[index] == "__");
        return index;
    }


}