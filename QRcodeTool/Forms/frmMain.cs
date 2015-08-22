using norplan.adm.qrlib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace norplan.adm.qrtoolui
{
    public partial class frmMain : Form
    {
        private int MinX;
        private int MinY;
        private int MaxX;
        private int MaxY;
        private bool OpenRect;
        private int SelectedRow;
        private string DecodedUrl;

        private void resetSelection()
        {
            if (hasSelection())
            {
                pbSelection.Image = null;
                pbSelection.Invalidate();
            }
            MinX = 0;
            MaxX = 0;
            MinY = 0;
            MaxY = 0;
            OpenRect = false;
            SelectedRow = -1;
            DecodedUrl = null;

            tsbtnOpenLink.Enabled = false;
            tsbtnOpenLink.Invalidate();
        }

        public frmMain()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFiles.AutoGenerateColumns = false;
            tsbtnOpenLink.Enabled = false;
            resetSelection();

        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if ((MaxY - MinY > 0) && (MaxX - MinX > 0))
                {
                    Rectangle ee = new Rectangle(MinX, MinY, MaxX - MinX, MaxY - MinY);
                    using (Pen pen = new Pen(Color.Red, 2))
                    {
                        e.Graphics.DrawRectangle(pen, ee);
                    }
                }
            }
            catch (Exception ex)
            {
                log("Application error: " + ex.Message);
            }
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            MinX = e.X;
            MinY = e.Y;
            MaxX = e.X;
            MaxY = e.Y;
            pbMain.Refresh();
            OpenRect = true;
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            // Create a new bitmap
            var mBitmap = new Bitmap(pbMain.Image);

            double mScale = 1;

            int mDeltaX = 0;
            int mDeltaY = 0;

            double mAspectPB = pbMain.Width / pbMain.Height;
            double mAspectImg = pbMain.Image.Width / pbMain.Image.Height;

            // Determine the aspect ratio
            if (mAspectPB >= mAspectImg)
            {
                //log("Picturebox is wider than picture");
                mScale = (double)mBitmap.Height / (double)pbMain.Height;
                mDeltaX = (((double)pbMain.Width * mScale) - (double)mBitmap.Width).AsInt();
            }
            else
            {
                //log("Picture is wider than picturebox");
                mScale = (double)mBitmap.Width / (double)pbMain.Width;
                mDeltaY = (((double)pbMain.Height * mScale) - (double)mBitmap.Height).AsInt();
            }

            // Create altered clipping extent
            int x1 = (((double)MinX * mScale) - ((double)mDeltaX / 2)).AsInt();
            int x2 = (((double)MaxX * mScale) - ((double)mDeltaX / 2)).AsInt();
            int y1 = (((double)MinY * mScale) - ((double)mDeltaY / 2)).AsInt();
            int y2 = (((double)MaxY * mScale) - ((double)mDeltaY / 2)).AsInt();

            // Construct rectangle
            var mRect = new Rectangle(
                x1,
                y1,
                (x2 - x1),
                (y2 - y1));

            if (mRect.X < 0)
            {
                mRect.X = 0;
            }

            if ((mRect.X + mRect.Width) > pbMain.Image.Width)
            {
                mRect.Width = (pbMain.Image.Width - mRect.X);
            }

            if (mRect.Y < 0)
            {
                mRect.Y = 0;
            }

            if ((mRect.Y + mRect.Height) > pbMain.Image.Height)
            {
                mRect.Height = (pbMain.Image.Height - mRect.Y);
            }

            if (mRect.Width < 1 || mRect.Height < 1)
            {
                log("Error: Either width or height of selection is zero, exiting");
                return;
            }

            if (hasSelection())
            {
                pbSelection.Image.Dispose();
            }

            var mBitmap2 = mBitmap.Clone(mRect, mBitmap.PixelFormat);

            pbSelection.SizeMode = PictureBoxSizeMode.Zoom;
            double mAspectSelection = (double)mRect.Width / (double)mRect.Height;
            pbSelection.Image = mBitmap2.ResizeImage(new Size(pbSelection.Width, (pbSelection.Width / mAspectSelection).AsInt()));
            pbSelection.Refresh();

            if (pbSelection.Image == null)
            {
                log("Error: You must select a portion of the image");
                resetSelection();
                return;
            }

            outputResult(mBitmap2);

            mBitmap.Dispose();

            OpenRect = false;
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (OpenRect == true)
            {
                MaxX = e.X;
                MaxY = e.Y;
                pbMain.Refresh();
            }
        }

        private string decodeBitmap(Bitmap pBitmap)
        {
            if (pBitmap == null)
            {
                log("Error: Bitmap error");
                return null;
            }

            var d = new ZXing.BarcodeReader();

            try
            {
                var r = d.Decode(pBitmap);
                if (r != null)
                {
                    return r.Text;
                }
                else
                {
                    log("Error: Cound not decode QR-code, try increasing the contrast or alter the selection");
                    return null;
                }
            }
            catch (Exception ex)
            {
                log("An error occurred while trying to decode the QR code");
                log("Exception: " + ex.Message, true);
                return null;
            }

        }

        private void log(object pMsg, bool pAppend = true)
        {
            var mTs = DateTime.Now.ToString("HH:mm:ss");
            if (pMsg == null || String.IsNullOrEmpty(pMsg.ToString()))
            {
                return;
            }
            else
            {
                pMsg = mTs + " - " + pMsg.ToString().Trim();
            }
            if (pAppend)
            {
                tbLog.AppendText(pMsg.ToString() + Environment.NewLine);
            }
            else
            {
                tbLog.Text = pMsg.ToString() + Environment.NewLine;
            }
        }

        private void tsbtnSelectFolder_Click(object sender, EventArgs e)
        {
            var mDir = @"C:\Users\runarbe\Dropbox (Personal)\20 - Middle East projects\Abu Dhabi Addressing (private)\QR-code\ANS Photos";
            if (Directory.Exists(mDir))
            {
                dlgSelectImageFolder.SelectedPath = mDir;
            }
            if (dlgSelectImageFolder.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                log("Please select a folder with images");
                return;
            }

            var mImages = Directory.GetFiles(dlgSelectImageFolder.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly);
            var mPhotos = new Photos();
            foreach (var mImage in mImages)
            {
                mPhotos.AddPhoto(mImage, getApprovalStatus(mImage));
            }

            dgvFiles.DataSource = mPhotos;
            dgvFiles.Refresh();

        }

        private void tsbtnDecode_Click(object sender, EventArgs e)
        {
            if (pbSelection.Image == null)
            {
                log("You must select a portion of the image");
                return;
            }
            using (var mBitmap = new Bitmap(pbSelection.Image))
            {
                log(decodeBitmap(mBitmap));
            }

        }

        private string getStatusFilename(string mBaseFile)
        {
            var mFilename = Path.GetFileNameWithoutExtension(mBaseFile);
            var mPath = Path.GetDirectoryName(mBaseFile);
            return mPath + "/" + mFilename + ".status";
        }

        private PhotoStatus getApprovalStatus(string mBaseFile)
        {
            var mStatusFile = getStatusFilename(mBaseFile);
            if (File.Exists(mStatusFile))
            {
                var mStatus = File.ReadAllText(mStatusFile);
                if (!String.IsNullOrEmpty(mStatus))
                {
                    return (PhotoStatus)Enum.Parse(typeof(PhotoStatus), mStatus);
                }
            }
            return PhotoStatus.NotChecked;
        }

        private void setApprovalStatus(PhotoStatus pStatus)
        {
            if (SelectedRow > -1)
            {
                var mRow = (Photo)dgvFiles.Rows[SelectedRow].DataBoundItem;
                File.WriteAllText(getStatusFilename(mRow.Filename), pStatus.ToString());
                mRow.Status = pStatus;
                dgvFiles.Refresh();
            }
        }

        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                resetSelection();

                SelectedRow = e.RowIndex;

                dgvFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                var mRow = (Photo)dgvFiles.Rows[e.RowIndex].DataBoundItem;

                var mImage = Bitmap.FromFile(mRow.Filename);
                if (pbMain.Image != null)
                {
                    pbMain.Image = null;
                    pbMain.Invalidate();
                }
                pbMain.Image = mImage;

            }

        }

        private void outputResult(Bitmap pBitmap)
        {
            var mUrl = decodeBitmap(pBitmap);
            if (!String.IsNullOrEmpty(mUrl) && mUrl.StartsWith("http://"))
            {
                tsbtnOpenLink.Enabled = true;
                DecodedUrl = mUrl;
            }
            else
            {
                tsbtnOpenLink.Enabled = false;
            }

            string mDistrictsShapefile = Application.StartupPath + "/Shape/districts.shp";
            var mRes = mUrl.TestQRCode(mDistrictsShapefile);
            if (mRes != null)
            {
                log(mRes.ToString());
            }
            else
            {
                log("Nothing decoded");
            }
        }

        private bool hasSelection()
        {
            return pbSelection.Image == null ? false : true;
        }

        private void tsbtnIncreaseSelectionContrast_Click(object sender, EventArgs e)
        {
            if (!hasSelection()) return;

            pbSelection.Image = new Bitmap(pbSelection.Image).SetContrast(100);
            outputResult(new Bitmap(pbSelection.Image));

        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            setApprovalStatus(PhotoStatus.Approved);
        }

        private void tsbtnReject_Click(object sender, EventArgs e)
        {
            setApprovalStatus(PhotoStatus.Rejected);
        }

        private void tsbtnOpenLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(DecodedUrl);
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnSelectLogFile_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                log("Set logfile for QR-code scans to: " + dlgSaveFile.FileName);
                QRLib.setLogFile(dlgSaveFile.FileName);
            }
        }

    }

}
