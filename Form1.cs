using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;//Yaron YT/Libkuza
using System.Windows.Forms;
using PS3Lib;
using ReaperTheme;

//Yaron YT/Libkuza
//Yaron YT/Libkuza
//Yaron YT/Libkuza
//Yaron YT/Libkuza
namespace YaronV1
{
    public partial class Form1 : ReaperForm
    {//Yaron YT/Libkuza
        public Form1()
        {
            InitializeComponent();
        }
        ////////////////////////
        public static uint ProcessID;
        public static uint[] processIDs;
        public static string snresult;
        public static string Info;
        public static PS3TMAPI.ConnectStatus connectStatus;
        public static string Status;//Yaron YT/Libkuza
        public static string MemStatus;
        private List<string> colorList = new List<string>();
        private Dictionary<string, Color> lblColors = new Dictionary<string, Color>();
        private List<Label> Labels = new List<Label>();
        private PS3API PS3 = new PS3API();
        private CCAPI PS31 = new CCAPI();
        private Random rand = new Random();
        ulong SpoofIPAddr = 0x0;
        public uint ZeroOffset;
        public int NumberOffsets = 0;
        public static PS3API PS39 = new PS3API();
        ////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }
        //Yaron YT/Libkuza
        private void ReaperCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (PS3.ConnectTarget())
                {
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "YaronV1 Connected");//Yaron YT/Libkuza
                    label1.Text = "PS3 Connected !";
                    label1.ForeColor = Color.Green;
                }
                else
                {

                    string Message = "YaronV1 can´t connect :/";
                    MessageBox.Show(Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!", ":/", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Not Connected";
                label1.ForeColor = Color.Red;

            }//Yaron YT/Libkuza
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {

                PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "Attached");
                label2.Text = "Attached !";
                label2.ForeColor = Color.Green;
              
                Form1.PS39.Extension.WriteString(814808680U, "##^1Yaron^5V1^7[^1Find Noobs^7]");
                Form1.PS39.Extension.WriteString(814874952U, "##^1Yaron^5V1^7[^1PLay 1vs1^7]");
                Form1.PS39.Extension.WriteString(814832874U, "##^1Yaron^5V1^7[^1Show Infections^7]");




            }//Yaron YT/Libkuza
            else
            {
                MessageBox.Show("Something Wrong !", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static PS3API PS35 = new PS3API();
        private void Button4_Click(object sender, EventArgs e)
        {
            Form1.PS35.DisconnectTarget();
            this.label1.Text = "Not Connected";
            this.label2.Text = "Not Attached";
            this.label1.ForeColor = Color.Red;
            this.label2.ForeColor = Color.Red;
        }

        private void ReaperCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {//Yaron YT/Libkuza
            bool @checked = this.metroCheckBox7.Checked;
            if (@checked)
            {
                byte[] buffer = new byte[]
                {
                    56,
                    96,
                    0,
                    1
                };
                this.PS3.SetMemory(492512u, buffer);
                this.PS31.SetMemory(492512u, buffer);
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer2 = array;
                this.PS3.SetMemory(493060u, buffer2);//Yaron YT/Libkuza
                this.PS31.SetMemory(493060u, buffer2);
            }
            else
            {
                byte[] array2 = new byte[4];
                array2[0] = 56;
                array2[1] = 96;
                byte[] buffer3 = array2;
                this.PS3.SetMemory(492512u, buffer3);
                this.PS31.SetMemory(492512u, buffer3);
                array2 = new byte[4];
                array2[0] = 56;
                array2[1] = 96;
                byte[] buffer4 = array2;
                this.PS3.SetMemory(493060u, buffer4);
                this.PS31.SetMemory(493060u, buffer4);//Yaron YT/Libkuza
            }
        }

        private void MetroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.metroCheckBox8.Checked;
            if (@checked)
            {
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                this.PS3.SetMemory(1023572u, buffer);
                this.PS31.SetMemory(1023572u, buffer);
            }
            else//Yaron YT/Libkuza
            {
                byte[] buffer2 = new byte[]
                {
                    72,
                    80,
                    110,
                    229
                };
                this.PS3.SetMemory(1023572u, buffer2);
                this.PS31.SetMemory(1023572u, buffer2);
            }
        }

        private void MetroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.metroCheckBox6.Checked;
            if (@checked)
            {//Yaron YT/Libkuza
                byte[] array = new byte[4];
                array[0] = 96;
                byte[] buffer = array;
                this.PS3.SetMemory(212064u, buffer);
                this.PS31.SetMemory(212064u, buffer);
            }
            else
            {
                byte[] buffer2 = new byte[]
                {
                    64,
                    129,
                    0,
                    68
                };
                this.PS3.SetMemory(212064u, buffer2);
                this.PS31.SetMemory(212064u, buffer2);
            }//Yaron YT/Libkuza
        }

