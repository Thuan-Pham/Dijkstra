using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Dijkstra : Form
    {
        public Dijkstra()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dijkstra_Load(object sender, EventArgs e)
        {
            string[] VertexData = File.ReadAllLines(@"VertexList.txt");
            foreach (var line in VertexData)
            {
                string[] s = line.Split(" ");
                string str = s[0].Substring(0,1);
                Locations.Items.Add(str+" "+s[0].Substring(1));
                From.Items.Add(s[0].Substring(1));
                To.Items.Add(s[0].Substring(1));
            }

        }

        private void FindWay_Click(object sender, EventArgs e)
        {
            Graph theGraph = new Graph();
            theGraph.result = "";
            theGraph.startToCurrent = 0;
            int from = From.SelectedIndex;
            int to = To.SelectedIndex; ;
            theGraph.Path(from, to);
            Show.Text=theGraph.result;
            Distance.Text = ">>Distance: "+ theGraph.startToCurrent.ToString("#.##")  + "km";
            
        }
    }
}
