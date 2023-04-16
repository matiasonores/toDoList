
namespace ToDoList
{
   partial class toDoList
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.desBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.titleBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.newButton = new System.Windows.Forms.Button();
         this.delButton = new System.Windows.Forms.Button();
         this.saveButton = new System.Windows.Forms.Button();
         this.editButton = new System.Windows.Forms.Button();
         this.toDoListView = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(776, 432);
         this.label1.TabIndex = 0;
         this.label1.Text = "To Do List";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // desBox
         // 
         this.desBox.Location = new System.Drawing.Point(12, 141);
         this.desBox.Name = "desBox";
         this.desBox.Size = new System.Drawing.Size(780, 20);
         this.desBox.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 115);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(776, 23);
         this.label2.TabIndex = 2;
         this.label2.Text = "Description";
         // 
         // titleBox
         // 
         this.titleBox.Location = new System.Drawing.Point(12, 92);
         this.titleBox.Name = "titleBox";
         this.titleBox.Size = new System.Drawing.Size(780, 20);
         this.titleBox.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 66);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(776, 23);
         this.label3.TabIndex = 4;
         this.label3.Text = "Title";
         // 
         // newButton
         // 
         this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.newButton.Location = new System.Drawing.Point(11, 167);
         this.newButton.Name = "newButton";
         this.newButton.Size = new System.Drawing.Size(190, 50);
         this.newButton.TabIndex = 5;
         this.newButton.Text = "+";
         this.newButton.UseVisualStyleBackColor = true;
         this.newButton.Click += new System.EventHandler(this.newButton_Click);
         // 
         // delButton
         // 
         this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.delButton.Location = new System.Drawing.Point(405, 167);
         this.delButton.Name = "delButton";
         this.delButton.Size = new System.Drawing.Size(190, 50);
         this.delButton.TabIndex = 6;
         this.delButton.Text = "-";
         this.delButton.UseVisualStyleBackColor = true;
         this.delButton.Click += new System.EventHandler(this.delButton_Click);
         // 
         // saveButton
         // 
         this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.saveButton.Location = new System.Drawing.Point(601, 167);
         this.saveButton.Name = "saveButton";
         this.saveButton.Size = new System.Drawing.Size(190, 50);
         this.saveButton.TabIndex = 7;
         this.saveButton.Text = "Save";
         this.saveButton.UseVisualStyleBackColor = true;
         this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
         // 
         // editButton
         // 
         this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.editButton.Location = new System.Drawing.Point(209, 167);
         this.editButton.Name = "editButton";
         this.editButton.Size = new System.Drawing.Size(190, 50);
         this.editButton.TabIndex = 8;
         this.editButton.Text = "Edit";
         this.editButton.UseVisualStyleBackColor = true;
         this.editButton.Click += new System.EventHandler(this.editButton_Click);
         // 
         // toDoListView
         // 
         this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.toDoListView.BackgroundColor = System.Drawing.Color.White;
         this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.toDoListView.Location = new System.Drawing.Point(12, 224);
         this.toDoListView.Name = "toDoListView";
         this.toDoListView.Size = new System.Drawing.Size(781, 217);
         this.toDoListView.TabIndex = 9;
         // 
         // toDoList
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.toDoListView);
         this.Controls.Add(this.editButton);
         this.Controls.Add(this.saveButton);
         this.Controls.Add(this.delButton);
         this.Controls.Add(this.newButton);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.titleBox);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.desBox);
         this.Controls.Add(this.label1);
         this.Name = "toDoList";
         this.Text = "To Do List";
         this.Load += new System.EventHandler(this.toDoList_Load);
         ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox desBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox titleBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button newButton;
      private System.Windows.Forms.Button delButton;
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button editButton;
      private System.Windows.Forms.DataGridView toDoListView;
   }
}

