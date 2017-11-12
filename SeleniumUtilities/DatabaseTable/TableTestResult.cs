using SeleniumUtilities.Definition;
using System;
using System.IO;

namespace SeleniumUtilities.DatabaseTable
{
    public class TableTestStepResult
    {
        private int Id { get; set; }

        public int TestCaseId { get; set; }

        public string ExecutedType { get; set; }

        private string ExecutedDateTime { get; set; }

        public string URL { get; set; }

        public string Result { get; set; }

        public string Message { get; set; }

        public string Remark { get; set; }

        public bool InsertDataTestStepResult()
        {
            string curDir = Directory.GetCurrentDirectory().ToLower();

            if (curDir.Contains("ProductionTestCases".ToLower()))
            {
                return InsertDataTestStepResultProduction();
            }
            else
            {
                return InsertDataTestStepResultDevelopment();
            }
        }

        private bool InsertDataTestStepResultProduction()
        {
            ExecutedType = string.IsNullOrEmpty(ExecutedType) ? "Auto" : ExecutedType;
            URL = string.IsNullOrEmpty(URL) ? "-" : URL;
            ExecutedDateTime = string.Format("{0}", DateTime.Now);

            string QueryString = string.Empty;
            QueryString += string.Format("INSERT INTO [QAAutomationTest].[dbo].[TestStepResultProduction] ([TestCaseId],[ExecutedType],[ExecutedDateTime],[URL],[Result],[Message],[Remark],[TestIndex])");
            QueryString += string.Format("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TestCaseId, ExecutedType, ExecutedDateTime, URL, Result, Message, Remark, Runner.IndexTimeTestStep);

            return SqlInterface.ExecuteQuery(QueryString);
        }

        private bool InsertDataTestStepResultDevelopment()
        {
            ExecutedType = string.IsNullOrEmpty(ExecutedType) ? "Auto" : ExecutedType;
            URL = string.IsNullOrEmpty(URL) ? "-" : URL;
            ExecutedDateTime = string.Format("{0}", DateTime.Now);

            string QueryString = string.Empty;
            QueryString += string.Format("INSERT INTO [QAAutomationTest].[dbo].[TestStepResultDevelopment] ([TestCaseId],[ExecutedType],[ExecutedDateTime],[URL],[Result],[Message],[Remark],[TestIndex])");
            QueryString += string.Format("VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", TestCaseId, ExecutedType, ExecutedDateTime, URL, Result, Message, Remark, Runner.IndexTimeTestStep);

            return SqlInterface.ExecuteQuery(QueryString);
        }
    }
}
