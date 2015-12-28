using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gma.System.MouseKeyHook;
using WindowsInput;
using WindowsInput.Native;

using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;

using DotImaging;

namespace ImageClicker2
{
    public partial class frmMain : Form
    {
        // Mouse & keyboard listener
        IKeyboardMouseEvents MouseKey_Hook;
        IKeyboardMouseEvents MouseKey_Global;

        // General
        int X_START, Y_START, X_END, Y_END,
            SIZE_WIDTH, SIZE_HEIGHT;
        int refreshTime;
        bool RectangleSet;
        Bitmap imgSource;
        string selectedPath;
        string[] extensions = new[] { ".jpg", ".png", ".bmp" };
        char lastGroup;

        // Image recognition & parallel threads
        List<TemplateImage> templImages;
        string screenDirectory = Application.StartupPath + "\\Screens";

        Bgr<byte>[,] frame = null;
        bool imageFound;
        //public StreamWriter logFile;

        public frmMain(StreamWriter w)
        {
            InitializeComponent();
            templImages = new List<TemplateImage>();
            //logFile = w;
        }

        public frmMain()
        {
            InitializeComponent();
            templImages = new List<TemplateImage>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearEverything();
            SubscribeKeyHooks();
            if (!Directory.Exists(screenDirectory))
            {
                Directory.CreateDirectory(screenDirectory);
            }
        }

        void SubscribeKeyHooks()
        {
            MouseKey_Global = Hook.GlobalEvents();
            MouseKey_Global.KeyDown += MouseKey_Global_KeyDown;
        }

