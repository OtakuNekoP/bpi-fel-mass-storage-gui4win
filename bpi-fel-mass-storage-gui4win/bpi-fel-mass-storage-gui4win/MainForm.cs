using System;
using System.Diagnostics;//ADD
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace bpi_fel_mass_storage_gui4win
{
    public partial class MainForm : Form
    {
        String FelBin = "pack\\win32\\sunxi-fel.exe";
        String DetectDevCmd = "ver";
        String sPattern = @"\(([^)]*)\)";
        String BroadTyp;

        String H3Cmd = "-p uboot pack\\h3\\u-boot-sunxi-with-spl.bin write 0x42000000 pack\\h3\\zImage write 0x43000000 pack\\h3\\script.bin write 0x43300000 pack\\h3\\uInitrd write 0x43100000 pack\\h3\\boot.scr";
        String A64Cmd = "-p spl pack\\m64\\spl32.bin write 0x44000 pack\\m64\\bl31.bin write 0x4a000000 pack\\m64\\u-boot.bin write 0x40080000 pack\\m64\\Image write 0x4fa00000 pack\\m64\\sun50i-a64-bananapi-m64.dtb write 0x4fc00000 pack\\m64\\boot.scr write 0x4fe00000 pack\\m64\\initramfs.uimg reset64 0x44000";


        public MainForm()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainFormResource.Text_MsgBox_About);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Launch_Click(object sender, EventArgs e)
        {
            Boolean LaunchFlag = false;
            if (BroadTyp == "(H3)")
            {
                LaunchFEL(H3Cmd);
                LaunchFlag = true;
            }
            if(BroadTyp == "(A64)")
            {
                LaunchFEL(A64Cmd);
                LaunchFlag = true;
            }
            if (BroadTyp == "")
            {
                MessageBox.Show(MainFormResource.Text_MsgBox_NoDev);
            }
            else
            {
                if(LaunchFlag == false)
                {

                    MessageBox.Show(MainFormResource.Text_MsgBox_UnknowDev);
                }
            }
            LaunchFlag = false;

        }

        private void LaunchFEL(string LaunchCmd)
        {
            try
            {
                Process proc = Process.Start(FelBin, LaunchCmd);
                if (proc != null)
                {
                    proc.WaitForExit();
                    MessageBox.Show(String.Format(MainFormResource.Text_MsgBox_Success, this.FelBin), this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetectDevTyp_Click(object sender, EventArgs e)
        {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = FelBin;
                    proc.StartInfo.Arguments = DetectDevCmd;
                    proc.StartInfo.CreateNoWindow = true;
                    proc.StartInfo.UseShellExecute = false;
                    proc.StartInfo.RedirectStandardOutput = true;
                    proc.StartInfo.RedirectStandardError = true;
                    proc.Start();
                    StreamReader ProcOutReader = proc.StandardOutput;
                    StreamReader ProcErrReader = proc.StandardError;
                    string output = ProcOutReader.ReadToEnd() + ProcErrReader.ReadToEnd();
                    DetectOut.Text = output;
                    Regex regex = new Regex(sPattern);
                    Match match = regex.Match(output);
                    BroadTyp = match.Value;

                if (proc != null)
                    {
                        proc.WaitForExit();
                        //MessageBox.Show(String.Format(BroadTyp, this.FelBin), this.Text,
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);
                        proc.Close();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

    }
}
