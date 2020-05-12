namespace Configuration.Reader
{
    public class SettingResponse<TValue>
    {
        public bool IsParsed { get; }

        public TValue Value { get; }

        public string Error { get; }

        private SettingResponse(bool isParsed, TValue value) =>
            (IsParsed, Value, Error) = (isParsed, value, string.Empty);

        private SettingResponse(string error) =>
            (IsParsed, Value, Error) = (false, default(TValue), error);

        public static SettingResponse<TValue> Create(bool isParsed, TValue value) =>
            new SettingResponse<TValue>(isParsed, value);

        public static SettingResponse<TValue> Create(string error) =>
            new SettingResponse<TValue>(error);

        public override string ToString() =>
            $"IsParsed: {IsParsed} -- Value: {Value} -- Error: {Error}";

        public override bool Equals(object other)
            => other is SettingResponse<TValue> settingResponse
            ? IsParsed == settingResponse.IsParsed
                && Value.Equals(settingResponse.Value)
                && Error == settingResponse.Error
            : false;

        public override int GetHashCode()
            => IsParsed.GetHashCode()
            ^ Value.GetHashCode()
            ^ Error.GetHashCode();
    }
}
