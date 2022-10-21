namespace Fucha.Application.Exceptions;

    public class RecordNotFound : Exception
    {
        public RecordNotFound(string name, object key) : base($"Could not find record for Entity '{name}' with Id of {key}")
        {
        }
        public RecordNotFound(string message) : base(message)
        {
        }
    }

