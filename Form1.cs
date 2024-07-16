using MGR.sets;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime;
using System.Windows.Forms;
namespace MGR
{
    public partial class Form1 : Form
    {
        //���� ����� ���������� json ������
        public readonly string PATH = @"C:\MyHeadaches";
        //������ ��������
        List<Headache> headaches;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormClosing += new FormClosingEventHandler(Closingg);
            treeView1.NodeMouseDoubleClick += TreeView1Double;
            treeView1.MouseUp += new MouseEventHandler(MouseUp);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Read(PATH);
            Refresher();
        }

        /// <summary>
        /// �����, �������������� ���� ��� �������� (�������������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode node = treeView1.GetNodeAt(e.X, e.Y);
                if (node != null)
                {
                    treeView1.SelectedNode = node;
                    contextMenuStrip1.Show(treeView1, e.Location);
                }
            }
        }
        
        /// <summary>
        /// ��� ��� ������ "�������" ������������� ��� ��� �� ���� (�������������)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //var N = treeView1.Nodes[treeView1.Nodes.IndexOfKey();
                //var N = treeView1.Nodes.Find(, true).First();

                var selectedache = (from item in headaches
                                    where $"�����������������: {item.Timecount} �� ������� �����: {item.goals}" == treeView1.SelectedNode.Text
                                    select item).FirstOrDefault();
                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    if (selectedache is not null)
                    {
                        headaches.Remove(selectedache);
                    }
                }
                else
                {
                    throw new Exception("���������� ������� ���� ����!");
                }
                Refresher();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ��������: {ex.Message}");
            }
        }

        /// <summary>
        /// ������� ���� �� ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1Double(object? sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count == 0)
                {
                    var selectedache = (from item in headaches
                                        where $"�����������������: {item.Timecount} �� ������� �����: {item.goals}" == e.Node.Text
                                        select item).FirstOrDefault();

                    using (Redactor red = new(selectedache))
                    {
                        if (red.ShowDialog() == DialogResult.OK)
                        {
                            headaches.Remove(selectedache);
                            headaches.Add(red.Headache);
                        }
                    }
                    Refresher();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ ������ ������ ��� �������� ����:\n{ex.Message}");
            }
        }
       
        /// <summary>
        /// ��� ������������� �� ����� �������� ����� (���������� ������ � json)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Closingg(object sender, FormClosingEventArgs e)
        {
            Write(PATH);
        }
        /// <summary>
        /// ����� ��� ���������� ��� � Treeview � ���������� ��������� ������ headaches
        /// </summary>
        
        public void Refresher()
        {
            try
            {
                headaches = (from p in headaches orderby p.Date select p).ToList();
                treeView1.Nodes.Clear();
                var iterator = -1;
                foreach (var item in headaches)
                {
                    var data = item.Date.ToString();

                    if (!treeView1.Nodes.ContainsKey(data))
                    {
                        treeView1.Nodes.Add(
                        new TreeNode(data) { Name = data }
                        );
                        iterator++;
                    }
                    treeView1.Nodes[iterator].Nodes.Add(Name = $"�����������������: {item.Timecount} �� ������� �����: {item.goals}");
                }
                Write(PATH);
            }
            catch (Exception e)
            {
                MessageBox.Show($"������ ��� ���������� ������: {e.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (Redactor red = new())
            {
                if (red.ShowDialog() == DialogResult.OK)
                {
                    headaches.Add(red.Headache);
                }
            }
            Refresher();
        }

        /// <summary>
        /// "������" �� ����������� ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var write = new WordWriter(headaches);
                write.Write();
                var path = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                    "��� �������.docx");
                string powerShellCommand = $"Start-Process -FilePath '{path}'";
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-NoProfile -Command \"{powerShellCommand}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(startInfo))
                {
                    // ������ �������� ����� ��� ��������� ������ (��� �������������)
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (process.ExitCode != 0)
                    {
                        throw new Exception(error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �� ����� �������� word-���������: {ex.Message}");
            }            
        }

        #region READWRITE
        public void Read(string path)
        {
            try
            {
                var info = new DirectoryInfo(path);
                if (!info.Exists)
                {
                    info.Create();
                    path = Path.Combine(path, "HA.json");
                    headaches = new List<Headache>();
                    var jsonstr = JsonConvert.SerializeObject(headaches);
                    File.WriteAllText(path, jsonstr);
                    return;
                }
                else
                {
                    path = Path.Combine(path, "HA.json");
                    string VALS;
                    using (var reader = new StreamReader(path))
                    {
                        VALS = reader.ReadToEnd();
                    }
                    headaches = JsonConvert.DeserializeObject<List<Headache>>(VALS) ?? throw new Exception(message: "������ ������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ �����: {ex.Message}");
            }
            finally
            {
                try
                {
                    headaches.Sort();
                }
                catch (Exception) { }
            }
        }
        public void Write(string path)
        {
            try
            {
                path = Path.Combine(path, "HA.json");
                var jsonstr = JsonConvert.SerializeObject(headaches);
                File.WriteAllText(path, jsonstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ � ����: {ex.Message}");
            }
        }
        #endregion
    }
}
