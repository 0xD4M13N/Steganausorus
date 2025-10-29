using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Steganausorus
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructor of the main form.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            // Show application version in the title bar
            Text += " v" + Application.ProductVersion;
        }






        /// <summary>
        /// Called when the "Open" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and show the "Open File" dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open an image file";
                openFileDialog.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg;*.gif;*.tiff|All Files|*.*";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    // Load the selected image into the PictureBox
                    PictureBoxOriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
                    PictureBoxOriginalImage.Image = Image.FromFile(selectedFilePath);
                }
            }
        }

        /// <summary>
        /// Called when the "Quit" menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Close();
        }

        /// <summary>
        /// Called when user double-clicks the application logo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxApplicationLogo_DoubleClick(object sender, EventArgs e)
        {
            // Open web brower on the GitHub repository of Steganausorus
            Process.Start("https://github.com/0xD4M13N/Steganausorus");
        }
    }
}
