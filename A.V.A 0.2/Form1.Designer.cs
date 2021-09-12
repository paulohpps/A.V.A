
namespace A.V.A_0._2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.audiovol = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recs = new System.Windows.Forms.Label();
            this.CPUBAR = new CircularProgressBar.CircularProgressBar();
            this.RAMBAR = new CircularProgressBar.CircularProgressBar();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // audiovol
            // 
            this.audiovol.ForeColor = System.Drawing.Color.DodgerBlue;
            this.audiovol.Location = new System.Drawing.Point(141, 32);
            this.audiovol.Name = "audiovol";
            this.audiovol.Size = new System.Drawing.Size(206, 35);
            this.audiovol.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::A.V.A_0._2.Properties.Resources.WeirdPoliteAntelope_size_restricted__1_;
            this.pictureBox1.Location = new System.Drawing.Point(254, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // recs
            // 
            this.recs.AutoSize = true;
            this.recs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recs.ForeColor = System.Drawing.Color.DodgerBlue;
            this.recs.Location = new System.Drawing.Point(21, 28);
            this.recs.Name = "recs";
            this.recs.Size = new System.Drawing.Size(114, 39);
            this.recs.TabIndex = 2;
            this.recs.Text = "⦿REC";
            // 
            // CPUBAR
            // 
            this.CPUBAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBAR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPUBAR.AnimationSpeed = 500;
            this.CPUBAR.BackColor = System.Drawing.Color.Transparent;
            this.CPUBAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBAR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CPUBAR.InnerColor = System.Drawing.Color.Black;
            this.CPUBAR.InnerMargin = 2;
            this.CPUBAR.InnerWidth = -1;
            this.CPUBAR.Location = new System.Drawing.Point(898, 329);
            this.CPUBAR.MarqueeAnimationSpeed = 3000;
            this.CPUBAR.Name = "CPUBAR";
            this.CPUBAR.OuterColor = System.Drawing.Color.Black;
            this.CPUBAR.OuterMargin = -25;
            this.CPUBAR.OuterWidth = 26;
            this.CPUBAR.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.CPUBAR.ProgressWidth = 25;
            this.CPUBAR.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPUBAR.Size = new System.Drawing.Size(207, 201);
            this.CPUBAR.StartAngle = 270;
            this.CPUBAR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUBAR.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPUBAR.SubscriptText = "";
            this.CPUBAR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUBAR.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPUBAR.SuperscriptText = "";
            this.CPUBAR.TabIndex = 3;
            this.CPUBAR.Text = "100%";
            this.CPUBAR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPUBAR.Value = 80;
            this.CPUBAR.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // RAMBAR
            // 
            this.RAMBAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RAMBAR.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.RAMBAR.AnimationSpeed = 500;
            this.RAMBAR.BackColor = System.Drawing.Color.Transparent;
            this.RAMBAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMBAR.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RAMBAR.InnerColor = System.Drawing.Color.Black;
            this.RAMBAR.InnerMargin = 2;
            this.RAMBAR.InnerWidth = -1;
            this.RAMBAR.Location = new System.Drawing.Point(12, 329);
            this.RAMBAR.MarqueeAnimationSpeed = 3000;
            this.RAMBAR.Name = "RAMBAR";
            this.RAMBAR.OuterColor = System.Drawing.Color.Black;
            this.RAMBAR.OuterMargin = -25;
            this.RAMBAR.OuterWidth = 26;
            this.RAMBAR.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.RAMBAR.ProgressWidth = 25;
            this.RAMBAR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RAMBAR.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.RAMBAR.Size = new System.Drawing.Size(207, 201);
            this.RAMBAR.StartAngle = 270;
            this.RAMBAR.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RAMBAR.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RAMBAR.SubscriptText = "";
            this.RAMBAR.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RAMBAR.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RAMBAR.SuperscriptText = "";
            this.RAMBAR.TabIndex = 4;
            this.RAMBAR.Text = "100%";
            this.RAMBAR.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RAMBAR.Value = 80;
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reconhecido:";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(76, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "RAM";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(959, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPU";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(896, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "©Copyright PauloHS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(390, -7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 118);
            this.label5.TabIndex = 10;
            this.label5.Text = "A.V.A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "A.V.A";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1117, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RAMBAR);
            this.Controls.Add(this.CPUBAR);
            this.Controls.Add(this.recs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.audiovol);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "Form1";
            this.Text = "A.V.A";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar audiovol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label recs;
        private CircularProgressBar.CircularProgressBar CPUBAR;
        private CircularProgressBar.CircularProgressBar RAMBAR;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