        private void MetroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked == true)
            {
                byte[] L = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
                PS3.SetMemory(0xEF68C, L);

            }
            else
            {
                byte[] L = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
                PS3.SetMemory(0xEF68C, L);
            }
        }
        //Yaron YT/Libkuza
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PS31.Extension.ReadByte(0x1CBF9F8) != 0)
            {
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x00 });
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x00 });
                PS31.SetMemory(0x000834D0, new byte[] { 0x38, 0xC0, 0xFF, 0xFF });
                PS31.SetMemory(0x000834D0, new byte[] { 0x38, 0xC0, 0xFF, 0xFF });
            }
            else
            {

            }
        }

        private void MetroCheckBox4_CheckedChanged(object sender, EventArgs e)//Yaron YT/Libkuza
        {
            if (PS31.Extension.ReadByte(0x1CBF9F8) != 0)
            {
                wallhackTimer.Start();
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x00 });
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x00 });
                PS31.SetMemory(0x000834D0, new byte[] { 0x38, 0xC0, 0xFF, 0xFF });
                PS31.SetMemory(0x000834D0, new byte[] { 0x38, 0xC0, 0xFF, 0xFF });
            }
            else
            {
                wallhackTimer.Stop();
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x01 });
                PS31.SetMemory(0x1CBF9F8, new byte[] { 0x01 });
                PS31.SetMemory(0x000834D0, new byte[] { 0x63, 0x26, 0x00, 0x00 });
                PS31.SetMemory(0x000834D0, new byte[] { 0x63, 0x26, 0x00, 0x00 });
            }
        }

        private void MetroCheckBox5_CheckedChanged(object sender, EventArgs e)//Yaron YT/Libkuza
        {
            bool @checked = this.metroCheckBox5.Checked;
            if (@checked)
            {
                byte[] buffer = new byte[]
                {
                    56,
                    192,
                    byte.MaxValue,
                    byte.MaxValue
                };
                this.PS3.SetMemory(537808u, buffer);
                this.PS31.SetMemory(537808u, buffer);
            }
            else
            {
                byte[] array = new byte[4];//Yaron YT/Libkuza
                array[0] = 99;
                array[1] = 38;
                byte[] buffer2 = array;
                this.PS3.SetMemory(537808u, buffer2);
                this.PS31.SetMemory(537808u, buffer2);
            }
        }

        private void MetroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.metroCheckBox2.Checked;
            if (@checked)
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory(0x1cd6018, buffer);
            }//Yaron YT/Libkuza
            else
            {
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory(0x1cd6018, buffer);
            }
        }

        private void ReaperButton3_Click(object sender, EventArgs e)
        {
            byte[] Name = Encoding.ASCII.GetBytes(textBox1.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(0x026C0658, Name);
            PS3.SetMemory(0x026c067f, Name);
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            base.Name = this.textBox1.Text; int num = new Random().Next(0, 9);//Yaron YT/Libkuza
            PS3.SetMemory(0x026C0658, Encoding.ASCII.GetBytes("^" + num.ToString() + base.Name + "\0"));
            PS3.SetMemory(0x026c067f, Encoding.ASCII.GetBytes("^" + num.ToString() + base.Name + "\0"));
        }

        private void ReaperButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ReaperButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            byte[] Name = Encoding.ASCII.GetBytes(textBox1.Text);
            Array.Resize(ref Name, Name.Length + 1);
            PS3.SetMemory(0x026C0658, Name);
            PS3.SetMemory(0x026c067f, Name);
        }
        //Yaron YT/Libkuza
        private void ReaperButton5_Click(object sender, EventArgs e)
        {
            Form1.PS35.SetMemory(40633944U, new byte[15]
          {
                (byte) 94,
                (byte) 72,
                (byte) 127,
                (byte) 127,
                (byte) 8,
                (byte) 117,
                (byte) 105,
                (byte) 95,
                (byte) 103,
                (byte) 108,
                (byte) 111,
                (byte) 98,
                (byte) 101,
                (byte) 0,
                (byte) 0
          });
        }
        //Yaron YT/Libkuza
        private void ReaperButton4_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton6_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1RTM");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);//Yaron YT/Libkuza
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton7_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5VenomCFW");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);//Yaron YT/Libkuza
        }
        //Yaron YT/Libkuza
        private void ReaperButton8_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("Venom like ^169");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);//Yaron YT/Libkuza
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }
        //Yaron YT/Libkuza
        private void ReaperButton12_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1YT^7/^2Libkuza");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton11_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Host = ^6Gay");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);//Yaron YT/Libkuza
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton9_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("Ihave^1RedBox^5Xd");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton16_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^1PS3^5isthebest");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton10_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5X^1N^5X^1X");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);//Yaron YT/Libkuza
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton15_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("Rebug^1<3");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton14_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("xThEsNiPeBeAsT");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton13_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");//Yaron YT/Libkuza
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton20_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton19_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton18_Click(object sender, EventArgs e)
        {//Yaron YT/Libkuza
            byte[] bytes = Encoding.ASCII.GetBytes("IYaronV1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton17_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton21_Click(object sender, EventArgs e)
        {
            byte[] prestige = BitConverter.GetBytes(Convert.ToInt32(numericUpDown1.Text));
            PS3.SetMemory(0x26FD014, prestige);
        }

        private void ReaperButton22_Click(object sender, EventArgs e)
        {
            byte[] LVL55 = new byte[] { 0x00, 0xFF, 0x12 };
            PS3.SetMemory(0x26FD02C, LVL55);//Yaron YT/Libkuza
        }

        private void ReaperButton23_Click(object sender, EventArgs e)
        {
            BO2.Method_Bo2Unlocks.UnlockAll();
            MessageBox.Show("Black Ops 2 Unlock All Method Complete.", "Check Your Callsign's and Custom Classes.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            for (int i = 0; i < 10; i++)
            {
                SetClass(0x02707AC7 + (uint)i * 0x10, "^2Yaron^1V1");
            }
        }

        private void ReaperButton25_Click(object sender, EventArgs e)
        {
            byte[] UnlockTokens = new byte[] { 0xFF, 0xFF };
            PS3.SetMemory(0x2706938, UnlockTokens);
        }

        private void ReaperButton24_Click(object sender, EventArgs e)
        {
            byte[] TenClass = new byte[] { 0x44, 0x80, 0x08, 0x10, 0x01, 0x22, 0x40, 0x04 };
            PS3.SetMemory(0x2708522, TenClass);
        }

        private void ReaperButton32_Click(object sender, EventArgs e)
        {
            byte[] buffer1 = new byte[2] { (byte)72, (byte)0 };
            PS3.SetMemory(4046164U, buffer1);
            byte[] buffer2 = new byte[2] { (byte)72, (byte)0 };
            PS3.SetMemory(5273536U, buffer2);
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,//Yaron YT/Libkuza
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(2948476U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(6797352U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797355U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797362U, new byte[1]);
            PS3.SetMemory(810557548U, new byte[9]
            {
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 114,
        (byte) 111,
        (byte) 117,
        (byte) 110,
        (byte) 100,
        (byte) 0
            });
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 127,
        byte.MaxValue,
        (byte) 24,
        (byte) 46
            });
            buffer2[0] = (byte)115;
            buffer2[1] = (byte)108;
            PS3.SetMemory(9482500U, buffer2);
            PS3.SetMemory(6797352U, new byte[1] { (byte)96 });
            PS3.SetMemory(6797355U, new byte[1]);
            PS3.SetMemory(6797362U, new byte[1] { (byte)127 });
            PS3.SetMemory(810557548U, new byte[8]);
            buffer1[0] = (byte)56;//Yaron YT/Libkuza
            buffer1[1] = (byte)96;
            PS3.SetMemory(111388U, buffer1);
            PS3.SetMemory(9482500U, new byte[3]);
            PS3.SetMemory(9347824U, new byte[1] { (byte)114 });
            PS3.SetMemory(9347824U, new byte[1] { (byte)82 });
            PS3.SetMemory(111388U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            buffer2[0] = (byte)56;
            buffer2[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer2);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer3 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer3);//Yaron YT/Libkuza
            buffer1[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer3[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer3);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
            PS3.SetMemory(111388U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            buffer3[0] = (byte)56;
            buffer3[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer3);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0//Yaron YT/Libkuza
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });//Yaron YT/Libkuza
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer4 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer4);
            buffer1[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer4[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer4);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 94,//Yaron YT/Libkuza
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
            PS3.SetMemory(111388U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            buffer4[0] = (byte)56;
            buffer4[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer4);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0//Yaron YT/Libkuza//Yaron YT/Libkuza
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer5 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer5);
            buffer1[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer5[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer5);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
            PS3.SetMemory(111388U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(6797348U, buffer1);
            buffer5[0] = (byte)56;
            buffer5[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer5);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer6 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer6);
            buffer1[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer1);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer6[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer6);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
        }

        private void ReaperButton29_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(6797352U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797355U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797362U, new byte[1]);
            PS3.SetMemory(810557548U, new byte[9]
            {
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 114,
        (byte) 111,
        (byte) 117,
        (byte) 110,
        (byte) 100,
        (byte) 0
            });
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 127,
        byte.MaxValue,
        (byte) 24,
        (byte) 46
            });
            PS3.SetMemory(9482500U, new byte[3]
            {
        (byte) 115,
        (byte) 108,
        (byte) 0
            });
            PS3.SetMemory(6797352U, new byte[1] { (byte)96 });//Yaron YT/Libkuza
            PS3.SetMemory(6797355U, new byte[1]);
            PS3.SetMemory(6797362U, new byte[1] { (byte)127 });
            PS3.SetMemory(810557548U, new byte[8]);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(9482500U, new byte[3]);
        }

        private void ReaperButton30_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(24667583U, new byte[15]
          {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
          });
            PS3.SetMemory(24690119U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 32,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24892943U, new byte[15]);
            PS3.SetMemory(24915479U, new byte[15]);
            PS3.SetMemory(24938015U, new byte[15]);
            PS3.SetMemory(24960551U, new byte[15]);
            PS3.SetMemory(24983087U, new byte[15]);
            PS3.SetMemory(25005623U, new byte[15]);
            PS3.SetMemory(25050695U, new byte[15]);
            PS3.SetMemory(24712655U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24735191U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24757727U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24780263U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24802799U, new byte[15]
            {
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 7,
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(24825335U, new byte[15]);
            PS3.SetMemory(24847871U, new byte[15]);
            PS3.SetMemory(24870407U, new byte[15]);
        }

        private void ReaperButton34_Click(object sender, EventArgs e)
        {
            byte[] buffer1 = new byte[4];
            byte[] buffer2 = new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 249
            };
            PS3.SetMemory(111388U, buffer2);
            PS3.SetMemory(6797348U, buffer2);
            PS3.SetMemory(6797348U, buffer2);
            buffer1[0] = (byte)56;
            buffer1[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer1);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer3 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer3);
            buffer2[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer2);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer3[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer3);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
            PS3.SetMemory(111388U, buffer2);
            PS3.SetMemory(6797348U, buffer2);
            PS3.SetMemory(6797348U, buffer2);
            buffer3[0] = (byte)56;
            buffer3[1] = (byte)96;
            PS3.SetMemory(6976224U, buffer3);
            PS3.SetMemory(6258260U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(4046164U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5273536U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5284768U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5289500U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5292000U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5295240U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5504108U, new byte[2]
            {
        (byte) 72,
        (byte) 0
            });
            PS3.SetMemory(5290612U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5537236U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(5538120U, new byte[4]
            {
        (byte) 96,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
            byte[] buffer4 = new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(2948476U, buffer4);
            buffer2[0] = (byte)96;
            PS3.SetMemory(6797348U, buffer2);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 53,
        (byte) 23,
        (byte) 53,
        (byte) 30
            });
            buffer4[0] = (byte)96;
            PS3.SetMemory(2948476U, buffer4);
            PS3.SetMemory(6797348U, new byte[7]
            {
        (byte) 144,
        (byte) 154,
        (byte) 0,
        (byte) 0,//Yaron YT/Libkuza
        (byte) 94,
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(6797362U, new byte[2]
            {
        (byte) 94,
        (byte) 94
            });
            PS3.SetMemory(9319824U, new byte[13]);
            PS3.SetMemory(229356U, new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 8,
        (byte) 240
            });
        }

        private void ReaperButton35_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(780200u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(4307164u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(4307128u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7894432u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(4307152u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7740788u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7607508u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7740752u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7746652u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(7743252u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7743232u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7743220u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7743212u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(7740768u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(7740756u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(7745684u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(7745656u, array);
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(7745700u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(7745632u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(4046164u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5273536u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5284768u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5289500u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5292000u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5295240u, array);
            array = new byte[2];
            array[0] = 72;
            this.PS3.SetMemory(5504108u, array);
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(5290612u, array);
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(5537236u, array);
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(5538120u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            byte[] array2 = array;
            this.PS3.SetMemory(4307152u, array2);
            this.PS3.SetMemory(111388u, array2);
            this.PS3.SetMemory(7746652u, array2);
            this.PS3.SetMemory(7894432u, array2);
            this.PS3.SetMemory(4307128u, array2);
            this.PS3.SetMemory(4307164u, array2);
            this.PS3.SetMemory(7894432u, array2);
            this.PS3.SetMemory(4307152u, array2);
            this.PS3.SetMemory(7740788u, array2);
            this.PS3.SetMemory(7740768u, array2);
            this.PS3.SetMemory(7740756u, array2);
            this.PS3.SetMemory(7607508u, array2);
            this.PS3.SetMemory(7743252u, array2);
            this.PS3.SetMemory(7743220u, array2);
            this.PS3.SetMemory(762714u, array2);
            this.PS3.SetMemory(7743232u, array2);
            this.PS3.SetMemory(7743176u, array2);
            this.PS3.SetMemory(3397704u, array2);
            this.PS3.SetMemory(4301148u, array2);
            this.PS3.SetMemory(4301156u, array2);
            this.PS3.SetMemory(4301252u, array2);
            this.PS3.SetMemory(4301272u, array2);
            this.PS3.SetMemory(4301288u, array2);
            this.PS3.SetMemory(4301312u, array2);
            this.PS3.SetMemory(4301332u, array2);
            this.PS3.SetMemory(4301356u, array2);
            this.PS3.SetMemory(4301380u, array2);
            this.PS3.SetMemory(4301432u, array2);
            this.PS3.SetMemory(4301436u, array2);
            this.PS3.SetMemory(4301828u, array2);
            this.PS3.SetMemory(4301960u, array2);
            byte[] buffer = new byte[]
            {
                    47,
                    131,
                    72,
                    0
            };
            this.PS3.SetMemory(7740752u, buffer);
            this.PS3.SetMemory(3341524u, buffer);
            this.PS3.SetMemory(7743212u, buffer);
            array = new byte[4];
            array[0] = 96;
            byte[] buffer2 = array;
            this.PS3.SetMemory(4599916u, buffer2);
            this.PS3.SetMemory(762700u, buffer2);
            this.PS3.SetMemory(2948476u, new byte[]
            {
                    96
            });
            array = new byte[2];
            array[0] = 96;
            this.PS3.SetMemory(6797348u, array);
            array = new byte[3];
            array[0] = 96;
            this.PS3.SetMemory(6797208u, array);
            this.PS3.SetMemory(6797232u, new byte[]
            {
                    60,
                    96,
                    81
            });
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(111388u, array);
            this.PS3.SetMemory(24666981u, new byte[]
            {
                    3,
                    69,
                    152
            });
            this.PS3.SetMemory(24667041u, new byte[]
            {
                    3,
                    69,
                    122
            });
            this.PS3.SetMemory(24667585u, new byte[]
            {
                    3,
                    81,
                    206
            });
            this.PS3.SetMemory(6797352u, new byte[]
            {
                    96
            });
            this.PS3.SetMemory(6797355u, new byte[1]);
            this.PS3.SetMemory(6797362u, new byte[]
            {
                    127
            });
            this.PS3.SetMemory(9347820u, new byte[]
            {
                    55,
                    105,
                    0,
                    0,
                    146
            });
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(1327440u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(1115588u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(780200u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(779932u, array);
            array = new byte[4];
            array[0] = 60;
            array[1] = 96;
            this.PS3.SetMemory(6976232u, array);
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            this.PS3.SetMemory(6976224u, array);
            byte[] array3 = new byte[4];
            array2[0] = 60;
            array2[1] = 96;
            this.PS3.SetMemory(1115588u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            this.PS3.SetMemory(1116644u, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            this.PS3.SetMemory(1115872u, array2);
        }

        private void ReaperButton37_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 124;
            this.PS3.SetMemory(1327440u, array);
            array[0] = 96;
            this.PS3.SetMemory(2948476u, array);
            this.PS3.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            this.PS3.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            this.PS3.SetMemory(9319824u, new byte[13]);
            this.PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            byte[] buffer = new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            };
            this.PS3.SetMemory(24646768u, new byte[]
            {
                37,//Yaron YT/Libkuza
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            this.PS3.SetMemory(24646776u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            this.PS3.SetMemory(24645416u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            this.PS3.SetMemory(9319824u, buffer);
            this.PS3.SetMemory(9319824u, buffer);
            byte[] buffer2 = new byte[]
            {
                65,
                130,
                8,
                240
            };
            this.PS3.SetMemory(229356u, buffer2);
            this.PS3.SetMemory(229356u, buffer2);
            this.PS3.SetMemory(6797348u, new byte[]
            {
                96,
                112,
                96,
                112,
                96,
                112,
                96,
                112,
                128,
                159,
                0,
                0,
                96,
                132,
                0,
                13
            });
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(111388u, array);
            this.PS3.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,//Yaron YT/Libkuza
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            this.PS3.SetMemory(9319824u, array);
            this.PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            this.PS3.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            this.PS3.SetMemory(9319824u, buffer);
            this.PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,//Yaron YT/Libkuza
                8,
                240
            });
            this.PS3.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            this.PS3.SetMemory(9319824u, buffer2);
            this.PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            this.PS3.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,//Yaron YT/Libkuza
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
        }

        private void ReaperButton36_Click(object sender, EventArgs e)
        {
            this.PS3.SetMemory(6797348u, new byte[]
            {
                96
            });
            byte[] array = new byte[3];
            array[0] = 96;
            this.PS3.SetMemory(2948476u, array);
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(111388u, array);
            this.PS3.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            array[0] = 96;
            array[3] = 249;
            this.PS3.SetMemory(6797348u, array);
            this.PS3.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            this.PS3.SetMemory(9319824u, new byte[]
            {
                13
            });
            this.PS3.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            this.PS3.SetMemory(6797208u, new byte[]
            {
                96
            });
            array = new byte[4];
            array[0] = 96;
            this.PS3.SetMemory(6797348u, array);
            this.PS3.SetMemory(6797352u, new byte[]
            {
                96
            });
            this.PS3.SetMemory(6797355u, new byte[1]);
            this.PS3.SetMemory(6797362u, new byte[]
            {
                127
            });
        }

        private void ReaperButton31_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(6797352U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797355U, new byte[1] { (byte)72 });
            PS3.SetMemory(6797362U, new byte[1]);
            PS3.SetMemory(810557548U, new byte[9]
            {
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 114,
        (byte) 111,
        (byte) 117,
        (byte) 110,
        (byte) 100,
        (byte) 0
            });
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 127,
        byte.MaxValue,
        (byte) 24,
        (byte) 46
            });
            PS3.SetMemory(9482500U, new byte[3]
            {
        (byte) 115,
        (byte) 108,
        (byte) 0
            });
            PS3.SetMemory(6797352U, new byte[1] { (byte)96 });
            PS3.SetMemory(6797355U, new byte[1]);
            PS3.SetMemory(6797362U, new byte[1] { (byte)127 });
            PS3.SetMemory(810557548U, new byte[8]);
            PS3.SetMemory(111388U, new byte[4]
            {
        (byte) 56,
        (byte) 96,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(9482500U, new byte[3]);
        }

        private void ReaperButton33_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(2948476u, new byte[]
           {
            96
           });
            PS3.SetMemory(9482500u, new byte[]
            {
            96
            });
            PS3.SetMemory(1327440u, new byte[]
            {
            96
            });
            PS3.SetMemory(9347824u, new byte[]
            {
            82
            });
        }

        private void ReaperButton28_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < 18; i++)
            {
                string text = Form1.PS35.Extension.ReadString(Convert.ToUInt32(16423368 + i * 328));
                if (text == string.Empty)
                {
                    text = "";
                }
                string text2 = string.Concat(new object[]
                {
                    ((int)Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16423470 + i * 328))).ToString(),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16423471 + i * 328)),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16423472 + i * 328)),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16423473 + i * 328))
                });
                this.listView1.Items.Add(new ListViewItem(Convert.ToString(text2))
                {
                    SubItems =
                    {
                        text,
                        text2
                    }
                });
            }
        }

        private void ReaperButton26_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < 18; i++)
            {
                string text = Form1.PS35.Extension.ReadString(Convert.ToUInt32(16377496 + i * 328));
                string text2 = string.Concat(new object[]
                {
                    ((int)Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16377638 + i * 328))).ToString(),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16377639 + i * 328)),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16377640 + i * 328)),
                    ".",
                    Form1.PS35.Extension.ReadByte(Convert.ToUInt32(16377641 + i * 328))
                });
                this.listView1.Items.Add(new ListViewItem(Convert.ToString(text2))
                {
                    SubItems =
                    {
                        text,
                        text2
                    }
                });
            }
        }

        private void ReaperButton27_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                return;
            }
            this.label3.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void ReaperButton38_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(this.label2.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS35.SetMemory(40633944u, bytes);
            Form1.PS35.SetMemory(40633983u, bytes);
        }

        private void ReaperButton39_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^5Yaron^1V1");
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            this.PS3.SetMemory(0x26c0658, bytes);
            this.PS3.SetMemory((uint)0x26c0658, bytes);
            this.PS3.SetMemory(0x26c067f, bytes);//Yaron YT/Libkuza
            this.PS3.SetMemory((uint)0x26c067f, bytes);
        }

        private void ReaperButton40_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.label3.Text);
        }

        private void ReaperCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.reaperCheckBox3.Checked)
            {
                byte[] buffer = new byte[4]
                 {
                (byte) 44,
                (byte) 4,
                (byte) 0,
                (byte) 0
                 };
                Form1.PS35.SetMemory(6228512U, buffer);
                byte[] numArray = new byte[4]
                 {
                 (byte) 44,
                 (byte) 4,
                 (byte) 0,
                 (byte) 0
                 };
            }
            else
                Form1.PS35.SetMemory(6228512U, new byte[4]
                {
                 (byte) 44,
                 (byte) 4,
                 (byte) 0,
                 (byte) 2
                });
        }
        
        private void ReaperButton41_Click(object sender, EventArgs e)
        {
            
        }

        public class RPC
        {
            public static int Call(uint func_address, params object[] parameters)
            {
                int length = parameters.Length;
                int index = 0;
                UInt32 num3 = 0;
                UInt32 num4 = 0;
                UInt32 num5 = 0;
                UInt32 num6 = 0;
                while (index < length)
                {
                    if (parameters[index] is int)
                    {
                        PS35.Extension.WriteInt32(0x10020000 + (num3 * 4), (int)parameters[index]);
                        num3++;
                    }
                    else if (parameters[index] is UInt32)
                    {
                        PS35.Extension.WriteUInt32(0x10020000 + (num3 * 4), (UInt32)parameters[index]);
                        num3++;
                    }
                    else
                    {
                        UInt32 num7;
                        if (parameters[index] is string)
                        {
                            num7 = 0x10022000 + (num4 * 0x400);
                            PS35.Extension.WriteString(num7, Convert.ToString(parameters[index]));
                            PS35.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                            num3++;
                            num4++;
                        }
                        else if (parameters[index] is float)
                        {
                            PS35.Extension.WriteFloat(0x10020024 + (num5 * 4), (float)parameters[index]);
                            num5++;
                        }
                        else if (parameters[index] is float[])
                        {
                            float[] input = (float[])parameters[index];
                            num7 = 0x10021000 + (num6 * 4);
                            PS35.Extension.WriteUInt32(0x10020000 + (num3 * 4), num7);
                            num3++;
                            num6 += (UInt32)input.Length;
                        }
                    }
                    index++;
                }
                PS35.Extension.WriteUInt32(0x1002004C, func_address);
                Thread.Sleep(20);
                return PS35.Extension.ReadInt32(0x10020050);
            }
            private static void Enable()
            {
                uint function_address = 0x7AA050;
                PS35.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
                Thread.Sleep(20);
                byte[] memory = new byte[]
                    { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x02, 0x81, 0x83, 0x00, 0x4C,
            0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08,
            0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18,
            0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xc0, 0x43, 0x00, 0x28,
            0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xc0, 0xC3, 0x00, 0x38,
            0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00,
            0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x02, 0x38, 0xA0, 0x00, 0x00,
            0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6,
            0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
                PS35.SetMemory(function_address + 4, memory);
                PS35.SetMemory(0x10020000, new byte[0x2854]);
                PS35.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
                //PS3.SetMemory(0x3DBF70, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS35.SetMemory(0x30010000, new byte[] { 0x01 });

            }
            public static void Init()
            {
                if (PS35.Extension.ReadByte(0x30010000) == 1)
                    Console.Write("RPC Already Enabled"); //RPC is enabled
                else
                    Enable(); //Enable RPC
            }

            public static void iPrintln(int Client, string Text)
            {
                SV_GameSendServerCommand(Client, "O \"" + Text + "\"");
            }

            public static void iPrintlnBold(int Client, string Text)
            {
                SV_GameSendServerCommand(Client, "< \"" + Text + "\"");
            }
            public static void CBuf_Addtext(string Command)
            {
                RPC.Call(0x0313C18, 0, Command);
            }

            public static void SV_GameSendServerCommand(int Client, string Command)
            {
                RPC.Call(0x0349F6C, Client, 1, Command);
            }
        }

        private void ReaperButton42_Click(object sender, EventArgs e)
        {
            string serverCmd = "cmd mr " + PS35.Extension.ReadInt32(0xF109E8 + 0x13B4) + " 3 " + "endround";
            RPC.Call(0x313C18, 0, serverCmd);
        }

        private static void Enable()
        {
            uint function_address = 0x7AA050;
            PS35.SetMemory(function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });
            Thread.Sleep(20);
            byte[] memory = new byte[]
                { 0x7C, 0x08, 0x02, 0xA6, 0xF8, 0x01, 0x00, 0x80, 0x3C, 0x60, 0x10, 0x02, 0x81, 0x83, 0x00, 0x4C,
            0x2C, 0x0C, 0x00, 0x00, 0x41, 0x82, 0x00, 0x64, 0x80, 0x83, 0x00, 0x04, 0x80, 0xA3, 0x00, 0x08,
            0x80, 0xC3, 0x00, 0x0C, 0x80, 0xE3, 0x00, 0x10, 0x81, 0x03, 0x00, 0x14, 0x81, 0x23, 0x00, 0x18,
            0x81, 0x43, 0x00, 0x1C, 0x81, 0x63, 0x00, 0x20, 0xC0, 0x23, 0x00, 0x24, 0xc0, 0x43, 0x00, 0x28,
            0xC0, 0x63, 0x00, 0x2C, 0xC0, 0x83, 0x00, 0x30, 0xC0, 0xA3, 0x00, 0x34, 0xc0, 0xC3, 0x00, 0x38,
            0xC0, 0xE3, 0x00, 0x3C, 0xC1, 0x03, 0x00, 0x40, 0xC1, 0x23, 0x00, 0x48, 0x80, 0x63, 0x00, 0x00,
            0x7D, 0x89, 0x03, 0xA6, 0x4E, 0x80, 0x04, 0x21, 0x3C, 0x80, 0x10, 0x02, 0x38, 0xA0, 0x00, 0x00,
            0x90, 0xA4, 0x00, 0x4C, 0x90, 0x64, 0x00, 0x50, 0xE8, 0x01, 0x00, 0x80, 0x7C, 0x08, 0x03, 0xA6,
            0x38, 0x21, 0x00, 0x70, 0x4E, 0x80, 0x00, 0x20 };
            PS35.SetMemory(function_address + 4, memory);
            PS35.SetMemory(0x10020000, new byte[0x2854]);
            PS35.SetMemory(function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });
            //PS3.SetMemory(0x3DBF70, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            PS35.SetMemory(0x30010000, new byte[] { 0x01 });

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            RPC.Init();
            label5.Text = "RPC On";
               
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            PS3.DisconnectTarget();
        }

        private void Form1_onColorBarColorChanged(object sender, ReaperEvents.OnColorBarColorChanged e)
        {
            
        }

        public uint ContainsSequence(byte[] toSearch, byte[] toFind, uint StartOffset, int bytes)
        {
            for (int i = 0; (i + toFind.Length) < toSearch.Length; i += bytes)
            {
                bool flag = true;
                for (int j = 0; j < toFind.Length; j++)
                {
                    if (toSearch[i + j] != toFind[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    NumberOffsets++;
                    int num3 = ((int)StartOffset) + i;
                    return (uint)num3;
                }
            }
            return 0;
        }

        private ulong Search(byte[] Search, uint Start, int Length, int bytes)
        {
            byte[] ReadBytes = PS3.Extension.ReadBytes(Start, Length);
            uint num = this.ContainsSequence(ReadBytes, Search, Start, bytes);
            if (num.Equals(this.ZeroOffset))
            {
                return 0;

            }
            else
            {
                int counter = 0;
                foreach (int value in Search)
                    if (value == 1) ++counter;
                uint num2 = num + ((uint)counter);
                return num2;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            switch (button1.Text)
            {
                case "Find Current Offset":
                    SpoofIPAddr = Search(PS3.Extension.ReadBytes(0x0FA9A2E, 4), 0x1A274E4, 0x200000, 4);
                    if (SpoofIPAddr != 0x0)
                    {
                        MessageBox.Show("Found Offset!\nNow You Can Spoof To Any IP Address You Want :)");
                        
                        label1.Text = "Found";
                        
                    }
                    else
                    {
                        MessageBox.Show("Offset Weren't Found\nReStart Your Game And Try Again :(");
                        label1.Text = "Not Found";
                    }
                    break;
            }
        }

        public static byte[] GrabIP(string ip)
        {
            string[] ipS = ip.Split('.');
            return new byte[] { Convert.ToByte(ipS[0]), Convert.ToByte(ipS[1]), Convert.ToByte(ipS[2]), Convert.ToByte(ipS[3]) };
        }


        private void ReaperButton41_Click_1(object sender, EventArgs e)
        {
            try
            {
                string text = this.button88.Text;
                if (text == "Spoof IP")
                {
                    this.SpoofIPAddr = this.Search(Form1.PS3a.Extension.ReadBytes(16423470u, 4), 27423972u, 2097152, 4);
                    bool flag = this.SpoofIPAddr > 0UL;
                    if (!flag)
                    {
                        MessageBox.Show("Code Not Found", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                bool flag2 = this.textBox1.Text == string.Empty;
                if (flag2)
                {
                    MessageBox.Show("Please Input An IP Address!");
                }
                else
                {
                    Form1.PS3a.SetMemory(Convert.ToUInt32(this.SpoofIPAddr), Form1.GrabIP(this.textBox1.Text));
                    MessageBox.Show("Successfully Spoofed Your IP Address Back Out To Lan Party For It To Show Online.");
                }
            }
            catch
            {
                MessageBox.Show("Error Nigga");
            }

        }

        public static void CBuf_Addtext(string Command)
        {
            RPC.Call(0x0313C18, 0, Command);
        }

        

        private void ReaperButton5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ReaperButton41_Click_2(object sender, EventArgs e)
        {
            
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReaperButton5_Click_2(object sender, EventArgs e)
        {
            //Form2 newForm2 = new Form2();
            //newForm2.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
        }

        private void reaperButton5_Click_3(object sender, EventArgs e)
        {
            var loadoffsetretrv39 = 0x27078C0 - 0x3782F21C;
            var loadoffsetretwrite39 = Convert.ToDecimal(loadoffsetretrv39);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite39 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv40 = 0x27078CE - 0x3782F21C;
            var loadoffsetretwrite40 = Convert.ToDecimal(loadoffsetretrv40);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite40 / 4 + " " + Convert.ToDecimal(0xA8000000));

            var loadoffsetretrv41 = 0x27078F4 - 0x3782F21C;
            var loadoffsetretwrite41 = Convert.ToDecimal(loadoffsetretrv41);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite41 / 4 + " " + Convert.ToDecimal(0x00150000));

            var loadoffsetretrv42 = 0x2707902 - 0x3782F21C;
            var loadoffsetretwrite42 = Convert.ToDecimal(loadoffsetretrv42);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite42 / 4 + " " + Convert.ToDecimal(0x800A0000));

            var loadoffsetretrv43 = 0x2707929 - 0x3782F21C;
            var loadoffsetretwrite43 = Convert.ToDecimal(loadoffsetretrv43);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite43 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv44 = 0x2707937 - 0x3782F21C;
            var loadoffsetretwrite44 = Convert.ToDecimal(loadoffsetretrv44);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite44 / 4 + " " + Convert.ToDecimal(0xA8000000));

            var loadoffsetretrv45 = 0x270795D - 0x3782F21C;
            var loadoffsetretwrite45 = Convert.ToDecimal(loadoffsetretrv45);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite45 / 4 + " " + Convert.ToDecimal(0x00150000));

            var loadoffsetretrv46 = 0x270796B - 0x3782F21C;
            var loadoffsetretwrite46 = Convert.ToDecimal(loadoffsetretrv46);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite46 / 4 + " " + Convert.ToDecimal(0x800A0000));

            var loadoffsetretrv47 = 0x2707992 - 0x3782F21C;
            var loadoffsetretwrite47 = Convert.ToDecimal(loadoffsetretrv47);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite47 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv48 = 0x27079A0 - 0x3782F21C;
            var loadoffsetretwrite48 = Convert.ToDecimal(loadoffsetretrv48);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite48 / 4 + " " + Convert.ToDecimal(0xA8000000));

            var loadoffsetretrv49 = 0x27079C6 - 0x3782F21C;
            var loadoffsetretwrite49 = Convert.ToDecimal(loadoffsetretrv49);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite49 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv50 = 0x27079D4 - 0x3782F21C;
            var loadoffsetretwrite50 = Convert.ToDecimal(loadoffsetretrv50);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite50 / 4 + " " + Convert.ToDecimal(0xA8000000));

            var loadoffsetretrv51 = 0x27079FB - 0x3782F21C;
            var loadoffsetretwrite51 = Convert.ToDecimal(loadoffsetretrv51);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite51 / 4 + " " + Convert.ToDecimal(0x00150000));

            var loadoffsetretrv52 = 0x2707A09 - 0x3782F21C;
            var loadoffsetretwrite52 = Convert.ToDecimal(loadoffsetretrv52);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite52 / 4 + " " + Convert.ToDecimal(0x800A0000));

            var loadoffsetretrv53 = 0x2707A2F - 0x3782F21C;
            var loadoffsetretwrite53 = Convert.ToDecimal(loadoffsetretrv53);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite53 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv54 = 0x2707A3D - 0x3782F21C;
            var loadoffsetretwrite54 = Convert.ToDecimal(loadoffsetretrv54);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite54 / 4 + " " + Convert.ToDecimal(0xA8000000));

            var loadoffsetretrv55 = 0x2707A64 - 0x3782F21C;
            var loadoffsetretwrite55 = Convert.ToDecimal(loadoffsetretrv55);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite55 / 4 + " " + Convert.ToDecimal(0x00150000));

            var loadoffsetretrv56 = 0x2707A72 - 0x3782F21C;
            var loadoffsetretwrite56 = Convert.ToDecimal(loadoffsetretrv56);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite56 / 4 + " " + Convert.ToDecimal(0x800A0000));

            var loadoffsetretrv57 = 0x2707A98 - 0x3782F21C;
            var loadoffsetretwrite57 = Convert.ToDecimal(loadoffsetretrv57);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite57 / 4 + " " + Convert.ToDecimal(0x50010000));

            var loadoffsetretrv58 = 0x2707AA6 - 0x3782F21C;
            var loadoffsetretwrite58 = Convert.ToDecimal(loadoffsetretrv58);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite58 / 4 + " " + Convert.ToDecimal(0xA8000000));
        }

        private void reaperButton17_Click_1(object sender, EventArgs e)
        {
           
        }

        private void reaperButton19_Click_1(object sender, EventArgs e)
        {
            var loadoffsetretrv11 = 0x26FD014 - 0x3782F21C;
            var loadoffsetretwrite11 = Convert.ToDecimal(loadoffsetretrv11);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite11 / 4 + " " + Convert.ToDecimal(0x0C000000));
        }

        private void reaperButton13_Click_1(object sender, EventArgs e)
        {
            var loadoffsetretrv39 = 0x01cc28d8 - 0x3782F21C;
            var loadoffsetretwrite39 = Convert.ToDecimal(loadoffsetretrv39);
            RPC.Call(0x349F6C, -1, 1, "i " + loadoffsetretwrite39 / 4 + " " + Convert.ToDecimal(0x3D800000));
        }

        private void reaperButton20_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Name2_Click(object sender, EventArgs e)
        {

        }
        //Yaron YT/Libkuza
        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private byte[] Combine(byte[] Arr1, byte[] Arr2)
        {
            byte[] Res = new byte[Arr1.Length + Arr2.Length];
            Buffer.BlockCopy(Arr1, 0, Res, 0, Arr1.Length);
            Buffer.BlockCopy(Arr2, 0, Res, Arr1.Length, Arr2.Length);
            return Res;
        }
        byte[] CombSetClan;
        private void SetClan(uint offset, string input)
        {
            PS3.SetMemory(offset, new byte[6]);
            PS31.SetMemory(offset, new byte[6]);
            if (input.Length == 1)
            {
                CombSetClan = Combine(new byte[7], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 2)
            {
                CombSetClan = Combine(new byte[6], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 3)
            {
                CombSetClan = Combine(new byte[5], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            else if (input.Length == 4)
            {
                CombSetClan = Combine(new byte[4], Encoding.ASCII.GetBytes(input).Reverse().ToArray()).Reverse().ToArray();
            }
            if (input.Length > 0)
            {
                PS3.SetMemory(offset, BitConverter.GetBytes(BitConverter.ToUInt64(CombSetClan, 0) * 64));
                PS31.SetMemory(offset, BitConverter.GetBytes(BitConverter.ToUInt64(CombSetClan, 0) * 64));
            }
        }
        uint ClanOffset = 0x2708238;
        
            private void reaperButton17_Click_2(object sender, EventArgs e)
        {
            SetClan(ClanOffset, ClanBox.Text);
        }
        private void SetClass(uint offset, string input)
        {
            PS3.SetMemory(offset, new byte[16]);
            PS31.SetMemory(offset, new byte[16]);
            byte[] Multiplier = new byte[] { 0x04 };
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            PS3.SetMemory(offset, Functions.Multiply(inputBytes, Multiplier));
            PS31.SetMemory(offset, Functions.Multiply(inputBytes, Multiplier));
        }
        private void reaperButton51_Click(object sender, EventArgs e)
        {
            SetClass(0x02707AC7 + ((uint)ClassNum.Value - 1) * 0x10, ClassName.Text);
        }

        private void reaperButton50_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                SetClass(0x02707AC7 + (uint)i * 0x10, ClassName.Text);
            }
        }

        private void reaperButton41_Click_3(object sender, EventArgs e)
        {
            //Days Played
            decimal num = 32 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 23 * 60M;
            decimal num4 = (num + num2) + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);
            PS31.SetMemory(0x26FD10A, bytes);
            //Deaths
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToInt32(142346.ToString()));
            PS3.SetMemory(0x26FC942, bytes1);
            PS31.SetMemory(0x26FC942, bytes1);
            //Kills
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(643568.ToString()));
            PS3.SetMemory(0x26FCB70, bytes2);
            PS31.SetMemory(0x26FCB70, bytes2);
            //Score
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(18456272.ToString()));
            PS3.SetMemory(0x26FD050, bytes3);
            PS31.SetMemory(0x26FD050, bytes3);
            //Wins
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(448871.ToString()));
            PS3.SetMemory(0x26FD152, bytes4);
            PS31.SetMemory(0x26FD152, bytes4);
            //Losses
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(116701.ToString()));
            PS3.SetMemory(0x26FCBE2, bytes5);
            PS31.SetMemory(0x26FCBE2, bytes5);
            //Level 55
            byte[] rank = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, rank);
            PS31.SetMemory(0x26FD016, rank);
        }

        private void reaperButton43_Click(object sender, EventArgs e)
        {
            //Days Played
            decimal num = 32 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 23 * 60M;
            decimal num4 = (num + num2) + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);
            PS31.SetMemory(0x26FD10A, bytes);
            //Deaths
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToInt32(14234.ToString()));
            PS3.SetMemory(0x26FC942, bytes1);
            PS31.SetMemory(0x26FC942, bytes1);
            //Kills
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(34356.ToString()));
            PS3.SetMemory(0x26FCB70, bytes2);
            PS31.SetMemory(0x26FCB70, bytes2);
            //Score
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(1845627.ToString()));
            PS3.SetMemory(0x26FD050, bytes3);
            PS31.SetMemory(0x26FD050, bytes3);
            //Wins
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(2887.ToString()));
            PS3.SetMemory(0x26FD152, bytes4);
            PS31.SetMemory(0x26FD152, bytes4);
            //Losses
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(1167.ToString()));
            PS3.SetMemory(0x26FCBE2, bytes5);
            PS31.SetMemory(0x26FCBE2, bytes5);
            //Level 55
            byte[] rank = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, rank);
            PS31.SetMemory(0x26FD016, rank);
        }

        private void reaperButton44_Click(object sender, EventArgs e)
        {
            //Days Played
            decimal num = 32 * 86400M;
            decimal num2 = 8 * 3600M;
            decimal num3 = 23 * 60M;
            decimal num4 = (num + num2) + num3;
            byte[] bytes = BitConverter.GetBytes(Convert.ToUInt32(num4.ToString()));
            PS3.SetMemory(0x26FD10A, bytes);
            PS31.SetMemory(0x26FD10A, bytes);
            //Deaths
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToInt32(142346.ToString()));
            PS3.SetMemory(0x26FC942, bytes1);
            PS31.SetMemory(0x26FC942, bytes1);
            //Kills
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(343568.ToString()));
            PS3.SetMemory(0x26FCB70, bytes2);
            PS31.SetMemory(0x26FCB70, bytes2);
            //Score
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(18456272.ToString()));
            PS3.SetMemory(0x26FD050, bytes3);
            PS31.SetMemory(0x26FD050, bytes3);
            //Wins
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(28871.ToString()));
            PS3.SetMemory(0x26FD152, bytes4);
            PS31.SetMemory(0x26FD152, bytes4);
            //Losses
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(11671.ToString()));
            PS3.SetMemory(0x26FCBE2, bytes5);
            PS31.SetMemory(0x26FCBE2, bytes5);
            //Level 55
            byte[] rank = new byte[] { 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00, 0x4C, 0x0F, 0x13 };
            PS3.SetMemory(0x26FD016, rank);
            PS31.SetMemory(0x26FD016, rank);
        }

        private void reaperButton45_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext(";cmd userinfo \"\\clanAbbrev\\" + IngameClan.Text + "\\name\\" + IngameName.Text);
        }

        private void reaperButton46_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext(";cmd userinfo \"\\clanAbbrev\\" + AdName.Text + "\\name\\" + AdClan.Text);
        }

        private void reaperButton57_Click(object sender, EventArgs e)
        {

        }
        public static PS3API PS3a = new PS3API(SelectAPI.TargetManager);
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox27.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(1290047u, new byte[]
                {
                    56
                });
            }
            else
            {
                Form1.PS3a.SetMemory(1290047u, new byte[]
                {
                    228
                });
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox36.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(30233528u, new byte[]
                {
                    153
                });
            }
            else
            {
                Form1.PS3a.SetMemory(30233528u, new byte[1]);
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(9482500u, new byte[2]);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox29.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(9347824u, new byte[]
                {
                    146
                });
            }
            else
            {
                Form1.PS3a.SetMemory(9347824u, new byte[]
                {
                    114
                });
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = !((CheckBox)sender).Checked;
            if (!flag)
            {
                Form1.PS3a.GetMemory(6797355u, new byte[1]);
                byte[] expr_29 = new byte[4];
                expr_29[1] = 96;
                byte[] buffer = expr_29;
                Form1.PS3a.GetMemory(4599916u, buffer);
                byte[] expr_30 = new byte[4];
                expr_30[0] = 96;
                byte[] buffer2 = expr_30;
                Form1.PS3a.GetMemory(229356u, buffer2);
                byte[] expr_31 = new byte[4];
                expr_31[0] = 56;
                expr_31[1] = 96;
                byte[] buffer3 = expr_31;
                Form1.PS3a.GetMemory(6258260u, buffer3);
                byte[] expr_32 = new byte[2];
                expr_32[0] = 72;
                byte[] buffer4 = expr_32;
                Form1.PS3a.GetMemory(4046164u, buffer4);
                byte[] expr_9E = new byte[2];
                expr_9E[0] = 72;
                byte[] buffer5 = expr_9E;
                Form1.PS3a.GetMemory(5273536u, buffer5);
                byte[] expr_BC = new byte[2];
                expr_BC[0] = 72;
                byte[] buffer6 = expr_BC;
                Form1.PS3a.GetMemory(5284768u, buffer6);
                byte[] expr_DA = new byte[2];
                expr_DA[0] = 72;
                byte[] buffer7 = expr_DA;
                Form1.PS3a.GetMemory(5289500u, buffer7);
                byte[] expr_F8 = new byte[2];
                expr_F8[0] = 72;
                byte[] buffer8 = expr_F8;
                Form1.PS3a.GetMemory(5292000u, buffer8);
                byte[] expr_33 = new byte[2];
                expr_33[0] = 72;
                byte[] buffer9 = expr_33;
                Form1.PS3a.GetMemory(5295240u, buffer9);
                byte[] expr_34 = new byte[2];
                expr_34[0] = 72;
                byte[] buffer10 = expr_34;
                Form1.PS3a.GetMemory(5504108u, buffer10);
                byte[] expr_35 = new byte[4];
                expr_35[0] = 96;
                byte[] buffer11 = expr_35;
                Form1.PS3a.GetMemory(5290612u, buffer11);
                byte[] expr_36 = new byte[4];
                expr_36[0] = 96;
                byte[] buffer12 = expr_36;
                Form1.PS3a.GetMemory(5537236u, buffer12);
                byte[] expr_18E = new byte[4];
                expr_18E[0] = 96;
                byte[] buffer13 = expr_18E;
                Form1.PS3a.GetMemory(5538120u, buffer13);
                byte[] expr_1AC = new byte[4];
                expr_1AC[1] = 96;
                byte[] buffer14 = expr_1AC;
                Form1.PS3a.GetMemory(2948476u, buffer14);
                byte[] expr_1CA = new byte[4];
                expr_1CA[0] = 56;
                expr_1CA[1] = 96;
                byte[] array = expr_1CA;
                Form1.PS3a.GetMemory(111388u, new byte[]
                {
                    127,
                    byte.MaxValue,
                    24,
                    46
                });
                array[0] = 96;
                Form1.PS3a.GetMemory(2948476u, array);
                byte[] array2 = new byte[2];
                byte[] expr_21E = new byte[4];
                expr_21E[0] = 96;
                byte[] buffer15 = expr_21E;
                Form1.PS3a.GetMemory(6797348u, buffer15);
                byte[] buffer16 = new byte[]
                {
                    13
                };
                Form1.PS3a.GetMemory(9319824u, buffer16);
                Form1.PS3a.GetMemory(229356u, new byte[]
                {
                    65,
                    130,
                    8,
                    240
                });
                byte[] buffer17 = new byte[]
                {
                    96
                };
                Form1.PS3a.GetMemory(6797352u, buffer17);
                Form1.PS3a.GetMemory(6797355u, new byte[1]);
                byte[] buffer18 = new byte[]
                {
                    127
                };
                Form1.PS3a.GetMemory(6797362u, buffer18);
                byte[] array5 = new byte[]
                {
                    94,
                    94
                };
                Form1.PS3a.GetMemory(229356u, new byte[]
                {
                    65,
                    130,
                    8,
                    240
                });
                Form1.PS3a.GetMemory(6797348u, new byte[]
                {
                    96,
                    112,
                    96,
                    112,
                    96,
                    112,
                    96,
                    112,
                    128,
                    159,
                    0,
                    0,
                    96,
                    132,
                    0,
                    13
                });
                Form1.PS3a.GetMemory(33556788u, new byte[]
                {
                    94,
                    1,
                    210,
                    221,
                    249
                });
                Form1.PS3a.GetMemory(33557012u, new byte[]
                {
                    94,
                    2,
                    195,
                    32,
                    33
                });
                byte[] expr_35E = new byte[4];
                expr_35E[0] = 96;
                byte[] array3 = expr_35E;
                Form1.PS3a.GetMemory(111388u, array3);
                array3[0] = 96;
                byte[] expr_37 = new byte[4];
                expr_37[0] = 96;
                byte[] buffer19 = expr_37;
                Form1.PS3a.GetMemory(5538120u, buffer19);
                byte[] expr_3A0 = new byte[4];
                expr_3A0[0] = 96;
                byte[] buffer20 = expr_3A0;
                Form1.PS3a.GetMemory(5439732u, buffer20);
                byte[] array6 = new byte[]
                {
                    15
                };
                byte[] array7 = new byte[]
                {
                    217,
                    95,
                    1
                };
                byte[] expr_3DE = new byte[3];
                expr_3DE[0] = 56;
                expr_3DE[1] = 96;
                byte[] buffer21 = expr_3DE;
                Form1.PS3a.GetMemory(2841188u, buffer21);
                Form1.PS3a.GetMemory(2841196u, buffer21);
                Form1.PS3a.GetMemory(2841180u, buffer21);
                byte[] expr_38 = new byte[4];
                expr_38[0] = 56;
                expr_38[1] = 96;
                byte[] buffer22 = expr_38;
                Form1.PS3a.GetMemory(1327440u, buffer22);
                byte[] expr_39 = new byte[4];
                expr_39[0] = 56;
                expr_39[1] = 96;
                byte[] buffer23 = expr_39;
                Form1.PS3a.GetMemory(1327444u, buffer23);
                Form1.PS3a.SetMemory(6797348u, new byte[]
                {
                    144,
                    154,
                    0,
                    0,
                    72,
                    0,
                    0,
                    72,
                    128,
                    159,
                    0,
                    0,
                    48,
                    132
                });
                Form1.PS3a.SetMemory(6797362u, new byte[]
                {
                    94,
                    94
                });
                Form1.PS3a.SetMemory(9319824u, new byte[13]);
                Form1.PS3a.SetMemory(229356u, new byte[]
                {
                    65,
                    130,
                    8,
                    240
                });
                Form1.PS3a.SetMemory(6797352u, new byte[]
                {
                    96
                });
                Form1.PS3a.SetMemory(6797355u, new byte[1]);
                Form1.PS3a.SetMemory(6797362u, new byte[]
                {
                    127
                });
                Form1.PS3a.SetMemory(111388u, new byte[]
                {
                    53,
                    23,
                    53,
                    30
                });
                Form1.PS3a.SetMemory(111388u, new byte[]
                {
                    127,
                    byte.MaxValue,
                    24,
                    46
                });
                byte[] expr_40 = new byte[3];
                expr_40[0] = 16;
                byte[] buffer24 = expr_40;
                Form1.PS3a.SetMemory(2948476u, buffer24);
                Form1.PS3a.SetMemory(6055024u, new byte[]
                {
                    64
                });
                byte[] expr_5A0 = new byte[3];
                expr_5A0[0] = 96;
                byte[] buffer25 = expr_5A0;
                Form1.PS3a.SetMemory(8994565u, buffer25);
                Form1.PS3a.SetMemory(6976232u, new byte[]
                {
                    64
                });
                Form1.PS3a.SetMemory(4595984u, new byte[]
                {
                    96
                });
                Form1.PS3a.SetMemory(6797664u, new byte[]
                {
                    96
                });
                byte[] expr_60C = new byte[4];
                expr_60C[0] = 56;
                expr_60C[1] = 96;
                byte[] buffer26 = expr_60C;
                Form1.PS3a.SetMemory(780200u, buffer26);
                Form1.PS3a.SetMemory(2948476u, new byte[]
                {
                    96
                });
                byte[] expr_41 = new byte[2];
                expr_41[0] = 96;
                byte[] buffer27 = expr_41;
                Form1.PS3a.SetMemory(6797348u, buffer27);
                byte[] expr_42 = new byte[3];
                expr_42[0] = 96;
                byte[] buffer28 = expr_42;
                Form1.PS3a.SetMemory(6797208u, buffer28);
                Form1.PS3a.SetMemory(6797232u, new byte[]
                {
                    60,
                    96,
                    81
                });
                byte[] expr_6A5 = new byte[4];
                expr_6A5[0] = 96;
                byte[] buffer29 = expr_6A5;
                Form1.PS3a.SetMemory(6976224u, buffer29);
                byte[] expr_6C3 = new byte[4];
                expr_6C3[0] = 96;
                byte[] buffer30 = expr_6C3;
                Form1.PS3a.SetMemory(111388u, buffer30);
                Form1.PS3a.SetMemory(24666981u, new byte[]
                {
                    3,
                    69,
                    152
                });
                Form1.PS3a.SetMemory(24667041u, new byte[]
                {
                    3,
                    69,
                    122
                });
                Form1.PS3a.SetMemory(24667585u, new byte[]
                {
                    3,
                    81,
                    206
                });
                byte[] array8 = new byte[]
                {
                    96
                };
                PS3API pS = Form1.PS3a;
                int offset = 6797352;
                byte[] array4 = new byte[]
                {
                    96
                };
                byte[] buffer31 = array4;
                pS.SetMemory((uint)offset, buffer31);
                Form1.PS3a.SetMemory(6797355u, new byte[1]);
                byte[] buffer32 = new byte[]
                {//Yaron YT/Libkuza
                    127
                };
                Form1.PS3a.SetMemory(6797362u, buffer32);
                Form1.PS3a.SetMemory(6797348u, new byte[]
                {
                    144,
                    154,
                    0,
                    0,
                    94,
                    94,
                    94
                });
                Form1.PS3a.CCAPI.SetMemory(6797348u, new byte[]
                {
                    144,
                    154,
                    0,
                    0,
                    94,
                    94,
                    94
                });
                Form1.PS3a.SetMemory(6797362u, new byte[]
                {
                    94,
                    94
                });
                Form1.PS3a.CCAPI.SetMemory(6797362u, new byte[]
                {
                    94,
                    94
                });
                byte[] buffer33 = new byte[]
                {
                    96,
                    0,
                    0,
                    249
                };
                Form1.PS3a.SetMemory(6797348u, buffer33);
                Form1.PS3a.CCAPI.SetMemory(6797348u, buffer33);
                Form1.PS3a.SetMemory(6797348u, new byte[]
                {
                    144,
                    154,
                    0,
                    0,
                    94,
                    94,
                    94
                });
                Form1.PS3a.CCAPI.SetMemory(6797348u, new byte[]
                {
                    144,
                    154,
                    0,
                    0,
                    94,
                    94,
                    94
                });
                Form1.PS3a.SetMemory(6797362u, new byte[]
                {
                    94,
                    94
                });
                Form1.PS3a.CCAPI.SetMemory(6797362u, new byte[]
                {
                    94,
                    94
                });
                byte[] buffer34 = new byte[]
                {
                    96,
                    0,
                    0,
                    249
                };
                Form1.PS3a.SetMemory(6797348u, buffer34);
                Form1.PS3a.CCAPI.SetMemory(6797348u, buffer34);
                Form1.PS3a.SetMemory(6797348u, new byte[]
                {
                    78,
                    128,
                    4,
                    33,
                    72,
                    0,
                    0,
                    72,
                    128,
                    159,
                    0,
                    0,
                    48,
                    132,
                    0,
                    1,
                    144,
                    159
                });
                Form1.PS3a.CCAPI.SetMemory(6797348u, new byte[]
                {
                    78,
                    128,
                    4,
                    33,
                    72,
                    0,
                    0,
                    72,
                    128,
                    159,
                    0,
                    0,
                    48,
                    132,
                    0,
                    1,
                    144,
                    159
                });
                Form1.PS3a.SetMemory(6797348u, new byte[]
                {
                    96,
                    0,
                    0,
                    249,
                    94,
                    94,
                    94,
                    72,
                    128,
                    159,
                    0,
                    0,
                    48,
                    132,
                    0,
                    1,
                    144,
                    159
                });
                Form1.PS3a.CCAPI.SetMemory(6797348u, new byte[]
                {
                    96,
                    0,
                    0,
                    249,
                    94,
                    94,
                    94,
                    72,
                    128,
                    159,
                    0,
                    0,
                    48,
                    132,
                    0,
                    1,
                    144,
                    159
                });
                byte[] buffer35 = new byte[]
                {
                    96,
                    0,
                    0,
                    249
                };
                Form1.PS3a.SetMemory(6797348u, buffer35);
                Form1.PS3a.CCAPI.SetMemory(6797348u, buffer35);
                int num = (int)MessageBox.Show("Anti Freeze is on", "YaronV1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox15.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(14164312u, new byte[1]);
            }
            else
            {
                Form1.PS3a.SetMemory(14164312u, new byte[]
                {
                    1
                });
            }
        }

        private void reaperButton47_Click(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(8036432u, new byte[]
            {
                78,
                128,
                0,
                32
            });
            Form1.PS3a.SetMemory(8036436u, new byte[]
            {
                124,
                8,
                2,
                166,
                248,
                1,
                0,
                128,
                60,
                96,
                16,
                2,
                129,
                131,
                0,
                76,
                44,
                12,
                0,
                0,
                65,
                130,
                0,
                100,
                128,
                131,
                0,
                4,
                128,
                163,
                0,
                8,
                128,
                195,
                0,
                12,
                128,
                227,
                0,
                16,
                129,
                3,
                0,
                20,
                129,
                35,
                0,
                24,
                129,
                67,
                0,
                28,
                129,
                99,
                0,
                32,
                192,
                35,
                0,
                36,
                192,
                67,
                0,
                40,//Yaron YT/Libkuza
                192,
                99,
                0,
                44,
                192,
                131,
                0,
                48,
                192,
                163,
                0,
                52,
                192,
                195,
                0,
                56,
                192,
                227,
                0,
                60,
                193,
                3,
                0,
                64,
                193,
                35,
                0,
                72,
                128,
                99,
                0,
                0,
                125,
                137,
                3,
                166,
                78,
                128,
                4,
                33,
                60,
                128,
                16,
                2,
                56,
                160,
                0,
                0,
                144,
                164,
                0,
                76,
                144,
                100,
                0,
                80,
                232,
                1,
                0,
                128,
                124,
                8,
                3,
                166,
                56,
                33,
                0,
                112,
                78,
                128,
                0,
                32
            });
            Form1.PS3a.SetMemory(268566528u, new byte[10324]);
            Form1.PS3a.SetMemory(8036432u, new byte[]
            {
                248,
                33,
                byte.MaxValue,
                145
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                108,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                50,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                51,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                52,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                53,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                54,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
            Form1.PS3a.SetMemory(268566528u, new byte[4]);
            Form1.PS3a.SetMemory(268574720u, new byte[]
            {
                99,
                109,
                100,
                32,
                115,
                55,
                0
            });
            Form1.PS3a.SetMemory(268566532u, new byte[]
            {
                16,
                2,
                32,
                0
            });
            Form1.PS3a.SetMemory(268566604u, new byte[]
            {
                0,
                49,
                60,
                24
            });
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = !this.checkBox30.Checked;
            if (flag)
            {
                byte[] array = new byte[3];
                array[0] = 6;
                Form1.PS3a.SetMemory(40634115u, array);
            }
            else
            {
                byte[] array2 = new byte[3];
                array2[0] = 4;
                Form1.PS3a.SetMemory(40634115u, array2);
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            int num = (int)MessageBox.Show("Disable Anti Level If you want To Enter The Game", "Info");
            Form1.PS3a.Extension.WriteBytes(16489104u, new byte[]
            {
                149
            });
            int num2 = (int)MessageBox.Show("AntiFreeze Custom [ ON ]", "YaronV1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox37.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(1290047u, new byte[]
                {
                    56
                });
            }
            else
            {
                Form1.PS3a.SetMemory(1290047u, new byte[]
                {
                    228
                });
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(16423905u, new byte[5]);
            Form1.PS3a.SetMemory(16424561u, new byte[5]);
            Form1.PS3a.SetMemory(16424233u, new byte[5]);
            Form1.PS3a.SetMemory(16424889u, new byte[5]);
            Form1.PS3a.SetMemory(16425217u, new byte[5]);
            Form1.PS3a.SetMemory(16423905u, new byte[5]);
            Form1.PS3a.SetMemory(16424561u, new byte[5]);
            Form1.PS3a.SetMemory(16424233u, new byte[5]);
            Form1.PS3a.SetMemory(16424889u, new byte[5]);
            Form1.PS3a.SetMemory(16425217u, new byte[5]);
            Form1.PS3a.SetMemory(16423905u, new byte[5]);
            Form1.PS3a.SetMemory(16424561u, new byte[5]);
            Form1.PS3a.SetMemory(16424233u, new byte[5]);
            Form1.PS3a.SetMemory(16424889u, new byte[5]);
            Form1.PS3a.SetMemory(16425217u, new byte[5]);
        }
        private void method_3()
        {
            throw new NotImplementedException();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.method_3();
            }
            catch
            {
                MessageBox.Show("Use it before you get in game !", "Anti InGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                byte[] array = new byte[4];
                array[0] = 96;
                Form1.PS3a.SetMemory(4173260u, array);
                byte[] array2 = new byte[4];
                array2[0] = 56;
                array2[1] = 96;
                Form1.PS3a.SetMemory(780200u, array2);
                byte[] array3 = new byte[4];
                array3[0] = 60;
                array3[1] = 96;
                Form1.PS3a.SetMemory(4307164u, array3);
                byte[] array4 = new byte[4];
                array4[0] = 60;
                array4[1] = 96;
                Form1.PS3a.SetMemory(4307128u, array4);
                byte[] array5 = new byte[4];
                array5[0] = 60;
                array5[1] = 96;
                Form1.PS3a.SetMemory(7894432u, array5);
                byte[] array6 = new byte[4];
                array6[0] = 56;
                array6[1] = 96;
                Form1.PS3a.SetMemory(4307152u, array6);
                byte[] array7 = new byte[4];
                array7[0] = 60;
                array7[1] = 96;
                Form1.PS3a.SetMemory(7740788u, array7);
                byte[] array8 = new byte[4];
                array8[0] = 60;
                array8[1] = 96;
                Form1.PS3a.SetMemory(7607508u, array8);
                byte[] array9 = new byte[4];
                array9[0] = 60;
                array9[1] = 96;
                Form1.PS3a.SetMemory(7740752u, array9);
                byte[] array10 = new byte[4];
                array10[0] = 60;
                array10[1] = 96;
                Form1.PS3a.SetMemory(7746652u, array10);
                byte[] array11 = new byte[4];
                array11[0] = 56;
                array11[1] = 96;
                Form1.PS3a.SetMemory(7743252u, array11);
                byte[] array12 = new byte[4];
                array12[0] = 60;
                array12[1] = 96;
                Form1.PS3a.SetMemory(7743232u, array12);
                byte[] array13 = new byte[4];
                array13[0] = 60;
                array13[1] = 96;
                Form1.PS3a.SetMemory(7743220u, array13);
                byte[] array14 = new byte[4];
                array14[0] = 60;
                array14[1] = 96;
                Form1.PS3a.SetMemory(7743212u, array14);
                byte[] array15 = new byte[4];
                array15[0] = 60;
                array15[1] = 96;
                Form1.PS3a.SetMemory(7740768u, array15);
                byte[] array16 = new byte[4];
                array16[0] = 56;
                array16[1] = 96;
                Form1.PS3a.SetMemory(7740756u, array16);
                byte[] array17 = new byte[4];
                array17[0] = 56;
                array17[1] = 96;
                Form1.PS3a.SetMemory(7745684u, array17);
                byte[] array18 = new byte[4];
                array18[0] = 56;
                array18[1] = 96;
                Form1.PS3a.SetMemory(7745656u, array18);
                byte[] array19 = new byte[4];
                array19[0] = 96;
                Form1.PS3a.SetMemory(7745700u, array19);
                byte[] array20 = new byte[4];
                array20[0] = 56;
                array20[1] = 96;
                Form1.PS3a.SetMemory(7745632u, array20);
                byte[] array21 = new byte[2];
                array21[0] = 72;
                Form1.PS3a.SetMemory(4046164u, array21);
                byte[] array22 = new byte[2];
                array22[0] = 72;
                Form1.PS3a.SetMemory(5273536u, array22);
                byte[] array23 = new byte[2];
                array23[0] = 72;
                Form1.PS3a.SetMemory(5284768u, array23);
                byte[] array24 = new byte[2];
                array24[0] = 72;
                Form1.PS3a.SetMemory(5289500u, array24);
                byte[] array25 = new byte[2];
                array25[0] = 72;
                Form1.PS3a.SetMemory(5292000u, array25);
                byte[] array26 = new byte[2];//Yaron YT/Libkuza
                array26[0] = 72;
                Form1.PS3a.SetMemory(5295240u, array26);
                byte[] array27 = new byte[2];
                array27[0] = 72;
                Form1.PS3a.SetMemory(5504108u, array27);
                byte[] array28 = new byte[4];
                array28[0] = 96;
                Form1.PS3a.SetMemory(5290612u, array28);
                byte[] array29 = new byte[4];
                array29[0] = 96;
                Form1.PS3a.SetMemory(5537236u, array29);
                byte[] array30 = new byte[4];
                array30[0] = 96;
                Form1.PS3a.SetMemory(5538120u, array30);
                byte[] array31 = new byte[4];
                array31[0] = 56;
                array31[1] = 96;
                byte[] buffer = array31;
                Form1.PS3a.SetMemory(4307152u, buffer);
                Form1.PS3a.SetMemory(111388u, buffer);
                Form1.PS3a.SetMemory(7746652u, buffer);
                Form1.PS3a.SetMemory(7894432u, buffer);
                Form1.PS3a.SetMemory(4307128u, buffer);
                Form1.PS3a.SetMemory(4307164u, buffer);
                Form1.PS3a.SetMemory(7894432u, buffer);
                Form1.PS3a.SetMemory(4307152u, buffer);
                Form1.PS3a.SetMemory(7740788u, buffer);
                Form1.PS3a.SetMemory(7740768u, buffer);
                Form1.PS3a.SetMemory(7740756u, buffer);
                Form1.PS3a.SetMemory(7607508u, buffer);
                Form1.PS3a.SetMemory(7743252u, buffer);
                Form1.PS3a.SetMemory(7743220u, buffer);
                Form1.PS3a.SetMemory(762714u, buffer);
                Form1.PS3a.SetMemory(7743232u, buffer);
                Form1.PS3a.SetMemory(7743176u, buffer);
                Form1.PS3a.SetMemory(3397704u, buffer);
                Form1.PS3a.SetMemory(4301148u, buffer);
                Form1.PS3a.SetMemory(4301156u, buffer);
                Form1.PS3a.SetMemory(4301252u, buffer);
                Form1.PS3a.SetMemory(4301272u, buffer);
                Form1.PS3a.SetMemory(4301288u, buffer);
                Form1.PS3a.SetMemory(4301312u, buffer);
                Form1.PS3a.SetMemory(4301332u, buffer);
                Form1.PS3a.SetMemory(4301356u, buffer);
                Form1.PS3a.SetMemory(4301380u, buffer);
                Form1.PS3a.SetMemory(4301432u, buffer);
                Form1.PS3a.SetMemory(4301436u, buffer);
                Form1.PS3a.SetMemory(4301828u, buffer);
                Form1.PS3a.SetMemory(4301960u, buffer);
                byte[] buffer2 = new byte[]
                {
                    47,
                    131,
                    72,
                    0
                };
                Form1.PS3a.SetMemory(7740752u, buffer2);
                Form1.PS3a.SetMemory(3341524u, buffer2);
                Form1.PS3a.SetMemory(7743212u, buffer2);
                byte[] array32 = new byte[4];
                array32[0] = 96;
                byte[] buffer3 = array32;
                Form1.PS3a.SetMemory(4599916u, buffer3);
                Form1.PS3a.SetMemory(762700u, buffer3);
                Form1.PS3a.SetMemory(2948476u, new byte[]
                {
                    96
                });
                byte[] array33 = new byte[2];
                array33[0] = 96;
                Form1.PS3a.SetMemory(6797348u, array33);
                byte[] array34 = new byte[3];
                array34[0] = 96;
                Form1.PS3a.SetMemory(6797208u, array34);
                Form1.PS3a.SetMemory(6797232u, new byte[]
                {
                    60,
                    96,
                    81
                });
                byte[] array35 = new byte[4];
                array35[0] = 56;
                array35[1] = 96;
                byte[] array36 = new byte[4];
                array36[0] = 56;
                array36[1] = 96;
                byte[] array37 = new byte[4];
                array37[0] = 56;
                array37[1] = 96;
                Form1.PS3a.SetMemory(111388u, array37);
                Form1.PS3a.SetMemory(24666981u, new byte[]
                {
                    3,
                    69,
                    152
                });
                Form1.PS3a.SetMemory(24667041u, new byte[]
                {
                    3,
                    69,
                    122
                });
                Form1.PS3a.SetMemory(24667585u, new byte[]
                {
                    3,
                    81,
                    206
                });
                Form1.PS3a.SetMemory(6797352u, new byte[]
                {
                    96
                });
                Form1.PS3a.SetMemory(6797355u, new byte[1]);
                Form1.PS3a.SetMemory(6797362u, new byte[]
                {
                    127
                });
                Form1.PS3a.SetMemory(9347820u, new byte[]
                {
                    55,
                    105,
                    0,
                    0,
                    146
                });
                byte[] array38 = new byte[4];
                array38[0] = 96;
                Form1.PS3a.SetMemory(1327440u, array38);
                byte[] array39 = new byte[4];
                array39[0] = 60;
                array39[1] = 96;
                Form1.PS3a.SetMemory(1115588u, array39);
                byte[] array40 = new byte[4];
                array40[0] = 60;
                array40[1] = 96;
                Form1.PS3a.SetMemory(780200u, array40);
                byte[] array41 = new byte[4];
                array41[0] = 60;
                array41[1] = 96;
                Form1.PS3a.SetMemory(779932u, array41);
                byte[] array42 = new byte[4];
                array42[0] = 60;
                array42[1] = 96;
                Form1.PS3a.SetMemory(6976232u, array42);
                byte[] array43 = new byte[4];
                array43[0] = 56;
                array43[1] = 96;
                Form1.PS3a.SetMemory(6976224u, array43);
                Form1.PS3a.SetMemory(6305492u, new byte[]
                {
                    51
                });
                Thread.Sleep(20);
                Form1.PS3a.SetMemory(6305492u, new byte[]
                {
                    147
                });
                byte[] array44 = new byte[4];
                array44[0] = 56;
                array44[1] = 96;
                byte[] buffer4 = array44;
                Form1.PS3a.SetMemory(4307152u, buffer4);
                Form1.PS3a.SetMemory(111388u, buffer4);
                Form1.PS3a.SetMemory(7746652u, buffer4);
                Form1.PS3a.SetMemory(7894432u, buffer4);
                Form1.PS3a.SetMemory(4307128u, buffer4);
                Form1.PS3a.SetMemory(4307164u, buffer4);
                Form1.PS3a.SetMemory(7894432u, buffer4);
                Form1.PS3a.SetMemory(4307152u, buffer4);
                Form1.PS3a.SetMemory(7740788u, buffer4);
                Form1.PS3a.SetMemory(7740768u, buffer4);
                Form1.PS3a.SetMemory(7740756u, buffer4);
                Form1.PS3a.SetMemory(7607508u, buffer4);
                Form1.PS3a.SetMemory(7743252u, buffer4);
                Form1.PS3a.SetMemory(7743220u, buffer4);
                Form1.PS3a.SetMemory(762714u, buffer4);
                Form1.PS3a.SetMemory(7743232u, buffer4);
                Form1.PS3a.SetMemory(7743176u, buffer4);
                Form1.PS3a.SetMemory(3397704u, buffer4);
                Form1.PS3a.SetMemory(4301148u, buffer4);
                Form1.PS3a.SetMemory(4301156u, buffer4);
                Form1.PS3a.SetMemory(4301252u, buffer4);
                Form1.PS3a.SetMemory(4301272u, buffer4);
                Form1.PS3a.SetMemory(4301288u, buffer4);
                Form1.PS3a.SetMemory(4301312u, buffer4);
                Form1.PS3a.SetMemory(4301332u, buffer4);
                Form1.PS3a.SetMemory(4301356u, buffer4);
                Form1.PS3a.SetMemory(4301380u, buffer4);
                Form1.PS3a.SetMemory(4301432u, buffer4);
                Form1.PS3a.SetMemory(4301436u, buffer4);
                Form1.PS3a.SetMemory(4301828u, buffer4);
                Form1.PS3a.SetMemory(4301960u, buffer4);
                byte[] buffer5 = new byte[]
                {
                    47,
                    131,
                    72,
                    0
                };
                Form1.PS3a.SetMemory(7740752u, buffer5);
                Form1.PS3a.SetMemory(3341524u, buffer5);
                Form1.PS3a.SetMemory(7743212u, buffer5);
                byte[] array45 = new byte[4];
                array45[0] = 96;
                byte[] buffer6 = array45;
                Form1.PS3a.SetMemory(4599916u, buffer6);
                Form1.PS3a.SetMemory(762700u, buffer6);
                Form1.PS3a.SetMemory(2948476u, new byte[]
                {
                    96
                });
                byte[] array46 = new byte[4];
                array46[0] = 56;
                array46[1] = 96;
                byte[] array47 = new byte[4];
                array47[0] = 56;
                array47[1] = 96;
                byte[] array48 = new byte[4];
                array48[0] = 56;
                array48[1] = 96;
                byte[] buffer7 = array48;
                Form1.PS3a.SetMemory(111388u, buffer7);
                Form1.PS3a.SetMemory(24666981u, new byte[]
                {
                    3,
                    69,
                    152
                });
                Form1.PS3a.SetMemory(24667041u, new byte[]
                {
                    3,
                    69,
                    122
                });
                Form1.PS3a.SetMemory(24667585u, new byte[]
                {
                    3,
                    81,
                    206
                });
                byte[] array49 = new byte[4];
                array49[0] = 96;
                byte[] buffer8 = array49;
                Form1.PS3a.SetMemory(1115588u, buffer8);
                byte[] array50 = new byte[4];
                array50[0] = 60;
                array50[1] = 96;
                byte[] buffer9 = array50;
                Form1.PS3a.SetMemory(780200u, buffer9);
                byte[] array51 = new byte[4];
                array51[0] = 60;
                array51[1] = 96;
                byte[] buffer10 = array51;
                Form1.PS3a.SetMemory(779932u, buffer10);
                byte[] array52 = new byte[4];
                array52[0] = 60;
                array52[1] = 96;
                byte[] buffer11 = array52;
                Form1.PS3a.SetMemory(6976232u, buffer11);
                byte[] array53 = new byte[4];
                array53[0] = 56;
                array53[1] = 96;
                byte[] buffer12 = array53;
                Form1.PS3a.SetMemory(6976224u, buffer12);
                byte[] array54 = new byte[4];
                array54[0] = 60;
                array54[1] = 96;
                byte[] buffer13 = array54;
                Form1.PS3a.SetMemory(6301728u, buffer13);
                byte[] array55 = new byte[4];
                array55[0] = 60;
                array55[1] = 96;
                byte[] buffer14 = array55;
                Form1.PS3a.SetMemory(6301756u, buffer14);
                Form1.PS3a.SetMemory(6301756u, buffer14);
            }
        }
        //Yaron YT/Libkuza
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            PS3API ps = Form1.PS3a;
            uint offset = 2948476u;
            byte[] array = new byte[3];
            array[0] = 96;
            ps.SetMemory(offset, array);
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            Form1.PS3a.SetMemory(9319824u, new byte[13]);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            byte[] buffer = new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            };
            Form1.PS3a.SetMemory(24646768u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(24646776u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(24645416u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(9319824u, buffer);
            Form1.PS3a.SetMemory(9319824u, buffer);
            byte[] buffer2 = new byte[]
            {
                65,
                130,
                8,
                240
            };
            Form1.PS3a.SetMemory(229356u, buffer2);
            Form1.PS3a.SetMemory(229356u, buffer2);
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                96,
                112,
                96,
                112,
                96,
                112,
                96,
                112,
                128,
                159,
                0,
                0,
                96,
                132,
                0,
                13
            });
            PS3API ps2 = Form1.PS3a;
            uint offset2 = 111388u;
            array = new byte[4];
            array[0] = 96;
            ps2.SetMemory(offset2, array);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = new byte[3];
            array[0] = 96;
            Form1.PS3a.SetMemory(2948476u, array);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            byte[] array = new byte[]
            {
                96,
                0,
                0,
                249
            };
            Form1.PS3a.SetMemory(111388u, array);
            Form1.PS3a.SetMemory(6797348u, array);
            Form1.PS3a.CCAPI.SetMemory(6797348u, array);
            PS3API ps = Form1.PS3a;
            uint offset = 6976224u;
            byte[] array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            ps.SetMemory(offset, array2);
            PS3API ps2 = Form1.PS3a;
            uint offset2 = 6258260u;
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            ps2.SetMemory(offset2, array2);
            PS3API ps3 = Form1.PS3a;
            uint offset3 = 4046164u;
            array2 = new byte[2];
            array2[0] = 72;
            ps3.SetMemory(offset3, array2);
            PS3API ps4 = Form1.PS3a;
            uint offset4 = 5273536u;
            array2 = new byte[2];
            array2[0] = 72;
            ps4.SetMemory(offset4, array2);
            PS3API ps5 = Form1.PS3a;
            uint offset5 = 5284768u;
            array2 = new byte[2];
            array2[0] = 72;
            ps5.SetMemory(offset5, array2);
            PS3API ps6 = Form1.PS3a;
            uint offset6 = 5289500u;
            array2 = new byte[2];
            array2[0] = 72;
            ps6.SetMemory(offset6, array2);
            PS3API ps7 = Form1.PS3a;
            uint offset7 = 5292000u;
            array2 = new byte[2];
            array2[0] = 72;
            ps7.SetMemory(offset7, array2);
            PS3API ps8 = Form1.PS3a;
            uint offset8 = 5295240u;
            array2 = new byte[2];
            array2[0] = 72;
            ps8.SetMemory(offset8, array2);
            PS3API ps9 = Form1.PS3a;
            uint offset9 = 5504108u;
            array2 = new byte[2];
            array2[0] = 72;
            ps9.SetMemory(offset9, array2);
            PS3API ps10 = Form1.PS3a;
            uint offset10 = 5290612u;
            array2 = new byte[4];
            array2[0] = 96;
            ps10.SetMemory(offset10, array2);
            PS3API ps11 = Form1.PS3a;
            uint offset11 = 5537236u;
            array2 = new byte[4];
            array2[0] = 96;
            ps11.SetMemory(offset11, array2);
            PS3API ps12 = Form1.PS3a;
            uint offset12 = 5538120u;
            array2 = new byte[4];
            array2[0] = 96;
            ps12.SetMemory(offset12, array2);
            array2 = new byte[4];
            array2[0] = 56;
            array2[1] = 96;
            byte[] array3 = array2;
            Form1.PS3a.SetMemory(2948476u, array3);
            array[0] = 96;
            Form1.PS3a.SetMemory(6797348u, array);
            Form1.PS3a.SetMemory(111388u, new byte[]
            {
                53,
                23,
                53,
                30
            });
            array3[0] = 96;
            Form1.PS3a.SetMemory(2948476u, array3);
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            Form1.PS3a.SetMemory(9319824u, new byte[13]);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            MessageBox.Show(" Sxny AntiFreeze #~~ ", "OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = ((CheckBox)sender).Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(1290040u, new byte[]
                {
                    56,
                    96,
                    0,
                    54
                });
                Form1.PS3a.SetMemory(5416688u, new byte[]
                {
                    56,
                    96,
                    0,
                    byte.MaxValue
                });
                Form1.PS3a.SetMemory(1290040u, new byte[]
                {
                    56,
                    96,
                    0,
                    119
                });
            }
            else
            {
                Form1.PS3a.SetMemory(1290040u, new byte[]
                {
                    72,
                    64,
                    100,
                    145
                });
                Form1.PS3a.SetMemory(5416688u, new byte[]
                {
                    72,
                    1,
                    108,
                    217
                });
                Form1.PS3a.SetMemory(1290040u, new byte[]
                {
                    56,
                    96,
                    0,//Yaron YT/Libkuza
                    119
                });
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox22.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(9482500u, new byte[2]);
            }
            else
            {
                Form1.PS3a.SetMemory(9482500u, new byte[]
                {
                    115
                });
            }
        }
        private bool state;
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(9482500u, new byte[2]);
            PS3API ps = Form1.PS3a;
            uint offset = 7076696u;
            byte[] array = new byte[2];
            array[0] = 72;
            ps.SetMemory(offset, array);
            Form1.PS3a.SetMemory(7895024u, new byte[]
            {
                78,
                128,
                0,
                32
            });
            PS3API ps2 = Form1.PS3a;
            uint offset2 = 212064u;
            array = new byte[4];
            array[0] = 96;
            ps2.SetMemory(offset2, array);
            PS3API ps3 = Form1.PS3a;
            uint offset3 = 5456560u;
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            ps3.SetMemory(offset3, array);
            PS3API ps4 = Form1.PS3a;
            uint offset4 = 1023572u;
            array = new byte[4];
            array[0] = 96;
            ps4.SetMemory(offset4, array);
            Form1.PS3a.SetMemory(492512u, new byte[]
            {
                56,
                96,
                0,
                1
            });
            PS3API ps5 = Form1.PS3a;
            uint offset5 = 493060u;
            array = new byte[4];
            array[0] = 96;
            ps5.SetMemory(offset5, array);
            PS3API ps6 = Form1.PS3a;
            uint offset6 = 4595788u;
            array = new byte[4];
            array[0] = 96;
            ps6.SetMemory(offset6, array);
            PS3API ps7 = Form1.PS3a;
            uint offset7 = 6380444u;
            array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            ps7.SetMemory(offset7, array);
            PS3API ps8 = Form1.PS3a;
            uint offset8 = 5462508u;
            array = new byte[4];
            array[0] = 96;
            ps8.SetMemory(offset8, array);
            Form1.PS3a.SetMemory(5401400u, new byte[]
            {
                78,
                128,
                0,
                32
            });
            Form1.PS3a.SetMemory(9055052u, new byte[]
            {
                160,
                129,
                0,
                166
            });
            Form1.PS3a.SetMemory(53743076u, new byte[]
            {
                56,
                96,
                0,
                1
            });
            PS3API ps9 = Form1.PS3a;
            uint offset9 = 2948476u;
            array = new byte[4];
            array[0] = 96;
            ps9.SetMemory(offset9, array);
            PS3API ps10 = Form1.PS3a;
            uint offset10 = 778216u;
            array = new byte[2];
            array[0] = 72;
            ps10.SetMemory(offset10, array);
            bool flag = this.state;
            if (flag)
            {
                PS3API ps11 = Form1.PS3a;
                uint offset11 = 6239624u;
                array = new byte[2];
                array[0] = 72;
                ps11.SetMemory(offset11, array);
                PS3API ps12 = Form1.PS3a;
                uint offset12 = 6239664u;
                array = new byte[2];
                array[0] = 72;
                ps12.SetMemory(offset12, array);
                PS3API ps13 = Form1.PS3a;
                uint offset13 = 6239704u;
                array = new byte[2];
                array[0] = 72;
                ps13.SetMemory(offset13, array);
                Form1.PS3a.SetMemory(6334100u, new byte[]
                {
                    56,
                    96,
                    0,
                    0,
                    144,
                    100,
                    0,
                    0,
                    144,
                    100,
                    0,
                    4,
                    144,
                    100,
                    0,
                    8,
                    78,
                    128,
                    0,
                    32
                });
            }
            else
            {
                Form1.PS3a.SetMemory(6239624u, new byte[]
                {
                    65,
                    130
                });
                Form1.PS3a.SetMemory(6239664u, new byte[]
                {
                    65,
                    130
                });
                Form1.PS3a.SetMemory(6239704u, new byte[]
                {
                    65,
                    130
                });
                Form1.PS3a.SetMemory(6334100u, new byte[]
                {
                    248,
                    33,
                    byte.MaxValue,
                    129,
                    124,
                    8,
                    2,
                    166,
                    248,
                    1,
                    0,
                    144,
                    251,
                    193,
                    0,
                    112,
                    251,
                    225,
                    0,
                    120
                });
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                96
            });
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                72,
                0,
                0,
                72,
                128,
                159,
                0,
                0,
                48,
                132
            });
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            Form1.PS3a.SetMemory(9319824u, new byte[13]);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            Form1.PS3a.SetMemory(6797352u, new byte[]
            {
                96
            });
            Form1.PS3a.SetMemory(6797355u, new byte[1]);
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                127
            });
            PS3API ps = Form1.PS3a;
            uint offset = 2948476u;
            byte[] array = new byte[3];
            array[0] = 96;
            ps.SetMemory(offset, array);
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                94,
                94,
                94
            });
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            Form1.PS3a.SetMemory(9319824u, new byte[13]);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            byte[] buffer = new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            };
            Form1.PS3a.SetMemory(24646768u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(24646776u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(24645416u, new byte[]
            {
                37,
                105,
                102,
                112,
                115,
                32,
                47,
                32,
                37,
                48,
                50,
                105,
                109,
                115,
                40,
                115,
                118,
                41,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Form1.PS3a.SetMemory(9319824u, buffer);
            Form1.PS3a.SetMemory(9319824u, buffer);
            byte[] buffer2 = new byte[]
            {
                65,
                130,
                8,
                240
            };
            Form1.PS3a.SetMemory(229356u, buffer2);
            Form1.PS3a.SetMemory(229356u, buffer2);
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                96,
                112,
                96,
                112,
                96,
                112,
                96,
                112,
                128,
                159,
                0,
                0,
                96,
                132,
                0,
                13
            });
            array = new byte[4];
            array[0] = 96;
            byte[] buffer3 = array;
            Form1.PS3a.SetMemory(111388u, buffer3);
            Form1.PS3a.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            Form1.PS3a.SetMemory(9319824u, buffer3);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            Form1.PS3a.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,//Yaron YT/Libkuza
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            Form1.PS3a.SetMemory(9319824u, buffer);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            Form1.PS3a.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            Form1.PS3a.SetMemory(9319824u, buffer2);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            Form1.PS3a.SetMemory(6797152u, new byte[]
            {
                147,
                254,
                0,
                0,
                56,
                96,
                0,
                96,
                72,
                0,
                1,
                8,
                44,
                5,
                0,
                72,
                65,
                130,
                0,
                12,
                44,
                5,
                0,
                73,
                64,
                130,
                0,
                180,
                139,
                57,
                0,
                3,
                50,
                225,
                0,
                128,
                48,
                131,
                0,
                5,
                127,
                57,
                7,
                116,
                98,
                227,
                0,
                0,
                120,
                132,
                0,
                32,
                123,
                37,
                0,
                32,
                96,
                0,
                0,
                0,
                124,
                97,
                200,
                20,
                58,
                192,
                0,
                0,
                120,
                103,
                0,
                32,
                56,
                128,
                0,
                7,
                56,
                160,
                0,
                1,
                98,
                227,
                0,
                0,
                56,
                192,
                byte.MaxValue,
                byte.MaxValue,
                154,
                199,
                0,
                128,
                72,
                14,
                122,
                101,
                128,
                191,
                0,
                0,
                98,
                196,
                0,
                0,
                120,
                166,
                0,
                32,
                44,
                132,
                0,
                3,
                136,
                198,
                0,
                0,
                44,
                6,
                0,
                94,
                76,
                66,
                35,
                66,
                65,
                130,
                0,
                32,
                124,
                216,
                33,
                174,
                48,
                228,
                0,
                1,
                128,
                191,
                0,
                0,
                124,
                228,
                7,
                180,
                48,
                165,
                0,
                1,
                144,
                191,
                0,
                0,
                75,
                byte.MaxValue,
                byte.MaxValue,
                208,
                48,
                217,
                96,
                0,
                56,
                224,
                0,
                0,
                124,
                165,
                48,
                20,
                44,
                27,
                0,
                0,
                144,
                191,
                0,
                0,
                124,
                248,
                33,
                174,
                65,
                130,
                0,
                24,
                96,
                100,
                0,
                0,
                147,
                27,
                0,
                0,
                56,
                96,
                0,
                1,
                96,
                0,
                0,
                0,
                96,
                0,
                0,
                0,
                128,
                159,
                0,
                0,
                48,
                132,
                96,
                0,
                144,
                159,
                0,
                0,
                72,
                0,
                0,
                36,
                99,
                227,
                0,
                0
            });
            Form1.PS3a.SetMemory(6797348u, new byte[]
            {
                144,
                154,
                0,
                0,
                72,
                0,
                0,
                72,
                128,
                159,
                0,
                0,
                48,
                132
            });
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                94,
                94
            });
            Form1.PS3a.SetMemory(9319824u, new byte[13]);
            Form1.PS3a.SetMemory(229356u, new byte[]
            {
                65,
                130,
                8,
                240
            });
            Form1.PS3a.SetMemory(6797352u, new byte[]
            {
                96
            });
            Form1.PS3a.SetMemory(6797355u, new byte[1]);
            Form1.PS3a.SetMemory(6797362u, new byte[]
            {
                127
            });
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox13.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(5381176u, new byte[]
                {
                    56
                });//Yaron YT/Libkuza
                byte[] expr_30 = new byte[4];
                expr_30[0] = 56;
                expr_30[1] = 96;
                byte[] buffer = expr_30;
                Form1.PS3a.SetMemory(5454192u, buffer);
                Form1.PS3a.SetMemory(5454204u, buffer);
                Form1.PS3a.SetMemory(5454216u, buffer);
                Form1.PS3a.SetMemory(5454152u, buffer);
                Form1.PS3a.SetMemory(5454108u, buffer);
                Form1.PS3a.SetMemory(5454156u, buffer);
                Form1.PS3a.SetMemory(5454216u, buffer);
            }
            else
            {
                Form1.PS3a.SetMemory(5381176u, new byte[]
                {
                    136
                });
            }
        }
        //Yaron YT/Libkuza
        private void reaperButton48_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            PS3API pS3 = Form1.PS3a;
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                250,
                250,
                250
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                byte.MaxValue,
                byte.MaxValue,
                249
            });
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
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
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                245
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                245
            });
            pS3.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                153,
                153,
                247
            });
            pS3.Extension.WriteString(40633944u, "{ Yaron }");
            pS3.Extension.WriteString(40633944u, this.Text);
            pS3.SetMemory(40927800u, new byte[6]);
        }
        private string userName;
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox6.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    72,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    72,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    72,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    72,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40927800u, new byte[6]);
            }
            bool flag = !this.checkBox6.Checked;
            if (flag)
            {
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox5.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox11.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    32,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    28,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    19,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    28,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    19,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    74,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    96,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    112,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    127,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    120,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    48,
                    120,
                    byte.MaxValue,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    48,
                    120,
                    byte.MaxValue,
                    249
                });
            }
            bool flag = !this.checkBox11.Checked;
            if (flag)
            {
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(Form1.PS3a.Extension.ReadString(30233528u));
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                17,
                15
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                2,
                18,
                31
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                3,
                19,
                47
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                4,
                20,
                63
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                5,
                21,
                79
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                6,
                22,
                95
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                7,
                23,
                111
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                8,
                24,
                127
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                9,
                25,
                143
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                0,
                16,
                159
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                10,
                26,
                175
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                17,
                15
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,//Yaron YT/Libkuza
                73,
                2,
                18,
                31
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                3,
                19,
                47
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                4,
                20,
                63
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                5,
                21,
                79
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                6,
                22,
                95
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                1,
                49,
                79
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                8,
                24,
                127
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                9,
                25,
                143
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                0,
                16,
                159
            });
            Form1.PS3a.SetMemory(40633944u, new byte[]
            {
                94,
                73,
                10,
                26,
                175
            });
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            Form1.PS3a.SetMemory(40633944u, bytes);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox20.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox16.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(31112u, new byte[]
                {
                    168,
                    10,
                    125,
                    9
                });
                Form1.PS3a.SetMemory(631080u, new byte[]
                {
                    72,
                    28,
                    110,
                    25
                });
                Form1.PS3a.SetMemory(13414229u, new byte[]
                {
                    85,
                    102,
                    102,
                    17
                });
                Form1.PS3a.SetMemory(787u, new byte[]
                {
                    247,
                    166,
                    175,
                    247,
                    byte.MaxValue,
                    134,
                    161,
                    34
                });
                Form1.PS3a.SetMemory(142529u, new byte[]
                {
                    byte.MaxValue,
                    168,
                    34,
                    250,
                    169
                });
                Form1.PS3a.SetMemory(105056u, new byte[]
                {
                    59,
                    128,
                    0,
                    0,
                    75,
                    243,
                    byte.MaxValue,
                    244
                });
            }
            bool flag = !this.checkBox16.Checked;
            if (flag)
            {
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox3.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    153,
                    153,
                    153
                });
            }
            bool flag = !this.checkBox3.Checked;
            if (flag)
            {
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox8.Checked;
            if (@checked)
            {
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    32,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    16,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    28,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    19,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    28,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    76,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    16,
                    19,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    74,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    96,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    112,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    127,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    32,
                    120,
                    96,
                    249
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    48,
                    120,
                    byte.MaxValue,
                    249//Yaron YT/Libkuza
                });
                Form1.PS3a.SetMemory(40633944u, new byte[]
                {
                    94,
                    73,
                    48,
                    120,
                    byte.MaxValue,
                    249
                });
            }
            bool flag = !this.checkBox4.Checked;
            if (flag)
            {
                Form1.PS3a.Extension.WriteString(40633944u, this.userName);
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(1290040u, new byte[]
            {
                72,
                64,
                100,
                145
            });
            Form1.PS3a.SetMemory(5416688u, new byte[]
            {
                72,
                1,
                108,
                217
            });
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            Form1.PS3a.SetMemory(40633983u, new byte[]
            {
                94,
                66,
                226,
                132,
                162,
                229,
                132,
                162,
                226,
                137,
                162,
                163,
                80,
                169
            });
            Form1.PS3a.SetMemory(40927800u, new byte[]
            {
                128,
                87,
                210,
                20
            });
            Form1.PS3a.SetMemory(40633983u, new byte[]
            {
                94,
                66,
                226,
                132,
                162,
                229,
                132,
                162,
                226,
                137,
                162,
                163,
                80,
                169
            });
            Form1.PS3a.SetMemory(40927800u, new byte[]
            {
                128,
                87,
                210,
                20
            });
            Form1.PS3a.SetMemory(40633983u, new byte[]
            {
                94,
                72,
                32,
                224,
                250
            });
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The Host of the Party cant Kick you any more\nIf he try to Kick you, his PS3 Freeze", "YaronV1");
            Form1.PS3a.SetMemory(1290040u, new byte[]
            {
                56,
                96,
                0,
                54
            });
            Form1.PS3a.SetMemory(5416688u, new byte[]
            {
                56,
                96,
                0,
                byte.MaxValue
            });
        }

        private void reaperButton48_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void reaperCheckBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            bool @checked = this.checkBox5.Checked;
            if (@checked)
            {
                Form2.PS3.Extension.WriteBytes(212148u, new byte[]
                {
                    44,
                    3,
                    0,
                    1
                });//Yaron YT/Libkuza
            }
            else
            {
                Form2.PS3.Extension.WriteBytes(212148u, new byte[]
                {
                    44,
                    3,
                    0,
                    1
                });
            }
        }

        private void reaperCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox10.Checked;
            if (@checked)//Yaron YT/Libkuza
            {
                Form1.PS3a.SetMemory(8683472u, new byte[]
                {
                    160,
                    9,
                    19,
                    0
                });
            }
            else
            {
                PS3API ps = Form1.PS3a;
                uint offset = 8683472u;
                byte[] array = new byte[4];
                array[0] = 160;
                array[1] = 9;
                ps.SetMemory(offset, array);
            }//Yaron YT/Libkuza
        }

        private void reaperButton49_Click(object sender, EventArgs e)
        {
            
            
        }

        private void reaperButton53_Click(object sender, EventArgs e)
        {
           
        }

        private void reaperButton52_Click(object sender, EventArgs e)
        {
            //Yaron YT/Libkuza
        }

        private void reaperButton53_Click_1(object sender, EventArgs e)
        {
            FOV80.Start();
            FOV90.Stop();
            FOV100.Stop();
            
            
        }

        private void reaperGroupBox5_Enter(object sender, EventArgs e)
        {
            
        }
        //Yaron YT/Libkuza
        private void reaperButton52_Click_1(object sender, EventArgs e)
        {
            FOV80.Stop();
            FOV90.Start();
            FOV100.Stop();
        }

        private void reaperButton54_Click(object sender, EventArgs e)
        {
            FOV80.Stop();
            FOV90.Stop();
            FOV100.Start();
        }
        //Yaron YT/Libkuza
        private void timer2_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            RPC.Call(3226648u, new object[] { 0, "cg_fov 80" });
        }

        private void reaperButton49_Click_1(object sender, EventArgs e)
        {
            RPC.Call(3226648u, new object[] { 0, "cg_fov 65" });
            FOV80.Stop();
            FOV90.Stop();
            FOV100.Stop();
        }

        private void FOV90_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            RPC.Call(3226648u, new object[] { 0, "cg_fov 90" });//Yaron YT/Libkuza
        }

        private void FOV100_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            RPC.Call(3226648u, new object[] { 0, "cg_fov 100" });
        }

        private void reaperButton55_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 0;statsetbyname PLEVEL 0;statsetbyname RANK 0;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }
        //Yaron YT/Libkuza
        private void reaperButton56_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 999999;statsetbyname PLEVEL 10;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }

        private void reaperButton57_Click_1(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_nuketown_2020;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }
        //Yaron YT/Libkuza
        private void reaperButton58_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_slums;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }

        private void reaperButton59_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }

        private void reaperButton60_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_raid;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }

        private void reaperButton61_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_village;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(1000);
            RPC.Call(0x313C18, 0, "disconnect\n");
        }//Yaron YT/Libkuza
        private void reaperButton76_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 999999;statsetbyname PLEVEL 15;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du den Call ge-voted hast!
        }

        private void reaperButton74_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 999999;statsetbyname PLEVEL 14;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du den Call ge-voted hast!
        }

        private void reaperButton72_Click(object sender, EventArgs e)//Yaron YT/Libkuza
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 999999;statsetbyname PLEVEL 13;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); 
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); 
        }

        private void reaperButton75_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 999999;statsetbyname PLEVEL 12;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du
        }

        private void reaperButton73_Click(object sender, EventArgs e)//Yaron YT/Libkuza
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 11;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach d
        }

        private void reaperButton67_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 10;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du den Call ge-voted hast!
        }//Yaron YT/Libkuza

        private void reaperButton62_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 9;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du den Call ge-voted hast!
        }

        private void reaperButton68_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 8;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach dem du den Call ge-
        }
        //Yaron YT/Libkuza
        private void reaperButton63_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 7;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disc
        }

        private void reaperButton69_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 6;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disc
        }//Yaron YT/Libkuza

        private void reaperButton64_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 5;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //
        }

        private void reaperButton70_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 4;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disc
        }
        //Yaron YT/Libkuza
        private void reaperButton65_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 3;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect nach de
        }

        private void reaperButton71_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 2;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disconnect 
        }

        private void reaperButton66_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"mp_hijacked;statsetbyname RANKXP 9999999;statsetbyname PLEVEL 1;statsetbyname RANK 1;\"";
            RPC.Call(0x124C80, 0, DRNKDBO2.Replace(';', '\x0D')); //CL_AddReliableCommand
            Thread.Sleep(400);
            RPC.Call(0x313C18, 0, "disconnect\n"); //Disco
        }
        //Yaron YT/Libkuza
        private void reaperButton77_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(40925376U, new byte[2] { (byte)80, (byte)1 });
            PS3.SetMemory(40925390U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40925428U, new byte[2] { (byte)0, (byte)21 });
            PS3.SetMemory(40925442U, new byte[2] { (byte)128, (byte)10 });
            PS3.SetMemory(40925481U, new byte[2] { (byte)80, (byte)1 });
            PS3.SetMemory(40925495U, new byte[2] { (byte)168, (byte)0 });//Yaron YT/Libkuza
            PS3.SetMemory(40925533U, new byte[2] { (byte)0, (byte)21 });
            PS3.SetMemory(40925547U, new byte[2] { (byte)128, (byte)10 });
            PS3.SetMemory(40925586U, new byte[2] { (byte)80, (byte)1 });
            PS3.SetMemory(40925600U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40925638U, new byte[2] { (byte)0, (byte)21 });
            PS3.SetMemory(40925652U, new byte[2] { (byte)128, (byte)10 });
            PS3.SetMemory(40925691U, new byte[2] { (byte)80, (byte)1 });
            PS3.SetMemory(40925705U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40925743U, new byte[2] { (byte)0, (byte)21 });
            PS3.SetMemory(40925757U, new byte[2] { (byte)128, (byte)10 });
            PS3.SetMemory(40925796U, new byte[2] { (byte)80, (byte)1 });
            PS3.SetMemory(40925810U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40925848U, new byte[2] { (byte)0, (byte)21 });
            PS3.SetMemory(40925862U, new byte[2] { (byte)128, (byte)10 });
        }
        //Yaron YT/Libkuza
        private void reaperButton78_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(40926068U, new byte[2] { (byte)159, (byte)10 });
            PS3.SetMemory(40926082U, new byte[2] { (byte)79, (byte)5 });
            PS3.SetMemory(40926121U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40926135U, new byte[2] { (byte)84, (byte)0 });
            PS3.SetMemory(40926173U, new byte[2] { (byte)159, (byte)10 });
            PS3.SetMemory(40926187U, new byte[2] { (byte)79, (byte)5 });
            PS3.SetMemory(40926226U, new byte[2] { (byte)168, (byte)0 });
            PS3.SetMemory(40926240U, new byte[2] { (byte)84, (byte)0 });
            PS3.SetMemory(40926278U, new byte[2] { (byte)159, (byte)10 });
            PS3.SetMemory(40926292U, new byte[2] { (byte)79, (byte)5 });
        }

        private void reaperButton79_Click(object sender, EventArgs e)
        {
            
        }
    }//Yaron YT/Libkuza
}
    

