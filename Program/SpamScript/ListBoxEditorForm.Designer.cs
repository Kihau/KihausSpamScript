namespace Kihson_s_Spam_Script
{
    partial class ListBoxEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxEditorForm));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.messedit_label = new System.Windows.Forms.Label();
            this.textBoxEditMessage = new System.Windows.Forms.TextBox();
            this.timeeidt_label = new System.Windows.Forms.Label();
            this.numberedit_label = new System.Windows.Forms.Label();
            this.delayedit_label = new System.Windows.Forms.Label();
            this.textBoxEditTime = new System.Windows.Forms.TextBox();
            this.textBoxEditNumber = new System.Windows.Forms.TextBox();
            this.textBoxEditDelay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(81, 226);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(82, 65);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "AKCEPTUJ";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(210, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 65);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "ANULUJ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // messedit_label
            // 
            this.messedit_label.AutoSize = true;
            this.messedit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.messedit_label.Location = new System.Drawing.Point(12, 9);
            this.messedit_label.Name = "messedit_label";
            this.messedit_label.Size = new System.Drawing.Size(341, 25);
            this.messedit_label.TabIndex = 2;
            this.messedit_label.Text = "Nowa wiadomość do spamowania:";
            // 
            // textBoxEditMessage
            // 
            this.textBoxEditMessage.Location = new System.Drawing.Point(17, 37);
            this.textBoxEditMessage.Name = "textBoxEditMessage";
            this.textBoxEditMessage.Size = new System.Drawing.Size(336, 20);
            this.textBoxEditMessage.TabIndex = 4;
            // 
            // timeeidt_label
            // 
            this.timeeidt_label.AutoSize = true;
            this.timeeidt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeeidt_label.Location = new System.Drawing.Point(12, 60);
            this.timeeidt_label.Name = "timeeidt_label";
            this.timeeidt_label.Size = new System.Drawing.Size(332, 25);
            this.timeeidt_label.TabIndex = 5;
            this.timeeidt_label.Text = "Nowa częstotliwość spamowania:";
            // 
            // numberedit_label
            // 
            this.numberedit_label.AutoSize = true;
            this.numberedit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numberedit_label.Location = new System.Drawing.Point(12, 111);
            this.numberedit_label.Name = "numberedit_label";
            this.numberedit_label.Size = new System.Drawing.Size(240, 25);
            this.numberedit_label.TabIndex = 6;
            this.numberedit_label.Text = "Nowa ilość wiadomości:";
            // 
            // delayedit_label
            // 
            this.delayedit_label.AutoSize = true;
            this.delayedit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.delayedit_label.Location = new System.Drawing.Point(12, 162);
            this.delayedit_label.Name = "delayedit_label";
            this.delayedit_label.Size = new System.Drawing.Size(183, 25);
            this.delayedit_label.TabIndex = 7;
            this.delayedit_label.Text = "Nowe opóźnienie:";
            // 
            // textBoxEditTime
            // 
            this.textBoxEditTime.Location = new System.Drawing.Point(17, 88);
            this.textBoxEditTime.Name = "textBoxEditTime";
            this.textBoxEditTime.Size = new System.Drawing.Size(336, 20);
            this.textBoxEditTime.TabIndex = 8;
            // 
            // textBoxEditNumber
            // 
            this.textBoxEditNumber.Location = new System.Drawing.Point(17, 139);
            this.textBoxEditNumber.Name = "textBoxEditNumber";
            this.textBoxEditNumber.Size = new System.Drawing.Size(336, 20);
            this.textBoxEditNumber.TabIndex = 9;
            // 
            // textBoxEditDelay
            // 
            this.textBoxEditDelay.Location = new System.Drawing.Point(17, 190);
            this.textBoxEditDelay.Name = "textBoxEditDelay";
            this.textBoxEditDelay.Size = new System.Drawing.Size(336, 20);
            this.textBoxEditDelay.TabIndex = 10;
            // 
            // ListBoxEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 303);
            this.Controls.Add(this.textBoxEditDelay);
            this.Controls.Add(this.textBoxEditNumber);
            this.Controls.Add(this.textBoxEditTime);
            this.Controls.Add(this.delayedit_label);
            this.Controls.Add(this.numberedit_label);
            this.Controls.Add(this.timeeidt_label);
            this.Controls.Add(this.textBoxEditMessage);
            this.Controls.Add(this.messedit_label);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListBoxEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kihau\'s Spam Script - Edit Window / Okno Edycji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label messedit_label;
        private System.Windows.Forms.TextBox textBoxEditMessage;
        private System.Windows.Forms.Label timeeidt_label;
        private System.Windows.Forms.Label numberedit_label;
        private System.Windows.Forms.Label delayedit_label;
        private System.Windows.Forms.TextBox textBoxEditTime;
        private System.Windows.Forms.TextBox textBoxEditNumber;
        private System.Windows.Forms.TextBox textBoxEditDelay;
    }
}