class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string subject, string title) : base(studentName, subject)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetName()}";
    }
}