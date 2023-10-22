using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLSach
{
    public partial class formQuanLyFB : Form
    {
        private feedbackService fbService = new feedbackService();
        public formQuanLyFB()
        {
            InitializeComponent();
        }
        private void BindLayout (FlowLayoutPanel flowLayoutPanel1)
        {
            // Create a loop to generate 10 GroupBoxes and add them to the FlowLayoutPanel
            foreach ( var item in fbService.FindAllFb())
            {
                // Create a new GroupBox
                GroupBox groupBox1 = new GroupBox();

                // Set the text of the GroupBox
                groupBox1.Text = "Feedback " + item.MaSach;

                // Set the size of the GroupBox
                groupBox1.Size = new Size(400, 200);

                // Set the margin of the GroupBox
                groupBox1.Margin = new Padding(10);

                // Create an array of labels
                Label[] labels = new Label[3];

                // Create an array of textboxes
                TextBox[] textBoxes = new TextBox[3];

                // Create a loop to generate 3 labels and 3 textboxes and add them to the GroupBox
                for (int j = 0; j < 3; j++)
                {
                    // Create a new label
                    labels[j] = new Label();

                    // Set the text of the label
                    if ( j == 0 )
                        labels[j].Text = "Tên TK: ";
                    if ( j == 1 )
                        labels[j].Text = "Mã sách: ";
                    if (j == 2)
                        labels[j].Text = "Đánh giá: ";

                    // Set the location of the label
                    labels[j].Location = new Point(10, 20 + j * 40);

                    // Set the size of the label
                    labels[j].Size = new Size(50, 20);

                    // Add the label to the GroupBox
                    groupBox1.Controls.Add(labels[j]);

                    // Create a new textbox
                    textBoxes[j] = new TextBox();

                    // Set the location of the textbox
                    textBoxes[j].Location = new Point(70, 20 + j * 40);

                    // Set the size of the textbox
                    textBoxes[j].Size = new Size(100, 20);

                    if (j == 0)
                        textBoxes[j].Text = item.TenTK;
                    if (j == 1)
                        textBoxes[j].Text = item.MaSach;
                    if (j == 2)
                        textBoxes[j].Text = item.DanhGia + " Sao";

                    textBoxes[j].ReadOnly = true;

                    // Add the textbox to the GroupBox
                    groupBox1.Controls.Add(textBoxes[j]);
                }

                // Create a new RichTextBox
                RichTextBox richTextBox1 = new RichTextBox();

                // Set the location of the RichTextBox
                richTextBox1.Location = new Point(200, 20);

                // Set the size of the RichTextBox
                richTextBox1.Size = new Size(180, 160);

                // Add some text to the RichTextBox
                richTextBox1.Text = item.Phanhoi;

                richTextBox1.ReadOnly = true;

                // Add the RichTextBox to the GroupBox
                groupBox1.Controls.Add(richTextBox1);

                // Add the GroupBox to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(groupBox1);
            }

        }
        private void formQuanLyFB_Load(object sender, EventArgs e)
        {
            // Create a new FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();

            // Set the flow direction to top-down
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            // Set the wrap contents to false
            flowLayoutPanel1.WrapContents = false;


            flowLayoutPanel1.Size = new Size(500, 500);
            // Enable auto-scrolling
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(250, 25);

            // Add the panel to the form
            this.Controls.Add(flowLayoutPanel1);
            BindLayout(flowLayoutPanel1);
        }
    }
}
