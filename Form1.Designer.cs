namespace Image_to_Text;

partial class baseForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.imageBox = new System.Windows.Forms.PictureBox();
        this.label = new System.Windows.Forms.Label();
        this.openButton = new System.Windows.Forms.Button();
        this.outputFolderButton = new System.Windows.Forms.Button();
        this.convertButton = new System.Windows.Forms.Button();
        this.textInput = new System.Windows.Forms.TextBox();
        this.textOutput = new System.Windows.Forms.RichTextBox();
        this.parameters = new System.Windows.Forms.TextBox();
        this.fontSizeLabel = new System.Windows.Forms.Label();
        this.fontSizeSlider = new System.Windows.Forms.TrackBar();
        this.charactersLabel = new System.Windows.Forms.Label();
        this.fontSizeTextBox = new System.Windows.Forms.TextBox();
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.fontSizeSlider)).BeginInit();
        this.SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 8;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
        this.tableLayoutPanel1.Controls.Add(this.imageBox, 0, 0);
        this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
        this.tableLayoutPanel1.Controls.Add(this.openButton, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.outputFolderButton, 7, 1);
        this.tableLayoutPanel1.Controls.Add(this.convertButton, 6, 1);
        this.tableLayoutPanel1.Controls.Add(this.textInput, 4, 3);
        this.tableLayoutPanel1.Controls.Add(this.textOutput, 3, 0);
        this.tableLayoutPanel1.Controls.Add(this.parameters, 2, 1);
        this.tableLayoutPanel1.Controls.Add(this.fontSizeLabel, 3, 1);
        this.tableLayoutPanel1.Controls.Add(this.fontSizeSlider, 4, 1);
        this.tableLayoutPanel1.Controls.Add(this.charactersLabel, 3, 3);
        this.tableLayoutPanel1.Controls.Add(this.fontSizeTextBox, 5, 1);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 4;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 720);
        this.tableLayoutPanel1.TabIndex = 0;
        this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
        // 
        // imageBox
        // 
        this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.tableLayoutPanel1.SetColumnSpan(this.imageBox, 3);
        this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.imageBox.Location = new System.Drawing.Point(3, 3);
        this.imageBox.Name = "imageBox";
        this.imageBox.Size = new System.Drawing.Size(506, 606);
        this.imageBox.TabIndex = 1;
        this.imageBox.TabStop = false;
        // 
        // label
        // 
        this.label.Anchor = System.Windows.Forms.AnchorStyles.Right;
        this.label.AutoSize = true;
        this.label.Location = new System.Drawing.Point(14, 656);
        this.label.Name = "label";
        this.tableLayoutPanel1.SetRowSpan(this.label, 3);
        this.label.Size = new System.Drawing.Size(111, 20);
        this.label.TabIndex = 3;
        this.label.Text = "Open an Image";
        this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label.Click += new System.EventHandler(this.label1_Click);
        // 
        // openButton
        // 
        this.openButton.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.openButton.AutoSize = true;
        this.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.openButton.Location = new System.Drawing.Point(164, 651);
        this.openButton.Name = "openButton";
        this.tableLayoutPanel1.SetRowSpan(this.openButton, 3);
        this.openButton.Size = new System.Drawing.Size(55, 30);
        this.openButton.TabIndex = 2;
        this.openButton.Text = "Open";
        this.openButton.UseVisualStyleBackColor = true;
        this.openButton.Click += new System.EventHandler(this.button1_Click);
        // 
        // outputFolderButton
        // 
        this.outputFolderButton.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.outputFolderButton.AutoSize = true;
        this.outputFolderButton.Location = new System.Drawing.Point(1108, 651);
        this.outputFolderButton.Name = "outputFolderButton";
        this.tableLayoutPanel1.SetRowSpan(this.outputFolderButton, 3);
        this.outputFolderButton.Size = new System.Drawing.Size(151, 30);
        this.outputFolderButton.TabIndex = 5;
        this.outputFolderButton.Text = "Open Output Folder";
        this.outputFolderButton.UseVisualStyleBackColor = true;
        // 
        // convertButton
        // 
        this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.convertButton.AutoSize = true;
        this.convertButton.Location = new System.Drawing.Point(945, 651);
        this.convertButton.Name = "convertButton";
        this.tableLayoutPanel1.SetRowSpan(this.convertButton, 3);
        this.convertButton.Size = new System.Drawing.Size(94, 30);
        this.convertButton.TabIndex = 4;
        this.convertButton.Text = "Convert ->";
        this.convertButton.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.tableLayoutPanel1.SetColumnSpan(this.textInput, 2);
        this.textInput.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textInput.Location = new System.Drawing.Point(643, 687);
        this.textInput.Name = "textBox1";
        this.textInput.Size = new System.Drawing.Size(250, 27);
        this.textInput.TabIndex = 7;
        this.textInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // textOutput
        // 
        this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.tableLayoutPanel1.SetColumnSpan(this.textOutput, 5);
        this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textOutput.Location = new System.Drawing.Point(515, 3);
        this.textOutput.Name = "textOutput";
        this.textOutput.ReadOnly = true;
        this.textOutput.Size = new System.Drawing.Size(762, 606);
        this.textOutput.TabIndex = 0;
        this.textOutput.Text = "";
        this.textOutput.WordWrap = false;
        this.textOutput.ZoomFactor = 0.016F;
        // 
        // textBox2
        // 
        this.parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.parameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.parameters.Location = new System.Drawing.Point(259, 615);
        this.parameters.Multiline = true;
        this.parameters.Name = "textBox2";
        this.parameters.ReadOnly = true;
        this.tableLayoutPanel1.SetRowSpan(this.parameters, 3);
        this.parameters.Size = new System.Drawing.Size(250, 102);
        this.parameters.TabIndex = 8;
        // 
        // label2
        // 
        this.fontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.fontSizeLabel.AutoSize = true;
        this.fontSizeLabel.Location = new System.Drawing.Point(541, 620);
        this.fontSizeLabel.Name = "label2";
        this.fontSizeLabel.Size = new System.Drawing.Size(69, 20);
        this.fontSizeLabel.TabIndex = 9;
        this.fontSizeLabel.Text = "Font Size";
        // 
        // fontSizeSlider
        // 
        this.fontSizeSlider.Dock = System.Windows.Forms.DockStyle.Fill;
        this.fontSizeSlider.Location = new System.Drawing.Point(643, 615);
        this.fontSizeSlider.Minimum = 1;
        this.fontSizeSlider.Name = "fontSizeSlider";
        this.fontSizeSlider.Size = new System.Drawing.Size(186, 30);
        this.fontSizeSlider.TabIndex = 6;
        this.fontSizeSlider.Value = 1;
        // 
        // label3
        // 
        this.charactersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.charactersLabel.AutoSize = true;
        this.charactersLabel.Location = new System.Drawing.Point(537, 692);
        this.charactersLabel.Name = "label3";
        this.charactersLabel.Size = new System.Drawing.Size(78, 20);
        this.charactersLabel.TabIndex = 10;
        this.charactersLabel.Text = "Characters";
        this.charactersLabel.Click += new System.EventHandler(this.label3_Click);
        // 
        // textBox3
        // 
        this.fontSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.fontSizeTextBox.Location = new System.Drawing.Point(835, 615);
        this.fontSizeTextBox.Name = "textBox3";
        this.fontSizeTextBox.ReadOnly = true;
        this.fontSizeTextBox.Size = new System.Drawing.Size(58, 27);
        this.fontSizeTextBox.TabIndex = 12;
        // 
        // baseForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1280, 720);
        this.Controls.Add(this.tableLayoutPanel1);
        this.MinimumSize = new System.Drawing.Size(1280, 720);
        this.Name = "baseForm";
        this.Text = "Image Convertor";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.fontSizeSlider)).EndInit();
        this.ResumeLayout(false);

    }


    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private RichTextBox textOutput;
    private PictureBox imageBox;
    private Button openButton;
    private Label label;
    private Button convertButton;
    private Button outputFolderButton;
    private TrackBar fontSizeSlider;
    private TextBox textInput;
    private TextBox parameters;
    private Label fontSizeLabel;
    private Label charactersLabel;
    private TextBox fontSizeTextBox;
}
