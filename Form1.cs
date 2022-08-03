namespace Image_to_Text;

public partial class baseForm : Form
{
    Panel panelT = new Panel();
    Panel panelM = new Panel();
    Panel panelB = new Panel();
    Label label = new Label();
    Button openButton = new Button();
    Button convertButton = new Button();
    PictureBox box = new PictureBox();
    // Label output = new Label();
    TextBox output = new TextBox();

    Bitmap? image;

    string imageFileName = "";

    // string characters = "   .,-_/|+*cabILOPSANM";
    string characters = "MNASPOLIbac*+|/_-,.   ";

    public baseForm()
    {
        InitializeComponent();

        panelB.Location = new Point(0, 9 * ClientSize.Height / 10);
        panelB.Size = new Size(ClientSize.Width, ClientSize.Height / 10);
        // panelB.BorderStyle = BorderStyle.FixedSingle;
        panelB.Anchor = (AnchorStyles.Bottom);

        // { get; set; }
        label.Text = "Select Image";
        label.Location = new Point(panelB.Width / 2 - label.Width - 50, panelB.Height / 2 - label.Height / 2);
        panelB.Controls.Add(label);

        openButton.Text = "Open";
        openButton.Height = 32;
        openButton.Location = new Point(panelB.Width / 2 + openButton.Width - 35, panelB.Height / 2 - openButton.Height / 2);
        openButton.TabIndex = 1;
        openButton.TabStop = true;
        openButton.Click += new EventHandler(button_Click);
        panelB.Controls.Add(openButton);

        // box.SizeMode = PictureBoxSizeMode.AutoSize; //CenterImage
        box.Size = new Size(720, 480);
        box.Location = new Point(0, 0);
        Controls.Add(box);

        convertButton.Text = "Convert >>";
        convertButton.Height = 32;
        convertButton.Location = new Point(panelB.Width - convertButton.Width - 35, panelB.Height / 2 - convertButton.Height / 2);
        convertButton.TabIndex = 2;
        convertButton.TabStop = true;
        convertButton.Click += new EventHandler(convertToText);
        panelB.Controls.Add(convertButton);

        output.Size = new Size(720, 480);
        output.Location = new Point(720, 0);
        output.AutoSize = true;
        output.Multiline = true;
        output.WordWrap = false;
        output.ScrollBars = ScrollBars.Both;
        output.ReadOnly = true;
        output.PlaceholderText = "The Text Appears Here";
        output.Font = new Font(FontFamily.GenericMonospace, 3);
        // output.Font = new Font("Consolas", 3);
        Controls.Add(output);
        Controls.Add(panelB);
    }

    private void convertToText(object? sender, EventArgs e)
    {
        if (image == null) return;

        string line = "";
        Color pixel;
        float brightness;

        int val = 0;

        Console.WriteLine(image.Height);
        Console.WriteLine(image.Width);
        Console.WriteLine(imageFileName);

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                pixel = image.GetPixel(x, y);
                brightness = pixel.GetBrightness();
                val = (int)Math.Round(map(brightness, 0, 1, 0, characters.Length - 1));
                line += characters[val];
            }

            line += "\n";
            output.AppendText(line);
            // output.Text += text;
            // text = "\n";
            // text += "\n";
        }


        // This text is added only once to the file.
        int ext = 1;
        if (!File.Exists($"{imageFileName}.txt"))
        {

            File.WriteAllText($"{imageFileName}.txt", output.Text);
            return;

        }

        while (File.Exists($"{imageFileName}{ext}.txt")) ext++;

        File.WriteAllText($"{imageFileName}{ext}.txt", output.Text);

    }

    private void button_Click(object? sender, EventArgs e)
    {

        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
        DialogResult dialogResult = fileDialog.ShowDialog();

        if (dialogResult != DialogResult.OK) return;
        imageFileName = fileDialog.SafeFileName.Split('.')[0];
        image = new Bitmap(fileDialog.FileName);

        Bitmap displayImage = resizeImage(image, new Size(100, 100));

        float h = image.HorizontalResolution;
        float v = image.VerticalResolution;
        Console.WriteLine("{0}, {1}", h, v);
        Console.WriteLine(image.Height);
        Console.WriteLine(image.Width);
        Console.WriteLine(image.PixelFormat);

        box.Image = image;
    }

    // public static async Task WriteToFile(string text) => await File.WriteAllTextAsync("WriteText.txt", text);

    private static double map(double value, double fromLow, double fromHigh, double toLow, double toHigh) => (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;

    private static Bitmap resizeImage(Image original, Size size)
    {
        int width = original.Width, height = original.Height;

        Bitmap bitmap = new Bitmap(size.Width, size.Height);

        Graphics graphics = Graphics.FromImage(bitmap);
        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        graphics.DrawImage(original, 0, 0, size.Width, size.Height);
        graphics.Dispose();
        // return (Image)bitmap;
        return bitmap;

    }
}










