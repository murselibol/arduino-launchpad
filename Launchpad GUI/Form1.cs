using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace launchpad
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort;
        static Queue<string> input = new Queue<string>();
        WindowsMediaPlayer playerA = new WindowsMediaPlayer();
        WindowsMediaPlayer playerB = new WindowsMediaPlayer();
        WindowsMediaPlayer playerC = new WindowsMediaPlayer();
        WindowsMediaPlayer playerD = new WindowsMediaPlayer();
        WindowsMediaPlayer playerE = new WindowsMediaPlayer();
        WindowsMediaPlayer playerF = new WindowsMediaPlayer();
        static Stack<string> directories = new Stack<string>();
        public static string path,music_path;
        bool running = false;
        Thread t,q;
        public Form1()
        {
            InitializeComponent();
        }

        private void source_button_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderDialog.SelectedPath;

                }
            }
            source_textbox.Text = path;
            findSubdirectories();
        }

        public void findSubdirectories()
        {
            var dirs = Directory.EnumerateDirectories(path, "*", SearchOption.AllDirectories);
            foreach(string dir in dirs)
            {
                directories.Push(dir);
                music_folder_box.Items.Add(dir);
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            t = new Thread(connect);
            t.Priority = ThreadPriority.Highest;
            t.Start();
            q = new Thread(play);
            q.Priority = ThreadPriority.Highest;
            q.Start();
            running = true;
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (music_folder_box.SelectedItem != null)
            {
                music_path = music_folder_box.SelectedItem.ToString();
                log_textbox.AppendText("music set!"+Environment.NewLine);
            }
            
        }

        public void playFromQueue()
        {
            if(input.Count != 0)
            {
                string filename = input.Peek();
                try
                {
                    if (playerA.playState == WMPPlayState.wmppsStopped || playerA.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerA.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    else if (playerB.playState == WMPPlayState.wmppsStopped || playerB.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerB.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    else if (playerC.playState == WMPPlayState.wmppsStopped || playerC.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerC.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    else if (playerD.playState == WMPPlayState.wmppsStopped || playerD.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerD.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    else if (playerE.playState == WMPPlayState.wmppsStopped || playerE.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerE.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    else if (playerF.playState == WMPPlayState.wmppsStopped || playerF.playState == WMPPlayState.wmppsUndefined)
                    {
                        playerF.URL = @"C:\Users\VedFI\Desktop\TEST\Kdrew-Circles\" + filename;
                    }
                    input.Dequeue();
                }
                catch (Exception e)
                {
                    playFromQueue();
                }
            }

        }

        public void play()
        {
            while (running)
            {
                playFromQueue();
            }
        }

        public void connect()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM8";
            serialPort.BaudRate = 9600;
            serialPort.RtsEnable = false;
            serialPort.DtrEnable = true;  
            serialPort.Open();
            while (true)
            {
                string msg = serialPort.ReadExisting();
                if (msg.Length != 0)
                {
                    try
                    {
                        MethodInvoker mi = delegate () { log_textbox.AppendText(msg + Environment.NewLine); };
                        this.Invoke(mi);
                        input.Enqueue(msg.Trim().ToLower() + ".wav");
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        serialPort.Close();
                        break;
                    }
                    
                }
                Thread.Sleep(10);
            }
            running = false;
        }
    }
}