using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BusinessRulesEngine.Program;

namespace BusinessRulesEngine
{
    class Program
    {
       

        static void Main(string[] args)
        {
           


            Console.WriteLine("Welcome to Business Rules Engines");
            Console.WriteLine("----------------------------------------");
            List<Rules> RuleSet = GetRuleSet();
            foreach (Rules item in RuleSet)
            {
                Console.WriteLine(item.RuleId + " - " + item.Rule);
            };

            Console.WriteLine("Please choose a rule from above!");
            var ExecuteRule = "0";//= Console.ReadLine();
            while (ExecuteRule != "8")
            {

                ExecuteRule = Console.ReadLine();
                GetExecuteRule(ExecuteRule);
            }
             
        }

        private static void GetExecuteRule(string executeRule)
        {
            List<Rules> RuleSet = GetRuleSet();
            var OrderNo = "SJHKS2332";
            switch (executeRule)
            {
                 
                case "1":
                    // Console.WriteLine("1st case");
                   
                    GeneratePackSlip(OrderNo);
                    break;
                case "2":
                    //Console.WriteLine("2st case");
                    GenerateDuplPackingSlip(OrderNo); 
                    break;
                case "3":
                    //Console.WriteLine("3st case");
                    AtivateMembership(OrderNo);
                    break;
                case "4":
                    //Console.WriteLine("4st case");
                    UpgradeMembership(OrderNo);
                    break;
                case "5":
                    //Console.WriteLine("5st case");
                    UpGradeNotifier(OrderNo);
                    break;
                case "6":
                    //Console.WriteLine("6st case");
                    VideoLearning(OrderNo);
                    break;
                case "7":
                    //Console.WriteLine("7st case");
                    GenerateAgencyCommission(OrderNo);
                    break;
                case "8":
                   // Console.WriteLine("8st case");
                    break;
            }
        }

        private static void GenerateAgencyCommission(string orderNo)
        {
            SyncCommisionDataOrder(orderNo);
            Console.WriteLine("Agency Commisionhas been send to the Agency Account and Email Genrated");
        }

        private static void SyncCommisionDataOrder(object orderNo0)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Agency Commission Send");
        }

        private static void VideoLearning(string orderNo)
        {
            var VideoURL = "https://url";
            PlayVideo(orderNo, VideoURL);

            Console.WriteLine("Added first Aid Video to the Learning Course Video");
        }

        private static void PlayVideo(string orderNo, object videoURL)
        {
            Console.WriteLine("Video played!");
        }

        private static void UpGradeNotifier(string orderNo)
        {
            GenerateEmailNotification(orderNo);
            Console.WriteLine("An Email has been generated to the Owner to notify the upgrade Or Membership");
        }

        private static void GenerateEmailNotification(string orderNo)
        {
            Console.WriteLine( orderNo.ToString()+": Email generated!");
        }

        private static void UpgradeMembership(string orderNo)
        {
            Console.WriteLine("Membership Upgrade has been completed Successfully!");
        }

        private static void AtivateMembership(string orderNo)
        {
            Console.WriteLine("Membership has been activated Successfully!");
        }

        private static void GenerateDuplPackingSlip(string orderNo)
        {
            Console.WriteLine("Duplicate Packing Slip for Royalty Department Has been Created Successfully!");
        }

        private static void GeneratePackSlip(string OrderID)
        {
            Console.WriteLine("Packing Slip for Shipping Has been Generated Successfully!");
        }

        public static List<Rules> GetRuleSet()
        {
            Rules Rule1 = new Rules
            {
                RuleId = 1,
                RuleName = "Pay_PhProduct",
                Rule = "Payment for Physical Product",
                State = true
            };
            Rules Rule2 = new Rules
            {
                RuleId = 2,
                RuleName = "Pay_Book",
                Rule = "Payment for Book",
                State = true
            };
            Rules Rule3 = new Rules
            {
                RuleId = 3,
                RuleName = "Pay_Membership",
                Rule = "Payment for Membership",
                State = true
            };
            Rules Rule4 = new Rules
            {
                RuleId = 4,
                RuleName = "Pay_UpgMembership",
                Rule = "Payment for Upgrade Membership",
                State = true
            };
            Rules Rule5 = new Rules
            {
                RuleId = 5,
                RuleName = "Pay_Activation",
                Rule = "Payment for Activation",
                State = true
            };
            Rules Rule6 = new Rules
            {
                RuleId = 6,
                RuleName = "Pay_Video",
                Rule = "Payment for Video Learning",
                State = true
            };
            Rules Rule7 = new Rules
            {
                RuleId = 7,
                RuleName = "Pay_new",
                Rule = "Payment for Book",
                State = true
            };
            Rules Rule0 = new Rules
            {
                RuleId = 8,
                RuleName = "Exit",
                Rule = "Exit Rule Engine",
                State = true
            };

            List<Rules> RuleSet = new List<Rules>();
            RuleSet.Add(Rule1);
            RuleSet.Add(Rule2);
            RuleSet.Add(Rule3);
            RuleSet.Add(Rule4);
            RuleSet.Add(Rule5);
            RuleSet.Add(Rule6);
            RuleSet.Add(Rule7);
            RuleSet.Add(Rule0);

            return RuleSet;
        }
        public class Rules
        {
            public int RuleId { get; set; }
            public string RuleName { get; set; }
            public string Rule { get; set; }
            public bool State { get; set; }
        }
    }
}
