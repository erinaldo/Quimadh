namespace Controles
{
    partial class CustomListView
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
            this.SuspendLayout();
            // 
            // CustomListView
            // 
            this.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.FullRowSelect = true;
            this.MultiSelect = false;
            this.View = System.Windows.Forms.View.Details;
            this.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.CustomListView_ColumnClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
