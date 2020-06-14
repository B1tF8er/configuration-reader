namespace Configuration.Reader.Tests
{
    public class Sample
    {
        public int Number { get; set; }

        public string Text { get; set; }

        public override bool Equals(object other) =>
            other is Sample sample
            && Number == sample.Number
            && Text == sample.Text;

        public override int GetHashCode() =>
            Number.GetHashCode() ^ Text.GetHashCode();
    }
}
