namespace note_pad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog muniiir = new OpenFileDialog();
            muniiir.Title = "Open";
            muniiir.Filter = "Text Document (*.txt) |*.txt|All files(*.*)|*.*)";
            if (muniiir.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(muniiir.FileName, RichTextBoxStreamType.PlainText);
            this.Text = muniiir.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog muniiir = new SaveFileDialog();
            muniiir.Title = "Save";
            muniiir.Filter = "Text Document (*.txt) |*.txt|All files(*.*)|*.*)";
            if (muniiir.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(muniiir.FileName, RichTextBoxStreamType.PlainText);
            this.Text = muniiir.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void delateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void dateTimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}