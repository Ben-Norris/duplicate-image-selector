using System.Security.Cryptography;
using System.Xml;

namespace DuplicateImageSelectorProj
{
    public partial class Form1 : Form
    {
        private string[] imgs;
        private HashSet<string> imageTypes = new HashSet<string>();
        private List<CheckBox> checkedBoxes = new List<CheckBox>();
        private bool selectAllFlag;

        public Form1()
        {
            InitializeComponent();
            imageTypes.Add(".jpg");
            checkedBoxes.Add(jpgCheckbox);
            imageTypes.Add(".png");
            checkedBoxes.Add(pngCheckbox);
            imageTypes.Add(".bmp");
            checkedBoxes.Add(bmpCheckbox);
            imageTypes.Add(".gif");
            checkedBoxes.Add(gifCheckbox);
            imageTypes.Add(".tif");
            checkedBoxes.Add(tifCheckbox);
            SelectAll(true);

            selectDuplicatesButton.Enabled = false;
        }

        private void selectFolderClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                currentFolderTextBox.Text = fd.SelectedPath;

                GetDirectoryFiles(fd.SelectedPath);
            }
        }

        private void GetDirectoryFiles(string path)
        {
            if (path == "")
            {
                return;
            }

            var files = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
                .Where(f => imageTypes.Contains(Path.GetExtension(f).ToLower()));
            imgs = files.ToArray();

            infoTextBox.Text = $"Images found : {imgs.Length}";

            selectDuplicatesButton.Enabled = imgs.Length > 0;
        }

        private void selectDuplicatesClick(object sender, EventArgs e)
        {
            FindAndMoveDuplicates();
        }

        private async Task FindAndMoveDuplicates()
        {
            Progress<FindDuplicatesProgressModel> progress = new Progress<FindDuplicatesProgressModel>();
            progress.ProgressChanged += CheckProgress;

            //get list of duplicates. wait and then move to _duplicates folder in this directory
            List<string> duplicates = await Task.Run(() => FindDuplicates(progress));

            infoTextBox.Text = $"Found {duplicates.Count} duplicates.";
            if (duplicates.Count < 1)
            {
                return;
            }

            string duplicatesFolder = $"{currentFolderTextBox.Text}\\_duplicates";
            if (!Directory.Exists(duplicatesFolder))
            {
                Directory.CreateDirectory(duplicatesFolder);
            }

            for (int i = 0; i < duplicates.Count; i++)
            {
                File.Move(duplicates[i], duplicatesFolder + "\\" + Path.GetFileName(duplicates[i]));
            }
        }

        //makes a hash of each image and adds to a set. anything not added to the set is returned
        private List<string> FindDuplicates(IProgress<FindDuplicatesProgressModel> progress)
        {
            FindDuplicatesProgressModel report = new FindDuplicatesProgressModel();

            ImageConverter converter = new ImageConverter();
            HashSet<byte[]> list = new HashSet<byte[]>(new ByteArrayComparer());
            List<string> duplicates = new List<string>();

            for (int i = 0; i < imgs.Length; i++)
            {
                byte[] bImage = new byte[1];
                using (var bitmap = new Bitmap(imgs[i]))
                {
                    bImage = (byte[])converter.ConvertTo(bitmap, bImage.GetType());
                }

                SHA256Managed shaM = new SHA256Managed();
                byte[] hash = shaM.ComputeHash(bImage);

                bool added = list.Add(hash);
                if (!added)
                {
                    duplicates.Add(imgs[i]);
                }

                report.CurrentImageIndex = i;
                progress.Report(report);
            }

            return duplicates;
        }

        private void CheckProgress(object sender, FindDuplicatesProgressModel progress)
        {
            infoTextBox.Text = $"Checking image {progress.CurrentImageIndex} / {imgs.Length}";
        }

        private void allCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SelectAll(allCheckbox.Checked);
        }

        private void SelectAll(bool selected)
        {
            selectAllFlag = true;
            for (int i = 0; i < checkedBoxes.Count; i++)
            {
                checkedBoxes[i].Checked = selected;
                checkedBoxes[i].Enabled = !selected;
            }
            selectAllFlag = false;

            GetDirectoryFiles(currentFolderTextBox.Text);
        }

        private void jpgCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (jpgCheckbox.Checked)
            {
                imageTypes.Add(".jpg");
            }
            else
            {
                imageTypes.Remove(".jpg");
            }

            if (!selectAllFlag)
            {
                GetDirectoryFiles(currentFolderTextBox.Text);
            }
        }

        private void pngCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (pngCheckbox.Checked)
            {
                imageTypes.Add(".png");
            }
            else
            {
                imageTypes.Remove(".png");
            }

            if (!selectAllFlag)
            {
                GetDirectoryFiles(currentFolderTextBox.Text);
            }
        }

        private void bmpCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (bmpCheckbox.Checked)
            {
                imageTypes.Add(".bmp");
            }
            else
            {
                imageTypes.Remove(".bmp");
            }

            if (!selectAllFlag)
            {
                GetDirectoryFiles(currentFolderTextBox.Text);
            }
        }

        private void gifCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (gifCheckbox.Checked)
            {
                imageTypes.Add(".gif");
            }
            else
            {
                imageTypes.Remove(".gif");
            }

            if (!selectAllFlag)
            {
                GetDirectoryFiles(currentFolderTextBox.Text);
            }
        }

        private void tifCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (tifCheckbox.Checked)
            {
                imageTypes.Add(".tif");
            }
            else
            {
                imageTypes.Remove(".tif");
            }

            if (!selectAllFlag)
            {
                GetDirectoryFiles(currentFolderTextBox.Text);
            }
        }
    }
}