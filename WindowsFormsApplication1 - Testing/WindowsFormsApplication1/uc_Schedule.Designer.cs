namespace HairBeautyNWRC
{
    partial class uc_Schedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_Schedule = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Schedule
            // 
            this.dg_Schedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Schedule.ColumnHeadersHeight = 50;
            this.dg_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_Schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Student1,
            this.Student2,
            this.Student3,
            this.Student4});
            this.dg_Schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Schedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_Schedule.Location = new System.Drawing.Point(0, 0);
            this.dg_Schedule.MultiSelect = false;
            this.dg_Schedule.Name = "dg_Schedule";
            this.dg_Schedule.RowHeadersWidth = 4;
            this.dg_Schedule.RowTemplate.Height = 60;
            this.dg_Schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dg_Schedule.Size = new System.Drawing.Size(945, 594);
            this.dg_Schedule.TabIndex = 4;
            this.dg_Schedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Schedule_CellClick);
            this.dg_Schedule.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Format = "t";
            this.Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Time.Frozen = true;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Student1
            // 
            this.Student1.HeaderText = "Student 1";
            this.Student1.Name = "Student1";
            this.Student1.Width = 200;
            // 
            // Student2
            // 
            this.Student2.HeaderText = "Student 2";
            this.Student2.Name = "Student2";
            this.Student2.Width = 200;
            // 
            // Student3
            // 
            this.Student3.HeaderText = "Student 3";
            this.Student3.Name = "Student3";
            this.Student3.Width = 200;
            // 
            // Student4
            // 
            this.Student4.HeaderText = "Student 4";
            this.Student4.Name = "Student4";
            this.Student4.Width = 200;
            // 
            // uc_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dg_Schedule);
            this.Name = "uc_Schedule";
            this.Size = new System.Drawing.Size(945, 594);
            this.Load += new System.EventHandler(this.uc_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Schedule;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student4;
    }
}
