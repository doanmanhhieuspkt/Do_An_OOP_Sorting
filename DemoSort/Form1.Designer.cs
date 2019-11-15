namespace DemoSort
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
            this.pnlSort = new System.Windows.Forms.Panel();
            this.rdSelecSort = new System.Windows.Forms.RadioButton();
            this.rdHeapSort = new System.Windows.Forms.RadioButton();
            this.rdShell = new System.Windows.Forms.RadioButton();
            this.rdMerge = new System.Windows.Forms.RadioButton();
            this.rdQuickSort = new System.Windows.Forms.RadioButton();
            this.rdInsertion = new System.Windows.Forms.RadioButton();
            this.rdBubbler = new System.Windows.Forms.RadioButton();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.trbSleep = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txbNhapTay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.lblDemoSort = new System.Windows.Forms.Label();
            this.pnlSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSort
            // 
            this.pnlSort.Controls.Add(this.rdSelecSort);
            this.pnlSort.Controls.Add(this.rdHeapSort);
            this.pnlSort.Controls.Add(this.rdShell);
            this.pnlSort.Controls.Add(this.rdMerge);
            this.pnlSort.Controls.Add(this.rdQuickSort);
            this.pnlSort.Controls.Add(this.rdInsertion);
            this.pnlSort.Controls.Add(this.rdBubbler);
            this.pnlSort.Location = new System.Drawing.Point(119, 602);
            this.pnlSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(220, 139);
            this.pnlSort.TabIndex = 0;
            // 
            // rdSelecSort
            // 
            this.rdSelecSort.AutoSize = true;
            this.rdSelecSort.Location = new System.Drawing.Point(4, 87);
            this.rdSelecSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSelecSort.Name = "rdSelecSort";
            this.rdSelecSort.Size = new System.Drawing.Size(117, 21);
            this.rdSelecSort.TabIndex = 6;
            this.rdSelecSort.TabStop = true;
            this.rdSelecSort.Text = "Selection Sort";
            this.rdSelecSort.UseVisualStyleBackColor = true;
            // 
            // rdHeapSort
            // 
            this.rdHeapSort.AutoSize = true;
            this.rdHeapSort.Location = new System.Drawing.Point(115, 4);
            this.rdHeapSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdHeapSort.Name = "rdHeapSort";
            this.rdHeapSort.Size = new System.Drawing.Size(93, 21);
            this.rdHeapSort.TabIndex = 5;
            this.rdHeapSort.TabStop = true;
            this.rdHeapSort.Text = "Heap Sort";
            this.rdHeapSort.UseVisualStyleBackColor = true;
            // 
            // rdShell
            // 
            this.rdShell.AutoSize = true;
            this.rdShell.Location = new System.Drawing.Point(4, 59);
            this.rdShell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdShell.Name = "rdShell";
            this.rdShell.Size = new System.Drawing.Size(90, 21);
            this.rdShell.TabIndex = 4;
            this.rdShell.TabStop = true;
            this.rdShell.Text = "Shell Sort";
            this.rdShell.UseVisualStyleBackColor = true;
            // 
            // rdMerge
            // 
            this.rdMerge.AutoSize = true;
            this.rdMerge.Location = new System.Drawing.Point(4, 31);
            this.rdMerge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMerge.Name = "rdMerge";
            this.rdMerge.Size = new System.Drawing.Size(99, 21);
            this.rdMerge.TabIndex = 3;
            this.rdMerge.TabStop = true;
            this.rdMerge.Text = "Merge Sort";
            this.rdMerge.UseVisualStyleBackColor = true;
            // 
            // rdQuickSort
            // 
            this.rdQuickSort.AutoSize = true;
            this.rdQuickSort.Location = new System.Drawing.Point(113, 31);
            this.rdQuickSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdQuickSort.Name = "rdQuickSort";
            this.rdQuickSort.Size = new System.Drawing.Size(89, 21);
            this.rdQuickSort.TabIndex = 2;
            this.rdQuickSort.TabStop = true;
            this.rdQuickSort.Text = "Quicksort";
            this.rdQuickSort.UseVisualStyleBackColor = true;
            // 
            // rdInsertion
            // 
            this.rdInsertion.AutoSize = true;
            this.rdInsertion.Location = new System.Drawing.Point(4, 113);
            this.rdInsertion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdInsertion.Name = "rdInsertion";
            this.rdInsertion.Size = new System.Drawing.Size(113, 21);
            this.rdInsertion.TabIndex = 1;
            this.rdInsertion.TabStop = true;
            this.rdInsertion.Text = "Insertion Sort";
            this.rdInsertion.UseVisualStyleBackColor = true;
            // 
            // rdBubbler
            // 
            this.rdBubbler.AutoSize = true;
            this.rdBubbler.Location = new System.Drawing.Point(4, 4);
            this.rdBubbler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBubbler.Name = "rdBubbler";
            this.rdBubbler.Size = new System.Drawing.Size(103, 21);
            this.rdBubbler.TabIndex = 0;
            this.rdBubbler.TabStop = true;
            this.rdBubbler.Text = "Bubble Sort";
            this.rdBubbler.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSort.Location = new System.Drawing.Point(12, 602);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(101, 47);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 655);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 42);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(345, 700);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(101, 41);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(345, 670);
            this.txbLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(100, 22);
            this.txbLength.TabIndex = 5;
            this.txbLength.Text = "25";
            this.txbLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 710);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(101, 31);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Pause";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(1260, 699);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // trbSleep
            // 
            this.trbSleep.Location = new System.Drawing.Point(684, 670);
            this.trbSleep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbSleep.Maximum = 1000;
            this.trbSleep.Name = "trbSleep";
            this.trbSleep.Size = new System.Drawing.Size(112, 56);
            this.trbSleep.SmallChange = 10;
            this.trbSleep.TabIndex = 8;
            this.trbSleep.Value = 1;
            this.trbSleep.Scroll += new System.EventHandler(this.TrbSleep_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 602);
            this.panel1.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(453, 700);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 41);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // txbNhapTay
            // 
            this.txbNhapTay.Location = new System.Drawing.Point(452, 670);
            this.txbNhapTay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNhapTay.Name = "txbNhapTay";
            this.txbNhapTay.Size = new System.Drawing.Size(225, 22);
            this.txbNhapTay.TabIndex = 11;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(803, 679);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(42, 17);
            this.lblDelay.TabIndex = 12;
            this.lblDelay.Text = "delay";
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Location = new System.Drawing.Point(1000, 702);
            this.ac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(46, 17);
            this.ac.TabIndex = 14;
            this.ac.Text = "label2";
            // 
            // lblDemoSort
            // 
            this.lblDemoSort.AutoSize = true;
            this.lblDemoSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoSort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDemoSort.Location = new System.Drawing.Point(500, 607);
            this.lblDemoSort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDemoSort.Name = "lblDemoSort";
            this.lblDemoSort.Size = new System.Drawing.Size(418, 31);
            this.lblDemoSort.TabIndex = 15;
            this.lblDemoSort.Text = "DEMO SORTING ALGORITHM";
            this.lblDemoSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1387, 798);
            this.ControlBox = false;
            this.Controls.Add(this.lblDemoSort);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.txbNhapTay);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trbSleep);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.pnlSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1387, 798);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1387, 798);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Sort";
            this.Load += new System.EventHandler(this.Form1_load);
            this.pnlSort.ResumeLayout(false);
            this.pnlSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSort;
        private System.Windows.Forms.RadioButton rdBubbler;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rdQuickSort;
        private System.Windows.Forms.RadioButton rdInsertion;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TrackBar trbSleep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txbNhapTay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.RadioButton rdMerge;
        private System.Windows.Forms.RadioButton rdShell;
        private System.Windows.Forms.RadioButton rdHeapSort;
        private System.Windows.Forms.RadioButton rdSelecSort;
        private System.Windows.Forms.Label lblDemoSort;
    }
}

