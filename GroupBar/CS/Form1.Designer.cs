#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace GroupBarDemo_2005
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable2 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageOutlook = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbProcess = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.lblEquation = new System.Windows.Forms.Label();
            this.lblTol = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.gbAlgorithm = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.itemBisection = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemFixedPoint = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemNewton = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemSecant = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemFalsePosition = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemMuller = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemLagrangeInter = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemNewtonInter = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemCubicInter = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemCubicInter2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemNumericDiferential = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemIntegrationTrapezoid = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemIntegrationSimpson = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemIntegrationGauss = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemEuler = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemEdoRunge = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemEdoRunge2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemEquationGauss = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemDescompLU = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemEquationInverse = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemLinealRegretion = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.itemFiniteDiferential = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scrollersFrame2 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageOutlook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAlgorithm)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1333, 669);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.BorderVisible = true;
            this.tabControlAdv1.Controls.Add(this.tabPageOutlook);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(10, 10);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(1333, 669);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemesEnabled = true;
            // 
            // tabPageOutlook
            // 
            this.tabPageOutlook.BackColor = System.Drawing.Color.White;
            this.tabPageOutlook.Controls.Add(this.btnExecute);
            this.tabPageOutlook.Controls.Add(this.groupBox3);
            this.tabPageOutlook.Controls.Add(this.groupBox2);
            this.tabPageOutlook.Controls.Add(this.groupBox1);
            this.tabPageOutlook.Controls.Add(this.lblAlgorithm);
            this.tabPageOutlook.Controls.Add(this.gbAlgorithm);
            this.tabPageOutlook.Image = null;
            this.tabPageOutlook.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageOutlook.Location = new System.Drawing.Point(2, 23);
            this.tabPageOutlook.Name = "tabPageOutlook";
            this.tabPageOutlook.ShowCloseButton = true;
            this.tabPageOutlook.Size = new System.Drawing.Size(1329, 644);
            this.tabPageOutlook.TabIndex = 3;
            this.tabPageOutlook.Text = "Algorithm`s Selection";
            this.tabPageOutlook.ThemesEnabled = false;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExecute.FlatAppearance.BorderSize = 2;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExecute.Font = new System.Drawing.Font("Segoe WP Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExecute.Location = new System.Drawing.Point(1214, 88);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(98, 534);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Calcular";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox3.Location = new System.Drawing.Point(370, 550);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salida";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.txtAns);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(35, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 47);
            this.panel3.TabIndex = 6;
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAns.Location = new System.Drawing.Point(136, 9);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(378, 24);
            this.txtAns.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Respuesta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(370, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 299);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proceso";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rtbProcess);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(35, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 254);
            this.panel2.TabIndex = 0;
            // 
            // rtbProcess
            // 
            this.rtbProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbProcess.Location = new System.Drawing.Point(32, 16);
            this.rtbProcess.Name = "rtbProcess";
            this.rtbProcess.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbProcess.Size = new System.Drawing.Size(701, 223);
            this.rtbProcess.TabIndex = 0;
            this.rtbProcess.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(370, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtC);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.lblIteration);
            this.panel1.Controls.Add(this.txtIteration);
            this.panel1.Controls.Add(this.txtB);
            this.panel1.Controls.Add(this.txtTolerance);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.txtEquation);
            this.panel1.Controls.Add(this.lblEquation);
            this.panel1.Controls.Add(this.lblTol);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 107);
            this.panel1.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(589, 64);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(161, 25);
            this.txtC.TabIndex = 11;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(547, 64);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 17);
            this.lblC.TabIndex = 10;
            this.lblC.Text = "c:";
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Location = new System.Drawing.Point(547, 18);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(27, 17);
            this.lblIteration.TabIndex = 9;
            this.lblIteration.Text = "Nº:";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(589, 10);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(161, 25);
            this.txtIteration.TabIndex = 8;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(339, 64);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(174, 25);
            this.txtB.TabIndex = 7;
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(100, 64);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(133, 25);
            this.txtTolerance.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(339, 10);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(174, 25);
            this.txtA.TabIndex = 5;
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(100, 9);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(133, 25);
            this.txtEquation.TabIndex = 4;
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Location = new System.Drawing.Point(15, 18);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(64, 17);
            this.lblEquation.TabIndex = 3;
            this.lblEquation.Text = "Ecuación:";
            // 
            // lblTol
            // 
            this.lblTol.AutoSize = true;
            this.lblTol.Location = new System.Drawing.Point(15, 70);
            this.lblTol.Name = "lblTol";
            this.lblTol.Size = new System.Drawing.Size(28, 17);
            this.lblTol.TabIndex = 2;
            this.lblTol.Text = "Tol:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(251, 64);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(251, 12);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.BackColor = System.Drawing.Color.White;
            this.lblAlgorithm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.ForeColor = System.Drawing.Color.Purple;
            this.lblAlgorithm.Location = new System.Drawing.Point(676, 13);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(0, 37);
            this.lblAlgorithm.TabIndex = 2;
            // 
            // gbAlgorithm
            // 
            this.gbAlgorithm.AllowCollapse = true;
            this.gbAlgorithm.AllowDrop = true;
            this.gbAlgorithm.AnimatedSelection = false;
            this.gbAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbAlgorithm.BeforeTouchSize = new System.Drawing.Size(283, 644);
            this.gbAlgorithm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.gbAlgorithm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gbAlgorithm.CollapseImage = ((System.Drawing.Image)(resources.GetObject("gbAlgorithm.CollapseImage")));
            this.gbAlgorithm.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbAlgorithm.ExpandButtonToolTip = null;
            this.gbAlgorithm.ExpandImage = ((System.Drawing.Image)(resources.GetObject("gbAlgorithm.ExpandImage")));
            this.gbAlgorithm.FlatLook = true;
            this.gbAlgorithm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbAlgorithm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.gbAlgorithm.GroupBarDropDownToolTip = null;
            this.gbAlgorithm.GroupBarItemHeight = 30;
            this.gbAlgorithm.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.itemBisection,
            this.itemFixedPoint,
            this.itemNewton,
            this.itemSecant,
            this.itemFalsePosition,
            this.itemMuller,
            this.itemLagrangeInter,
            this.itemNewtonInter,
            this.itemCubicInter,
            this.itemCubicInter2,
            this.itemNumericDiferential,
            this.itemIntegrationTrapezoid,
            this.itemIntegrationSimpson,
            this.itemIntegrationGauss,
            this.itemEuler,
            this.itemEdoRunge,
            this.itemEdoRunge2,
            this.itemEquationGauss,
            this.itemDescompLU,
            this.itemEquationInverse,
            this.itemLinealRegretion,
            this.itemFiniteDiferential});
            this.gbAlgorithm.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.gbAlgorithm.HeaderFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gbAlgorithm.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.gbAlgorithm.HeaderHeight = 0;
            this.gbAlgorithm.IndexOnVisibleItems = true;
            this.gbAlgorithm.Location = new System.Drawing.Point(0, 0);
            this.gbAlgorithm.MinimizeButtonToolTip = null;
            this.gbAlgorithm.Name = "gbAlgorithm";
            this.gbAlgorithm.NavigationPaneHeight = 0;
            this.gbAlgorithm.NavigationPaneTooltip = null;
            this.gbAlgorithm.PopupClientSize = new System.Drawing.Size(0, 0);
            this.gbAlgorithm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbAlgorithm.SelectedItem = 7;
            this.gbAlgorithm.Size = new System.Drawing.Size(283, 644);
            this.gbAlgorithm.Splittercolor = System.Drawing.SystemColors.ControlDark;
            this.gbAlgorithm.StackedMode = true;
            this.gbAlgorithm.TabIndex = 0;
            this.gbAlgorithm.Text = "groupBar1";
            this.gbAlgorithm.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.gbAlgorithm.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2010;
            this.gbAlgorithm.GroupBarItemSelected += new System.EventHandler(this.gbAlgorithm_GroupBarItemSelected);
            // 
            // itemBisection
            // 
            this.itemBisection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemBisection.Client = null;
            this.itemBisection.LargeImageMode = true;
            this.itemBisection.Text = "Método de Bisección";
            // 
            // itemFixedPoint
            // 
            this.itemFixedPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemFixedPoint.Client = null;
            this.itemFixedPoint.LargeImageMode = true;
            this.itemFixedPoint.Text = "Método de Punto Fijo ";
            // 
            // itemNewton
            // 
            this.itemNewton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemNewton.Client = null;
            this.itemNewton.LargeImageMode = true;
            this.itemNewton.Text = "Método de Newton ";
            // 
            // itemSecant
            // 
            this.itemSecant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemSecant.Client = null;
            this.itemSecant.LargeImageMode = true;
            this.itemSecant.Text = "Método de Secante";
            // 
            // itemFalsePosition
            // 
            this.itemFalsePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemFalsePosition.Client = null;
            this.itemFalsePosition.LargeImageMode = true;
            this.itemFalsePosition.Text = "Método de la Falsa Posición";
            // 
            // itemMuller
            // 
            this.itemMuller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemMuller.Client = null;
            this.itemMuller.LargeImageMode = true;
            this.itemMuller.Text = "Método de Müller";
            // 
            // itemLagrangeInter
            // 
            this.itemLagrangeInter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemLagrangeInter.Client = null;
            this.itemLagrangeInter.LargeImageMode = true;
            this.itemLagrangeInter.Text = "Interpolación de Lagrange ";
            // 
            // itemNewtonInter
            // 
            this.itemNewtonInter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemNewtonInter.Client = null;
            this.itemNewtonInter.LargeImageMode = true;
            this.itemNewtonInter.Text = "Interpolación Polinomial de Newton ";
            // 
            // itemCubicInter
            // 
            this.itemCubicInter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemCubicInter.Client = null;
            this.itemCubicInter.LargeImageMode = true;
            this.itemCubicInter.Text = "Interpolación Cúbicos Naturales";
            // 
            // itemCubicInter2
            // 
            this.itemCubicInter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemCubicInter2.Client = null;
            this.itemCubicInter2.LargeImageMode = true;
            this.itemCubicInter2.Text = "Interpolación Cúbicos Sujetos";
            // 
            // itemNumericDiferential
            // 
            this.itemNumericDiferential.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemNumericDiferential.Client = null;
            this.itemNumericDiferential.LargeImageMode = true;
            this.itemNumericDiferential.Text = "Diferenciación Numérica ";
            // 
            // itemIntegrationTrapezoid
            // 
            this.itemIntegrationTrapezoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemIntegrationTrapezoid.Client = null;
            this.itemIntegrationTrapezoid.LargeImageMode = true;
            this.itemIntegrationTrapezoid.Text = "Integración Numérica :Regla del Trapecio ";
            // 
            // itemIntegrationSimpson
            // 
            this.itemIntegrationSimpson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemIntegrationSimpson.Client = null;
            this.itemIntegrationSimpson.LargeImageMode = true;
            this.itemIntegrationSimpson.Text = "Integración Numérica: Simpson";
            // 
            // itemIntegrationGauss
            // 
            this.itemIntegrationGauss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemIntegrationGauss.Client = null;
            this.itemIntegrationGauss.LargeImageMode = true;
            this.itemIntegrationGauss.Text = "Integración Numérica: Gauss ";
            // 
            // itemEuler
            // 
            this.itemEuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemEuler.Client = null;
            this.itemEuler.LargeImageMode = true;
            this.itemEuler.Text = "Solución de Edo: Método de Euler";
            // 
            // itemEdoRunge
            // 
            this.itemEdoRunge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemEdoRunge.Client = null;
            this.itemEdoRunge.LargeImageMode = true;
            this.itemEdoRunge.Text = "Solución de Edo: Runge-Kutta ";
            // 
            // itemEdoRunge2
            // 
            this.itemEdoRunge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemEdoRunge2.Client = null;
            this.itemEdoRunge2.LargeImageMode = true;
            this.itemEdoRunge2.Text = "Sistemas de Edo: Runge-Kutta ";
            // 
            // itemEquationGauss
            // 
            this.itemEquationGauss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemEquationGauss.Client = null;
            this.itemEquationGauss.LargeImageMode = true;
            this.itemEquationGauss.Text = "Sistemas de ecuaciones: Gauss";
            // 
            // itemDescompLU
            // 
            this.itemDescompLU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemDescompLU.Client = null;
            this.itemDescompLU.LargeImageMode = true;
            this.itemDescompLU.Text = "Descomposición LU";
            // 
            // itemEquationInverse
            // 
            this.itemEquationInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemEquationInverse.Client = null;
            this.itemEquationInverse.LargeImageMode = true;
            this.itemEquationInverse.Text = "Sistema de ecuaciones: Inversa";
            // 
            // itemLinealRegretion
            // 
            this.itemLinealRegretion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemLinealRegretion.Client = null;
            this.itemLinealRegretion.LargeImageMode = true;
            this.itemLinealRegretion.Text = "Regresión Lineal";
            // 
            // itemFiniteDiferential
            // 
            this.itemFiniteDiferential.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.itemFiniteDiferential.Client = null;
            this.itemFiniteDiferential.LargeImageMode = true;
            this.itemFiniteDiferential.Text = "Método lineal de diferencias finitas";
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images13"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images14"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images15"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images16"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images17"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images18"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images19"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images20"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images21")))});
            this.imageListAdv1.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.CustomRender = null;
            this.scrollersFrame1.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame1.MetroThumbSize = new System.Drawing.Size(0, 0);
            metroColorTable1.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ArrowInActive = System.Drawing.Color.White;
            metroColorTable1.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable1.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable1.ThumbInActive = System.Drawing.Color.White;
            metroColorTable1.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable1.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable1.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.scrollersFrame1.ScrollMetroColorTable = metroColorTable1;
            this.scrollersFrame1.ShowMetroArrowButton = true;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 150;
            // 
            // scrollersFrame2
            // 
            this.scrollersFrame2.CustomRender = null;
            this.scrollersFrame2.MetroColorScheme = Syncfusion.Windows.Forms.MetroColorScheme.Managed;
            this.scrollersFrame2.MetroThumbSize = new System.Drawing.Size(0, 0);
            metroColorTable2.ArrowChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable2.ArrowInActive = System.Drawing.Color.White;
            metroColorTable2.ArrowNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable2.ArrowNormalBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable2.ArrowPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable2.ArrowPushedBackGround = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable2.ScrollerBackground = System.Drawing.Color.White;
            metroColorTable2.ThumbChecked = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            metroColorTable2.ThumbInActive = System.Drawing.Color.White;
            metroColorTable2.ThumbNormal = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            metroColorTable2.ThumbPushed = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            metroColorTable2.ThumbPushedBorder = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.scrollersFrame2.ScrollMetroColorTable = metroColorTable2;
            this.scrollersFrame2.ShowMetroArrowButton = true;
            this.scrollersFrame2.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame2.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 689);
            this.Controls.Add(this.tabControlAdv1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 545);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Methods";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageOutlook.ResumeLayout(false);
            this.tabPageOutlook.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAlgorithm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;


        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageOutlook;

        private System.Windows.Forms.ToolTip toolTip1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame1;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame2;
        private Syncfusion.Windows.Forms.Tools.GroupBar gbAlgorithm;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemBisection;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemFixedPoint;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemNewton;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemSecant;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemFalsePosition;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemMuller;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemLagrangeInter;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemNewtonInter;
        private System.Windows.Forms.ColumnHeader columnHeader3;

        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemCubicInter;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemCubicInter2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemNumericDiferential;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemIntegrationTrapezoid;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemIntegrationSimpson;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemIntegrationGauss;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemEuler;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemEdoRunge;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemEdoRunge2;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemEquationGauss;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemDescompLU;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemEquationInverse;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemLinealRegretion;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem itemFiniteDiferential;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Label lblTol;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbProcess;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
       
    }
}