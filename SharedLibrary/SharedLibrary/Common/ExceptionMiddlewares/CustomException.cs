using System.Globalization;

namespace SharedLibrary.Common.ExceptionMiddlewares;

/// <summary>
/// Represents a custom exception for the transcription service.
/// </summary>
public class CustomException : Exception
{
    /// <summary>Initializes a new instance of the <see cref="CustomException"/> class.</summary>
    public CustomException()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomException"/> class with a message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public CustomException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomException"/> class with a message and inner exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="ex">The exception that is the cause of the current exception.</param>
    public CustomException(string message, Exception ex)
        : base(message, ex)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomException"/> class with a formatted message.
    /// </summary>
    /// <param name="message">The composite format string that describes the error.</param>
    /// <param name="args">An array of objects to format.</param>
    public CustomException(string message, params object[] args)
        : base(string.Format(CultureInfo.CurrentCulture, message, args))
    {
    }
}