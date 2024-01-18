using System.Security.Policy;

namespace CRUD
{
    public partial class Form1 : Form
    {

        Usuario[] usuarios = new Usuario[]
        {
           new Usuario("Rubens", "rubiinho@live.it", 29132295, 12323696),
           new Usuario("Valdir", "valdir@live.it", 29222995, 232323112)

    };

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 0;
            button1.Text = "Carregar";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(194, 144);
            button2.Name = "button2";
            button2.Size = new Size(71, 28);
            button2.TabIndex = 1;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Location = new Point(37, 140);
            button3.Name = "button3";
            button3.Size = new Size(93, 29);
            button3.TabIndex = 1;
            button3.Text = "Procurar";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 123);
            dataGridView1.TabIndex = 2;
            dataGridView1.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(18, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 192);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuário";
            groupBox1.UseWaitCursor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(139, 112);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(126, 23);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.UseWaitCursor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(139, 83);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(126, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.UseWaitCursor = true;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(13, 113);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "Contato";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento";
            label3.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 23);
            textBox2.TabIndex = 3;
            textBox2.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 3;
            textBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            label1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(311, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 192);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro";
            groupBox2.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 80);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 3;
            label6.Text = "Email";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 26);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 3;
            label5.Text = "Nome";
            label5.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 2;
            textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 2;
            textBox3.UseWaitCursor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(480, 395);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Gerênciador de Dados";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;



        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuarios;
        }
    }


    class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int DataNascimento { get; set; }

        public Usuario(string nome, string email, int phone, int datanascimento)
        {
            Nome = nome;
            Email = email;
            Phone = phone;
            DataNascimento = datanascimento;
        }
    }
}
