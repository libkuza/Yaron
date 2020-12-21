using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaperTheme;
using PS3Lib;

namespace YaronV1
{
    public partial class Form2 : ReaperForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static PS3API PS3 = new PS3API(SelectAPI.TargetManager);
        private void Form2_onColorBarColorChanged(object sender, ReaperEvents.OnColorBarColorChanged e)
        {
            Form1.PS35.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.PS35.ConnectTarget(0);
                Form1.PS35.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Connected To PS35");
            }
            catch
            {
                Form1.PS35.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Connect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.PS35.AttachProcess();
                Form1.PS35.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Attached To Sxny V2 Black Ops II RTM Tool!");
            }
            catch
            {
                Form1.PS35.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Attach :/");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                90,
                43,
                45,
                46,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                90,
                43,
                45,
                46,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                90,
                43,
                45,
                46,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                90,
                43,
                45,
                46,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                90,
                43,
                45,
                46,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                134,
                134,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                32,
                32,
                32,
                32,
                32,
                94,
                73,
                130,
                130,
                247
            });
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                245
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                245
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                247
            });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(Form1.PS35.Extension.ReadString(40633944u));
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.Extension.WriteString(40633944u, "^2Bye ^3Bye ^1Boo");
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249
            });
            
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS35.SetMemory(40633944u, bytes);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form1.PS35.Extension.WriteString(40633983u, "Yaron V2L^I�\u0010\u0010\u0010�™™™");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(16363627u, new byte[]
            {
                byte.MaxValue
            });
            Form1.PS35.SetMemory(1290083u, new byte[]
            {
                3
            });
            Form1.PS35.SetMemory(14164312u, new byte[1]);
            Form1.PS35.SetMemory(40633944u, new byte[13]);
            Form1.PS35.SetMemory(40633983u, new byte[13]);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form1.PS35.Extension.WriteString(40633983u, "^b");
            Form1.PS35.Extension.WriteString(40633983u, "^B^");
            Form1.PS35.Extension.WriteString(40633983u, "^B^ Yaron  ^B^ ^I�\u0010\u0010\u0010�™");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                127,
                127,
                13,
                102,
                101,
                101,
                100,
                98,
                97,
                99,
                107,
                98,
                108,
                101,
                110,
                100
            });
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633983u, new byte[]
            {
                94,
                66,
                226,
                132,
                162,
                226,
                132,
                162,
                226,
                132,
                162,
                226,
                131,
                162
            });
            Form1.PS35.SetMemory(40927800u, new byte[]
            {
                128,
                87,
                210,
                15
            });
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633983u, new byte[]
            {
                94,
                66,
                226,
                132,
                162,
                226,
                132,
                162,
                226,
                132,
                162,
                226,
                131,
                162
            });
            Form1.PS35.SetMemory(40927800u, new byte[]
            {
                128,
                87,
                210,
                15
            });
        }

        private void button31_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(Form1.PS35.Extension.ReadString(30233528u));
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                17,
                15
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                2,
                18,
                31
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                3,
                19,
                47
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                4,
                20,
                63
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                5,
                21,
                79
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                6,
                22,
                95
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                7,
                23,
                111
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                8,
                24,
                127
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                9,
                25,
                143
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                0,
                16,
                159
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                10,
                26,
                175
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                17,
                15
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                2,
                18,
                31
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                3,
                19,
                47
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                4,
                20,
                63
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                5,
                21,
                79
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                6,
                22,
                95
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                8,
                24,
                127
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                9,
                25,
                143
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                0,
                16,
                159
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                10,
                26,
                175
            });
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS35.SetMemory(40633944u, bytes);
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249,
                0
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                16,
                16,
                249,
                0
            });
            Form1.PS35.SetMemory(40633944u, new byte[]
            {
                94,
                72,
                16,
                16,
                249
            });
        }
    }
}
