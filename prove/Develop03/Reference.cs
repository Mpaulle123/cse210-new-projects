class Reference
{
    private string _reference;
    private string _text;


    public Reference(string reference, string text)
    {
        this._reference = reference;
        this._text = text;
    }

    public string GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }
}