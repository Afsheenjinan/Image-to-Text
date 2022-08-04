namespace Image_to_Text;

public partial class baseForm : Form
{
    Panel panelT = new Panel();
    Panel panelM = new Panel();
    Panel panelB = new Panel();
    Label label = new Label();
    Button openButton = new Button();
    Button convertButton = new Button();
    PictureBox imageBox = new PictureBox();
    // Label output = new Label();
    TextBox textOutput = new TextBox();

    // Bitmap? image;

    Picture? picture;

    // string imageFileName = "";

    // string characters = "   .,-_/|+*cabILOPSANM";
    string characters = "MNASPOLIbac*+|/_-,.   ";

    public baseForm()
    {
        InitializeComponent();


        panelT.Location = new Point(0, 0);
        panelT.Size = new Size(ClientSize.Width, 9 * ClientSize.Height / 10);
        panelT.Anchor = (AnchorStyles.Top);
        panelT.BorderStyle = BorderStyle.FixedSingle;
        panelT.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

        panelB.Location = new Point(0, 9 * ClientSize.Height / 10);
        panelB.Size = new Size(ClientSize.Width, ClientSize.Height / 10);
        panelB.BorderStyle = BorderStyle.FixedSingle;
        panelB.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

        label.Text = "Select Image";
        label.Location = new Point(panelB.Width / 2 - label.Width - 50, panelB.Height / 2 - label.Height / 2);

        openButton.Text = "Open";
        openButton.Height = 32;
        openButton.Location = new Point(panelB.Width / 2 + openButton.Width - 35, panelB.Height / 2 - openButton.Height / 2);
        openButton.TabIndex = 1;
        openButton.TabStop = true;
        openButton.Click += new EventHandler(button_Click);

        convertButton.Text = "Convert -->";
        convertButton.AutoSize = true;
        convertButton.Height = 32;
        convertButton.Location = new Point(panelB.Width - convertButton.Width - 35, panelB.Height / 2 - convertButton.Height / 2);
        convertButton.TabIndex = 2;
        convertButton.TabStop = true;
        convertButton.Click += new EventHandler(convertToText);

        // box.SizeMode = PictureBoxSizeMode.AutoSize; //CenterImage
        imageBox.Location = new Point(0, 0);
        imageBox.Size = new Size(ClientSize.Width / 2, 9 * ClientSize.Height / 10);
        imageBox.SizeMode = PictureBoxSizeMode.CenterImage;
        imageBox.BorderStyle = BorderStyle.FixedSingle;
        imageBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);

        textOutput.Location = new Point(ClientSize.Width / 2, 0);
        textOutput.Size = new Size(ClientSize.Width / 2, 9 * ClientSize.Height / 10);
        // textOutput.AutoSize = false;
        textOutput.Multiline = true;
        textOutput.WordWrap = false;
        textOutput.ReadOnly = true;
        // textOutput.TextAlign = HorizontalAlignment.Center;
        textOutput.ScrollBars = ScrollBars.Both;
        textOutput.PlaceholderText = "The Text Appears Here";
        // output.Font = new Font(FontFamily.GenericMonospace, 8);
        textOutput.Font = new Font("Consolas", 4);
        textOutput.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);

        panelB.Controls.Add(label);
        panelB.Controls.Add(openButton);
        panelB.Controls.Add(convertButton);
        panelT.Controls.Add(imageBox);
        panelT.Controls.Add(textOutput);
        Controls.Add(panelT);
        Controls.Add(panelB);
    }

    private void convertToText(object? sender, EventArgs e)
    {
        if (picture == null) return;

        Bitmap image = picture.bitmap;

        textOutput.Clear();

        string line = "";
        float brightness;

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                brightness = image.GetPixel(x, y).GetBrightness();
                line += characters[(int)Math.Round(map(brightness, 0, 1, 0, characters.Length - 1))] + " ";
            }
            textOutput.AppendText(line + Environment.NewLine);
            line = "";
        }


        string outputPath = @"./output/" + picture.fileName;
        if (!Directory.Exists("output")) Directory.CreateDirectory("output");

        if (!File.Exists($"{outputPath}.txt"))
        {
            File.WriteAllText($"{outputPath}.txt", textOutput.Text);
            return;
        }

        int ext = 1;
        while (File.Exists($"{outputPath} ({ext}).txt")) ext++;

        File.WriteAllText($"{outputPath} ({ext}).txt", textOutput.Text);

    }

    private void button_Click(object? sender, EventArgs e)
    {

        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg;";
        DialogResult dialogResult = fileDialog.ShowDialog();

        if (dialogResult != DialogResult.OK) return;
        string imageFileName = fileDialog.SafeFileName.Split('.')[0];
        Bitmap image = new Bitmap(fileDialog.FileName);

        picture = new Picture(image, imageFileName);
        Bitmap displayImage = resizeImage(image, new Size(100, 100));

        Console.WriteLine($"{image.HorizontalResolution}, {image.VerticalResolution}");
        Console.WriteLine(image.Height);
        Console.WriteLine(image.Width);
        Console.WriteLine(image.PixelFormat);

        imageBox.Image = image;
    }

    private static double map(double value, double fromLow, double fromHigh, double toLow, double toHigh) => (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;

    private static Bitmap resizeImage(Image sourceImage, Size size)
    {
        int width = sourceImage.Width, height = sourceImage.Height;

        Bitmap bitmap = new Bitmap(size.Width, size.Height);
        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        graphics.DrawImage(sourceImage, 0, 0, size.Width, size.Height);
        graphics.Dispose();
        return bitmap;
    }

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

}










