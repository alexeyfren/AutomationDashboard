﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace AutomationDashboard
{
    public partial class MainForm : Form
    {
        MySqlClient m_MySql;
        public MainForm()
        {
            InitializeComponent();
            m_MySql = new MySqlClient(ConfigurationManager.AppSettings["ip"], ConfigurationManager.AppSettings["userName"], ConfigurationManager.AppSettings["password"], ConfigurationManager.AppSettings["database"]);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!m_MySql.IsConnected)
                this.Close();

            InitializeTestsTree();

            comboBox_Branch.Items.Add("All");
            comboBox_Branch.Items.AddRange(m_MySql.GetAllBranches());
            comboBox_Branch.SelectedIndex = 0;
        }

        public void InitializeTestsTree()
        {
            ImageList treeList = new ImageList();
            treeList.Images.Add("folder", Properties.Resources.folder);
            treeList.Images.Add("test", Properties.Resources.test);
            treeView_Tests.ImageList = treeList;

            treeView_Tests.Nodes.Add("Automation Test Cases");
            foreach (DataRow test in m_MySql.GetAllTests().Rows)
            {
                if (treeView_Tests.Nodes[0].Nodes.Find(test["TestCaseType"].ToString(), false).Length == 0)
                {
                    treeView_Tests.Nodes[0].Nodes.Add(test["TestCaseType"].ToString(), test["TestCaseType"].ToString());
                }

                TreeNode node = new TreeNode(test["TestCaseName"].ToString());
                node.Tag = test["ID"].ToString();
                node.ImageKey = "test";
                node.SelectedImageKey = "test";

                treeView_Tests.Nodes[0].Nodes[test["TestCaseType"].ToString()].Nodes.Add(node);
            }

            foreach (TreeNode node in treeView_Tests.Nodes[0].Nodes)
            {
                node.ImageKey = "folder";
                node.SelectedImageKey = "folder";
            }

            treeView_Tests.Nodes[0].Expand();
        }

        public void RefreshGraphs(string branch)
        {
            UpdateTestsCountChart(branch);
            UpdateTestsSetsChart(branch);

            if (treeView_Tests.SelectedNode != null && treeView_Tests.SelectedNode.Tag != null)
            { 
                zedGraphControl_TestPassFail.Visible = true;
                UpdateTestPassFailChart(branch, treeView_Tests.SelectedNode.Tag.ToString(), treeView_Tests.SelectedNode.Text.ToString());
            }
            else
                zedGraphControl_TestPassFail.Visible = false;
        }

        public void UpdateTestsCountChart(string branch)
        {
            GraphPane myPane = zedGraphControl_TestsCount.GraphPane;
            myPane.CurveList.Clear();
            zedGraphControl_TestsCount.Refresh();

            Dictionary<DateTime, double> ret = m_MySql.GetTestsCountByDate(branch);
            if (ret.Count == 0)
                return;

            List<double> vals = new List<double>();
            List<double> dates = new List<double>();

            foreach (DateTime rec in ret.Keys)
            {
                dates.Add(new XDate(rec));
                vals.Add(ret[rec]);
            }

            zedGraphControl_TestsCount.IsShowPointValues = true;
            zedGraphControl_TestsCount.PointValueFormat = "0";

            myPane.Title.Text = "Sanity tests count per time";
            myPane.Fill = new Fill(Color.Snow, Color.LightGoldenrodYellow, Color.Snow);

            myPane.XAxis.Title.Text = "Time (days)";
            myPane.XAxis.Type = AxisType.Date;
            myPane.XAxis.Scale.Format = "dd.MM.yy";
            myPane.XAxis.Scale.FontSpec.Angle = 45;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.Scale.MajorUnit = DateUnit.Day;

            myPane.XAxis.Scale.MajorStep = ret.Count / 12;
            myPane.XAxis.Scale.MinorStep = ret.Count / 24;
            myPane.XAxis.Scale.Min = new XDate(ret.Keys.First());
            myPane.XAxis.Scale.Max = new XDate(ret.Keys.Last());

            myPane.YAxis.Title.Text = "Count of tests";
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.Scale.Format = "F0";

            LineItem pointsCurve = myPane.AddCurve("All tests", dates.ToArray(), vals.ToArray(), Color.Blue, SymbolType.Star);
            pointsCurve.Line.IsVisible = true;
            pointsCurve.Line.Width = 3.0F;

            zedGraphControl_TestsCount.AxisChange();
            zedGraphControl_TestsCount.Refresh();
        }

        public void UpdateTestsSetsChart(string branch)
        {
            GraphPane myPane = zedGraphControl_TestSets.GraphPane;
            myPane.CurveList.Clear();
            zedGraphControl_TestSets.Refresh();

            Dictionary<DateTime, List<double>> ret = m_MySql.GetPassFailTestsCountByDate(branch);
            if (ret.Count == 0)
                return;

            List<double> passed = new List<double>();
            List<double> failed = new List<double>();
            List<string> dates = new List<string>();

            foreach (DateTime rec in ret.Keys)
            {
                dates.Add(rec.ToShortDateString());
                passed.Add(ret[rec][0]);
                failed.Add(ret[rec][1]);
            }

            myPane.BarSettings.Type = BarType.Stack;
            myPane.Title.Text = "Sanity tests status per execution";
            myPane.Fill = new Fill(Color.Snow, Color.LightGoldenrodYellow, Color.Snow);
            zedGraphControl_TestSets.IsShowPointValues = true;
            zedGraphControl_TestSets.PointValueFormat = "0";

            myPane.XAxis.Title.Text = "Execution (days)";
            myPane.XAxis.Type = AxisType.Text;
            myPane.XAxis.Scale.Format = "dd.MM.yy";
            myPane.XAxis.Scale.FontSpec.Angle = 45;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.Scale.TextLabels = dates.ToArray();

            myPane.YAxis.Title.Text = "Count of pass and fail tests";
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MinorGrid.IsVisible = true;

            BarItem passedBar = myPane.AddBar("Passed", null, passed.ToArray(), Color.Green);
            BarItem failedBar = myPane.AddBar("Failed", null, failed.ToArray(), Color.Red);
            passedBar.IsVisible = true;
            failedBar.IsVisible = true;

            zedGraphControl_TestSets.AxisChange();
            zedGraphControl_TestSets.Refresh();
        }

        public void UpdateTestPassFailChart(string branch, string testID, string testName)
        {
            GraphPane myPane = zedGraphControl_TestPassFail.GraphPane;
            myPane.CurveList.Clear();
            zedGraphControl_TestPassFail.Refresh();

            double passed = m_MySql.GetTestStatusCountByDate(branch, testID, "PASS");
            double failed = m_MySql.GetTestStatusCountByDate(branch, testID, "FAIL");

            if (passed == 0 && failed == 0)
                return;

            myPane.Title.Text = "[" + testName + "]" + " PASSED/FAILED executions count";
            myPane.Fill = new Fill(Color.Snow, Color.LightGoldenrodYellow, Color.Snow);
            zedGraphControl_TestSets.IsShowPointValues = true;
            zedGraphControl_TestSets.PointValueFormat = "0";

            PieItem passedPie = myPane.AddPieSlice(passed, Color.Green, 0.2, "Passed");
            passedPie.IsVisible = true;
            passedPie.LabelType = PieLabelType.Name_Value_Percent;

            PieItem failedPie = myPane.AddPieSlice(failed, Color.Red, 0.05, "Failed");
            failedPie.IsVisible = true;
            failedPie.LabelType = PieLabelType.Name_Value_Percent;

            zedGraphControl_TestPassFail.AxisChange();
            zedGraphControl_TestPassFail.Refresh();
        }

        private void comboBox_Branch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Branch.SelectedItem.ToString() == null)
                return;

            RefreshGraphs(comboBox_Branch.SelectedItem.ToString());
        }

        private void treeView_Tests_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView_Tests.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right)
                return;
            else
            {
                if (treeView_Tests.SelectedNode != null && treeView_Tests.SelectedNode.Tag != null)
                {
                    zedGraphControl_TestPassFail.Visible = true;
                    label_TestGraph.Text = "Charts fot test case: " + treeView_Tests.SelectedNode.Text;
                    label_TestGraph.Text += "";
                    UpdateTestPassFailChart(comboBox_Branch.SelectedItem.ToString(), treeView_Tests.SelectedNode.Tag.ToString(), treeView_Tests.SelectedNode.Text.ToString());
                }
                else
                {
                    zedGraphControl_TestPassFail.Visible = false;
                    label_TestGraph.Text = "";
                }
            }
        }
    }
}