using System;

namespace RPNCalculator.UI
{
    partial class CalcForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.grpCalc = new System.Windows.Forms.GroupBox();
            this.grpSymbols = new System.Windows.Forms.GroupBox();
            this.listViewSymbols = new System.Windows.Forms.ListView();
            this.symbolHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpCalc.SuspendLayout();
            this.grpSymbols.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(290, 350);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(245, 43);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(239, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // grpOutput
            // 
            this.grpOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutput.Controls.Add(this.txtOuput);
            this.grpOutput.Location = new System.Drawing.Point(290, 12);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(245, 332);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Stack";
            // 
            // txtOuput
            // 
            this.txtOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOuput.Location = new System.Drawing.Point(3, 16);
            this.txtOuput.Multiline = true;
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.ReadOnly = true;
            this.txtOuput.Size = new System.Drawing.Size(239, 313);
            this.txtOuput.TabIndex = 1;
            // 
            // grpButtons
            // 
            this.grpCalc.Controls.Add(this.grpSymbols);
            this.grpCalc.Controls.Add(this.grpOutput);
            this.grpCalc.Controls.Add(this.grpInput);
            this.grpCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCalc.Location = new System.Drawing.Point(0, 24);
            this.grpCalc.Name = "grpButtons";
            this.grpCalc.Size = new System.Drawing.Size(546, 396);
            this.grpCalc.TabIndex = 1;
            this.grpCalc.TabStop = false;
            this.grpCalc.Text = "RPN Calculator";
            // 
            // grpSymbols
            // 
            this.grpSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSymbols.Controls.Add(this.listViewSymbols);
            this.grpSymbols.Location = new System.Drawing.Point(6, 12);
            this.grpSymbols.Name = "grpSymbols";
            this.grpSymbols.Size = new System.Drawing.Size(278, 378);
            this.grpSymbols.TabIndex = 2;
            this.grpSymbols.TabStop = false;
            this.grpSymbols.Text = "Symbols";
            // 
            // listViewSymbols
            // 
            this.listViewSymbols.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.symbolHeader,
            this.descriptionHeader});
            this.listViewSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSymbols.HideSelection = false;
            this.listViewSymbols.Location = new System.Drawing.Point(3, 16);
            this.listViewSymbols.Name = "listViewSymbols";
            this.listViewSymbols.Size = new System.Drawing.Size(272, 359);
            this.listViewSymbols.TabIndex = 0;
            this.listViewSymbols.UseCompatibleStateImageBehavior = false;
            this.listViewSymbols.View = System.Windows.Forms.View.Details;
            // 
            // symbolHeader
            // 
            this.symbolHeader.Text = "Symbol";
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 420);
            this.Controls.Add(this.grpCalc);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CalcForm";
            this.Text = "RPN Calculator";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpCalc.ResumeLayout(false);
            this.grpSymbols.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.GroupBox grpCalc;
        private System.Windows.Forms.GroupBox grpSymbols;
        private System.Windows.Forms.ListView listViewSymbols;
        private System.Windows.Forms.ColumnHeader symbolHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}