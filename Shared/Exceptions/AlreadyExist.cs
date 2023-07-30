using System;

namespace Shared.Exceptions {
  public class AlreadyExist : Exception {

    public AlreadyExist()
    {
    }

    public AlreadyExist(string message) : base(message)
    {
    }

    public AlreadyExist(string message, Exception innerException) : base(message, innerException)
    {
    }
  }
}