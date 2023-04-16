using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
   public partial class toDoList : Form
   {
      public toDoList()
      {
         InitializeComponent();
      }
      DataTable todoList = new DataTable();
      bool isEditing = false;
      private void toDoList_Load(object sender, EventArgs e)
      {
         //Create columns
         todoList.Columns.Add("Title");
         todoList.Columns.Add("Description");

         //Point our datagridview to our datasource
         toDoListView.DataSource = todoList;
      }

      private void newButton_Click(object sender, EventArgs e)
      {
         titleBox.Text = "";
         desBox.Text = "";
      }

      private void editButton_Click(object sender, EventArgs e)
      {
         isEditing = true;
         //Fill text fields with data from the table
         titleBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
         desBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
      }

      private void delButton_Click(object sender, EventArgs e)
      {
         try
         {
            todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
         }
         catch (Exception ex)
         {
            Console.WriteLine("Error: "+ ex);
         }
      }

      private void saveButton_Click(object sender, EventArgs e)
      {
         if(isEditing)
         {
            todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleBox.Text;
            todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = desBox.Text;
         }
         else
         {
            todoList.Rows.Add(titleBox.Text, desBox.Text);
         }
         //Clear fields
         titleBox.Text = "";
         desBox.Text = "";
         isEditing = false;
      }
   }
}
