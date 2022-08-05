namespace Image_to_Text;
class Picture
{
    public Bitmap bitmap;
    public Size size;
    public string fileName;
    public double horizontalResolution;
    public double verticalResolution;

    public int width { get => size.Width; }
    public int height { get => size.Height; }

    public Picture(Bitmap image, string fileName)
    {
        this.bitmap = image;
        this.fileName = fileName;
        this.size = image.Size;
        this.horizontalResolution = image.HorizontalResolution;
        this.verticalResolution = image.VerticalResolution;
    }
}

partial class baseForm
{

    Picture picture;

    string characters = "@B&NWMOGSXUKFJItTL+*;~:,\".`'    ";
    int max_char_length = 2147483600;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.characterInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.imageParameters = new System.Windows.Forms.TextBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontSizeSlider = new System.Windows.Forms.TrackBar();
            this.charactersLabel = new System.Windows.Forms.Label();
            this.fontSizeTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderButton = new System.Windows.Forms.Button();
            this.notepadButton = new System.Windows.Forms.Button();
            this.browserButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.imageBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.convertButton, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.characterInput, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.textOutput, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageParameters, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fontSizeLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.fontSizeSlider, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.charactersLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.fontSizeTextBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderButton, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.notepadButton, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.browserButton, 7, 3);
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
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.imageBox, 3);
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Location = new System.Drawing.Point(3, 3);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(506, 606);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
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
            this.label.TabIndex = 1;
            this.label.Text = "Open an Image";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.openButton.Click += new System.EventHandler(this.openImage);
            // 
            // convertButton
            // 
            this.convertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertButton.AutoSize = true;
            this.convertButton.Location = new System.Drawing.Point(913, 651);
            this.convertButton.Name = "convertButton";
            this.tableLayoutPanel1.SetRowSpan(this.convertButton, 3);
            this.convertButton.Size = new System.Drawing.Size(94, 30);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert ->";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertToText);
            // 
            // characterInput
            // 
            this.characterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.characterInput, 2);
            this.characterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterInput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.characterInput.Location = new System.Drawing.Point(643, 687);
            this.characterInput.Name = "characterInput";
            this.characterInput.Size = new System.Drawing.Size(250, 27);
            this.characterInput.TabIndex = 7;
            // 
            // textOutput
            // 
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.textOutput, 5);
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOutput.Font = new System.Drawing.Font("Consolas", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textOutput.Location = new System.Drawing.Point(515, 3);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(762, 606);
            this.textOutput.TabIndex = 8;
            this.textOutput.Text = "";
            this.textOutput.WordWrap = false;
            this.textOutput.ZoomFactor = 0.016F;
            // 
            // imageParameters
            // 
            this.imageParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageParameters.Location = new System.Drawing.Point(259, 615);
            this.imageParameters.Multiline = true;
            this.imageParameters.Name = "imageParameters";
            this.imageParameters.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.imageParameters, 3);
            this.imageParameters.Size = new System.Drawing.Size(250, 102);
            this.imageParameters.TabIndex = 9;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(541, 620);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(69, 20);
            this.fontSizeLabel.TabIndex = 10;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontSizeSlider
            // 
            this.fontSizeSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontSizeSlider.Location = new System.Drawing.Point(643, 615);
            this.fontSizeSlider.Minimum = 2;
            this.fontSizeSlider.Name = "fontSizeSlider";
            this.fontSizeSlider.Size = new System.Drawing.Size(186, 30);
            this.fontSizeSlider.TabIndex = 6;
            this.fontSizeSlider.Value = 2;
            this.fontSizeSlider.ValueChanged += new System.EventHandler(this.changeFontSize);
            // 
            // charactersLabel
            // 
            this.charactersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.charactersLabel.AutoSize = true;
            this.charactersLabel.Location = new System.Drawing.Point(537, 692);
            this.charactersLabel.Name = "charactersLabel";
            this.charactersLabel.Size = new System.Drawing.Size(78, 20);
            this.charactersLabel.TabIndex = 11;
            this.charactersLabel.Text = "Characters";
            // 
            // fontSizeTextBox
            // 
            this.fontSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSizeTextBox.Location = new System.Drawing.Point(835, 615);
            this.fontSizeTextBox.Name = "fontSizeTextBox";
            this.fontSizeTextBox.ReadOnly = true;
            this.fontSizeTextBox.Size = new System.Drawing.Size(58, 27);
            this.fontSizeTextBox.TabIndex = 12;
            // 
            // outputFolderButton
            // 
            this.outputFolderButton.AutoSize = true;
            this.outputFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("outputFolderButton.Image")));
            this.outputFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.outputFolderButton.Location = new System.Drawing.Point(1027, 651);
            this.outputFolderButton.Name = "outputFolderButton";
            this.outputFolderButton.Size = new System.Drawing.Size(250, 30);
            this.outputFolderButton.TabIndex = 5;
            this.outputFolderButton.Text = "Open Output Folder";
            this.outputFolderButton.UseVisualStyleBackColor = true;
            this.outputFolderButton.Click += new System.EventHandler(this.openOutputFolder);
            // 
            // notepadButton
            // 
            this.notepadButton.AutoSize = true;
            this.notepadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notepadButton.Image = ((System.Drawing.Image)(resources.GetObject("notepadButton.Image")));
            this.notepadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notepadButton.Location = new System.Drawing.Point(1027, 615);
            this.notepadButton.Name = "notepadButton";
            this.notepadButton.Size = new System.Drawing.Size(250, 30);
            this.notepadButton.TabIndex = 13;
            this.notepadButton.Text = "Open with Notepad";
            this.notepadButton.UseVisualStyleBackColor = true;
            this.notepadButton.Click += new System.EventHandler(this.openInNotepad);
            // 
            // browserButton
            // 
            this.browserButton.AutoSize = true;
            this.browserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserButton.Image = ((System.Drawing.Image)(resources.GetObject("browserButton.Image")));
            this.browserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browserButton.Location = new System.Drawing.Point(1027, 687);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(250, 30);
            this.browserButton.TabIndex = 14;
            this.browserButton.Text = "Open with Browser";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.openInBrowser);
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
    private TextBox characterInput;
    private TextBox imageParameters;
    private Label fontSizeLabel;
    private Label charactersLabel;
    private TextBox fontSizeTextBox;
    private Button notepadButton;
    private Button browserButton;
}
