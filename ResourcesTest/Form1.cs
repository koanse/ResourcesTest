using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;

namespace ResourcesTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResourceManager rm = new ResourceManager(typeof(Resource2));
            this.Text = rm.GetString("MainFormCaption");
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point p = pictureBox1.PointToClient(Cursor.Position);
            this.Text = p.X.ToString() + " " + p.Y.ToString();
            base.OnMouseClick(e);
        }
    }
}