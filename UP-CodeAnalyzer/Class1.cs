using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Activities;
using System.ComponentModel;

namespace CodeAnalyzer
{
    public class ReadXAML: CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> FileName { get; set; }

        [Category("Output")]
        public OutArgument<XDocument> WorkflowData { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //======= Variables =======

            var strFileName = FileName.Get(context);
            var xmlWorkflowData = new XDocument();


            //======= Read XAML File =======

            // To be implemented


            //======= Set Output =======

            WorkflowData.Set(context, xmlWorkflowData);
        }
    }

    public class AnalyzeXAML : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<XDocument> WorkflowData { get; set; }

        [Category("Output")]
        public OutArgument<XDocument> StructData { get; set; }

        [Category("Output")]
        public OutArgument<DataTable> IssueList { get; set; }

        [Category("Output")]
        public OutArgument<DataTable> StatList { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //======= Variables =======

            var xmlWorkflowData = WorkflowData.Get(context);
            var xmlStructData = new XDocument();
            var dtIssueList = new DataTable();
            var dtStatList = new DataTable();


            //======= Analyze XAML Data =======

            // To be implemented


            //======= Set Output =======

            StructData.Set(context, xmlStructData);
            IssueList.Set(context, dtIssueList);
            StatList.Set(context, dtStatList);
        }
    }
}
