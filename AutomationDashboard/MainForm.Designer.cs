namespace AutomationDashboard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_Tests = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraphControl_TestsCount = new ZedGraph.ZedGraphControl();
            this.zedGraphControl_TestSets = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Branch = new System.Windows.Forms.Label();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.label_Node = new System.Windows.Forms.Label();
            this.comboBox_Node = new System.Windows.Forms.ComboBox();
            this.zedGraphControl_TestPassFail = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalTests = new System.Windows.Forms.Label();
            this.label_TotalExecutionsCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ChartForTest = new System.Windows.Forms.Label();
            this.label_TestName = new System.Windows.Forms.Label();
            this.label_TestTotalExecutions = new System.Windows.Forms.Label();
            this.label_TestTotalExecutionsCount = new System.Windows.Forms.Label();
            this.zedGraphControl_TestPassFailByExecution = new ZedGraph.ZedGraphControl();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMain.Panel1MinSize = 130;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainerMain.Size = new System.Drawing.Size(1480, 588);
            this.splitContainerMain.SplitterDistance = 130;
            this.splitContainerMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeView_Tests, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 588);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView_Tests
            // 
            this.treeView_Tests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.treeView_Tests.Location = new System.Drawing.Point(3, 3);
            this.treeView_Tests.Name = "treeView_Tests";
            this.treeView_Tests.Size = new System.Drawing.Size(124, 582);
            this.treeView_Tests.TabIndex = 1;
            this.treeView_Tests.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Tests_NodeMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.zedGraphControl_TestsCount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.zedGraphControl_TestSets, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.zedGraphControl_TestPassFail, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.zedGraphControl_TestPassFailByExecution, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1346, 588);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // zedGraphControl_TestsCount
            // 
            this.zedGraphControl_TestsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestsCount.Location = new System.Drawing.Point(3, 28);
            this.zedGraphControl_TestsCount.Name = "zedGraphControl_TestsCount";
            this.zedGraphControl_TestsCount.ScrollGrace = 0D;
            this.zedGraphControl_TestsCount.ScrollMaxX = 0D;
            this.zedGraphControl_TestsCount.ScrollMaxY = 0D;
            this.zedGraphControl_TestsCount.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestsCount.ScrollMinX = 0D;
            this.zedGraphControl_TestsCount.ScrollMinY = 0D;
            this.zedGraphControl_TestsCount.ScrollMinY2 = 0D;
            this.zedGraphControl_TestsCount.Size = new System.Drawing.Size(667, 260);
            this.zedGraphControl_TestsCount.TabIndex = 0;
            // 
            // zedGraphControl_TestSets
            // 
            this.zedGraphControl_TestSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestSets.Location = new System.Drawing.Point(676, 28);
            this.zedGraphControl_TestSets.Name = "zedGraphControl_TestSets";
            this.zedGraphControl_TestSets.ScrollGrace = 0D;
            this.zedGraphControl_TestSets.ScrollMaxX = 0D;
            this.zedGraphControl_TestSets.ScrollMaxY = 0D;
            this.zedGraphControl_TestSets.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestSets.ScrollMinX = 0D;
            this.zedGraphControl_TestSets.ScrollMinY = 0D;
            this.zedGraphControl_TestSets.ScrollMinY2 = 0D;
            this.zedGraphControl_TestSets.Size = new System.Drawing.Size(667, 260);
            this.zedGraphControl_TestSets.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label_Branch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Branch, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Node, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Node, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_To, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_From, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker_From, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker_To, 8, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(673, 25);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label_Branch
            // 
            this.label_Branch.AutoSize = true;
            this.label_Branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Branch.Location = new System.Drawing.Point(3, 0);
            this.label_Branch.Name = "label_Branch";
            this.label_Branch.Size = new System.Drawing.Size(51, 25);
            this.label_Branch.TabIndex = 0;
            this.label_Branch.Text = "Branch:";
            this.label_Branch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(60, 3);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Branch.TabIndex = 1;
            this.comboBox_Branch.SelectedValueChanged += new System.EventHandler(this.comboBox_Branch_SelectedValueChanged);
            // 
            // label_Node
            // 
            this.label_Node.AutoSize = true;
            this.label_Node.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Node.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Node.Location = new System.Drawing.Point(148, 0);
            this.label_Node.Name = "label_Node";
            this.label_Node.Size = new System.Drawing.Size(41, 25);
            this.label_Node.TabIndex = 2;
            this.label_Node.Text = "Node:";
            this.label_Node.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Node
            // 
            this.comboBox_Node.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Node.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Node.FormattingEnabled = true;
            this.comboBox_Node.Items.AddRange(new object[] {
            "All",
            "Single",
            "Three"});
            this.comboBox_Node.Location = new System.Drawing.Point(195, 3);
            this.comboBox_Node.Name = "comboBox_Node";
            this.comboBox_Node.Size = new System.Drawing.Size(68, 21);
            this.comboBox_Node.TabIndex = 3;
            this.comboBox_Node.SelectedValueChanged += new System.EventHandler(this.comboBox_Node_SelectedValueChanged);
            // 
            // zedGraphControl_TestPassFail
            // 
            this.zedGraphControl_TestPassFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestPassFail.Location = new System.Drawing.Point(3, 324);
            this.zedGraphControl_TestPassFail.Name = "zedGraphControl_TestPassFail";
            this.zedGraphControl_TestPassFail.ScrollGrace = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxX = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxY = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinX = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinY = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinY2 = 0D;
            this.zedGraphControl_TestPassFail.Size = new System.Drawing.Size(667, 261);
            this.zedGraphControl_TestPassFail.TabIndex = 3;
            this.zedGraphControl_TestPassFail.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_TotalTests, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_TotalExecutionsCount, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(673, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(673, 25);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total tests:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(152, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total executions:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TotalTests
            // 
            this.label_TotalTests.AutoSize = true;
            this.label_TotalTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TotalTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TotalTests.ForeColor = System.Drawing.Color.Blue;
            this.label_TotalTests.Location = new System.Drawing.Point(102, 0);
            this.label_TotalTests.Name = "label_TotalTests";
            this.label_TotalTests.Size = new System.Drawing.Size(44, 25);
            this.label_TotalTests.TabIndex = 7;
            this.label_TotalTests.Text = "0";
            this.label_TotalTests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TotalExecutionsCount
            // 
            this.label_TotalExecutionsCount.AutoSize = true;
            this.label_TotalExecutionsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TotalExecutionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TotalExecutionsCount.ForeColor = System.Drawing.Color.Blue;
            this.label_TotalExecutionsCount.Location = new System.Drawing.Point(296, 0);
            this.label_TotalExecutionsCount.Name = "label_TotalExecutionsCount";
            this.label_TotalExecutionsCount.Size = new System.Drawing.Size(39, 25);
            this.label_TotalExecutionsCount.TabIndex = 8;
            this.label_TotalExecutionsCount.Text = "0";
            this.label_TotalExecutionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label_ChartForTest, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_TestName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_TestTotalExecutions, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_TestTotalExecutionsCount, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 294);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(667, 24);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label_ChartForTest
            // 
            this.label_ChartForTest.AutoSize = true;
            this.label_ChartForTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ChartForTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ChartForTest.Location = new System.Drawing.Point(3, 0);
            this.label_ChartForTest.Name = "label_ChartForTest";
            this.label_ChartForTest.Size = new System.Drawing.Size(123, 24);
            this.label_ChartForTest.TabIndex = 0;
            this.label_ChartForTest.Text = "Charts for test: ";
            this.label_ChartForTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TestName
            // 
            this.label_TestName.AutoSize = true;
            this.label_TestName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TestName.ForeColor = System.Drawing.Color.Blue;
            this.label_TestName.Location = new System.Drawing.Point(132, 0);
            this.label_TestName.Name = "label_TestName";
            this.label_TestName.Size = new System.Drawing.Size(344, 24);
            this.label_TestName.TabIndex = 1;
            this.label_TestName.Text = "Test";
            this.label_TestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TestTotalExecutions
            // 
            this.label_TestTotalExecutions.AutoSize = true;
            this.label_TestTotalExecutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TestTotalExecutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TestTotalExecutions.Location = new System.Drawing.Point(482, 0);
            this.label_TestTotalExecutions.Name = "label_TestTotalExecutions";
            this.label_TestTotalExecutions.Size = new System.Drawing.Size(140, 24);
            this.label_TestTotalExecutions.TabIndex = 2;
            this.label_TestTotalExecutions.Text = "Total executions:";
            this.label_TestTotalExecutions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TestTotalExecutionsCount
            // 
            this.label_TestTotalExecutionsCount.AutoSize = true;
            this.label_TestTotalExecutionsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TestTotalExecutionsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TestTotalExecutionsCount.ForeColor = System.Drawing.Color.Blue;
            this.label_TestTotalExecutionsCount.Location = new System.Drawing.Point(628, 0);
            this.label_TestTotalExecutionsCount.Name = "label_TestTotalExecutionsCount";
            this.label_TestTotalExecutionsCount.Size = new System.Drawing.Size(36, 24);
            this.label_TestTotalExecutionsCount.TabIndex = 3;
            this.label_TestTotalExecutionsCount.Text = "0";
            this.label_TestTotalExecutionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zedGraphControl_TestPassFailByExecution
            // 
            this.zedGraphControl_TestPassFailByExecution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestPassFailByExecution.Location = new System.Drawing.Point(676, 324);
            this.zedGraphControl_TestPassFailByExecution.Name = "zedGraphControl_TestPassFailByExecution";
            this.zedGraphControl_TestPassFailByExecution.ScrollGrace = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMaxX = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMaxY = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMinX = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMinY = 0D;
            this.zedGraphControl_TestPassFailByExecution.ScrollMinY2 = 0D;
            this.zedGraphControl_TestPassFailByExecution.Size = new System.Drawing.Size(667, 261);
            this.zedGraphControl_TestPassFailByExecution.TabIndex = 7;
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_From.Location = new System.Drawing.Point(294, 0);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(39, 25);
            this.label_From.TabIndex = 4;
            this.label_From.Text = "From:";
            this.label_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_To.Location = new System.Drawing.Point(441, 0);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(27, 25);
            this.label_To.TabIndex = 5;
            this.label_To.Text = "To:";
            this.label_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(339, 3);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_From.TabIndex = 6;
            this.dateTimePicker_From.Value = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePicker_From_ValueChanged);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(474, 3);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_To.TabIndex = 7;
            this.dateTimePicker_To.Value = new System.DateTime(2016, 9, 4, 16, 24, 40, 0);
            this.dateTimePicker_To.ValueChanged += new System.EventHandler(this.dateTimePicker_To_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 588);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainForm";
            this.Text = "Automation Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ZedGraph.ZedGraphControl zedGraphControl_TestsCount;
        private ZedGraph.ZedGraphControl zedGraphControl_TestSets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_Branch;
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private ZedGraph.ZedGraphControl zedGraphControl_TestPassFail;
        private System.Windows.Forms.TreeView treeView_Tests;
        private System.Windows.Forms.Label label_Node;
        private System.Windows.Forms.ComboBox comboBox_Node;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalTests;
        private System.Windows.Forms.Label label_TotalExecutionsCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_ChartForTest;
        private System.Windows.Forms.Label label_TestName;
        private System.Windows.Forms.Label label_TestTotalExecutions;
        private System.Windows.Forms.Label label_TestTotalExecutionsCount;
        private ZedGraph.ZedGraphControl zedGraphControl_TestPassFailByExecution;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
    }
}

