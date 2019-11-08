namespace DoAnOOP
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
            this.btnSort = new System.Windows.Forms.Button();
            this.rdBS = new System.Windows.Forms.RadioButton();
            this.rdIS = new System.Windows.Forms.RadioButton();
            this.rdQS = new System.Windows.Forms.RadioButton();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.btnCreaterArray = new System.Windows.Forms.Button();
            this.trbSleep = new System.Windows.Forms.TrackBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlPain = new System.Windows.Forms.Panel();
            this.rdMS = new System.Windows.Forms.RadioButton();
            this.lbSleep = new System.Windows.Forms.Label();
            this.rdHeapSort = new System.Windows.Forms.RadioButton();
            this.rdShellSort = new System.Windows.Forms.RadioButton();
            this.rdSelectionSort = new System.Windows.Forms.RadioButton();
            this.lbComArray = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.Control;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSort.Location = new System.Drawing.Point(463, 603);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 37);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // rdBS
            // 
            this.rdBS.AutoSize = true;
            this.rdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdBS.Location = new System.Drawing.Point(358, 645);
            this.rdBS.Name = "rdBS";
            this.rdBS.Size = new System.Drawing.Size(99, 22);
            this.rdBS.TabIndex = 3;
            this.rdBS.TabStop = true;
            this.rdBS.Text = "BubbleSort";
            this.rdBS.UseVisualStyleBackColor = true;
            this.rdBS.CheckedChanged += new System.EventHandler(this.RdBS_CheckedChanged);
            // 
            // rdIS
            // 
            this.rdIS.AutoSize = true;
            this.rdIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdIS.Location = new System.Drawing.Point(133, 646);
            this.rdIS.Name = "rdIS";
            this.rdIS.Size = new System.Drawing.Size(110, 22);
            this.rdIS.TabIndex = 4;
            this.rdIS.TabStop = true;
            this.rdIS.Text = "InsertionSort";
            this.rdIS.UseVisualStyleBackColor = true;
            this.rdIS.CheckedChanged += new System.EventHandler(this.RdIS_CheckedChanged);
            // 
            // rdQS
            // 
            this.rdQS.AutoSize = true;
            this.rdQS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdQS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdQS.Location = new System.Drawing.Point(249, 618);
            this.rdQS.Name = "rdQS";
            this.rdQS.Size = new System.Drawing.Size(93, 22);
            this.rdQS.TabIndex = 5;
            this.rdQS.TabStop = true;
            this.rdQS.Text = "QuickSort";
            this.rdQS.UseVisualStyleBackColor = true;
            this.rdQS.CheckedChanged += new System.EventHandler(this.RdQS_CheckedChanged);
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(625, 603);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(75, 20);
            this.txbLength.TabIndex = 6;
            // 
            // btnCreaterArray
            // 
            this.btnCreaterArray.Location = new System.Drawing.Point(625, 639);
            this.btnCreaterArray.Name = "btnCreaterArray";
            this.btnCreaterArray.Size = new System.Drawing.Size(75, 28);
            this.btnCreaterArray.TabIndex = 7;
            this.btnCreaterArray.Text = "Create Array";
            this.btnCreaterArray.UseVisualStyleBackColor = true;
            this.btnCreaterArray.Click += new System.EventHandler(this.BtnCreateArray_Click);
            // 
            // trbSleep
            // 
            this.trbSleep.BackColor = System.Drawing.SystemColors.GrayText;
            this.trbSleep.Location = new System.Drawing.Point(729, 602);
            this.trbSleep.Maximum = 1000;
            this.trbSleep.Name = "trbSleep";
            this.trbSleep.Size = new System.Drawing.Size(104, 45);
            this.trbSleep.TabIndex = 8;
            this.trbSleep.Scroll += new System.EventHandler(this.TrbSleep_Scroll);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(745, 646);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(544, 647);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(463, 645);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // pnlPain
            // 
            this.pnlPain.AutoScroll = true;
            this.pnlPain.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlPain.Location = new System.Drawing.Point(-3, -1);
            this.pnlPain.Name = "pnlPain";
            this.pnlPain.Size = new System.Drawing.Size(1267, 597);
            this.pnlPain.TabIndex = 12;
            // 
            // rdMS
            // 
            this.rdMS.AutoSize = true;
            this.rdMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdMS.Location = new System.Drawing.Point(12, 645);
            this.rdMS.Name = "rdMS";
            this.rdMS.Size = new System.Drawing.Size(96, 22);
            this.rdMS.TabIndex = 13;
            this.rdMS.TabStop = true;
            this.rdMS.Text = "MergeSort";
            this.rdMS.UseVisualStyleBackColor = true;
            this.rdMS.CheckedChanged += new System.EventHandler(this.RdMS_CheckedChanged);
            // 
            // lbSleep
            // 
            this.lbSleep.AutoSize = true;
            this.lbSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSleep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSleep.Location = new System.Drawing.Point(863, 602);
            this.lbSleep.Name = "lbSleep";
            this.lbSleep.Size = new System.Drawing.Size(0, 16);
            this.lbSleep.TabIndex = 14;
            // 
            // rdHeapSort
            // 
            this.rdHeapSort.AutoSize = true;
            this.rdHeapSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHeapSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdHeapSort.Location = new System.Drawing.Point(133, 618);
            this.rdHeapSort.Name = "rdHeapSort";
            this.rdHeapSort.Size = new System.Drawing.Size(89, 22);
            this.rdHeapSort.TabIndex = 15;
            this.rdHeapSort.TabStop = true;
            this.rdHeapSort.Text = "HeapSort";
            this.rdHeapSort.UseVisualStyleBackColor = true;
            this.rdHeapSort.CheckedChanged += new System.EventHandler(this.RdHeapSort_CheckedChanged);
            // 
            // rdShellSort
            // 
            this.rdShellSort.AutoSize = true;
            this.rdShellSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdShellSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdShellSort.Location = new System.Drawing.Point(249, 645);
            this.rdShellSort.Name = "rdShellSort";
            this.rdShellSort.Size = new System.Drawing.Size(86, 22);
            this.rdShellSort.TabIndex = 16;
            this.rdShellSort.TabStop = true;
            this.rdShellSort.Text = "ShellSort";
            this.rdShellSort.UseVisualStyleBackColor = true;
            this.rdShellSort.CheckedChanged += new System.EventHandler(this.RdShellSort_CheckedChanged);
            // 
            // rdSelectionSort
            // 
            this.rdSelectionSort.AutoSize = true;
            this.rdSelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSelectionSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdSelectionSort.Location = new System.Drawing.Point(12, 617);
            this.rdSelectionSort.Name = "rdSelectionSort";
            this.rdSelectionSort.Size = new System.Drawing.Size(115, 22);
            this.rdSelectionSort.TabIndex = 17;
            this.rdSelectionSort.TabStop = true;
            this.rdSelectionSort.Text = "SelectionSort";
            this.rdSelectionSort.UseVisualStyleBackColor = true;
            this.rdSelectionSort.CheckedChanged += new System.EventHandler(this.RdSelectionSort_CheckedChanged);
            // 
            // lbComArray
            // 
            this.lbComArray.AutoSize = true;
            this.lbComArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComArray.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbComArray.Location = new System.Drawing.Point(863, 643);
            this.lbComArray.Name = "lbComArray";
            this.lbComArray.Size = new System.Drawing.Size(204, 18);
            this.lbComArray.TabIndex = 18;
            this.lbComArray.Text = "comparisons, array accesses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbComArray);
            this.Controls.Add(this.rdSelectionSort);
            this.Controls.Add(this.rdShellSort);
            this.Controls.Add(this.rdHeapSort);
            this.Controls.Add(this.lbSleep);
            this.Controls.Add(this.rdMS);
            this.Controls.Add(this.pnlPain);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.trbSleep);
            this.Controls.Add(this.btnCreaterArray);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.rdQS);
            this.Controls.Add(this.rdIS);
            this.Controls.Add(this.rdBS);
            this.Controls.Add(this.btnSort);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "SORTING ALGORITHMS";
            ((System.ComponentModel.ISupportInitialize)(this.trbSleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton rdBS;
        private System.Windows.Forms.RadioButton rdIS;
        private System.Windows.Forms.RadioButton rdQS;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Button btnCreaterArray;
        private System.Windows.Forms.TrackBar trbSleep;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlPain;
        private System.Windows.Forms.RadioButton rdMS;
        private System.Windows.Forms.Label lbSleep;
        private System.Windows.Forms.RadioButton rdHeapSort;
        private System.Windows.Forms.RadioButton rdShellSort;
        private System.Windows.Forms.RadioButton rdSelectionSort;
        private System.Windows.Forms.Label lbComArray;
    }
}

