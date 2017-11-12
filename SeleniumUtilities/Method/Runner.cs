using SeleniumUtilities.Definition;
using System;

namespace SeleniumUtilities
{
    public class Runner
    {
        private static DateTime startTestStepTime;
        private static DateTime startTestCaseTime;
        private static string sMessage;
        private static string sTestMode = TestModeOption.Default;
        private static string sDevelopmentProcess = DevelopmentProcessOption.Default;
        private static int iTestStep;
        private static int iTestCase;
        private static int iCountTestStepPass;
        private static int iCountTestStepAll;
        public static bool ResultLogic { get; set; }
        public static void Pass() { ResultLogic = true; }
        public static void Fail() { ResultLogic = false; }
        public static string ResultLabel
        {
            get
            {
                return ResultLogic == true ? "PASS" : "FAIL";
            }
        }
        public static string MessageTestStep
        {
            get
            {
                return string.Format("Step {0}: {1}", Runner.TestStep, sMessage);
            }
            set
            {
                sMessage = value;
            }
        }
        public static string MessageTestCase
        {
            get
            {
                return string.Format("Test result of running test case {0:00-0000}", Runner.TestCase);
            }
        }
        public static string TestMode
        {
            get { return sTestMode; }
            set { sTestMode = value; }
        }
        public static string URL { get; set; }
        public static int TestCase { get { return iTestCase; } }
        public static int TestStep { get { return iTestStep; } }
        public static double IndexTimeTestStep
        {
            get
            {
                TimeSpan difference = DateTime.Now - startTestStepTime;
                return difference.TotalHours * 60 * 60 + difference.TotalMinutes * 60 + difference.TotalSeconds;
            }
        }
        public static double IndexTimeTestCase
        {
            get
            {
                TimeSpan difference = DateTime.Now - startTestCaseTime;
                return difference.TotalHours * 60 * 60 + difference.TotalMinutes * 60 + difference.TotalSeconds;
            }
        }
        public static string DevelopmentProcess
        {
            get
            {
                return sDevelopmentProcess;
            }
            set
            {
                sDevelopmentProcess = value;
            }
        }
        public static void SaveTestCase()
        {
            SaveData.SaveTestCase(URL);
        }
        public static void StartTestStep(int TestStep)
        {
            Fail();
            iTestStep = TestStep;
            startTestStepTime = DateTime.Now;
        }
        public static void StartTestCase(int TestCase)
        {
            Fail();
            iTestCase = TestCase;
            iCountTestStepPass = 0;
            iCountTestStepAll = 0;
            startTestCaseTime = DateTime.Now;
        }
    }
}
