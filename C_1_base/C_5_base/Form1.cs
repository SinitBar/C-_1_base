using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_5_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
||||||| constructed merge base
            InitializeComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        { // кнопка Up
            string bla = label4.Text;
            int index = bla.LastIndexOf('\\');
            if ((index != -1) && (bla != comboBox1.Text))
            {
                label4.Text = bla.Substring(0, index); 
                if (label4.Text.LastIndexOf('\\') == -1)
                { // попадаем сюда только когда вернулись кнопкой Up в родительский каталог
                    label4.Text += '\\';
                    //button1.Enabled = false;
                }
                List<string> directory_names = Directory.GetFileSystemEntries(label4.Text).ToList();
                treeView1.Nodes.Clear();
                foreach (string d in directory_names)
                    treeView1.Nodes.Add(d);
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> filenames;
            filenames = Directory.GetDirectories(comboBox1.SelectedItem.ToString()).ToList();
            foreach (string f in filenames)
                treeView1.Nodes.Add(f);
            filenames = Directory.GetFiles(comboBox1.SelectedItem.ToString()).ToList();
            foreach (string f in filenames)
                treeView1.Nodes.Add(f);
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string bla = treeView1.SelectedNode.Text;
            label4.Text = bla;
            List<string> directory_names = new List<string>();
            if (Directory.Exists(bla)) // выбрали папку
                directory_names = Directory.GetFileSystemEntries(bla).ToList();
            else // выбрали файл
                Process.Start(bla);
            treeView1.Nodes.Clear();
            foreach (string d in directory_names)
                treeView1.Nodes.Add(d);
            button1.Enabled = true;
        }

        private void InitializeComboBox()
        {
            button1.Enabled = false;
            // начинаем с выбора локального диска в комбобоксе
            // для этого добавляем локальные диски в комбобокс
            DriveInfo[] local_discs = DriveInfo.GetDrives();
            foreach (DriveInfo disc in local_discs)
                comboBox1.Items.Add(disc.Name);
            // добавили локальные диски
            //button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

=======
            InitializeComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        { // кнопка Up
            string bla = label4.Text;
            int index = bla.LastIndexOf('\\');
            if ((index != -1) && (bla != comboBox1.Text))
            {
                label4.Text = bla.Substring(0, index); 
                if (label4.Text.LastIndexOf('\\') == -1)
                { // попадаем сюда только когда вернулись кнопкой Up в родительский каталог
                    label4.Text += '\\';
                    button1.Enabled = false;
                }
                List<string> directory_names = Directory.GetFileSystemEntries(label4.Text).ToList();
                treeView1.Nodes.Clear();
                foreach (string d in directory_names)
                    treeView1.Nodes.Add(d);
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> filenames;
            filenames = Directory.GetFileSystemEntries(comboBox1.SelectedItem.ToString()).ToList();
            treeView1.Nodes.Clear();
            foreach (string f in filenames)
                treeView1.Nodes.Add(f);
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        bool treeView1Reset = true;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!treeView1Reset)
            {
                string bla = treeView1.SelectedNode.Text;
                label4.Text = bla;
                List<string> directory_names = new List<string>();
                if (Directory.Exists(bla)) // выбрали папку
                    directory_names = Directory.GetFileSystemEntries(bla).ToList();
                else // выбрали файл
                    Process.Start(bla);
                treeView1.Nodes.Clear();
                foreach (string d in directory_names)
                    treeView1.Nodes.Add(d);
                button1.Enabled = true;
                treeView1Reset = true;
            }
        }

        private void InitializeComboBox()
        {
            button1.Enabled = false;
            // начинаем с выбора локального диска в комбобоксе
            // для этого добавляем локальные диски в комбобокс
            DriveInfo[] local_discs = DriveInfo.GetDrives();
            foreach (DriveInfo disc in local_discs)
                comboBox1.Items.Add(disc.Name);
            // добавили локальные диски
            //button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

>>>>>>> all works
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1Reset = false;
        }
    }
}
