using System;


class Program
{
static void Main(string[] arg)
{
        List<Reference> _verses = new List<Reference>
    {
        new Reference("1 Nephi 3:7"," And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Reference("","")
    };
        Scripture scripture = new Scripture(_verses);
        scripture.Display();
}

}



