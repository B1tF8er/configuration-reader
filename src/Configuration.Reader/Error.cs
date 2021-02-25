namespace Configuration.Reader
{
    using System;

    public sealed class Error
    {
        private readonly string value;

        private Error(string value) => this.value = value;

        public static Error Create(string error)
        {
            if (error is null)
            {
                throw new ArgumentNullException(nameof(error), "Error cannot be null");
            }

            return new Error(error);
        }

        public static implicit operator string(Error error) => error.value;

        public static implicit operator Error(string error) => Create(error);

        public override bool Equals(object obj)
        {
            var error = obj as Error;

            if (error is null)
            {
                return false;
            }

            return value == error.value;
        }

        public override int GetHashCode() => value.GetHashCode();

        public override string ToString() => value;
    }
}
