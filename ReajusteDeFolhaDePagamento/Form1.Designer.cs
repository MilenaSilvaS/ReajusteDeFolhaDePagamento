
namespace ReajusteDeFolhaDePagamento
{
    partial class ReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReajusteSalarial));
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercentualR = new System.Windows.Forms.Label();
            this.lblTotalCReajuste = new System.Windows.Forms.Label();
            this.lblTotalSReajuste = new System.Windows.Forms.Label();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(488, 20);
            this.txtArquivo.TabIndex = 0;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(506, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(51, 19);
            this.btnSelecionarArquivo.TabIndex = 1;
            this.btnSelecionarArquivo.Text = "...";
            this.toolTip1.SetToolTip(this.btnSelecionarArquivo, "Clique para pesquisar o arquivo");
            this.btnSelecionarArquivo.UseCompatibleTextRendering = true;
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 79);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalCReajuste, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSReajuste, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualReajuste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPercentualR
            // 
            this.lblPercentualR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualR.Location = new System.Drawing.Point(375, 39);
            this.lblPercentualR.Name = "lblPercentualR";
            this.lblPercentualR.Size = new System.Drawing.Size(168, 40);
            this.lblPercentualR.TabIndex = 7;
            this.lblPercentualR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCReajuste
            // 
            this.lblTotalCReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCReajuste.Location = new System.Drawing.Point(189, 39);
            this.lblTotalCReajuste.Name = "lblTotalCReajuste";
            this.lblTotalCReajuste.Size = new System.Drawing.Size(178, 40);
            this.lblTotalCReajuste.TabIndex = 6;
            this.lblTotalCReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSReajuste
            // 
            this.lblTotalSReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSReajuste.Location = new System.Drawing.Point(3, 39);
            this.lblTotalSReajuste.Name = "lblTotalSReajuste";
            this.lblTotalSReajuste.Size = new System.Drawing.Size(178, 40);
            this.lblTotalSReajuste.TabIndex = 5;
            this.lblTotalSReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(375, 0);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(152, 19);
            this.lblPercentualReajuste.TabIndex = 3;
            this.lblPercentualReajuste.Text = "Percentual reajuste";
            this.lblPercentualReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(189, 0);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(178, 19);
            this.lblTotalComReajuste.TabIndex = 2;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(3, 0);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(178, 19);
            this.lblTotalSemReajuste.TabIndex = 1;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLeitura
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeitura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeitura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeitura.Location = new System.Drawing.Point(12, 123);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.Size = new System.Drawing.Size(545, 231);
            this.dgvLeitura.TabIndex = 3;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos Textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do Arquvio com dados de funcionários ";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // ReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 363);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReajusteSalarial";
            this.Text = "Leitura de arquivo para reajuste de salários";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPercentualR;
        private System.Windows.Forms.Label lblTotalCReajuste;
        private System.Windows.Forms.Label lblTotalSReajuste;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

