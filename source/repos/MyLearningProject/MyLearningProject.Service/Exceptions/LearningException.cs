namespace MyLearningProject.Service.Exceptions;

public class LearningException : Exception
{
    public int StatusCode { get; set; }

    public LearningException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}
