namespace Configuration.Reader
{
    public sealed class SettingResponse<TValue>
    {
        public bool IsParsed { get; }

        public TValue Value { get; }

        public Error Error { get; }

        private SettingResponse(bool isParsed, TValue value) =>
            (IsParsed, Value, Error) = (isParsed, value, string.Empty);

        private SettingResponse(Error error) =>
            (IsParsed, Value, Error) = (false, default(TValue), error);

        public static SettingResponse<TValue> Create(bool isParsed, TValue value) =>
            new SettingResponse<TValue>(isParsed, value);

        public static SettingResponse<TValue> Create(Error error) =>
            new SettingResponse<TValue>(error);

        public override string ToString() =>
            $"IsParsed: {IsParsed} -- Value: {Value} -- Error: {Error}";

        public override bool Equals(object other) =>
            other is SettingResponse<TValue> settingResponse
            && IsParsed == settingResponse.IsParsed
            && Value.Equals(settingResponse.Value)
            && Error.Equals(settingResponse.Error);

        public override int GetHashCode() =>
            IsParsed.GetHashCode()
            ^ Value.GetHashCode()
            ^ Error.GetHashCode();
    }
}
