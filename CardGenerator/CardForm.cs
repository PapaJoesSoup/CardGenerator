using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGenerator
{
  public partial class CardForm : Form
  {
    public SqlConnection con;
    public SqlDataAdapter ada;
    public DataSet ds;
    public DataTable dt;

    public CardForm()
    {
      InitializeComponent();
      LoadDataSource();
      LoadCardList();
      SetActionButtonStates(false);
      SetFormFieldStates(false);
    }

    #region ListView Operations
    private void LoadCardList()
    {
      CardListView.View = View.Details;
      CardListView.Items.Clear();
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        DataRow dr = dt.Rows[i];
        ListViewItem listitem = new ListViewItem(dr["ID"].ToString());
        listitem.SubItems.Add(dr["CardName"].ToString());
        listitem.SubItems.Add(dr["ID"].ToString());
        listitem.SubItems.Add(dr["ID"].ToString());
        CardListView.Items.Add(listitem);
      }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(false);
      SetFormFieldStates(false);
      LoadRowData();
      if (CardListView.SelectedItems.Count > 0)
        SetFormFieldStates(true);

    }
    #endregion

    #region Data I/O Operations
    private void LoadDataSource()
    {

      // Setup the DataSource
      con = new SqlConnection("Data Source = JDK_DESKTOP; Database = CardGenerator; Integrated Security = True");
      ada = new SqlDataAdapter();
      ada.TableMappings.Add("Table", "Card");

      // Setup the sql commands
      SqlCommand selectCmd = new SqlCommand("SELECT * from Card", con);

      SqlCommand updateCmd = new SqlCommand("UPDATE Card SET CardName = @CardName, AttackValue = @AttackValue, SpellValue = @SpellValue," + 
                                            " HealthValue = @HealthValue, ManaCost = @ManaCost, RangeValue = @RangeValue, Modifier = @Modifier," + 
                                            " IsStructure = @IsStructure, IsTotem = @IsTotem, IsUndead = @IsUndead, Type = @Type WHERE ID = @ID", con);
 
      updateCmd.Parameters.Add("@CardName", SqlDbType.NVarChar, 255, "CardName");
      updateCmd.Parameters.Add("@AttackValue", SqlDbType.Int, 4, "AttackValue");
      updateCmd.Parameters.Add("@SpellValue", SqlDbType.Int, 4, "SpellValue");
      updateCmd.Parameters.Add("@HealthValue", SqlDbType.Int, 4, "HealthValue");
      updateCmd.Parameters.Add("@ManaCost", SqlDbType.Int, 4, "ManaCost");
      updateCmd.Parameters.Add("@RangeValue", SqlDbType.Int, 4, "RangeValue");
      updateCmd.Parameters.Add("@Modifier", SqlDbType.NVarChar, 512, "Modifier");
      updateCmd.Parameters.Add("@IsStructure", SqlDbType.Bit, 1, "IsStructure");
      updateCmd.Parameters.Add("@IsTotem", SqlDbType.Bit, 1, "IsTotem");
      updateCmd.Parameters.Add("@IsUndead", SqlDbType.Bit, 1, "IsUndead");
      updateCmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type");
      updateCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");


      SqlCommand deleteCmd = new SqlCommand("DELETE FROM Card WHERE ID = @ID", con);

      deleteCmd.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");

      SqlCommand insertCmd = new SqlCommand("INSERT INTO Card (CardName, AttackValue, SpellValue, HealthValue, ManaCost, RangeValue," + 
                                            " Modifier, IsStructure, IsTotem, IsUndead, Type)" + 
                                            "VALUES (@CardName, @AttackValue, @SpellValue, @HealthValue, @ManaCost, @RangeValue, @Modifier," + 
                                            " @IsStructure, @IsTotem, @IsUndead, @Type)", con);

      insertCmd.Parameters.Add("@CardName", SqlDbType.NVarChar, 255, "CardName");
      insertCmd.Parameters.Add("@AttackValue", SqlDbType.Int, 4, "AttackValue");
      insertCmd.Parameters.Add("@SpellValue", SqlDbType.Int, 4, "SpellValue");
      insertCmd.Parameters.Add("@HealthValue", SqlDbType.Int, 4, "HealthValue");
      insertCmd.Parameters.Add("@ManaCost", SqlDbType.Int, 4, "ManaCost");
      insertCmd.Parameters.Add("@RangeValue", SqlDbType.Int, 4, "RangeValue");
      insertCmd.Parameters.Add("@Modifier", SqlDbType.NVarChar, 512, "Modifier");
      insertCmd.Parameters.Add("@IsStructure", SqlDbType.Bit, 1, "IsStructure");
      insertCmd.Parameters.Add("@IsTotem", SqlDbType.Bit, 1, "IsTotem");
      insertCmd.Parameters.Add("@IsUndead", SqlDbType.Bit, 1, "IsUndead");
      insertCmd.Parameters.Add("@Type", SqlDbType.NVarChar, 50, "Type");

      ada.SelectCommand = selectCmd;
      ada.UpdateCommand = updateCmd;
      ada.DeleteCommand = deleteCmd;
      ada.InsertCommand = insertCmd;

      // Load the data...
      ds = new DataSet();
      dt = new DataTable();
      ada.Fill(ds);
      dt = ds.Tables[0];

      // Close the connection, we are done with the fill...
      con.Close();

      //Set Primary key
      DataColumn[] keys = new DataColumn[1];
      keys[0] = dt.Columns[0];
      dt.PrimaryKey = keys;
    }

    private void LoadRowData()
    {
      var items = this.CardListView.SelectedItems;
      if (items.Count == 0)
      {
        SetActionButtonStates(false);
        return;
      }
      var rowid = 0;
      Int32.TryParse(items[0].SubItems[0].Text, out rowid);
      if (rowid < 1) return;
      DataRow dr = dt.Rows.Find(rowid);
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
        this.nudAttack.Value = (int)dr["AttackValue"];
      else
        this.nudAttack.Value = -1;
      if (dr["SpellValue"] != DBNull.Value)
        this.nudSpell.Value = (int)dr["SpellValue"];
      else
        this.nudSpell.Value = -1;
      if (dr["HealthValue"] != DBNull.Value)
        this.nudHealth.Value = (int)dr["HealthValue"];
      else
        this.nudHealth.Value = -1;
      if (dr["ManaCost"] != DBNull.Value)
        this.nudManaCost.Value = (int)dr["ManaCost"];
      else
        this.nudManaCost.Value = -1;
      if (dr["RangeValue"] != DBNull.Value)
        this.nudRange.Value = (int)dr["RangeValue"];
      else
        this.nudRange.Value = -1;
      this.lblIDValue.Text = dr["ID"].ToString();
      SetActionButtonStates(true);

    }

    private void SaveRowData()
    {
      var CurrentItem = this.CardListView.SelectedItems[0];
      var items = this.CardListView.SelectedItems;
      var rowid = 0;
      Int32.TryParse(items[0].SubItems[0].Text, out rowid);
      if (rowid < 1) return;
      DataRow dr = dt.Rows.Find(rowid);
      if (dr == null)
      {
        return;
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

      ada.Update(ds);
      //dr.AcceptChanges();
      //dt.AcceptChanges();
      //ds.AcceptChanges();
    }
    #endregion

    #region Form Field Event Handlers
    private void btnCancel_Click(object sender, EventArgs e)
    {
      LoadRowData();
      SetActionButtonStates(false);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveRowData();
      SetActionButtonStates(false);
    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void txtType_TextChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void nudAttack_ValueChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void nudSpell_ValueChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void nudRange_ValueChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void nudHealth_ValueChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void nudManaCost_ValueChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void txtModifier_TextChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void chkStructure_CheckedChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void chkTotem_CheckedChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }

    private void chkUndead_CheckedChanged(object sender, EventArgs e)
    {
      SetActionButtonStates(true);
    }
    #endregion

    private void SetActionButtonStates(bool state)
    {
      btnSave.Enabled = state;
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

  }
}
