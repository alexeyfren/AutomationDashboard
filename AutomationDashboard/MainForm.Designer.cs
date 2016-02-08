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
            this.label_Brabch = new System.Windows.Forms.Label();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.zedGraphControl_TestPassFail = new ZedGraph.ZedGraphControl();
            this.label_TestGraph = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.splitContainerMain.Size = new System.Drawing.Size(1055, 547);
            this.splitContainerMain.SplitterDistance = 150;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView_Tests
            // 
            this.treeView_Tests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.treeView_Tests.Location = new System.Drawing.Point(3, 3);
            this.treeView_Tests.Name = "treeView_Tests";
            this.treeView_Tests.Size = new System.Drawing.Size(144, 541);
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
            this.tableLayoutPanel2.Controls.Add(this.label_TestGraph, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 547);
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
            this.zedGraphControl_TestsCount.Size = new System.Drawing.Size(444, 240);
            this.zedGraphControl_TestsCount.TabIndex = 0;
            // 
            // zedGraphControl_TestSets
            // 
            this.zedGraphControl_TestSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestSets.Location = new System.Drawing.Point(453, 28);
            this.zedGraphControl_TestSets.Name = "zedGraphControl_TestSets";
            this.zedGraphControl_TestSets.ScrollGrace = 0D;
            this.zedGraphControl_TestSets.ScrollMaxX = 0D;
            this.zedGraphControl_TestSets.ScrollMaxY = 0D;
            this.zedGraphControl_TestSets.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestSets.ScrollMinX = 0D;
            this.zedGraphControl_TestSets.ScrollMinY = 0D;
            this.zedGraphControl_TestSets.ScrollMinY2 = 0D;
            this.zedGraphControl_TestSets.Size = new System.Drawing.Size(445, 240);
            this.zedGraphControl_TestSets.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label_Brabch, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_Branch, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 25);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label_Brabch
            // 
            this.label_Brabch.AutoSize = true;
            this.label_Brabch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Brabch.Location = new System.Drawing.Point(3, 0);
            this.label_Brabch.Name = "label_Brabch";
            this.label_Brabch.Size = new System.Drawing.Size(44, 25);
            this.label_Brabch.TabIndex = 0;
            this.label_Brabch.Text = "Branch:";
            this.label_Brabch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(53, 3);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(89, 21);
            this.comboBox_Branch.TabIndex = 1;
            this.comboBox_Branch.SelectedValueChanged += new System.EventHandler(this.comboBox_Branch_SelectedValueChanged);
            // 
            // zedGraphControl_TestPassFail
            // 
            this.zedGraphControl_TestPassFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl_TestPassFail.Location = new System.Drawing.Point(3, 304);
            this.zedGraphControl_TestPassFail.Name = "zedGraphControl_TestPassFail";
            this.zedGraphControl_TestPassFail.ScrollGrace = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxX = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxY = 0D;
            this.zedGraphControl_TestPassFail.ScrollMaxY2 = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinX = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinY = 0D;
            this.zedGraphControl_TestPassFail.ScrollMinY2 = 0D;
            this.zedGraphControl_TestPassFail.Size = new System.Drawing.Size(444, 240);
            this.zedGraphControl_TestPassFail.TabIndex = 3;
            this.zedGraphControl_TestPassFail.Visible = false;
            // 
            // label_TestGraph
            // 
            this.label_TestGraph.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label_TestGraph, 2);
            this.label_TestGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TestGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_TestGraph.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_TestGraph.Location = new System.Drawing.Point(3, 271);
            this.label_TestGraph.Name = "label_TestGraph";
            this.label_TestGraph.Size = new System.Drawing.Size(895, 30);
            this.label_TestGraph.TabIndex = 4;
            this.label_TestGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 547);
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
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ZedGraph.ZedGraphControl zedGraphControl_TestsCount;
        private ZedGraph.ZedGraphControl zedGraphControl_TestSets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_Brabch;
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private ZedGraph.ZedGraphControl zedGraphControl_TestPassFail;
        private System.Windows.Forms.Label label_TestGraph;
        private System.Windows.Forms.TreeView treeView_Tests;
    }
}

