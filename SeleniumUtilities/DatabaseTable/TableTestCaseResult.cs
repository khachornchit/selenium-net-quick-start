using SeleniumUtilities.DatabaseTable;
using SeleniumUtilities.Definition;
using System;
using System.IO;

namespace SeleniumUtilities.DatabaseTable
{
    public class TableTestCaseResult
    {
        private int Id { get; set; }

        public int TestCaseId { get; set; }

        public string ExecutedType { get; set; }

        private string ExecutedDateTime { get; set; }

        public string URL { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }

        public string Remark { get; set; }

        public bool InsertDataTestCaseResult()
        {
            string curDir = Directory.GetCurrentDirectory().ToLower();

            if (curDir.Contains("ProductionTestCases".ToLower()))
            {
                return InsertDataTestCaseResultProduction();
            }
            else
            {
                return InsertDataTestCaseResultDevelopment();
            }
        }

        private bool InsertDataTestCaseResultProduction()
        {
            ExecutedType = string.IsNullOrEmpty(ExecutedType) ? "Auto" : ExecutedType;
            URL = string.IsNullOrEmpty(URL) ? "-" : URL;
            ExecutedDateTime = string.Format("{0}", DateTime.Now);

            string QueryString = string.Empty;
            QueryString += string.Format("INSERT INTO [QAAutomationTest].[dbo].[TestCaseResultProduction] ([TestCaseId],[ExecutedType],[ExecutedDateTime],[URL],[Result],[Message],[Remark],[TestIndex])");
            QueryString += string.Format("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TestCaseId, ExecutedType, ExecutedDateTime, URL, Result, Message, Remark, Runner.IndexTimeTestCase);

            return SqlInterface.ExecuteQuery(QueryString);
        }

        private bool InsertDataTestCaseResultDevelopment()
        {
            ExecutedType = string.IsNullOrEmpty(ExecutedType) ? "Auto" : ExecutedType;
            URL = string.IsNullOrEmpty(URL) ? "-" : URL;
            ExecutedDateTime = string.Format("{0}", DateTime.Now);

            string QueryString = string.Empty;
            QueryString += string.Format("INSERT INTO [QAAutomationTest].[dbo].[TestCaseResultDevelopment] ([TestCaseId],[ExecutedType],[ExecutedDateTime],[URL],[Result],[Message],[Remark],[TestIndex])");
            QueryString += string.Format("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TestCaseId, ExecutedType, ExecutedDateTime, URL, Result, Message, Remark, Runner.IndexTimeTestCase);

            return SqlInterface.ExecuteQuery(QueryString);
        }
    }
}
