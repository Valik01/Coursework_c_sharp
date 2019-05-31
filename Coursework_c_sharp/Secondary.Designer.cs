namespace Coursework_c_sharp
{
   partial class Secondary
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
         this.cecondarytB = new System.Windows.Forms.TextBox();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.butSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // cecondarytB
         // 
         this.cecondarytB.Location = new System.Drawing.Point(31, 28);
         this.cecondarytB.Name = "cecondarytB";
         this.cecondarytB.Size = new System.Drawing.Size(88, 22);
         this.cecondarytB.TabIndex = 0;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // butSave
         // 
         this.butSave.Location = new System.Drawing.Point(31, 69);
         this.butSave.Name = "butSave";
         this.butSave.Size = new System.Drawing.Size(87, 34);
         this.butSave.TabIndex = 2;
         this.butSave.Text = "Save";
         this.butSave.UseVisualStyleBackColor = true;
         this.butSave.Click += new System.EventHandler(this.butSave_Click);
         // 
         // Secondary
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(148, 134);
         this.Controls.Add(this.butSave);
         this.Controls.Add(this.cecondarytB);
         this.Name = "Secondary";
         this.Text = "Secondary";
         this.Load += new System.EventHandler(this.Secondary_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox cecondarytB;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Button butSave;
   }
}