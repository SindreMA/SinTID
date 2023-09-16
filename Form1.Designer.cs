namespace SinTID
{
    partial class SinTid
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
            this.button_LoggInn = new System.Windows.Forms.Button();
            this.button_LoggUt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_visuke = new System.Windows.Forms.Label();
            this.button_NesteUke = new System.Windows.Forms.Button();
            this.button_Forje = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label__Innidag = new System.Windows.Forms.Label();
            this.label_utidag = new System.Windows.Forms.Label();
            this.label_utidag_value = new System.Windows.Forms.Label();
            this.label_innidag_value = new System.Windows.Forms.Label();
            this.label_påloggetTid = new System.Windows.Forms.Label();
            this.label_OverTid = new System.Windows.Forms.Label();
            this.label_PåloggetTid_value = new System.Windows.Forms.Label();
            this.label_OverTId_value = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LoggInn
            // 
            this.button_LoggInn.Location = new System.Drawing.Point(12, 12);
            this.button_LoggInn.Name = "button_LoggInn";
            this.button_LoggInn.Size = new System.Drawing.Size(286, 37);
            this.button_LoggInn.TabIndex = 0;
            this.button_LoggInn.Text = "Logg Inn";
            this.button_LoggInn.UseVisualStyleBackColor = true;
            this.button_LoggInn.Click += new System.EventHandler(this.button_LoggInn_Click);
            // 
            // button_LoggUt
            // 
            this.button_LoggUt.Location = new System.Drawing.Point(344, 12);
            this.button_LoggUt.Name = "button_LoggUt";
            this.button_LoggUt.Size = new System.Drawing.Size(312, 37);
            this.button_LoggUt.TabIndex = 1;
            this.button_LoggUt.Text = "Logg Ut";
            this.button_LoggUt.UseVisualStyleBackColor = true;
            this.button_LoggUt.Click += new System.EventHandler(this.button_LoggUt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label_visuke
            // 
            this.label_visuke.AutoSize = true;
            this.label_visuke.Location = new System.Drawing.Point(497, 61);
            this.label_visuke.Name = "label_visuke";
            this.label_visuke.Size = new System.Drawing.Size(42, 13);
            this.label_visuke.TabIndex = 3;
            this.label_visuke.Text = "Vis uke";
            // 
            // button_NesteUke
            // 
            this.button_NesteUke.Location = new System.Drawing.Point(629, 55);
            this.button_NesteUke.Name = "button_NesteUke";
            this.button_NesteUke.Size = new System.Drawing.Size(27, 25);
            this.button_NesteUke.TabIndex = 4;
            this.button_NesteUke.Text = ">";
            this.button_NesteUke.UseVisualStyleBackColor = true;
            this.button_NesteUke.Click += new System.EventHandler(this.button_NesteUke_Click);
            // 
            // button_Forje
            // 
            this.button_Forje.Location = new System.Drawing.Point(596, 55);
            this.button_Forje.Name = "button_Forje";
            this.button_Forje.Size = new System.Drawing.Size(27, 25);
            this.button_Forje.TabIndex = 5;
            this.button_Forje.Text = "<";
            this.button_Forje.UseVisualStyleBackColor = true;
            this.button_Forje.Click += new System.EventHandler(this.button_Forje_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(671, 248);
            this.dataGridView1.TabIndex = 6;
            // 
            // label__Innidag
            // 
            this.label__Innidag.AutoSize = true;
            this.label__Innidag.Location = new System.Drawing.Point(12, 52);
            this.label__Innidag.Name = "label__Innidag";
            this.label__Innidag.Size = new System.Drawing.Size(89, 13);
            this.label__Innidag.TabIndex = 7;
            this.label__Innidag.Text = "Logget inn i dag: ";
            // 
            // label_utidag
            // 
            this.label_utidag.AutoSize = true;
            this.label_utidag.Location = new System.Drawing.Point(12, 66);
            this.label_utidag.Name = "label_utidag";
            this.label_utidag.Size = new System.Drawing.Size(84, 13);
            this.label_utidag.TabIndex = 8;
            this.label_utidag.Text = "Logget ut i dag: ";
            // 
            // label_utidag_value
            // 
            this.label_utidag_value.AutoSize = true;
            this.label_utidag_value.Location = new System.Drawing.Point(102, 67);
            this.label_utidag_value.Name = "label_utidag_value";
            this.label_utidag_value.Size = new System.Drawing.Size(0, 13);
            this.label_utidag_value.TabIndex = 9;
            // 
            // label_innidag_value
            // 
            this.label_innidag_value.AutoSize = true;
            this.label_innidag_value.Location = new System.Drawing.Point(102, 54);
            this.label_innidag_value.Name = "label_innidag_value";
            this.label_innidag_value.Size = new System.Drawing.Size(0, 13);
            this.label_innidag_value.TabIndex = 10;
            // 
            // label_påloggetTid
            // 
            this.label_påloggetTid.AutoSize = true;
            this.label_påloggetTid.Location = new System.Drawing.Point(229, 52);
            this.label_påloggetTid.Name = "label_påloggetTid";
            this.label_påloggetTid.Size = new System.Drawing.Size(69, 13);
            this.label_påloggetTid.TabIndex = 11;
            this.label_påloggetTid.Text = "Pålogget tid: ";
            // 
            // label_OverTid
            // 
            this.label_OverTid.AutoSize = true;
            this.label_OverTid.Location = new System.Drawing.Point(251, 70);
            this.label_OverTid.Name = "label_OverTid";
            this.label_OverTid.Size = new System.Drawing.Size(47, 13);
            this.label_OverTid.TabIndex = 12;
            this.label_OverTid.Text = "Overtid: ";
            // 
            // label_PåloggetTid_value
            // 
            this.label_PåloggetTid_value.AutoSize = true;
            this.label_PåloggetTid_value.Location = new System.Drawing.Point(294, 52);
            this.label_PåloggetTid_value.Name = "label_PåloggetTid_value";
            this.label_PåloggetTid_value.Size = new System.Drawing.Size(0, 13);
            this.label_PåloggetTid_value.TabIndex = 13;
            // 
            // label_OverTId_value
            // 
            this.label_OverTId_value.AutoSize = true;
            this.label_OverTId_value.Location = new System.Drawing.Point(294, 70);
            this.label_OverTId_value.Name = "label_OverTId_value";
            this.label_OverTId_value.Size = new System.Drawing.Size(0, 13);
            this.label_OverTId_value.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SinTid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.Controls.Add(this.label_OverTId_value);
            this.Controls.Add(this.label_PåloggetTid_value);
            this.Controls.Add(this.label_OverTid);
            this.Controls.Add(this.label_påloggetTid);
            this.Controls.Add(this.label_innidag_value);
            this.Controls.Add(this.label_utidag_value);
            this.Controls.Add(this.label_utidag);
            this.Controls.Add(this.label__Innidag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Forje);
            this.Controls.Add(this.button_NesteUke);
            this.Controls.Add(this.label_visuke);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_LoggUt);
            this.Controls.Add(this.button_LoggInn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SinTid";
            this.Text = "SinTid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LoggInn;
        private System.Windows.Forms.Button button_LoggUt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_visuke;
        private System.Windows.Forms.Button button_NesteUke;
        private System.Windows.Forms.Button button_Forje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label__Innidag;
        private System.Windows.Forms.Label label_utidag;
        private System.Windows.Forms.Label label_utidag_value;
        private System.Windows.Forms.Label label_innidag_value;
        private System.Windows.Forms.Label label_påloggetTid;
        private System.Windows.Forms.Label label_OverTid;
        private System.Windows.Forms.Label label_PåloggetTid_value;
        private System.Windows.Forms.Label label_OverTId_value;
        public System.Windows.Forms.Timer timer1;
    }
}

