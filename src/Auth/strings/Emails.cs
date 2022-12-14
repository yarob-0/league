namespace Auth
{
    public class Emails
    {
        private Emails(string value) { Value = value; }

        public string Value { get; private set; }

        public static Emails User { get { return new Emails("user@mail.com"); } }
        public static Emails Admin{ get { return new Emails("admin@mail.com"); } }
	}
}

