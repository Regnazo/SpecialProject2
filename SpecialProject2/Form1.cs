using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpecialProject2
{
    public partial class Form1 : Form
    {
        //Overall integers for the class
        private List<Shape> shapes = new List<Shape>();
        private Shape currentShape;
        private Color currentColor = Color.Black;
        private string currentShapeType;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        // Adds the shape options to the combobox
        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Rectangle");
            comboBox1.Items.Add("Circle");
        }
        // Allows the panel to draw the shapes
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
        //Sets the values in drawing panel to the shapes
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            int x, y, width, height;
            if (int.TryParse(XText.Text, out x) && int.TryParse(YText.Text, out y) &&
                int.TryParse(WidthText.Text, out width) && int.TryParse(HeightText.Text, out height))
            {
                if (currentShapeType == "Rectangle")
                    currentShape = new RectangleShape(x, y, width, height, currentColor);
                else if (currentShapeType == "Circle")
                    currentShape = new CircleShape(x, y, width, currentColor);

                shapes.Add(currentShape);
                DrawingPanel.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        //Adds a color choosing menu which is very easy to use
        private void ColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                }
            }
        }
    }
    // Shape Class to define the shapes
    public abstract class Shape
        {
            public Color Colortype { get; set; }

            public Shape(Color color)
            {
                Colortype = color;
            }
            public abstract void Draw(Graphics g);
        }
        // Rectangle Shape
        public class RectangleShape : Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public RectangleShape(int x, int y, int width, int height, Color color) : base(color)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Colortype))
                {
                    g.FillRectangle(brush, X, Y, Width, Height);
                }
            }
        }

        // Circle Shape
        public class CircleShape : Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius { get; set; }

            public CircleShape(int x, int y, int radius, Color color) : base(color)
            {
                X = x;
                Y = y;
                Radius = radius;
            }

            public override void Draw(Graphics g)
            {
                using (Brush brush = new SolidBrush(Colortype))
                {
                    g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
                }
            }
        }
}

