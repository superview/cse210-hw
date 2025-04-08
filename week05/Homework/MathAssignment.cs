public class MathAssignment : Assignment
{
    private string _textboodSection;
    private string _problems;
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base (name, topic)
    {
        _problems = problems;
        _textboodSection = textbookSection;
    }
    public string GetHomeworkList()
    {

        return $"Student: {GetStudentName()}\nhomework list... {_textboodSection} & {_problems}";
    }
}