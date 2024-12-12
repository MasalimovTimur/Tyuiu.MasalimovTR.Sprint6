namespace Tyuiu.MasalimovTR.Sprint6.Task0.V6
{
    partial class FormMain
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
            Result = new TextBox();
            SuspendLayout();
            // 
            // Result
            // 
            Result.Location = new Point(173, 181);
            Result.Name = "Result";
            Result.Size = new Size(442, 23);
            Result.TabIndex = 1;
            Result.TextAlign = HorizontalAlignment.Center;
            Result.TextChanged += Result_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Result);
            Name = "FormMain";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Result;
    }
}
