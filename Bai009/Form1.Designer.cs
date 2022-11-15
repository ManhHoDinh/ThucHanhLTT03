namespace Bai009
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
        private System.Windows.Forms.Button btUnselectedSubjects;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSaveInformation;
        private System.Windows.Forms.Button btAddSubjects;
        private System.Windows.Forms.ListView lwUnselectedSubject;
        private System.Windows.Forms.ListView lwSelectedSubject;
        private System.Windows.Forms.RadioButton rbWomen;
        private System.Windows.Forms.RadioButton rbMen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMSSV;
    }
}

