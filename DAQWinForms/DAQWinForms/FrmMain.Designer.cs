
namespace DAQWinForms
{
    partial class FrmMain
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMBCommand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtL1Volts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOFaseL1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmpsL1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 39);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 24);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(126, 39);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(100, 24);
            this.txtCommand.TabIndex = 2;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Channel";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(242, 39);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 24);
            this.txtChannel.TabIndex = 4;
            this.txtChannel.TextChanged += new System.EventHandler(this.txtChannel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CRC";
            // 
            // txtCRC
            // 
            this.txtCRC.Location = new System.Drawing.Point(359, 39);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.Size = new System.Drawing.Size(100, 24);
            this.txtCRC.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(135, 162);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMBCommand
            // 
            this.txtMBCommand.Location = new System.Drawing.Point(13, 162);
            this.txtMBCommand.Name = "txtMBCommand";
            this.txtMBCommand.Size = new System.Drawing.Size(116, 24);
            this.txtMBCommand.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "MODBUS Command";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Volts L1";
            // 
            // txtL1Volts
            // 
            this.txtL1Volts.Location = new System.Drawing.Point(12, 252);
            this.txtL1Volts.Name = "txtL1Volts";
            this.txtL1Volts.Size = new System.Drawing.Size(100, 24);
            this.txtL1Volts.TabIndex = 11;
            this.txtL1Volts.TextChanged += new System.EventHandler(this.txtL1Volts_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Frequency";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(118, 252);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 24);
            this.txtFrequency.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Angulo de Fase L1";
            // 
            // txtOFaseL1
            // 
            this.txtOFaseL1.Location = new System.Drawing.Point(224, 252);
            this.txtOFaseL1.Name = "txtOFaseL1";
            this.txtOFaseL1.Size = new System.Drawing.Size(100, 24);
            this.txtOFaseL1.TabIndex = 15;
            this.txtOFaseL1.TextChanged += new System.EventHandler(this.txtOFaseL1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Amps L1";
            // 
            // txtAmpsL1
            // 
            this.txtAmpsL1.Location = new System.Drawing.Point(12, 305);
            this.txtAmpsL1.Name = "txtAmpsL1";
            this.txtAmpsL1.Size = new System.Drawing.Size(100, 24);
            this.txtAmpsL1.TabIndex = 17;
            this.txtAmpsL1.TextChanged += new System.EventHandler(this.txtAmpsL1_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAmpsL1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOFaseL1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtL1Volts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMBCommand);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCRC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Name = "FrmMain";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMBCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtL1Volts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOFaseL1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmpsL1;
    }
}

