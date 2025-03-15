namespace ToDoListApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.rbHighPriority = new System.Windows.Forms.RadioButton();
            this.rbMediumPriority = new System.Windows.Forms.RadioButton();
            this.rbLowPriority = new System.Windows.Forms.RadioButton();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSetDueDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(125, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "To-Do-List";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.White;
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(20, 50);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(320, 29);
            this.txtTask.TabIndex = 1;
            this.txtTask.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(350, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(20, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(187, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.BackColor = System.Drawing.Color.Orange;
            this.btnMarkComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkComplete.Location = new System.Drawing.Point(342, 398);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(130, 30);
            this.btnMarkComplete.TabIndex = 6;
            this.btnMarkComplete.Text = "Mark Completed";
            this.btnMarkComplete.UseVisualStyleBackColor = false;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTasks.Location = new System.Drawing.Point(20, 445);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(307, 30);
            this.lblTotalTasks.TabIndex = 7;
            this.lblTotalTasks.Text = "Tatal Tasks: 0";
            // 
            // rbHighPriority
            // 
            this.rbHighPriority.AutoSize = true;
            this.rbHighPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHighPriority.Location = new System.Drawing.Point(20, 90);
            this.rbHighPriority.Name = "rbHighPriority";
            this.rbHighPriority.Size = new System.Drawing.Size(106, 21);
            this.rbHighPriority.TabIndex = 9;
            this.rbHighPriority.TabStop = true;
            this.rbHighPriority.Text = "High Priority";
            this.rbHighPriority.UseVisualStyleBackColor = true;
            // 
            // rbMediumPriority
            // 
            this.rbMediumPriority.AutoSize = true;
            this.rbMediumPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumPriority.Location = new System.Drawing.Point(160, 90);
            this.rbMediumPriority.Name = "rbMediumPriority";
            this.rbMediumPriority.Size = new System.Drawing.Size(127, 21);
            this.rbMediumPriority.TabIndex = 10;
            this.rbMediumPriority.TabStop = true;
            this.rbMediumPriority.Text = "Medium Priority";
            this.rbMediumPriority.UseVisualStyleBackColor = true;
            // 
            // rbLowPriority
            // 
            this.rbLowPriority.AutoSize = true;
            this.rbLowPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLowPriority.Location = new System.Drawing.Point(320, 90);
            this.rbLowPriority.Name = "rbLowPriority";
            this.rbLowPriority.Size = new System.Drawing.Size(101, 21);
            this.rbLowPriority.TabIndex = 11;
            this.rbLowPriority.TabStop = true;
            this.rbLowPriority.Text = "Low Priority";
            this.rbLowPriority.UseVisualStyleBackColor = true;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkMode.Location = new System.Drawing.Point(395, 10);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(104, 24);
            this.chkDarkMode.TabIndex = 12;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // lstTasks
            // 
            this.lstTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasks.HideSelection = false;
            this.lstTasks.Location = new System.Drawing.Point(20, 182);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(450, 199);
            this.lstTasks.TabIndex = 13;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.BackColor = System.Drawing.SystemColors.Info;
            this.btnChangeColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(20, 17);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 14;
            this.btnChangeColor.Text = "Set Color";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(20, 127);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(303, 27);
            this.dtpDueDate.TabIndex = 15;
            // 
            // btnSetDueDate
            // 
            this.btnSetDueDate.BackColor = System.Drawing.Color.Crimson;
            this.btnSetDueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDueDate.Location = new System.Drawing.Point(342, 124);
            this.btnSetDueDate.Name = "btnSetDueDate";
            this.btnSetDueDate.Size = new System.Drawing.Size(130, 30);
            this.btnSetDueDate.TabIndex = 16;
            this.btnSetDueDate.Text = "Set Due Date";
            this.btnSetDueDate.UseVisualStyleBackColor = false;
            this.btnSetDueDate.Click += new System.EventHandler(this.btnSetDueDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.Controls.Add(this.btnSetDueDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.rbLowPriority);
            this.Controls.Add(this.rbMediumPriority);
            this.Controls.Add(this.rbHighPriority);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ": To-Do List Application";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.RadioButton rbHighPriority;
        private System.Windows.Forms.RadioButton rbMediumPriority;
        private System.Windows.Forms.RadioButton rbLowPriority;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnSetDueDate;
    }
}

