namespace Chinook.UI.Windows
{
    partial class frmSearchTrack
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchTrack = new System.Windows.Forms.Button();
            this.txtTrackFilterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectedTrack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchTrack);
            this.groupBox1.Controls.Add(this.txtTrackFilterName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSearchTrack
            // 
            this.btnSearchTrack.Location = new System.Drawing.Point(313, 23);
            this.btnSearchTrack.Name = "btnSearchTrack";
            this.btnSearchTrack.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTrack.TabIndex = 2;
            this.btnSearchTrack.Text = "Buscar";
            this.btnSearchTrack.UseVisualStyleBackColor = true;
            this.btnSearchTrack.Click += new System.EventHandler(this.btnSearchTrack_Click);
            // 
            // txtTrackFilterName
            // 
            this.txtTrackFilterName.Location = new System.Drawing.Point(47, 26);
            this.txtTrackFilterName.Name = "txtTrackFilterName";
            this.txtTrackFilterName.Size = new System.Drawing.Size(237, 20);
            this.txtTrackFilterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTrack);
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgvTrack
            // 
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(7, 20);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.Size = new System.Drawing.Size(384, 112);
            this.dgvTrack.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancelar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectedTrack
            // 
            this.btnSelectedTrack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectedTrack.Location = new System.Drawing.Point(222, 233);
            this.btnSelectedTrack.Name = "btnSelectedTrack";
            this.btnSelectedTrack.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedTrack.TabIndex = 3;
            this.btnSelectedTrack.Text = "Seleccionar";
            this.btnSelectedTrack.UseVisualStyleBackColor = true;
            this.btnSelectedTrack.Click += new System.EventHandler(this.btnSelectedTrack_Click);
            // 
            // frmSearchTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectedTrack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchTrack";
            this.Text = "frmSearchTrack";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchTrack;
        private System.Windows.Forms.TextBox txtTrackFilterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectedTrack;
    }
}