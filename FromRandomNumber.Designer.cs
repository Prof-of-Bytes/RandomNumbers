namespace RandomNumbers
{
    partial class FromRandomNumber
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGenNumbers = new Button();
            listBoxNumbers = new ListBox();
            comboBoxSelection = new ComboBox();
            labelNumberInstruction = new Label();
            buttonSave = new Button();
            saveFileDialogNumbers = new SaveFileDialog();
            SuspendLayout();
            // 
            // buttonGenNumbers
            // 
            buttonGenNumbers.Location = new Point(48, 321);
            buttonGenNumbers.Name = "buttonGenNumbers";
            buttonGenNumbers.Size = new Size(264, 57);
            buttonGenNumbers.TabIndex = 0;
            buttonGenNumbers.Text = "Generate Random Numbers";
            buttonGenNumbers.UseVisualStyleBackColor = true;
            buttonGenNumbers.Click += buttonGenNumbers_Click;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 25;
            listBoxNumbers.Location = new Point(36, 20);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(206, 279);
            listBoxNumbers.TabIndex = 1;
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxSelection.Location = new Point(274, 58);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(182, 33);
            comboBoxSelection.TabIndex = 2;
            // 
            // labelNumberInstruction
            // 
            labelNumberInstruction.AutoSize = true;
            labelNumberInstruction.Location = new Point(278, 19);
            labelNumberInstruction.Name = "labelNumberInstruction";
            labelNumberInstruction.Size = new Size(176, 25);
            labelNumberInstruction.TabIndex = 3;
            labelNumberInstruction.Text = "How many Numbers";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(343, 321);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(264, 57);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save Numbers";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FromRandomNumber
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(labelNumberInstruction);
            Controls.Add(comboBoxSelection);
            Controls.Add(listBoxNumbers);
            Controls.Add(buttonGenNumbers);
            Name = "FromRandomNumber";
            Text = "Random Number Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGenNumbers;
        private ListBox listBoxNumbers;
        private ComboBox comboBoxSelection;
        private Label labelNumberInstruction;
        private Button buttonSave;
        private SaveFileDialog saveFileDialogNumbers;
    }
}
