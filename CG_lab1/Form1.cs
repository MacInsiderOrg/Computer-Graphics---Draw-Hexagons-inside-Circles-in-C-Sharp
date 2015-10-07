using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CG_lab1
{
    public partial class Form1 : Form
    {
        /* Count of pixels in width and height */
        private int width = 500;
        private int height = 500;

        // Create coordinate plane
        CoordinatePlane coordinatePlane;

        // List of circles, which containes hexagons
        List<Circle> circles = new List<Circle>();

        public Form1()
        {
            InitializeComponent();

            coordinatePlane = new CoordinatePlane(width, height);
            coordinatePlane.DrawCoordinatePlane();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawCircle.Enabled = false;
            panel.Image = coordinatePlane.GetImage();
        }

        /* Redraw circles and points */
        private void RedrawCoordinatePlane()
        {
            coordinatePlane.DrawCoordinatePlane();

            for (int i = 0; i < circles.Count; i++)
            {
                coordinatePlane.DrawCircle(circles[i]);
            }
        }

        /* Choose color in colorDialog */
        private Color ChooseColor()
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;
            else
                return Color.White;
        }
        
        private void borderColor_Click(object sender, EventArgs e)
        {
            borderColor.BackColor = ChooseColor();
        }

        private void circleBgColor_Click(object sender, EventArgs e)
        {
            circleBgColor.BackColor = ChooseColor();
        }

        private void hexagonBgColor_Click(object sender, EventArgs e)
        {
            hexagonBgColor.BackColor = ChooseColor();
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            float x = Convert.ToSingle(textBox1.Text),
                  y = Convert.ToSingle(textBox2.Text),
                  radius = Convert.ToSingle(textBox3.Text);

            if (x > 0 || y > 0 || x + radius > 0 || y + radius > 0)
                MessageBox.Show("Невірно введені дані!", "Помилка", MessageBoxButtons.OK);
            else
            {
                float minValue = (x < y) ? x : y;
                float newCoord = minValue - radius;

                coordinatePlane.SetMinValue(
                    (newCoord < coordinatePlane.GetMinValue()) ? newCoord : coordinatePlane.GetMinValue()
                );
                coordinatePlane.SetCoefficient(Math.Abs(-400 / coordinatePlane.GetMinValue()));

                // Create Circle
                Circle circle = new Circle(x, y, radius, borderColor.BackColor, circleBgColor.BackColor, hexagonBgColor.BackColor);

                // Add circle to list
                circles.Add(circle);

                // Redraw all coordinate plane, circles and hexagons
                RedrawCoordinatePlane();

                // Store current process to richTextBox
                stepByStep.Text += string.Format("{0}) Circle: (x: {1}, y: {2}), radius: {3}\n", circles.Count, x, y, radius);
                stepByStep.Text += string.Format("Hexagon: (x: {0}, y: {1}), radius: {2}\nPoints: ", x, y, radius) + "{\n";

                for (int i = 0; i < 6; i++)
                {
                    stepByStep.Text += string.Format(" (x: {0}, y: {1})\n", circle.GetHexagon().GetPoints()[i].X, circle.GetHexagon().GetPoints()[i].Y);
                }

                stepByStep.Text += "}\n\n";

                // Save all changes to form
                panel.Image = coordinatePlane.GetImage();
            }
        }

        private void clearCoordinatePlane_Click(object sender, EventArgs e)
        {
            circles = new List<Circle>();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            stepByStep.Clear();

            coordinatePlane = new CoordinatePlane(width, height);
            coordinatePlane.DrawCoordinatePlane();
            panel.Image = coordinatePlane.GetImage();

            drawCircle.Enabled = false;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if ((char.IsNumber(e.KeyChar)) || e.KeyChar == 8)
                return;

            if (textBox.Name != "textBox3")
            {
                if (e.KeyChar == '-')
                {
                    if (textBox.Text.IndexOf('-') != -1 || textBox.Text.Length > 0)
                        e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (textBox.Text.IndexOf(',') != -1)
                    e.Handled = true;
                return;
            }

            if (e.KeyChar == ',')
            {
                if (textBox.Text.IndexOf(',') != -1)
                    e.Handled = true;
                return;
            }

            e.Handled = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            drawCircle.Enabled = (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty);
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
