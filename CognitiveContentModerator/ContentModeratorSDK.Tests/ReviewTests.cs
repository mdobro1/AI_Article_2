using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Microsoft.CognitiveServices.ContentModerator;
using Microsoft.CognitiveServices.ContentModerator.Contract.Review;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContentModeratorSDK.Test
{
    using System.Configuration;

    /// <summary>
    /// Summary description for ReviewTests
    /// </summary>
    [TestClass]
    public class ReviewTests
    {
        private readonly ReviewClient client = null;
        private readonly string testImageContent = @"Content\sample.jpg";
        private readonly string reviewTeamName;
        public ReviewTests()
        {
            this.client = new ReviewClient(ConfigurationManager.AppSettings["subscriptionkey"], ConfigurationManager.AppSettings["Review.ClientId"],ConfigurationManager.AppSettings["Review.ClientSecret"]);
            this.reviewTeamName = ConfigurationManager.AppSettings["Review.TeamName"];
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void GetReviewDetails()
        {
            var lastReviewId = File.ReadAllText(Path.Combine(Path.GetTempPath(), "LastReviewCache.tmp"));
            Assert.IsNotNull(lastReviewId);

            var task = this.client.GetReview(this.reviewTeamName, lastReviewId);
            var result = task.Result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Status == "Complete");
        }

        [TestMethod]
        public void CreateReview()
        {            
            var result = CreateReviewJob(false, false);

            if (result != null && result.Length > 0)
            {
                File.WriteAllText(Path.Combine(Path.GetTempPath(), "LastReviewCache.tmp"), result[0]);
            }              

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }

        private string[] CreateReviewJob(bool adult, bool racy)
        {
            List<ReviewRequest> revrequests = new List<ReviewRequest>();
            List<KeyValue> mData = new List<KeyValue>();

      
                KeyValue kv = new KeyValue()
                {
                    Key = "a",
                    Value = adult.ToString()
                };
                mData.Add(kv);
                kv = new KeyValue()
                {
                    Key = "r",
                    Value = racy.ToString()
                };
                mData.Add(kv);
            

            ReviewRequest req1 = new ReviewRequest()
            {
                CallbackEndpoint = string.Empty,
                Content = "https://moderatorsampleimages.blob.core.windows.net/samples/sample.jpg",
                ContentId = "sample.jpg",
                Type = ContentType.Image,
                Metadata = mData
            };
            revrequests.Add(req1);
            var task = this.client.CreateReview(this.reviewTeamName, revrequests);
            var result = task.Result;
            return result;
        }


        [TestMethod]
        public void GetJobDetails()
        {
            var task = this.client.GetJobDetails(this.reviewTeamName, "<JobId>");
            var result = task.Result;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateJob()
        {
            var task = this.client.CreateJob(this.reviewTeamName, "https://hashblobsm2.blob.core.windows.net/testimages/BMPOCR.bmp", ContentType.Image,
                "ABC.jpg", "default", "");
            var result = task.Result;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateJobStream()
        {
            CreateJobResult result = null;
            using (Stream stream = new FileStream(this.testImageContent, FileMode.Open, FileAccess.Read))
            {
                var task = this.client.CreateJob(this.reviewTeamName, stream, ContentType.Image,
                "ABC.jpg", "default", "");
                result = task.Result;
            }
            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllTeamWorkflows()
        {
            var task = this.client.GetAllWorkflows(this.reviewTeamName);
            var result = task.Result;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetTeamWorkflow()
        {
            var task = this.client.GetWorkflow(this.reviewTeamName, "default");
            var result = task.Result;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateWorkFlowSimple()
        {
            Condition condition = new Condition()
            {
                ConnectorName = "imagemoderator",
                OutputName = "adultscore",
                Operator = ConditionOperator.ge,
                Value = "0.4"
            };


            var task = this.client.CreateWorkFlow(this.reviewTeamName, "MySimpleWorkFlow", "This is a simple workflow", condition);
            var result = task.Result;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CreateWorkFlowComplex()
        {
            Condition c1 = new Condition()
            {
                ConnectorName = "imagemoderator",
                OutputName = "isadult",
                Operator = ConditionOperator.eq,
                Value = "true"
            };

            Condition c2 = new Condition()
            {
                ConnectorName = "imagemoderator",
                OutputName = "isracy",
                Operator = ConditionOperator.eq,
                Value = "true"
            };

            Condition c3 = new Condition()
            {
                ConnectorName = "imagemoderator",
                OutputName = "adultscore",
                Operator = ConditionOperator.ge,
                Value = "0.4"
            };

            Condition c4 = new Condition()
            {
                ConnectorName = "imagemoderator",
                OutputName = "racyscore",
                Operator = ConditionOperator.ge,
                Value = "0.5"
            };

            Combination combine1 = new Combination()
            {
                Left = c1,
                Combine = CombineCondition.AND,
                Right = c3,
            };

            Combination combine2 = new Combination()
            {
                Left = c2,
                Combine = CombineCondition.AND,
                Right = c4,
            };

            Combination parent = new Combination()
            {
                Left = combine1,
                Combine = CombineCondition.OR,
                Right = combine2
            };

            var task = this.client.CreateWorkFlow(this.reviewTeamName, "MyComplexWorkflow", "This is a complex workflow", parent);
            var result = task.Result;
            Assert.IsTrue(result);
        }

    }
}
