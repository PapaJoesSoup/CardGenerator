namespace CardGenerator
{
  partial class CardForm
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
      this.CardListView = new System.Windows.Forms.ListView();
      this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ManaCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chkStructure = new System.Windows.Forms.CheckBox();
      this.chkTotem = new System.Windows.Forms.CheckBox();
      this.chkUndead = new System.Windows.Forms.CheckBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.txtModifier = new System.Windows.Forms.TextBox();
      this.txtType = new System.Windows.Forms.TextBox();
      this.lblID = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.lblModifier = new System.Windows.Forms.Label();
      this.lblAttack = new System.Windows.Forms.Label();
      this.lblHealth = new System.Windows.Forms.Label();
      this.lblManaCost = new System.Windows.Forms.Label();
      this.lblType = new System.Windows.Forms.Label();
      this.lblIDValue = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblCardList = new System.Windows.Forms.Label();
      this.lblSpell = new System.Windows.Forms.Label();
      this.lblRange = new System.Windows.Forms.Label();
      this.nudAttack = new System.Windows.Forms.NumericUpDown();
      this.nudSpell = new System.Windows.Forms.NumericUpDown();
      this.nudRange = new System.Windows.Forms.NumericUpDown();
      this.nudHealth = new System.Windows.Forms.NumericUpDown();
      this.nudManaCost = new System.Windows.Forms.NumericUpDown();
      this.btnInsert = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSpell)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudManaCost)).BeginInit();
      this.SuspendLayout();
      // 
      // CardListView
      // 
      this.CardListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.CardListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CardName,
            this.ManaCost});
      this.CardListView.FullRowSelect = true;
      this.CardListView.HideSelection = false;
      this.CardListView.Location = new System.Drawing.Point(438, 42);
      this.CardListView.MultiSelect = false;
      this.CardListView.Name = "CardListView";
      this.CardListView.Size = new System.Drawing.Size(335, 363);
      this.CardListView.TabIndex = 0;
      this.CardListView.UseCompatibleStateImageBehavior = false;
      this.CardListView.SelectedIndexChanged += new System.EventHandler(this.CardListView_SelectedIndexChanged);
      // 
      // ID
      // 
      this.ID.Text = "ID";
      // 
      // CardName
      // 
      this.CardName.Text = "Card Name";
      // 
      // ManaCost
      // 
      this.ManaCost.Text = "ManaCost";
      // 
      // chkStructure
      // 
      this.chkStructure.AutoSize = true;
      this.chkStructure.Location = new System.Drawing.Point(94, 411);
      this.chkStructure.Name = "chkStructure";
      this.chkStructure.Size = new System.Drawing.Size(80, 17);
      this.chkStructure.TabIndex = 9;
      this.chkStructure.Text = "Is Structure";
      this.chkStructure.UseVisualStyleBackColor = true;
      this.chkStructure.CheckedChanged += new System.EventHandler(this.ChkStructure_CheckedChanged);
      // 
      // chkTotem
      // 
      this.chkTotem.AutoSize = true;
      this.chkTotem.Location = new System.Drawing.Point(180, 411);
      this.chkTotem.Name = "chkTotem";
      this.chkTotem.Size = new System.Drawing.Size(63, 17);
      this.chkTotem.TabIndex = 10;
      this.chkTotem.Text = "isTotem";
      this.chkTotem.UseVisualStyleBackColor = true;
      this.chkTotem.CheckedChanged += new System.EventHandler(this.ChkTotem_CheckedChanged);
      // 
      // chkUndead
      // 
      this.chkUndead.AutoSize = true;
      this.chkUndead.Location = new System.Drawing.Point(249, 412);
      this.chkUndead.Name = "chkUndead";
      this.chkUndead.Size = new System.Drawing.Size(75, 17);
      this.chkUndead.TabIndex = 11;
      this.chkUndead.Text = "Is Undead";
      this.chkUndead.UseVisualStyleBackColor = true;
      this.chkUndead.CheckedChanged += new System.EventHandler(this.ChkUndead_CheckedChanged);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(94, 40);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(230, 20);
      this.txtName.TabIndex = 1;
      this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
      this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
      // 
      // txtModifier
      // 
      this.txtModifier.Location = new System.Drawing.Point(94, 223);
      this.txtModifier.Multiline = true;
      this.txtModifier.Name = "txtModifier";
      this.txtModifier.Size = new System.Drawing.Size(230, 181);
      this.txtModifier.TabIndex = 8;
      this.txtModifier.TextChanged += new System.EventHandler(this.TxtModifier_TextChanged);
      this.txtModifier.Enter += new System.EventHandler(this.TxtModifier_Enter);
      // 
      // txtType
      // 
      this.txtType.Location = new System.Drawing.Point(94, 66);
      this.txtType.Name = "txtType";
      this.txtType.Size = new System.Drawing.Size(230, 20);
      this.txtType.TabIndex = 2;
      this.txtType.TextChanged += new System.EventHandler(this.TxtType_TextChanged);
      this.txtType.Enter += new System.EventHandler(this.TxtType_Enter);
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Location = new System.Drawing.Point(25, 24);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(43, 13);
      this.lblID.TabIndex = 12;
      this.lblID.Text = "Card ID";
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(25, 47);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(35, 13);
      this.lblName.TabIndex = 13;
      this.lblName.Text = "Name";
      this.lblName.Click += new System.EventHandler(this.lblName_Click);
      // 
      // lblModifier
      // 
      this.lblModifier.AutoSize = true;
      this.lblModifier.Location = new System.Drawing.Point(25, 230);
      this.lblModifier.Name = "lblModifier";
      this.lblModifier.Size = new System.Drawing.Size(44, 13);
      this.lblModifier.TabIndex = 15;
      this.lblModifier.Text = "Modifier";
      // 
      // lblAttack
      // 
      this.lblAttack.AutoSize = true;
      this.lblAttack.Location = new System.Drawing.Point(25, 99);
      this.lblAttack.Name = "lblAttack";
      this.lblAttack.Size = new System.Drawing.Size(38, 13);
      this.lblAttack.TabIndex = 16;
      this.lblAttack.Text = "Attack";
      // 
      // lblHealth
      // 
      this.lblHealth.AutoSize = true;
      this.lblHealth.Location = new System.Drawing.Point(25, 177);
      this.lblHealth.Name = "lblHealth";
      this.lblHealth.Size = new System.Drawing.Size(38, 13);
      this.lblHealth.TabIndex = 17;
      this.lblHealth.Text = "Health";
      // 
      // lblManaCost
      // 
      this.lblManaCost.AutoSize = true;
      this.lblManaCost.Location = new System.Drawing.Point(25, 203);
      this.lblManaCost.Name = "lblManaCost";
      this.lblManaCost.Size = new System.Drawing.Size(58, 13);
      this.lblManaCost.TabIndex = 18;
      this.lblManaCost.Text = "Mana Cost";
      // 
      // lblType
      // 
      this.lblType.AutoSize = true;
      this.lblType.Location = new System.Drawing.Point(25, 73);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(31, 13);
      this.lblType.TabIndex = 19;
      this.lblType.Text = "Type";
      // 
      // lblIDValue
      // 
      this.lblIDValue.AutoSize = true;
      this.lblIDValue.Location = new System.Drawing.Point(94, 24);
      this.lblIDValue.Name = "lblIDValue";
      this.lblIDValue.Size = new System.Drawing.Size(13, 13);
      this.lblIDValue.TabIndex = 20;
      this.lblIDValue.Text = "0";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(341, 39);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(341, 68);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // lblCardList
      // 
      this.lblCardList.AutoSize = true;
      this.lblCardList.Location = new System.Drawing.Point(435, 24);
      this.lblCardList.Name = "lblCardList";
      this.lblCardList.Size = new System.Drawing.Size(83, 13);
      this.lblCardList.TabIndex = 23;
      this.lblCardList.Text = "Card List Viewer";
      // 
      // lblSpell
      // 
      this.lblSpell.AutoSize = true;
      this.lblSpell.Location = new System.Drawing.Point(25, 125);
      this.lblSpell.Name = "lblSpell";
      this.lblSpell.Size = new System.Drawing.Size(64, 13);
      this.lblSpell.TabIndex = 25;
      this.lblSpell.Text = "Spellcasting";
      // 
      // lblRange
      // 
      this.lblRange.AutoSize = true;
      this.lblRange.Location = new System.Drawing.Point(25, 151);
      this.lblRange.Name = "lblRange";
      this.lblRange.Size = new System.Drawing.Size(39, 13);
      this.lblRange.TabIndex = 27;
      this.lblRange.Text = "Range";
      // 
      // nudAttack
      // 
      this.nudAttack.Location = new System.Drawing.Point(97, 93);
      this.nudAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudAttack.Name = "nudAttack";
      this.nudAttack.Size = new System.Drawing.Size(227, 20);
      this.nudAttack.TabIndex = 3;
      this.nudAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudAttack.ValueChanged += new System.EventHandler(this.NudAttack_ValueChanged);
      this.nudAttack.Enter += new System.EventHandler(this.NudAttack_Enter);
      // 
      // nudSpell
      // 
      this.nudSpell.Location = new System.Drawing.Point(97, 118);
      this.nudSpell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudSpell.Name = "nudSpell";
      this.nudSpell.Size = new System.Drawing.Size(227, 20);
      this.nudSpell.TabIndex = 4;
      this.nudSpell.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudSpell.ValueChanged += new System.EventHandler(this.NudSpell_ValueChanged);
      this.nudSpell.Enter += new System.EventHandler(this.NudSpell_Enter);
      // 
      // nudRange
      // 
      this.nudRange.Location = new System.Drawing.Point(97, 144);
      this.nudRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudRange.Name = "nudRange";
      this.nudRange.Size = new System.Drawing.Size(227, 20);
      this.nudRange.TabIndex = 5;
      this.nudRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudRange.ValueChanged += new System.EventHandler(this.NudRange_ValueChanged);
      this.nudRange.Enter += new System.EventHandler(this.NudRange_Enter);
      // 
      // nudHealth
      // 
      this.nudHealth.Location = new System.Drawing.Point(97, 170);
      this.nudHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudHealth.Name = "nudHealth";
      this.nudHealth.Size = new System.Drawing.Size(227, 20);
      this.nudHealth.TabIndex = 6;
      this.nudHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudHealth.ValueChanged += new System.EventHandler(this.NudHealth_ValueChanged);
      this.nudHealth.Enter += new System.EventHandler(this.NudHealth_Enter);
      // 
      // nudManaCost
      // 
      this.nudManaCost.Location = new System.Drawing.Point(97, 196);
      this.nudManaCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudManaCost.Name = "nudManaCost";
      this.nudManaCost.Size = new System.Drawing.Size(227, 20);
      this.nudManaCost.TabIndex = 7;
      this.nudManaCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudManaCost.ValueChanged += new System.EventHandler(this.NudManaCost_ValueChanged);
      this.nudManaCost.Enter += new System.EventHandler(this.NudManaCost_Enter);
      // 
      // btnInsert
      // 
      this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnInsert.Location = new System.Drawing.Point(437, 411);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(75, 23);
      this.btnInsert.TabIndex = 14;
      this.btnInsert.Text = "Insert";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDelete.Location = new System.Drawing.Point(518, 412);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 15;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
      // 
      // btnGenerate
      // 
      this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGenerate.Location = new System.Drawing.Point(656, 413);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(117, 23);
      this.btnGenerate.TabIndex = 28;
      this.btnGenerate.Text = "Open Generator";
      this.btnGenerate.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(323, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 29;
      this.label1.Text = "*";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(323, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(12, 13);
      this.label2.TabIndex = 30;
      this.label2.Text = "*";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(323, 198);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(12, 13);
      this.label3.TabIndex = 31;
      this.label3.Text = "*";
      // 
      // CardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 451);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGenerate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.nudManaCost);
      this.Controls.Add(this.nudHealth);
      this.Controls.Add(this.nudRange);
      this.Controls.Add(this.nudSpell);
      this.Controls.Add(this.nudAttack);
      this.Controls.Add(this.lblRange);
      this.Controls.Add(this.lblSpell);
      this.Controls.Add(this.lblCardList);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lblIDValue);
      this.Controls.Add(this.lblType);
      this.Controls.Add(this.lblManaCost);
      this.Controls.Add(this.lblHealth);
      this.Controls.Add(this.lblAttack);
      this.Controls.Add(this.lblModifier);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblID);
      this.Controls.Add(this.txtType);
      this.Controls.Add(this.txtModifier);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.chkUndead);
      this.Controls.Add(this.chkTotem);
      this.Controls.Add(this.chkStructure);
      this.Controls.Add(this.CardListView);
      this.MinimumSize = new System.Drawing.Size(815, 490);
      this.Name = "CardForm";
      this.Text = "CardGenerator";
      ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSpell)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudManaCost)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView CardListView;
    private System.Windows.Forms.ColumnHeader ID;
    private System.Windows.Forms.ColumnHeader CardName;
    private System.Windows.Forms.ColumnHeader ManaCost;

    private System.Windows.Forms.CheckBox chkStructure;
    private System.Windows.Forms.CheckBox chkTotem;
    private System.Windows.Forms.CheckBox chkUndead;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtModifier;
    private System.Windows.Forms.TextBox txtType;
    private System.Windows.Forms.Label lblID;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblModifier;
    private System.Windows.Forms.Label lblAttack;
    private System.Windows.Forms.Label lblHealth;
    private System.Windows.Forms.Label lblManaCost;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Label lblIDValue;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lblCardList;
    private System.Windows.Forms.Label lblSpell;
    private System.Windows.Forms.Label lblRange;
    private System.Windows.Forms.NumericUpDown nudAttack;
    private System.Windows.Forms.NumericUpDown nudSpell;
    private System.Windows.Forms.NumericUpDown nudRange;
    private System.Windows.Forms.NumericUpDown nudHealth;
    private System.Windows.Forms.NumericUpDown nudManaCost;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}

