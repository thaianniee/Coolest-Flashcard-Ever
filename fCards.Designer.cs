
using System.Drawing;

namespace CoolestFlashCardAppEver
{
    partial class fCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCards));
            this.lblEng = new System.Windows.Forms.Label();
            this.lblVi = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btCustomize = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEng
            // 
            resources.ApplyResources(this.lblEng, "lblEng");
            this.lblEng.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEng.Name = "lblEng";
            // 
            // lblVi
            // 
            resources.ApplyResources(this.lblVi, "lblVi");
            this.lblVi.ForeColor = System.Drawing.Color.Navy;
            this.lblVi.Name = "lblVi";
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::CoolestFlashCardAppEver.Properties.Resources.delete;
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btCustomize
            // 
            this.btCustomize.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCustomize.BackgroundImage = global::CoolestFlashCardAppEver.Properties.Resources.settings;
            resources.ApplyResources(this.btCustomize, "btCustomize");
            this.btCustomize.ForeColor = System.Drawing.Color.Black;
            this.btCustomize.Name = "btCustomize";
            this.btCustomize.UseVisualStyleBackColor = false;
            this.btCustomize.Click += new System.EventHandler(this.btCustomize_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.BackgroundImage = global::CoolestFlashCardAppEver.Properties.Resources.pencil_128x128;
            resources.ApplyResources(this.btEdit, "btEdit");
            this.btEdit.ForeColor = System.Drawing.Color.Black;
            this.btEdit.Name = "btEdit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // fCards
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ControlBox = false;
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btCustomize);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lblVi);
            this.Controls.Add(this.lblEng);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCards";
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.DarkSalmon;
            this.Load += new System.EventHandler(this.fCards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblEng;
        public System.Windows.Forms.Label lblVi;
        public System.Windows.Forms.Button btClose;
        public System.Windows.Forms.Button btCustomize;
        public System.Windows.Forms.Button btEdit;
    }
}

