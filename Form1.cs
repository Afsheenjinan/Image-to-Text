namespace Image_to_Text;

public partial class baseForm : Form
{

    string? lastSavedFileName;


    public baseForm()
    {
        InitializeComponent();
        this.characterInput.Text = characters;
        this.fontSizeTextBox.Text = $"{this.fontSizeSlider.Value}";
        this.fontSizeTextBox.TextAlign = HorizontalAlignment.Center;
    }

    private void changeFontSize(object? sender, EventArgs e)
    {
        fontSizeTextBox.Text = $"{fontSizeSlider.Value}";
        textOutput.Font = new Font("Consolas", fontSizeSlider.Value);
    }

    private void openOutputFolder(object? sender, EventArgs e) => System.Diagnostics.Process.Start("explorer.exe", @".\output\");

    private void openInBrowser(object sender, EventArgs e)
    {
        string outputPath = @".\output\" + (lastSavedFileName ?? "") + ".html";
        if (lastSavedFileName == null || !File.Exists(outputPath))
        {
            MessageBox.Show($"Convert First", "The File Doesn't Exist");
            return;
        }
        var process = new System.Diagnostics.Process();
        process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputPath)
        {
            UseShellExecute = true
        };
        process.Start();
    }
    private void openInNotepad(object sender, EventArgs e)
    {
        string outputPath = @".\output\" + (lastSavedFileName ?? "") + ".txt";
        Console.WriteLine(outputPath);
        if (lastSavedFileName == null || !File.Exists(outputPath))
        {
            MessageBox.Show($"Convert First", "The File Doesn't Exist");
            return;
        }
        var process = new System.Diagnostics.Process();
        process.StartInfo = new System.Diagnostics.ProcessStartInfo(outputPath)
        {
            UseShellExecute = true
        };
        process.Start();
    }
    private void convertToText(object? sender, EventArgs e)
    {
        if (picture == null) return;

        Bitmap image = picture.bitmap;

        textOutput.Clear();

        string line = "";
        float brightness;
        string a_z = characterInput.Text; // characters

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                brightness = image.GetPixel(x, y).GetBrightness();
                line += a_z[(int)Math.Round(map(brightness, 0, 1, 0, a_z.Length - 1))] + "";
            }
            textOutput.AppendText(line + Environment.NewLine);
            line = "";
        }

        string htmlStyle = "line-height:0.6;letter-spacing:-0.5;font-family:monospace;font-size:";

        string outputPath = @"./output/" + picture.fileName;
        if (!Directory.Exists("output")) Directory.CreateDirectory("output");

        if (!File.Exists($"{outputPath}.txt"))
        {
            lastSavedFileName = picture.fileName;
            File.WriteAllText($"{outputPath}.txt", textOutput.Text);
            File.WriteAllText($"{outputPath}.html", $"<div style=\"{htmlStyle}{fontSizeSlider.Value}pt\"> <pre> {textOutput.Text} </pre></div>");
            return;
        }

        int ext = 1;
        while (File.Exists($"{outputPath} ({ext}).txt")) ext++;

        lastSavedFileName = $"{picture.fileName} ({ext})";

        File.WriteAllText($"{outputPath} ({ext}).txt", textOutput.Text);
        File.WriteAllText($"{outputPath} ({ext}).html", $"<div style=\"{htmlStyle}{fontSizeSlider.Value}pt\"> <pre> {textOutput.Text} </pre></div>");


    }

    private void openImage(object? sender, EventArgs e)
    {


        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg;)|*.png; *.jpg; *.jpeg;";
        DialogResult dialogResult = fileDialog.ShowDialog();

        if (dialogResult != DialogResult.OK) return;
        string imageFileName = fileDialog.SafeFileName.Split('.')[0];
        Bitmap image = new Bitmap(fileDialog.FileName);
        if (image.Height * image.Width > max_char_length)
        {
            MessageBox.Show($"Image must NOT contain more than {max_char_length} Pixels", "Too many Pixels");
            return;
        }

        int imageHeight = image.Height;
        int imageWidth = image.Width;
        string orientation = imageHeight > imageWidth ? "Portrait" : "Landscape";
        int imageBoxHeight = imageBox.Height;
        int imageBoxWidth = imageBox.Width;

        Bitmap? thumbnailImage = resizeImage(image, new Size(100, 100));

        picture = new Picture(image, imageFileName);

        this.imageParameters.Text = $"Resolution -{Environment.NewLine}";
        this.imageParameters.AppendText($"   Horizontal\t: {image.HorizontalResolution} dpi{Environment.NewLine}");
        this.imageParameters.AppendText($"   Vertical\t\t: {image.VerticalResolution} dpi{Environment.NewLine}");
        this.imageParameters.AppendText($"Height\t\t: {image.Height} px{Environment.NewLine}");
        this.imageParameters.AppendText($"Width\t\t: {image.Width} px{Environment.NewLine}");
        this.imageParameters.AppendText($"Pixel Format\t: {image.PixelFormat}");
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


}










