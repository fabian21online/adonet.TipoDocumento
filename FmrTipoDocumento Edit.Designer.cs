
namespace AppWinForm2
{
    partial class FmrTipoDocumento_Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnsafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(137, 25);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(211, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(12, 83);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(336, 21);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "¿El tipo de Documento se encuentra disponible?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnsafe
            // 
            this.btnsafe.Location = new System.Drawing.Point(256, 134);
            this.btnsafe.Name = "btnsafe";
            this.btnsafe.Size = new System.Drawing.Size(92, 42);
            this.btnsafe.TabIndex = 3;
            this.btnsafe.Text = "Guardar";
            this.btnsafe.UseVisualStyleBackColor = true;
            this.btnsafe.Click += new System.EventHandler(this.btnsafe_Click);
            // 
            // FmrTipoDocumento_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 212);
            this.Controls.Add(this.btnsafe);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "FmrTipoDocumento_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmrTipoDocumento_Edit";
            this.Load += new System.EventHandler(this.FmrTipoDocumento_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnsafe;
    }
}