namespace diplom
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.storacDataSet = new diplom.StoracDataSet();
            this.storacDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new diplom.StoracDataSetTableAdapters.SuppliersTableAdapter();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Add_Import = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.storacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storacDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // storacDataSet
            // 
            this.storacDataSet.DataSetName = "StoracDataSet";
            this.storacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storacDataSetBindingSource
            // 
            this.storacDataSetBindingSource.DataSource = this.storacDataSet;
            this.storacDataSetBindingSource.Position = 0;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.storacDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(385, 257);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(125, 125);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Добавить поставщика";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Add_Import
            // 
            this.Add_Import.ActiveControl = null;
            this.Add_Import.Location = new System.Drawing.Point(123, 257);
            this.Add_Import.Name = "Add_Import";
            this.Add_Import.Size = new System.Drawing.Size(125, 125);
            this.Add_Import.TabIndex = 1;
            this.Add_Import.Text = "Приход";
            this.Add_Import.UseSelectable = true;
            this.Add_Import.Click += new System.EventHandler(this.Add_Import_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(254, 257);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(125, 125);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Отгрузка";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(254, 126);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(125, 125);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Приход";
            this.metroTile3.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.Add_Import);
            this.Controls.Add(this.metroTile1);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Storac";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.SystemColors.MenuBar;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storacDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource storacDataSetBindingSource;
        private StoracDataSet storacDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private StoracDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile Add_Import;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}

