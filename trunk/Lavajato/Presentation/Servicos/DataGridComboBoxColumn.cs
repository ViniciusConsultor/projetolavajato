using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

//
// Derive a custom column style from DataGridTextBoxColumn that:
//  - adds a ComboBox member
//  - tracks when the combobox has focus in the Enter and Leave events
//  - overrides Edit event so the ComboBox replaces the TextBox
//  - overrides Commit event to save the changed data
//

namespace HenryCorporation.Lavajato.BusinessLogic
{
	public class DataGridComboBoxColumn : DataGridTextBoxColumn
	{

#region Declarations 

		public NoKeyUpCombo ColumnComboBox;
		private System.Windows.Forms.CurrencyManager mcmSource;
		private int mintRowNum;
		private bool mblnEditing;

		#endregion

#region Private Methods

		public DataGridComboBoxColumn()
		{
			mcmSource = null;
			mblnEditing = false;

			ColumnComboBox = new NoKeyUpCombo();
			ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			this.ColumnComboBox.Leave += new System.EventHandler(LeaveComboBox);
			this.ColumnComboBox.SelectionChangeCommitted += new System.EventHandler(ComboStartEditing);
		}

#endregion

#region Private Methods

		private void HandleScroll(Object sender, EventArgs e)
		{
			if (ColumnComboBox.Visible)
				ColumnComboBox.Hide();
		}
			
		private void ComboStartEditing(Object sender, EventArgs e)
		{
			mblnEditing = true;
			base.ColumnStartedEditing((System.Windows.Forms.Control) sender);
		}

		private void LeaveComboBox(Object sender, EventArgs e)
		{
			if (mblnEditing)
			{
				SetColumnValueAtRow(mcmSource, mintRowNum, ColumnComboBox.Text);
				mblnEditing = false;
				Invalidate();
			}
			ColumnComboBox.Hide();
			this.DataGridTableStyle.DataGrid.Scroll += new System.EventHandler(HandleScroll);
		}

		#endregion

#region Overridden Methods

		protected override void Edit(
			System.Windows.Forms.CurrencyManager source,
			int rowNum,
			System.Drawing.Rectangle bounds,
			bool readOnly, 
			string instantText, 
			bool cellIsVisible)
		{
			base.Edit(source, rowNum, bounds, readOnly, instantText, cellIsVisible);

			mintRowNum = rowNum;
			mcmSource = source;

			Point NewLoc;

			ColumnComboBox.Parent = this.TextBox.Parent;

			NewLoc = this.TextBox.Location;
			NewLoc.X -= 3;
			NewLoc.Y -= 3;
			ColumnComboBox.Location = NewLoc;

			ColumnComboBox.Size = new Size(this.TextBox.Size.Width + 3, ColumnComboBox.Size.Height);
			ColumnComboBox.SelectedIndex = ColumnComboBox.FindStringExact(this.TextBox.Text);
			ColumnComboBox.Text = this.TextBox.Text;

			this.TextBox.Visible = false;
			ColumnComboBox.Visible = true;

			this.DataGridTableStyle.DataGrid.Scroll += new System.EventHandler(HandleScroll);

			ColumnComboBox.BringToFront();
			ColumnComboBox.Focus();
		}

		protected override bool Commit(System.Windows.Forms.CurrencyManager dataSource, int rowNum) 
		{
			if (mblnEditing)
			{
				mblnEditing = false;
				SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text);
			}
			return true;
		}


		protected override void ConcedeFocus()
		{
			Console.WriteLine("ConcedeFocus");
			base.ConcedeFocus();
		}

		protected override Object GetColumnValueAtRow(System.Windows.Forms.CurrencyManager source,int rowNum)
		{
			Object s = base.GetColumnValueAtRow(source, rowNum);
			DataView dv = (DataView)this.ColumnComboBox.DataSource;
			int rowCount = dv.Count;
			int i = 0;
			Object obj;

			while (i < rowCount)
			{
				obj = dv[i][this.ColumnComboBox.ValueMember];
				if ((obj != DBNull.Value) & (s != DBNull.Value) & (s.Equals(obj)))
				{
					break;
				}
				i += 1;
			}

			if (i < rowCount)
			{
				return dv[i][this.ColumnComboBox.DisplayMember];
			}
			else
			{
				return DBNull.Value;
			}
		}

		protected override void SetColumnValueAtRow(
			System.Windows.Forms.CurrencyManager source,
			int rowNum, Object value)
		{
			Object s = value;
			DataView dv = (DataView)this.ColumnComboBox.DataSource;
			int rowCount = dv.Count;
			int i  = 0;
			Object obj;

			while (i < rowCount)
			{
				obj = dv[i][this.ColumnComboBox.DisplayMember];

				if ((obj != DBNull.Value) && (s.Equals(obj)))
				{
					break;
				}
				i += 1;
			}

			if (i < rowCount)
			{
				s = dv[i][this.ColumnComboBox.ValueMember];
			}
			else
			{
				s = DBNull.Value;
			}

			base.SetColumnValueAtRow(source, rowNum, s);
		}

#endregion

	} // class

} // namespace
