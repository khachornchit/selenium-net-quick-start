namespace Selenium2016.Models
{
    public class TestResultInPage
    {
        public string Id { get; set; }
        public string TestedDateTime { get; set; }
        public string Name { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }
        private static string PASSED { get { return "PASSED"; } }
        private static string FAILED { get { return "FAILED"; } }

        public TestResultInPage(string Name, bool Result)
        {
            this.Name = Name;
            this.Result = Result;
            Message = (Result == true) ? PASSED : FAILED;

            Id = AutoId.Id;
            TestedDateTime = AutoId.CurrentDateTime;
        }

        public TestResultInPage(string Name, string Message, bool Result)
        {
            this.Name = Name;
            this.Result = Result;
            this.Message = Message;

            Id = AutoId.Id;
            TestedDateTime = AutoId.CurrentDateTime;
        }

        public string Report()
        {
            return string.Format("{0}{1}{2}{3}{4}", Id.PadRight(20), TestedDateTime.PadRight(20), Name.PadRight(30), Message.PadRight(50), Result.ToString());
        }
    }
}
