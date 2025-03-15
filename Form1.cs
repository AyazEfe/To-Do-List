using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private Color savedBackgroundColor;
        private SpeechRecognitionEngine recognizer; // Voice recognition engine
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
            LoadBackgroundColor();
            LoadTasks();

        }

        private void InitializeListView()
        {
            lstTasks.View = View.Details;
            // Prevent reinsertion if a column has already been inserted
            if (lstTasks.Columns.Count == 0)
            {
                lstTasks.Columns.Add("Tasks", 200);
                lstTasks.Columns.Add("Due Date", 100);
            }
        }
        // Adding a task (registration with colour)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                string taskText = txtTask.Text;
                Color taskColor = Color.Black; // Default colour

                if (rbHighPriority.Checked)
                    taskColor = Color.Red;
                else if (rbMediumPriority.Checked)
                    taskColor = Color.Blue;
                else if (rbLowPriority.Checked)
                    taskColor = Color.Green;

                // Create ListViewItem
                ListViewItem item = new ListViewItem(taskText);
                item.ForeColor = taskColor;

                lstTasks.Items.Add(item);
                txtTask.Clear();
                UpdateTaskCount();
                SaveTasks(); // Save when new task is added

                // Reset priority selections
                rbHighPriority.Checked = false;
                rbMediumPriority.Checked = false;
                rbLowPriority.Checked = false;
            }
            else
            {
                MessageBox.Show("Please enter a task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Edit task
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                string newTask = Microsoft.VisualBasic.Interaction.InputBox("Enter the new task text:", "Edit Task", lstTasks.SelectedItems[0].Text);

                if (!string.IsNullOrWhiteSpace(newTask))
                {
                    lstTasks.SelectedItems[0].Text = newTask;
                    SaveTasks();  // Save when edited
                }
            }
            else
            {
                MessageBox.Show("Please choose a task to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Task
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItems[0]);
                UpdateTaskCount();
                SaveTasks(); // Save when task is deleted
            }
            else
            {
                MessageBox.Show("Please select a task to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Marking a task copleted
        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                string taskText = lstTasks.SelectedItems[0].Text;

                if (!taskText.StartsWith("✔ "))
                {
                    lstTasks.SelectedItems[0].Text = "✔ " + taskText;
                    SaveTasks();
                }
                else
                {
                    MessageBox.Show("This task is already marked as completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UpdateTaskCount();
            }
            else
            {
                MessageBox.Show("Please select a task to complete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTaskCount()
        {
            lblTotalTasks.Text = "Total Tasks: " + lstTasks.Items.Count.ToString();
        }

        // Recording tasks with colour
        private void SaveTasks()
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (ListViewItem item in lstTasks.Items)
                {
                    string taskText = item.Text;
                    string dueDate = (item.SubItems.Count > 1 && !string.IsNullOrWhiteSpace(item.SubItems[1].Text))
                        ? item.SubItems[1].Text
                        : "No Date";
                    writer.WriteLine(taskText + "|" + dueDate);
                }
            }
        }

        // Loading tasks with colour 
        private void LoadTasks()
        {
            if (File.Exists("tasks.txt"))
            {
                lstTasks.Items.Clear();
                using (StreamReader reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string taskText = parts[0];
                            string dueDateText = parts[1];

                            ListViewItem item = new ListViewItem(taskText);

                            // If it is a valid date, add it
                            DateTime dueDate;
                            if (DateTime.TryParse(dueDateText, out dueDate))
                            {
                                item.SubItems.Add(dueDate.ToString("yyyy-MM-dd"));
                            }
                            else
                            {
                                item.SubItems.Add(""); // it is invalid, leave it blank
                            }

                            lstTasks.Items.Add(item);
                        }
                    }
                }
                UpdateTaskColors(); // When the dates are loaded, update the colors
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
            recognizer.Dispose();
        }

        // DARK MODE 
        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDarkMode.Checked)
            {
                savedBackgroundColor = this.BackColor;
                this.BackColor = Color.Black;
                lblTotalTasks.ForeColor = Color.White;
                lstTasks.BackColor = Color.Gray;
                rbHighPriority.ForeColor = Color.White;
                rbLowPriority.ForeColor = Color.White;
                rbMediumPriority.ForeColor = Color.White;
                lblTitle.ForeColor = Color.White;
                chkDarkMode.Text = ("Light Mode");
                chkDarkMode.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = savedBackgroundColor;
                lblTotalTasks.ForeColor = Color.Black;
                lstTasks.BackColor = Color.White;
                rbHighPriority.ForeColor = Color.Black;
                rbLowPriority.ForeColor = Color.Black;
                rbMediumPriority.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Navy;
                chkDarkMode.Text = ("Dark Mode");
                chkDarkMode.ForeColor = Color.Black;
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                savedBackgroundColor = colorDialog.Color; // Hide the new color in the variable
                this.BackColor = savedBackgroundColor;
                SaveBackgroundColor(savedBackgroundColor);
            }

        }

        private void SaveBackgroundColor(Color color)
        {
            File.WriteAllText("background_color.txt", color.ToArgb().ToString());
        }

        private void LoadBackgroundColor()
        {
            if (File.Exists("background_color.txt"))
            {
                string colorValue = File.ReadAllText("background_color.txt");
                savedBackgroundColor = Color.FromArgb(int.Parse(colorValue));
                this.BackColor = savedBackgroundColor; // Apply the loaded color
            }
            else
            {
                savedBackgroundColor = SystemColors.Control; // Default color
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitializeListView();
            LoadTasks();
            LoadBackgroundColor(); // Apply the background color
        }            

        private void btnSetDueDate_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                DateTime selectedDate = dtpDueDate.Value;
                lstTasks.SelectedItems[0].SubItems.Add(selectedDate.ToString("yyyy-MM-dd"));
                UpdateTaskColors();
                SaveTasks(); // Save when updated
            }
            else
            {
                MessageBox.Show("Please select a task to set a due date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateTaskColors()
        {
            foreach (ListViewItem item in lstTasks.Items)
            {
                if (item.SubItems.Count > 1 && !string.IsNullOrWhiteSpace(item.SubItems[1].Text)) // If there is a date
                {
                    DateTime dueDate;
                    if (DateTime.TryParse(item.SubItems[1].Text, out dueDate))
                    {
                        TimeSpan difference = dueDate - DateTime.Now;

                        if (difference.TotalDays <= 3) 
                        {
                            item.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }
    }
}





