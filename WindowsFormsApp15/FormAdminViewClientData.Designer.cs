namespace WindowsFormsApp15
{
    partial class FormAdminViewClientData
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
            this.SuspendLayout();
            // 
            // FormAdminViewClientData
            // 
            this.ClientSize = new System.Drawing.Size(1070, 691);
            this.Name = "FormAdminViewClientData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonBack;
        private vege_wholesaleDataSet cookiesDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private cookiesDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.Label label2;
    }
}