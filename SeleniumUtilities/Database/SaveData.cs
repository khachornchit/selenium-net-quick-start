using SeleniumUtilities.DatabaseTable;

namespace SeleniumUtilities
{
    public class SaveData
    {
        public static string ServerName
        {
            set { SqlInterface.ServerName = value; }
        }

        public static string DatabaseName
        {
            set { SqlInterface.DatabaseName = value; }
        }

        public static string UserName
        {
            set { SqlInterface.UserName = value; }
        }

        public static string Password
        {
            set { SqlInterface.Password = value; }
        }

        public static void SaveTestStepPass()
        {
            Runner.Pass();
            SaveTestStep();
        }

        public static void SaveTestStepFail()
        {
            Runner.Fail();
            SaveTestStep();
        }

        public static void TestCasePass()
        {
            Runner.Pass();
            SaveTestCase();
        }

        public static void TestCaseFail()
        {
            Runner.Fail();
            SaveTestCase();
        }

        private static void SaveTestStep()
        {
            try
            {
                TableTestStepResult table = new TableTestStepResult();
                table.TestCaseId = Runner.TestCase;
                table.ExecutedType = Runner.TestMode;
                table.URL = Runner.URL;
                table.Message = Runner.MessageTestStep;
                table.Result = Runner.ResultLabel;
                table.InsertDataTestStepResult();
                Runner.ResultLogic = true;
            }
            catch (System.Exception)
            {
                Runner.ResultLogic = false;
            }
        }

        public static void SaveTestCase(string URL)
        {
            Runner.URL = URL;
            if (Runner.ResultLogic == true)
            {
                SaveData.TestCasePass();
            }
            else
            {
                SaveData.TestCaseFail();
            }
        }

        private static void SaveTestCase()
        {
            try
            {
                TableTestCaseResult table = new TableTestCaseResult();
                table.TestCaseId = Runner.TestCase;
                table.ExecutedType = Runner.TestMode;
                table.URL = Runner.URL;
                table.Message = Runner.MessageTestCase;
                table.Result = Runner.ResultLabel;
                table.InsertDataTestCaseResult();
                Runner.ResultLogic = true;
            }
            catch (System.Exception)
            {
                Runner.ResultLogic = false;
            }
        }
    }
}
