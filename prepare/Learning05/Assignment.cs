using System.Security.Cryptography.X509Certificates;

class Assignment
{
    private string _studentName;
    private string _subject;

    public Assignment(string studentName, string subject)
    {
        _studentName = studentName;
        _subject = subject;
    }

    public string GetName()
    {
        return _studentName;
    }
    public void SetName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetSubject()
    {
        return _subject;
    }
    public void SetSubject(string subject)
    {
        _subject = subject;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_subject}";
    }

}