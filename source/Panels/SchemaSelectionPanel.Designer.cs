﻿namespace MySQL.ForExcel
{
  partial class SchemaSelectionPanel
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchemaSelectionPanel));
      this.lblConnectionName = new System.Windows.Forms.Label();
      this.lblUserIP = new System.Windows.Forms.Label();
      this.picAddInLogo = new System.Windows.Forms.PictureBox();
      this.largeImages = new System.Windows.Forms.ImageList(this.components);
      this.btnBack = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.lblInstructions = new System.Windows.Forms.Label();
      this.btnHelp = new System.Windows.Forms.Button();
      this.databaseList = new MySQL.ForExcel.MyTreeView();
      this.schemaFilter = new MySQL.ForExcel.SearchEdit();
      this.createNewSchema = new MySQL.ForExcel.HotLabel();
      this.selectSchemaLabel = new MySQL.ForExcel.HotLabel();
      this.picSeparator = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picAddInLogo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picSeparator)).BeginInit();
      this.SuspendLayout();
      // 
      // lblConnectionName
      // 
      this.lblConnectionName.AutoSize = true;
      this.lblConnectionName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblConnectionName.Location = new System.Drawing.Point(61, 18);
      this.lblConnectionName.Name = "lblConnectionName";
      this.lblConnectionName.Size = new System.Drawing.Size(118, 17);
      this.lblConnectionName.TabIndex = 0;
      this.lblConnectionName.Text = "Connection Name";
      // 
      // lblUserIP
      // 
      this.lblUserIP.AutoSize = true;
      this.lblUserIP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserIP.Location = new System.Drawing.Point(61, 36);
      this.lblUserIP.Name = "lblUserIP";
      this.lblUserIP.Size = new System.Drawing.Size(77, 13);
      this.lblUserIP.TabIndex = 1;
      this.lblUserIP.Text = "User: ??, IP: ??";
      // 
      // picAddInLogo
      // 
      this.picAddInLogo.Image = global::MySQL.ForExcel.Properties.Resources.MySQLforExcel_Logo_64x64;
      this.picAddInLogo.Location = new System.Drawing.Point(9, 11);
      this.picAddInLogo.Name = "picAddInLogo";
      this.picAddInLogo.Size = new System.Drawing.Size(64, 64);
      this.picAddInLogo.TabIndex = 13;
      this.picAddInLogo.TabStop = false;
      // 
      // largeImages
      // 
      this.largeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImages.ImageStream")));
      this.largeImages.TransparentColor = System.Drawing.Color.Transparent;
      this.largeImages.Images.SetKeyName(0, "MySQLforExcel-SchemaPanel-ListItem-Schema-24x24.png");
      // 
      // btnBack
      // 
      this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBack.Location = new System.Drawing.Point(90, 599);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(75, 23);
      this.btnBack.TabIndex = 7;
      this.btnBack.Text = "< Back";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // btnNext
      // 
      this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnNext.Enabled = false;
      this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNext.Location = new System.Drawing.Point(166, 599);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(75, 23);
      this.btnNext.TabIndex = 8;
      this.btnNext.Text = "Next >";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // lblInstructions
      // 
      this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(151)))), ((int)(((byte)(178)))));
      this.lblInstructions.Location = new System.Drawing.Point(6, 73);
      this.lblInstructions.Name = "lblInstructions";
      this.lblInstructions.Size = new System.Drawing.Size(247, 71);
      this.lblInstructions.TabIndex = 2;
      this.lblInstructions.Text = "Please select the MySQL schema you want to work with. Each schema can hold a coll" +
    "ection of tables that store data, views that hold selected data and routines tha" +
    "t generate data.";
      // 
      // btnHelp
      // 
      this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHelp.Location = new System.Drawing.Point(9, 599);
      this.btnHelp.Name = "btnHelp";
      this.btnHelp.Size = new System.Drawing.Size(75, 23);
      this.btnHelp.TabIndex = 6;
      this.btnHelp.Text = "Help";
      this.btnHelp.UseVisualStyleBackColor = true;
      this.btnHelp.Visible = false;
      this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
      // 
      // databaseList
      // 
      this.databaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.databaseList.CollapsedIcon = global::MySQL.ForExcel.Properties.Resources.ArrowRight;
      this.databaseList.DescriptionColor = System.Drawing.Color.Silver;
      this.databaseList.DescriptionColorOpacity = 1D;
      this.databaseList.DescriptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.databaseList.DescriptionTextVerticalPixelsOffset = 0;
      this.databaseList.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
      this.databaseList.ExpandedIcon = global::MySQL.ForExcel.Properties.Resources.ArrowDown;
      this.databaseList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.databaseList.ImageHorizontalPixelsOffset = 14;
      this.databaseList.ImageToTextHorizontalPixelsOffset = 3;
      this.databaseList.Indent = 18;
      this.databaseList.ItemHeight = 10;
      this.databaseList.Location = new System.Drawing.Point(9, 222);
      this.databaseList.Name = "databaseList";
      this.databaseList.NodeHeightMultiple = 3;
      this.databaseList.NodeImages = this.largeImages;
      this.databaseList.Size = new System.Drawing.Size(232, 329);
      this.databaseList.TabIndex = 23;
      this.databaseList.TitleColorOpacity = 0.8D;
      this.databaseList.TitleTextVerticalPixelsOffset = 0;
      this.databaseList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.databaseList_AfterSelect);
      this.databaseList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.databaseList_NodeMouseDoubleClick);
      // 
      // schemaFilter
      // 
      this.schemaFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.schemaFilter.BackColor = System.Drawing.SystemColors.Window;
      this.schemaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.schemaFilter.Location = new System.Drawing.Point(9, 195);
      this.schemaFilter.Name = "schemaFilter";
      this.schemaFilter.NoTextLabel = "Filter Schemas";
      this.schemaFilter.Size = new System.Drawing.Size(232, 21);
      this.schemaFilter.TabIndex = 16;
      this.schemaFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.schemaFilter_KeyDown);
      // 
      // createNewSchema
      // 
      this.createNewSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.createNewSchema.Description = "Add a new Database Schema";
      this.createNewSchema.DescriptionColor = System.Drawing.SystemColors.WindowText;
      this.createNewSchema.DescriptionColorOpacity = 0.6D;
      this.createNewSchema.DescriptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createNewSchema.DescriptionShadowOpacity = 0.8D;
      this.createNewSchema.DescriptionShadowPixelsXOffset = 0;
      this.createNewSchema.DescriptionShadowPixelsYOffset = 1;
      this.createNewSchema.DisabledImage = null;
      this.createNewSchema.DrawShadow = true;
      this.createNewSchema.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createNewSchema.HotTracking = true;
      this.createNewSchema.Image = global::MySQL.ForExcel.Properties.Resources.MySQLforExcel_SchemaPanel_NewSchema_24x24;
      this.createNewSchema.ImagePixelsXOffset = 0;
      this.createNewSchema.ImagePixelsYOffset = 0;
      this.createNewSchema.Location = new System.Drawing.Point(9, 558);
      this.createNewSchema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.createNewSchema.Name = "createNewSchema";
      this.createNewSchema.Size = new System.Drawing.Size(232, 28);
      this.createNewSchema.TabIndex = 15;
      this.createNewSchema.Title = "Create New Schema";
      this.createNewSchema.TitleColor = System.Drawing.SystemColors.WindowText;
      this.createNewSchema.TitleColorOpacity = 0.8D;
      this.createNewSchema.TitleDescriptionPixelsSpacing = 0;
      this.createNewSchema.TitlePixelsXOffset = 0;
      this.createNewSchema.TitlePixelsYOffset = 0;
      this.createNewSchema.TitleShadowOpacity = 0.3D;
      this.createNewSchema.TitleShadowPixelsXOffset = 0;
      this.createNewSchema.TitleShadowPixelsYOffset = 1;
      this.createNewSchema.Click += new System.EventHandler(this.createNewSchema_Click);
      // 
      // selectSchemaLabel
      // 
      this.selectSchemaLabel.Description = "Then click the [Next>] button below";
      this.selectSchemaLabel.DescriptionColor = System.Drawing.SystemColors.WindowText;
      this.selectSchemaLabel.DescriptionColorOpacity = 0.6D;
      this.selectSchemaLabel.DescriptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectSchemaLabel.DescriptionShadowOpacity = 0.8D;
      this.selectSchemaLabel.DescriptionShadowPixelsXOffset = 0;
      this.selectSchemaLabel.DescriptionShadowPixelsYOffset = 1;
      this.selectSchemaLabel.DisabledImage = null;
      this.selectSchemaLabel.DrawShadow = true;
      this.selectSchemaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectSchemaLabel.HotTracking = false;
      this.selectSchemaLabel.Image = global::MySQL.ForExcel.Properties.Resources.MySQLforExcel_SchemaPanel_Schemas_24x24;
      this.selectSchemaLabel.ImagePixelsXOffset = 0;
      this.selectSchemaLabel.ImagePixelsYOffset = 2;
      this.selectSchemaLabel.Location = new System.Drawing.Point(9, 160);
      this.selectSchemaLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.selectSchemaLabel.Name = "selectSchemaLabel";
      this.selectSchemaLabel.Size = new System.Drawing.Size(232, 28);
      this.selectSchemaLabel.TabIndex = 14;
      this.selectSchemaLabel.Title = "Select a Database Schema";
      this.selectSchemaLabel.TitleColor = System.Drawing.SystemColors.WindowText;
      this.selectSchemaLabel.TitleColorOpacity = 0.8D;
      this.selectSchemaLabel.TitleDescriptionPixelsSpacing = 0;
      this.selectSchemaLabel.TitlePixelsXOffset = 0;
      this.selectSchemaLabel.TitlePixelsYOffset = 0;
      this.selectSchemaLabel.TitleShadowOpacity = 0.3D;
      this.selectSchemaLabel.TitleShadowPixelsXOffset = 0;
      this.selectSchemaLabel.TitleShadowPixelsYOffset = 1;
      // 
      // picSeparator
      // 
      this.picSeparator.Image = global::MySQL.ForExcel.Properties.Resources.MySQLforExcel_Separator;
      this.picSeparator.Location = new System.Drawing.Point(9, 132);
      this.picSeparator.Name = "picSeparator";
      this.picSeparator.Size = new System.Drawing.Size(232, 21);
      this.picSeparator.TabIndex = 24;
      this.picSeparator.TabStop = false;
      // 
      // SchemaSelectionPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblUserIP);
      this.Controls.Add(this.picSeparator);
      this.Controls.Add(this.databaseList);
      this.Controls.Add(this.schemaFilter);
      this.Controls.Add(this.selectSchemaLabel);
      this.Controls.Add(this.createNewSchema);
      this.Controls.Add(this.lblInstructions);
      this.Controls.Add(this.btnHelp);
      this.Controls.Add(this.btnNext);
      this.Controls.Add(this.lblConnectionName);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.picAddInLogo);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "SchemaSelectionPanel";
      this.Size = new System.Drawing.Size(250, 625);
      ((System.ComponentModel.ISupportInitialize)(this.picAddInLogo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picSeparator)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblConnectionName;
    private System.Windows.Forms.Label lblUserIP;
    private System.Windows.Forms.PictureBox picAddInLogo;
    public System.Windows.Forms.Button btnBack;
    public System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.ImageList largeImages;
    private System.Windows.Forms.Label lblInstructions;
    public System.Windows.Forms.Button btnHelp;
    private HotLabel selectSchemaLabel;
    private HotLabel createNewSchema;
    private SearchEdit schemaFilter;
    private MyTreeView databaseList;
    private System.Windows.Forms.PictureBox picSeparator;
  }
}
