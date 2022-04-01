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
      this.CardListView.Location = new System.Drawing.Point(438, 53);
      this.CardListView.MultiSelect = false;
      this.CardListView.Name = "CardListView";
      this.CardListView.Size = new System.Drawing.Size(336, 385);
      this.CardListView.TabIndex = 0;
      this.CardListView.UseCompatibleStateImageBehavior = false;
      this.CardListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
      this.chkStructure.Location = new System.Drawing.Point(94, 420);
      this.chkStructure.Name = "chkStructure";
      this.chkStructure.Size = new System.Drawing.Size(80, 17);
      this.chkStructure.TabIndex = 1;
      this.chkStructure.Text = "Is Structure";
      this.chkStructure.UseVisualStyleBackColor = true;
      this.chkStructure.CheckedChanged += new System.EventHandler(this.chkStructure_CheckedChanged);
      // 
      // chkTotem
      // 
      this.chkTotem.AutoSize = true;
      this.chkTotem.Location = new System.Drawing.Point(180, 420);
      this.chkTotem.Name = "chkTotem";
      this.chkTotem.Size = new System.Drawing.Size(63, 17);
      this.chkTotem.TabIndex = 2;
      this.chkTotem.Text = "isTotem";
      this.chkTotem.UseVisualStyleBackColor = true;
      this.chkTotem.CheckedChanged += new System.EventHandler(this.chkTotem_CheckedChanged);
      // 
      // chkUndead
      // 
      this.chkUndead.AutoSize = true;
      this.chkUndead.Location = new System.Drawing.Point(249, 421);
      this.chkUndead.Name = "chkUndead";
      this.chkUndead.Size = new System.Drawing.Size(75, 17);
      this.chkUndead.TabIndex = 3;
      this.chkUndead.Text = "Is Undead";
      this.chkUndead.UseVisualStyleBackColor = true;
      this.chkUndead.CheckedChanged += new System.EventHandler(this.chkUndead_CheckedChanged);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(94, 65);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(180, 20);
      this.txtName.TabIndex = 4;
      this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
      // 
      // txtModifier
      // 
      this.txtModifier.Location = new System.Drawing.Point(94, 248);
      this.txtModifier.Multiline = true;
      this.txtModifier.Name = "txtModifier";
      this.txtModifier.Size = new System.Drawing.Size(180, 166);
      this.txtModifier.TabIndex = 6;
      this.txtModifier.TextChanged += new System.EventHandler(this.txtModifier_TextChanged);
      // 
      // txtType
      // 
      this.txtType.Location = new System.Drawing.Point(94, 91);
      this.txtType.Name = "txtType";
      this.txtType.Size = new System.Drawing.Size(180, 20);
      this.txtType.TabIndex = 10;
      this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
      // 
      // lblID
      // 
      this.lblID.AutoSize = true;
      this.lblID.Location = new System.Drawing.Point(25, 34);
      this.lblID.Name = "lblID";
      this.lblID.Size = new System.Drawing.Size(43, 13);
      this.lblID.TabIndex = 12;
      this.lblID.Text = "Card ID";
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(25, 72);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(35, 13);
      this.lblName.TabIndex = 13;
      this.lblName.Text = "Name";
      // 
      // lblModifier
      // 
      this.lblModifier.AutoSize = true;
      this.lblModifier.Location = new System.Drawing.Point(25, 255);
      this.lblModifier.Name = "lblModifier";
      this.lblModifier.Size = new System.Drawing.Size(44, 13);
      this.lblModifier.TabIndex = 15;
      this.lblModifier.Text = "Modifier";
      // 
      // lblAttack
      // 
      this.lblAttack.AutoSize = true;
      this.lblAttack.Location = new System.Drawing.Point(25, 124);
      this.lblAttack.Name = "lblAttack";
      this.lblAttack.Size = new System.Drawing.Size(38, 13);
      this.lblAttack.TabIndex = 16;
      this.lblAttack.Text = "Attack";
      // 
      // lblHealth
      // 
      this.lblHealth.AutoSize = true;
      this.lblHealth.Location = new System.Drawing.Point(25, 202);
      this.lblHealth.Name = "lblHealth";
      this.lblHealth.Size = new System.Drawing.Size(38, 13);
      this.lblHealth.TabIndex = 17;
      this.lblHealth.Text = "Health";
      // 
      // lblManaCost
      // 
      this.lblManaCost.AutoSize = true;
      this.lblManaCost.Location = new System.Drawing.Point(25, 228);
      this.lblManaCost.Name = "lblManaCost";
      this.lblManaCost.Size = new System.Drawing.Size(58, 13);
      this.lblManaCost.TabIndex = 18;
      this.lblManaCost.Text = "Mana Cost";
      // 
      // lblType
      // 
      this.lblType.AutoSize = true;
      this.lblType.Location = new System.Drawing.Point(25, 98);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(31, 13);
      this.lblType.TabIndex = 19;
      this.lblType.Text = "Type";
      // 
      // lblIDValue
      // 
      this.lblIDValue.AutoSize = true;
      this.lblIDValue.Location = new System.Drawing.Point(94, 34);
      this.lblIDValue.Name = "lblIDValue";
      this.lblIDValue.Size = new System.Drawing.Size(13, 13);
      this.lblIDValue.TabIndex = 20;
      this.lblIDValue.Text = "0";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(332, 59);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 21;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(332, 88);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 22;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lblCardList
      // 
      this.lblCardList.AutoSize = true;
      this.lblCardList.Location = new System.Drawing.Point(435, 34);
      this.lblCardList.Name = "lblCardList";
      this.lblCardList.Size = new System.Drawing.Size(83, 13);
      this.lblCardList.TabIndex = 23;
      this.lblCardList.Text = "Card List Viewer";
      // 
      // lblSpell
      // 
      this.lblSpell.AutoSize = true;
      this.lblSpell.Location = new System.Drawing.Point(25, 150);
      this.lblSpell.Name = "lblSpell";
      this.lblSpell.Size = new System.Drawing.Size(64, 13);
      this.lblSpell.TabIndex = 25;
      this.lblSpell.Text = "Spellcasting";
      // 
      // lblRange
      // 
      this.lblRange.AutoSize = true;
      this.lblRange.Location = new System.Drawing.Point(25, 176);
      this.lblRange.Name = "lblRange";
      this.lblRange.Size = new System.Drawing.Size(39, 13);
      this.lblRange.TabIndex = 27;
      this.lblRange.Text = "Range";
      // 
      // nudAttack
      // 
      this.nudAttack.Location = new System.Drawing.Point(97, 118);
      this.nudAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudAttack.Name = "nudAttack";
      this.nudAttack.Size = new System.Drawing.Size(177, 20);
      this.nudAttack.TabIndex = 28;
      this.nudAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudAttack.ValueChanged += new System.EventHandler(this.nudAttack_ValueChanged);
      // 
      // nudSpell
      // 
      this.nudSpell.Location = new System.Drawing.Point(97, 143);
      this.nudSpell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudSpell.Name = "nudSpell";
      this.nudSpell.Size = new System.Drawing.Size(177, 20);
      this.nudSpell.TabIndex = 29;
      this.nudSpell.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudSpell.ValueChanged += new System.EventHandler(this.nudSpell_ValueChanged);
      // 
      // nudRange
      // 
      this.nudRange.Location = new System.Drawing.Point(97, 169);
      this.nudRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudRange.Name = "nudRange";
      this.nudRange.Size = new System.Drawing.Size(177, 20);
      this.nudRange.TabIndex = 30;
      this.nudRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudRange.ValueChanged += new System.EventHandler(this.nudRange_ValueChanged);
      // 
      // nudHealth
      // 
      this.nudHealth.Location = new System.Drawing.Point(97, 195);
      this.nudHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudHealth.Name = "nudHealth";
      this.nudHealth.Size = new System.Drawing.Size(177, 20);
      this.nudHealth.TabIndex = 31;
      this.nudHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudHealth.ValueChanged += new System.EventHandler(this.nudHealth_ValueChanged);
      // 
      // nudManaCost
      // 
      this.nudManaCost.Location = new System.Drawing.Point(97, 221);
      this.nudManaCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudManaCost.Name = "nudManaCost";
      this.nudManaCost.Size = new System.Drawing.Size(177, 20);
      this.nudManaCost.TabIndex = 32;
      this.nudManaCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
      this.nudManaCost.ValueChanged += new System.EventHandler(this.nudManaCost_ValueChanged);
      // 
      // CardForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
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
  }
}