        void MouseKey_Global_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnStartMonitoring.Enabled && e.KeyCode == Keys.F9)
            {
                btnStartMonitoring.PerformClick();
                e.Handled = true;
            }
            else if (btnStopMonitoring.Enabled && e.KeyCode == Keys.F10)
            {
                btnStopMonitoring.PerformClick();
                e.Handled = true;
            }
        }

        void UnsubscribeKeyHooks()
        {
            MouseKey_Global.KeyDown -= MouseKey_Global_KeyDown;
            MouseKey_Global.Dispose();
        }


        private void SubscribeHooks()
        {
            MouseKey_Hook = Hook.GlobalEvents();

            MouseKey_Hook.MouseDownExt += MouseKey_Hook_MouseDownExt;
            MouseKey_Hook.MouseUpExt += MouseKey_Hook_MouseUpExt;
        }

        private void UnsubscribeHooks()
        {
            if (MouseKey_Hook == null) return;
            MouseKey_Hook.MouseDownExt -= MouseKey_Hook_MouseDownExt;
            MouseKey_Hook.MouseUpExt -= MouseKey_Hook_MouseUpExt;

            MouseKey_Hook.Dispose();
        }


        void MouseKey_Hook_MouseUpExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //Debug.WriteLine("LeftMouse up");
                X_END = e.X;
                Y_END = e.Y;

                //Debug.WriteLine("X_END: " + X_END + "; Y_END: " + Y_END);
                RectangleSet = true;
            }
            UnsubscribeHooks();
            UpdateForm();
        }

        void MouseKey_Hook_MouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //Debug.WriteLine("LeftMouse down");
                X_START = e.X;
                Y_START = e.Y;

                //Debug.WriteLine("X_START: " + X_START + "; Y_START: " + Y_START);
            }
        }

        void ClearEverything()
        {
            tbMonitorSpeed.Value = tbMonitorSpeed.Maximum / 2;
            refreshTime = tbMonitorSpeed.Value;
            txtSpeed.Text = tbMonitorSpeed.Value.ToString();

            txtYstart.Text = "";
            txtXstart.Text = "";
            txtYend.Text = "";
            txtXend.Text = "";
            txtFolder.Text = "";

            selectedPath = "";

            X_START = 0;
            Y_START = 0;
            X_END = 0;
            Y_END = 0;

            SIZE_HEIGHT = 0;
            SIZE_WIDTH = 0;

            RectangleSet = false;

            btnStartMonitoring.Enabled = false;
            btnStopMonitoring.Enabled = false;

            btnRefreshList.Enabled = false;
        }

        private void btnSetRectangle_Click(object sender, EventArgs e)
        {
            SubscribeHooks();
        }

        void UpdateForm()
        {
            if (RectangleSet && X_START != X_END && Y_START != Y_END)
            {
                if (X_START > X_END)
                {
                    int tmp = X_END;
                    X_END = X_START;
                    X_START = tmp;
                }

                if (Y_START > Y_END)
                {
                    int tmp = Y_END;
                    Y_END = Y_START;
                    Y_START = tmp;
                }

                txtXstart.Text = X_START.ToString();
                txtYstart.Text = Y_START.ToString();
                txtXend.Text = X_END.ToString();
                txtYend.Text = Y_END.ToString();

                btnStartMonitoring.Enabled = true;
                btnStopMonitoring.Enabled = false;

                SIZE_WIDTH = X_END - X_START;
                SIZE_HEIGHT = Y_END - Y_START;
            }
            else
            {
                ClearEverything();
            }
        }

        private Bitmap ScreenShot()
        {
            Bitmap screenShot = new Bitmap(SIZE_WIDTH, SIZE_HEIGHT, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(screenShot))
            {
                g.CopyFromScreen(X_START, Y_START, 0, 0, screenShot.Size);
                if (chkScreens.Checked)
                    screenShot.Save(screenDirectory + "\\screen_" + DateTime.Now.ToString("HHmmssf") + ".png", ImageFormat.Png);
            }

            return screenShot;
        }

        private void btnStartMonitoring_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("Monitor start...");

            lastGroup = '.';

            tmrClicker.Interval = tbMonitorSpeed.Value;
            tmrClicker.Enabled = true;

            btnStartMonitoring.Enabled = false;
            btnStopMonitoring.Enabled = true;
        }

        private void btnStopMonitoring_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("Monitor stop...");

            tmrClicker.Enabled = false;

            btnStartMonitoring.Enabled = true;
            btnStopMonitoring.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnsubscribeKeyHooks();
        }

        Bgr<byte>[,] BitmapToBgrByte(Bitmap source)
        {
            Bgr<byte>[,] byteArray = new Bgr<byte>[source.Width, source.Height];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y);
                    byteArray[x, y] = new Bgr<byte>(pixelColor.B, pixelColor.G, pixelColor.R);
                }
            }

            return byteArray;
        }

        private void tmrClicker_Tick(object sender, EventArgs e)
        {
            imgSource = ScreenShot();

            if (!chkClick.Checked)
            {
                return;
            }

            frame = BitmapToBgrByte(imgSource);
            imageFound = false;

            Parallel.ForEach(templImages, template =>
                {
                    // Measure search time
                    var stopwatch = System.Diagnostics.Stopwatch.StartNew();

                    Point loc;
                    if (TemplateFound(frame, template.BitmapArray, out loc))
                    {
                        imageFound = true;
                        stopwatch.Stop();

                        if (lastGroup != template.Group)
                        {
                            lastGroup = template.Group;
                            //LogMessage("Template clicked: " + template.Name);

                            System.Drawing.Point location = new System.Drawing.Point(
                                loc.X + X_START + (template.Size.Width / 2),
                                loc.Y + Y_START + (template.Size.Height / 2));
                            //Debug.WriteLine("DoMouseClick. Coordinates X:" + location.X + " Y:" + location.Y);
                            Cursor.Position = location;

                            InputSimulator inputSim = new InputSimulator();
                            inputSim.Mouse.LeftButtonDown();
                            inputSim.Mouse.LeftButtonUp();

                        }
                    }
                });
        }

        bool TemplateFound(Bgr<byte>[,] source, Bgr<byte>[,] template, out Point location)
        {
            location = Point.Empty;
            bool match = false;

            for (int xS = 0; xS < (source.GetLength(0) - template.GetLength(0)); xS++)
            {
                if (imageFound) return false;
                for (int yS = 0; yS < (source.GetLength(1) - template.GetLength(1)); yS++)
                {
                    if (imageFound) return false;
                    //if source pixel == template's 1st pixel
                    if (source[xS, yS].Equals(template[0, 0]))
                    {
                        location = new Point(xS, yS);
                        //check next pixels on template for match
                        for (int xT = 0; xT < template.GetLength(0); xT++)
                        {
                            if (imageFound) return false;
                            for (int yT = 0; yT < template.GetLength(1); yT++)
                            {
                                if (imageFound) return false;
                                // if next pixel doesn't match
                                if (!source[xS + xT, yS + yT].Equals(template[xT, yT]))
                                {
                                    match = false;
                                    xT = template.GetLength(0) - 1; // to break outer loop
                                    break;
                                }
                                match = true;
                            }
                        }
                        if (match)
                        {
                            return match;
                        }
                    }
                }
            }

            return false;
        }

        private void tbMonitorSpeed_ValueChanged(object sender, EventArgs e)
        {
            refreshTime = tbMonitorSpeed.Value;
            txtSpeed.Text = tbMonitorSpeed.Value.ToString();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtFolder.Text = dialog.SelectedPath;
                selectedPath = dialog.SelectedPath;

                getList();

                btnRefreshList.Enabled = true;
            }
        }

        void getList()
        {
            lstImageList.Items.Clear();
            templImages.Clear();

            DirectoryInfo dir = new DirectoryInfo(@"" + selectedPath + "");
            FileInfo[] imageFiles = dir.EnumerateFiles()
                .Where(f => extensions.Contains(f.Extension.ToLower()))
                .ToArray();

            foreach (FileInfo file in imageFiles)
            {
                templImages.Add(new TemplateImage(
                    file.Name, (Bitmap)Bitmap.FromFile(file.FullName).Clone()));

                lstImageList.Items.Add(file.Name);
                //LogMessage("Template loaded: " + file.Name);
            }
            //LogMessage("");
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            getList();
        }

        //void LogMessage(string message)
        //{
        //    logFile.WriteLine(message);
        //    logFile.Flush();
        //}

        private void btnResetGroup_Click(object sender, EventArgs e)
        {
            lastGroup = '.';
        }

    }
}
