namespace Configuration.Reader
{
	public class SettingResponse<TValue>
    {
		public bool IsParsed { get; set; }

		public TValue Value { get; set; }

		public string Error { get; set; }

		public SettingResponse(bool isParsed, TValue value) =>
			(IsParsed, Value) = (isParsed, value);

		public SettingResponse(string error) =>
			(IsParsed, Error) = (false, error);

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
