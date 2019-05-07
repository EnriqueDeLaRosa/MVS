namespace EjemploBBDD
{
    partial class VentanaPrincipal
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
            this.desplegablePelis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // desplegablePelis
            // 
            this.desplegablePelis.FormattingEnabled = true;
            this.desplegablePelis.Location = new System.Drawing.Point(13, 13);
            this.desplegablePelis.Name = "desplegablePelis";
            this.desplegablePelis.Size = new System.Drawing.Size(121, 21);
            this.desplegablePelis.TabIndex = 0;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desplegablePelis);
            this.Name = "VentanaPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegablePelis;
    }
}