using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGenerator
{
    public partial class CardForm : Form
    {
        // For Ethan, use "Ethan_Con" instead of "JDK_Con"
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Ethan_Con"].ConnectionString;
        public SqlConnection Con;
        public SqlDataAdapter Ada;
        public DataSet Ds;
        public DataTable Dt;

        public bool Inserting = false;
        public bool updatinglist = false;
        
        public ListViewItem SelectedItem;

        public CardForm()
        {
            InitializeComponent();
            LoadDataSource();
            LoadCardList();
            SetFormButtonStates(false);
            SetFormFieldStates(false);
        }

    public Dictionary<string, bool> RqdFieldsChanged;

    #region CardListView Operations
    
    private void BtnInsert_Click(object sender, EventArgs e)
    {
      Inserting = true;
      ClearFormDetails();
      lblIDValue.Text = "Inserting New Card";
      SetListButtonStates();
      SetFormFieldStates(true);
      btnCancel.Enabled = true;
      txtName.Focus();
    }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CardListView.SelectedItems.Count == 0) return;

            Int32.TryParse(CardListView.SelectedItems[0].SubItems[0].Text, out int rowId);
            if (rowId < 1) return;
            DataRow dr = Dt.Rows.Find(rowId);
            dr.Delete();
            if (Ada.Update(Ds) > 0)
            {
                CardListView.SelectedItems[0].Remove();
                SelectedItem = null;
            }
            ClearFormDetails();
            SetFormButtonStates(false);
            SetListButtonStates();
        }

        private void SetListButtonStates()
        {
            btnInsert.Enabled = !Inserting;
            btnDelete.Enabled = CardListView.SelectedItems.Count > 0;
        }

        private void LoadCardList()
        {
            CardListView.View = View.Details;
            CardListView.Items.Clear();
            updatinglist = true;
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                DataRow dr = Dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID"].ToString());

                listitem.SubItems.Add(dr["CardName"].ToString());
                listitem.SubItems.Add(dr["ManaCost"].ToString());
                listitem.SubItems.Add(dr["ID"].ToString());
                if (SelectedItem != null && SelectedItem.Text == listitem.Text) listitem.Selected = true;
                CardListView.Items.Add(listitem);
            }
            updatinglist = false;
        }

        private void CardListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updatinglist) return;
            SetFormButtonStates(false);
            SetFormFieldStates(false);
            LoadRowData();
            SetListButtonStates();
            if (CardListView.SelectedItems.Count > 0)
            {
                SelectedItem = CardListView.SelectedItems[0];
                SetFormFieldStates(true);
            }
            else
                SelectedItem = null;
        }
        #endregion

        #region Data I/O Operations
        private void LoadDataSource()
        {

            // Setup the DataSource
            Con = new SqlConnection(_connectionString);
            Ada = new SqlDataAdapter();
            Ada.TableMappings.Add("Table", "CardTable");


            // Setup the sql commands
            SqlCommand selectCmd = new SqlCommand("SELECT * from CardTable", Con);

      SqlCommand updateCmd = new SqlCommand("UPDATE CardTable SET CardName = @CardName, AttackValue = @AttackValue, SpellValue = @SpellValue," + 
                                            " HealthValue = @HealthValue, ManaCost = @ManaCost, RangeValue = @RangeValue, Modifier = @Modifier," + 
                                            " IsStructure = @IsStructure, IsTotem = @IsTotem, IsUndead = @IsUndead, Type = @Type WHERE ID = @ID", Con);
 
      updateCmd.Parameters.Add("@CardName", SqlDbType.VarChar, 50, "CardName");
      updateCmd.Parameters.Add("@AttackValue", SqlDbType.TinyInt, 1, "AttackValue");
      updateCmd.Parameters.Add("@SpellValue", SqlDbType.TinyInt, 1, "SpellValue");
      updateCmd.Parameters.Add("@HealthValue", SqlDbType.TinyInt, 1, "HealthValue");
      updateCmd.Parameters.Add("@ManaCost", SqlDbType.TinyInt, 1, "ManaCost");
      updateCmd.Parameters.Add("@RangeValue", SqlDbType.TinyInt, 1, "RangeValue");
      updateCmd.Parameters.Add("@Modifier", SqlDbType.NVarChar, 255, "Modifier");
      updateCmd.Parameters.Add("@IsStructure", SqlDbType.Bit, 1, "IsStructure");
      updateCmd.Parameters.Add("@IsTotem", SqlDbType.Bit, 1, "IsTotem");
      updateCmd.Parameters.Add("@IsUndead", SqlDbType.Bit, 1, "IsUndead");
      updateCmd.Parameters.Add("@Type", SqlDbType.VarChar, 20, "Type");
      updateCmd.Parameters.Add("@ID", SqlDbType.SmallInt, 2, "ID");


            SqlCommand deleteCmd = new SqlCommand("DELETE FROM CardTable WHERE ID = @ID", Con);

      deleteCmd.Parameters.Add("@ID", SqlDbType.SmallInt, 4, "ID");

      SqlCommand insertCmd = new SqlCommand("INSERT INTO CardTable (CardName, AttackValue, SpellValue, HealthValue, ManaCost, RangeValue," + 
                                            " Modifier, IsStructure, IsTotem, IsUndead, Type)" + 
                                            "VALUES (@CardName, @AttackValue, @SpellValue, @HealthValue, @ManaCost, @RangeValue, @Modifier," + 
                                            " @IsStructure, @IsTotem, @IsUndead, @Type)", Con);

      insertCmd.Parameters.Add("@CardName", SqlDbType.VarChar, 50, "CardName");
      insertCmd.Parameters.Add("@AttackValue", SqlDbType.TinyInt, 1, "AttackValue");
      insertCmd.Parameters.Add("@SpellValue", SqlDbType.TinyInt, 1, "SpellValue");
      insertCmd.Parameters.Add("@HealthValue", SqlDbType.TinyInt, 1, "HealthValue");
      insertCmd.Parameters.Add("@ManaCost", SqlDbType.TinyInt, 1, "ManaCost");
      insertCmd.Parameters.Add("@RangeValue", SqlDbType.TinyInt, 1, "RangeValue");
      insertCmd.Parameters.Add("@Modifier", SqlDbType.NVarChar, 255, "Modifier");
      insertCmd.Parameters.Add("@IsStructure", SqlDbType.Bit, 1, "IsStructure");
      insertCmd.Parameters.Add("@IsTotem", SqlDbType.Bit, 1, "IsTotem");
      insertCmd.Parameters.Add("@IsUndead", SqlDbType.Bit, 1, "IsUndead");
      insertCmd.Parameters.Add("@Type", SqlDbType.VarChar, 20, "Type");
      insertCmd.Parameters.Add("@ID", SqlDbType.SmallInt, 2, "ID");

            Ada.SelectCommand = selectCmd;
            Ada.UpdateCommand = updateCmd;
            Ada.DeleteCommand = deleteCmd;
            Ada.InsertCommand = insertCmd;

            // Load the data...
            Ds = new DataSet();
            Dt = new DataTable();
            Ada.Fill(Ds);
            Dt = Ds.Tables[0];
            Dt.Columns[0].AutoIncrement = true;
            Dt.Columns[0].AutoIncrementSeed = 1;
            Dt.Columns[0].AutoIncrementStep = 1;

            // Close the connection, we are done with the fill...
            Con.Close();

            //Set Primary key
            DataColumn[] keys = new DataColumn[1];
            keys[0] = Dt.Columns[0];
            Dt.PrimaryKey = keys;
        }

        private void LoadRowData()
        {
            ListView.SelectedListViewItemCollection items = this.CardListView.SelectedItems;
            if (items.Count == 0)
            {
                SetFormButtonStates(false);
                return;
            }

      int.TryParse(items[0].SubItems[0].Text, out int rowid);
      if (rowid < 1) return;
      DataRow dr = Dt.Rows.Find(rowid);
      if (dr == null)
      {
        return;
      }
      this.chkStructure.Checked = (bool)dr["IsStructure"];
      this.chkTotem.Checked = (bool)dr["IsTotem"];
      this.chkUndead.Checked = (bool)dr["IsUndead"];
      if (dr["Modifier"] != DBNull.Value)
        this.txtModifier.Text = (string)dr["Modifier"];
      else
        this.txtModifier.Text = "";
      this.txtType.Text = (string)dr["Type"];
      this.txtName.Text = (string)dr["CardName"];
      if (dr["AttackValue"] != DBNull.Value)
        this.nudAttack.Value = (byte)dr["AttackValue"];
      else
        this.nudAttack.Value = -1;
      if (dr["SpellValue"] != DBNull.Value)
        this.nudSpell.Value = (byte)dr["SpellValue"];
      else
        this.nudSpell.Value = -1;
      if (dr["HealthValue"] != DBNull.Value)
        this.nudHealth.Value = (byte)dr["HealthValue"];
      else
        this.nudHealth.Value = -1;
      if (dr["ManaCost"] != DBNull.Value)
        this.nudManaCost.Value = (byte)dr["ManaCost"];
      else
        this.nudManaCost.Value = -1;
      if (dr["RangeValue"] != DBNull.Value)
        this.nudRange.Value = (byte)dr["RangeValue"];
      else
        this.nudRange.Value = -1;
      this.lblIDValue.Text = dr["ID"].ToString();
      SetFormButtonStates(true);

        }

    private void SaveRowData()
    {
      DataRow dr;
      if (Inserting)
      {
        dr = Dt.NewRow();
      }
      else
      {
        Int32.TryParse(CardListView.SelectedItems[0].Text, out int rowid);
        if (rowid < 1) return;
        dr = Dt.Rows.Find(rowid);
        if (dr == null) return;
      }
      dr["IsStructure"] = this.chkStructure.Checked ? 1 : 0;
      dr["IsTotem"] = this.chkTotem.Checked ? 1 : 0;
      dr["IsUndead"] = this.chkUndead.Checked ? 1 : 0;
      if (this.txtModifier.Text == string.Empty)
        dr["Modifier"] = DBNull.Value;
      else
        dr["Modifier"] = this.txtModifier.Text;
      dr["Type"] = this.txtType.Text;
      dr["CardName"] = this.txtName.Text;
      if (this.nudAttack.Value == -1)
        dr["AttackValue"] = DBNull.Value;
      else
        dr["AttackValue"] = this.nudAttack.Value;
      if (this.nudSpell.Value == -1)
        dr["SpellValue"] = DBNull.Value;
      else
        dr["SpellValue"] = this.nudSpell.Value;
      if (this.nudHealth.Value == -1)
        dr["HealthValue"] = DBNull.Value;
      else
        dr["HealthValue"] = this.nudHealth.Value;
      if (this.nudManaCost.Value == -1)
        dr["ManaCost"] = DBNull.Value;
      else
        dr["ManaCost"] = this.nudManaCost.Value;
      if (this.nudRange.Value == -1)
        dr["RangeValue"] = DBNull.Value;
      else
        dr["RangeValue"] = this.nudRange.Value;

            if (Inserting)
            {
                dr["ID"] = -1; // on an insert with an identity field, pass -1 and the db will insert the correct id.
                Dt.Rows.Add(dr);
                Inserting = false;
                SelectedItem = null;
                SetListButtonStates();
            }
            Ada.Update(Ds);
            Dt.Clear();
            Ada.Fill(Dt);
            LoadCardList();

            if (CardListView.SelectedItems.Count > 0)
            {
                //CardListView.SelectedItems[0] = SelectedItem;
            }
        }
        #endregion

        #region Form Operations

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LoadRowData();
            SetFormButtonStates(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveRowData();
            SetFormButtonStates(false);
        }

    private void SetFormButtonStates(bool state)
    {
      btnSave.Enabled = CanInsert(state);
      btnCancel.Enabled = state;
    }

        private void SetFormFieldStates(bool state)
        {
            this.txtName.Enabled = state;
            this.txtType.Enabled = state;
            this.nudAttack.Enabled = state;
            this.nudSpell.Enabled = state;
            this.nudRange.Enabled = state;
            this.nudHealth.Enabled = state;
            this.nudManaCost.Enabled = state;
            this.txtModifier.Enabled = state;
            this.chkStructure.Enabled = state;
            this.chkTotem.Enabled = state;
            this.chkUndead.Enabled = state;
        }

        private void ClearFormDetails()
        {
            this.lblIDValue.Text = "0";
            this.txtName.Text = "";
            this.txtType.Text = "";
            this.nudAttack.Value = -1;
            this.nudSpell.Value = -1;
            this.nudRange.Value = -1;
            this.nudHealth.Value = -1;
            this.nudManaCost.Value = -1;
            this.txtModifier.Text = "";
            this.chkStructure.Checked = false;
            this.chkTotem.Checked = false;
            this.chkUndead.Checked = false;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void TxtType_TextChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void NudAttack_ValueChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void NudSpell_ValueChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void NudRange_ValueChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void NudHealth_ValueChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void NudManaCost_ValueChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void TxtModifier_TextChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void ChkStructure_CheckedChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void ChkTotem_CheckedChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void ChkUndead_CheckedChanged(object sender, EventArgs e)
        {
            SetFormButtonStates(true);
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        private void TxtType_Enter(object sender, EventArgs e)
        {
            txtType.SelectAll();
        }

        private void TxtModifier_Enter(object sender, EventArgs e)
        {
            txtType.SelectAll();
        }

        private void NudAttack_Enter(object sender, EventArgs e)
        {
            nudAttack.Select(0, 2);
        }

        private void NudRange_Enter(object sender, EventArgs e)
        {
            nudRange.Select(0, 2);
        }

        private void NudHealth_Enter(object sender, EventArgs e)
        {
            nudHealth.Select(0, 2);
        }

        private void NudSpell_Enter(object sender, EventArgs e)
        {
            nudSpell.Select(0, 2);
        }

        private void NudManaCost_Enter(object sender, EventArgs e)
        {
            nudManaCost.Select(0, 2);
        }

    public bool CanInsert(bool state)
    {
      if (!Inserting) return state;
      foreach (var item in RqdFieldsChanged)
      {
        if (!item.Value) return false;
      }
      return true;
    }

    #endregion

    }
}
