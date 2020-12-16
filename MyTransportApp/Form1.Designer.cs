namespace MyTransportApp
{
  partial class Form1
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.OverlayVerbindungen = new System.Windows.Forms.TabPage();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.dateTimePickerZeit = new System.Windows.Forms.DateTimePicker();
      this.dataGridViewVerbindungen = new System.Windows.Forms.DataGridView();
      this.VonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NachColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AbfahrtszeitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AnkunftszeitClolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DauerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.NachComboBox = new System.Windows.Forms.ComboBox();
      this.VonComboBox = new System.Windows.Forms.ComboBox();
      this.SearchButton = new System.Windows.Forms.Button();
      this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
      this.VerbindungenLabel = new System.Windows.Forms.Label();
      this.NachLabel = new System.Windows.Forms.Label();
      this.VonLabel = new System.Windows.Forms.Label();
      this.TextBoxVerbindungen = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.TextBox = new System.Windows.Forms.TextBox();
      this.OverlayArbeitstafel = new System.Windows.Forms.TabPage();
      this.dataGridViewArbeitstafel = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SearchButtonArbeitstafel = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.VonComboBoxArbeitstafel = new System.Windows.Forms.ComboBox();
      this.ArbeitstafelTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.OverlayKarte = new System.Windows.Forms.TabPage();
      this.KarteTextbox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.tabControl1.SuspendLayout();
      this.OverlayVerbindungen.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).BeginInit();
      this.OverlayArbeitstafel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbeitstafel)).BeginInit();
      this.OverlayKarte.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.OverlayVerbindungen);
      this.tabControl1.Controls.Add(this.OverlayArbeitstafel);
      this.tabControl1.Controls.Add(this.OverlayKarte);
      this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(799, 448);
      this.tabControl1.TabIndex = 0;
      // 
      // OverlayVerbindungen
      // 
      this.OverlayVerbindungen.BackColor = System.Drawing.Color.Silver;
      this.OverlayVerbindungen.Controls.Add(this.label6);
      this.OverlayVerbindungen.Controls.Add(this.label5);
      this.OverlayVerbindungen.Controls.Add(this.dateTimePickerZeit);
      this.OverlayVerbindungen.Controls.Add(this.dataGridViewVerbindungen);
      this.OverlayVerbindungen.Controls.Add(this.NachComboBox);
      this.OverlayVerbindungen.Controls.Add(this.VonComboBox);
      this.OverlayVerbindungen.Controls.Add(this.SearchButton);
      this.OverlayVerbindungen.Controls.Add(this.dateTimePickerDatum);
      this.OverlayVerbindungen.Controls.Add(this.VerbindungenLabel);
      this.OverlayVerbindungen.Controls.Add(this.NachLabel);
      this.OverlayVerbindungen.Controls.Add(this.VonLabel);
      this.OverlayVerbindungen.Controls.Add(this.TextBoxVerbindungen);
      this.OverlayVerbindungen.Controls.Add(this.label1);
      this.OverlayVerbindungen.Controls.Add(this.TextBox);
      this.OverlayVerbindungen.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.OverlayVerbindungen.Location = new System.Drawing.Point(4, 22);
      this.OverlayVerbindungen.Name = "OverlayVerbindungen";
      this.OverlayVerbindungen.Size = new System.Drawing.Size(791, 422);
      this.OverlayVerbindungen.TabIndex = 2;
      this.OverlayVerbindungen.Text = "Verbindungen";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(225, 98);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(41, 13);
      this.label6.TabIndex = 18;
      this.label6.Text = "Datum:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(225, 146);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(28, 13);
      this.label5.TabIndex = 17;
      this.label5.Text = "Zeit:";
      // 
      // dateTimePickerZeit
      // 
      this.dateTimePickerZeit.Checked = false;
      this.dateTimePickerZeit.CustomFormat = "HH:mm";
      this.dateTimePickerZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePickerZeit.Location = new System.Drawing.Point(259, 143);
      this.dateTimePickerZeit.Name = "dateTimePickerZeit";
      this.dateTimePickerZeit.ShowUpDown = true;
      this.dateTimePickerZeit.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerZeit.TabIndex = 16;
      this.dateTimePickerZeit.Value = new System.DateTime(2020, 12, 16, 12, 31, 0, 0);
      // 
      // dataGridViewVerbindungen
      // 
      this.dataGridViewVerbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewVerbindungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VonColumn,
            this.NachColumn,
            this.AbfahrtszeitColumn,
            this.AnkunftszeitClolumn,
            this.DauerColumn});
      this.dataGridViewVerbindungen.Location = new System.Drawing.Point(23, 202);
      this.dataGridViewVerbindungen.Name = "dataGridViewVerbindungen";
      this.dataGridViewVerbindungen.Size = new System.Drawing.Size(718, 204);
      this.dataGridViewVerbindungen.TabIndex = 15;
      this.dataGridViewVerbindungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerbindungen_CellContentClick);
      // 
      // VonColumn
      // 
      this.VonColumn.HeaderText = "Von";
      this.VonColumn.Name = "VonColumn";
      this.VonColumn.ReadOnly = true;
      this.VonColumn.Width = 170;
      // 
      // NachColumn
      // 
      this.NachColumn.HeaderText = "Nach";
      this.NachColumn.Name = "NachColumn";
      this.NachColumn.ReadOnly = true;
      this.NachColumn.Width = 170;
      // 
      // AbfahrtszeitColumn
      // 
      this.AbfahrtszeitColumn.HeaderText = "Abfahrtszeit";
      this.AbfahrtszeitColumn.Name = "AbfahrtszeitColumn";
      this.AbfahrtszeitColumn.ReadOnly = true;
      this.AbfahrtszeitColumn.Width = 170;
      // 
      // AnkunftszeitClolumn
      // 
      this.AnkunftszeitClolumn.HeaderText = "Ankunftszeit";
      this.AnkunftszeitClolumn.Name = "AnkunftszeitClolumn";
      this.AnkunftszeitClolumn.ReadOnly = true;
      this.AnkunftszeitClolumn.Width = 170;
      // 
      // DauerColumn
      // 
      this.DauerColumn.HeaderText = "Dauer";
      this.DauerColumn.Name = "DauerColumn";
      this.DauerColumn.ReadOnly = true;
      this.DauerColumn.Width = 150;
      // 
      // NachComboBox
      // 
      this.NachComboBox.FormattingEnabled = true;
      this.NachComboBox.Location = new System.Drawing.Point(55, 143);
      this.NachComboBox.Name = "NachComboBox";
      this.NachComboBox.Size = new System.Drawing.Size(132, 21);
      this.NachComboBox.TabIndex = 14;
      // 
      // VonComboBox
      // 
      this.VonComboBox.FormattingEnabled = true;
      this.VonComboBox.Location = new System.Drawing.Point(55, 91);
      this.VonComboBox.Name = "VonComboBox";
      this.VonComboBox.Size = new System.Drawing.Size(132, 21);
      this.VonComboBox.TabIndex = 13;
      // 
      // SearchButton
      // 
      this.SearchButton.Location = new System.Drawing.Point(641, 146);
      this.SearchButton.Name = "SearchButton";
      this.SearchButton.Size = new System.Drawing.Size(100, 38);
      this.SearchButton.TabIndex = 11;
      this.SearchButton.Text = "Search";
      this.SearchButton.UseVisualStyleBackColor = true;
      this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
      // 
      // dateTimePickerDatum
      // 
      this.dateTimePickerDatum.Location = new System.Drawing.Point(267, 92);
      this.dateTimePickerDatum.Name = "dateTimePickerDatum";
      this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerDatum.TabIndex = 10;
      this.dateTimePickerDatum.Value = new System.DateTime(2020, 12, 16, 0, 0, 0, 0);
      // 
      // VerbindungenLabel
      // 
      this.VerbindungenLabel.AutoSize = true;
      this.VerbindungenLabel.Location = new System.Drawing.Point(20, 186);
      this.VerbindungenLabel.Name = "VerbindungenLabel";
      this.VerbindungenLabel.Size = new System.Drawing.Size(76, 13);
      this.VerbindungenLabel.TabIndex = 8;
      this.VerbindungenLabel.Text = "Verbindungen:";
      // 
      // NachLabel
      // 
      this.NachLabel.AutoSize = true;
      this.NachLabel.Location = new System.Drawing.Point(20, 146);
      this.NachLabel.Name = "NachLabel";
      this.NachLabel.Size = new System.Drawing.Size(36, 13);
      this.NachLabel.TabIndex = 7;
      this.NachLabel.Text = "Nach:";
      // 
      // VonLabel
      // 
      this.VonLabel.AutoSize = true;
      this.VonLabel.Location = new System.Drawing.Point(20, 95);
      this.VonLabel.Name = "VonLabel";
      this.VonLabel.Size = new System.Drawing.Size(29, 13);
      this.VonLabel.TabIndex = 6;
      this.VonLabel.Text = "Von:";
      // 
      // TextBoxVerbindungen
      // 
      this.TextBoxVerbindungen.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TextBoxVerbindungen.Location = new System.Drawing.Point(105, 27);
      this.TextBoxVerbindungen.Name = "TextBoxVerbindungen";
      this.TextBoxVerbindungen.Size = new System.Drawing.Size(240, 36);
      this.TextBoxVerbindungen.TabIndex = 4;
      this.TextBoxVerbindungen.Text = "Verbindungen suchen";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(16, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 42);
      this.label1.TabIndex = 3;
      this.label1.Text = "MTA";
      // 
      // TextBox
      // 
      this.TextBox.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TextBox.Location = new System.Drawing.Point(8, 12);
      this.TextBox.Multiline = true;
      this.TextBox.Name = "TextBox";
      this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
      this.TextBox.Size = new System.Drawing.Size(776, 67);
      this.TextBox.TabIndex = 2;
      // 
      // OverlayArbeitstafel
      // 
      this.OverlayArbeitstafel.BackColor = System.Drawing.Color.Silver;
      this.OverlayArbeitstafel.Controls.Add(this.dataGridViewArbeitstafel);
      this.OverlayArbeitstafel.Controls.Add(this.SearchButtonArbeitstafel);
      this.OverlayArbeitstafel.Controls.Add(this.label4);
      this.OverlayArbeitstafel.Controls.Add(this.VonComboBoxArbeitstafel);
      this.OverlayArbeitstafel.Controls.Add(this.ArbeitstafelTextBox);
      this.OverlayArbeitstafel.Controls.Add(this.label2);
      this.OverlayArbeitstafel.Controls.Add(this.textBox2);
      this.OverlayArbeitstafel.Location = new System.Drawing.Point(4, 22);
      this.OverlayArbeitstafel.Name = "OverlayArbeitstafel";
      this.OverlayArbeitstafel.Padding = new System.Windows.Forms.Padding(3);
      this.OverlayArbeitstafel.Size = new System.Drawing.Size(791, 422);
      this.OverlayArbeitstafel.TabIndex = 1;
      this.OverlayArbeitstafel.Text = "Arbeitstafel";
      // 
      // dataGridViewArbeitstafel
      // 
      this.dataGridViewArbeitstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewArbeitstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.dataGridViewArbeitstafel.Location = new System.Drawing.Point(26, 155);
      this.dataGridViewArbeitstafel.Name = "dataGridViewArbeitstafel";
      this.dataGridViewArbeitstafel.Size = new System.Drawing.Size(718, 261);
      this.dataGridViewArbeitstafel.TabIndex = 17;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Von";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 170;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Nach";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 170;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Abfahrtszeit";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 170;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "Ankunftszeit";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 170;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "Dauer";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 150;
      // 
      // SearchButtonArbeitstafel
      // 
      this.SearchButtonArbeitstafel.Location = new System.Drawing.Point(286, 102);
      this.SearchButtonArbeitstafel.Name = "SearchButtonArbeitstafel";
      this.SearchButtonArbeitstafel.Size = new System.Drawing.Size(100, 38);
      this.SearchButtonArbeitstafel.TabIndex = 16;
      this.SearchButtonArbeitstafel.Text = "Search";
      this.SearchButtonArbeitstafel.UseVisualStyleBackColor = true;
      this.SearchButtonArbeitstafel.Click += new System.EventHandler(this.SearchButtonArbeitstafel_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(23, 115);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Von:";
      // 
      // VonComboBoxArbeitstafel
      // 
      this.VonComboBoxArbeitstafel.FormattingEnabled = true;
      this.VonComboBoxArbeitstafel.Location = new System.Drawing.Point(58, 115);
      this.VonComboBoxArbeitstafel.Name = "VonComboBoxArbeitstafel";
      this.VonComboBoxArbeitstafel.Size = new System.Drawing.Size(132, 21);
      this.VonComboBoxArbeitstafel.TabIndex = 14;
      // 
      // ArbeitstafelTextBox
      // 
      this.ArbeitstafelTextBox.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ArbeitstafelTextBox.Location = new System.Drawing.Point(108, 35);
      this.ArbeitstafelTextBox.Name = "ArbeitstafelTextBox";
      this.ArbeitstafelTextBox.Size = new System.Drawing.Size(240, 36);
      this.ArbeitstafelTextBox.TabIndex = 5;
      this.ArbeitstafelTextBox.Text = "Arbeitstafel";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label2.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Blue;
      this.label2.Location = new System.Drawing.Point(19, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 42);
      this.label2.TabIndex = 4;
      this.label2.Text = "MTA";
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox2.Location = new System.Drawing.Point(9, 17);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
      this.textBox2.Size = new System.Drawing.Size(776, 67);
      this.textBox2.TabIndex = 3;
      // 
      // OverlayKarte
      // 
      this.OverlayKarte.BackColor = System.Drawing.Color.Silver;
      this.OverlayKarte.Controls.Add(this.KarteTextbox);
      this.OverlayKarte.Controls.Add(this.label3);
      this.OverlayKarte.Controls.Add(this.textBox3);
      this.OverlayKarte.Location = new System.Drawing.Point(4, 22);
      this.OverlayKarte.Name = "OverlayKarte";
      this.OverlayKarte.Padding = new System.Windows.Forms.Padding(3);
      this.OverlayKarte.Size = new System.Drawing.Size(791, 422);
      this.OverlayKarte.TabIndex = 0;
      this.OverlayKarte.Text = "Karte";
      // 
      // KarteTextbox
      // 
      this.KarteTextbox.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KarteTextbox.Location = new System.Drawing.Point(106, 30);
      this.KarteTextbox.Name = "KarteTextbox";
      this.KarteTextbox.Size = new System.Drawing.Size(240, 36);
      this.KarteTextbox.TabIndex = 6;
      this.KarteTextbox.Text = "Karte";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label3.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.Blue;
      this.label3.Location = new System.Drawing.Point(17, 30);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(83, 42);
      this.label3.TabIndex = 5;
      this.label3.Text = "MTA";
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox3.Location = new System.Drawing.Point(6, 17);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
      this.textBox3.Size = new System.Drawing.Size(776, 67);
      this.textBox3.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "MyTransportApp";
      this.tabControl1.ResumeLayout(false);
      this.OverlayVerbindungen.ResumeLayout(false);
      this.OverlayVerbindungen.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerbindungen)).EndInit();
      this.OverlayArbeitstafel.ResumeLayout(false);
      this.OverlayArbeitstafel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArbeitstafel)).EndInit();
      this.OverlayKarte.ResumeLayout(false);
      this.OverlayKarte.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage OverlayVerbindungen;
    private System.Windows.Forms.Button SearchButton;
    private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
    private System.Windows.Forms.Label VerbindungenLabel;
    private System.Windows.Forms.Label NachLabel;
    private System.Windows.Forms.Label VonLabel;
    private System.Windows.Forms.TextBox TextBoxVerbindungen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TextBox;
    private System.Windows.Forms.TabPage OverlayArbeitstafel;
    private System.Windows.Forms.TabPage OverlayKarte;
    private System.Windows.Forms.ComboBox NachComboBox;
    private System.Windows.Forms.ComboBox VonComboBox;
    private System.Windows.Forms.TextBox ArbeitstafelTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox KarteTextbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.DataGridView dataGridViewVerbindungen;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.DataGridViewTextBoxColumn VonColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn NachColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AbfahrtszeitColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AnkunftszeitClolumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DauerColumn;
    private System.Windows.Forms.DataGridView dataGridViewArbeitstafel;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.Button SearchButtonArbeitstafel;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox VonComboBoxArbeitstafel;
    private System.Windows.Forms.DateTimePicker dateTimePickerZeit;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
  }
}

