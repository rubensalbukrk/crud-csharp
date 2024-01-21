using System.Security.Policy;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace CRUD
{
    public partial class Form1 : Form
    {
      readonly string auth = "Data Source=localhost;User Id=system;Password=peixe;";

     
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            phoneValue = new MaskedTextBox();
            dataValue = new MaskedTextBox();
            button2 = new Button();
            idadeValue = new NumericUpDown();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            emailValue = new TextBox();
            label2 = new Label();
            nomeValue = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            emailFilter = new TextBox();
            nomeFilter = new TextBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idadeValue).BeginInit();
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
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(64, 136);
            button3.Name = "button3";
            button3.Size = new Size(93, 29);
            button3.TabIndex = 1;
            button3.Text = "Procurar";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 123);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(phoneValue);
            groupBox1.Controls.Add(dataValue);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(idadeValue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(emailValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nomeValue);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuário";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(139, 114);
            phoneValue.Mask = "(00) 00000-0000";
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(126, 23);
            phoneValue.TabIndex = 7;
            // 
            // dataValue
            // 
            dataValue.Location = new Point(139, 84);
            dataValue.Mask = "00/00/0000";
            dataValue.Name = "dataValue";
            dataValue.Size = new Size(126, 23);
            dataValue.TabIndex = 7;
            dataValue.ValidatingType = typeof(DateTime);
            // 
            // button2
            // 
            button2.Location = new Point(200, 145);
            button2.Name = "button2";
            button2.Size = new Size(66, 26);
            button2.TabIndex = 6;
            button2.Text = "Criar";
            button2.UseVisualStyleBackColor = true;
            // 
            // idadeValue
            // 
            idadeValue.Location = new Point(139, 142);
            idadeValue.Name = "idadeValue";
            idadeValue.Size = new Size(49, 23);
            idadeValue.TabIndex = 5;
            idadeValue.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(13, 140);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 2;
            label7.Text = "Idade";
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
            // 
            // emailValue
            // 
            emailValue.Location = new Point(139, 53);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(126, 23);
            emailValue.TabIndex = 3;
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
            // 
            // nomeValue
            // 
            nomeValue.Location = new Point(139, 24);
            nomeValue.Name = "nomeValue";
            nomeValue.Size = new Size(126, 23);
            nomeValue.TabIndex = 3;
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(emailFilter);
            groupBox2.Controls.Add(nomeFilter);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(311, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(161, 177);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 80);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 26);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 3;
            label5.Text = "Nome";
            // 
            // emailFilter
            // 
            emailFilter.Location = new Point(6, 103);
            emailFilter.Name = "emailFilter";
            emailFilter.Size = new Size(149, 23);
            emailFilter.TabIndex = 2;
            // 
            // nomeFilter
            // 
            nomeFilter.Location = new Point(6, 49);
            nomeFilter.Name = "nomeFilter";
            nomeFilter.Size = new Size(149, 23);
            nomeFilter.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idadeValue).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox emailValue;
        private Label label2;
        private TextBox nomeValue;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox emailFilter;
        private TextBox nomeFilter;
        private BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            dataGridView1.DataSource = null;
            string query = "SELECT * FROM usuarios";

            using (OracleConnection connection = new OracleConnection(auth))
            {
                try
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario(
                                    reader["NOME"].ToString(),
                                    reader["EMAIL"].ToString(),
                                    reader["IDADE"].ToString(),
                                    reader["DATA"].ToString(),
                                    reader["PHONE"].ToString()
                                    );
                                usuarios.Add(usuario);
                            }
                        }
                    }
                    dataGridView1.DataSource = usuarios;
                }
                catch (Exception error)
                {

                    MessageBox.Show($"Houve um problema ao consultar banco de dados: {error.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private NumericUpDown idadeValue;
        private Label label7;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private MaskedTextBox phoneValue;
        private MaskedTextBox dataValue;
        private Button button2;
    }


    class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Phone { get; set; }
        public string DataNascimento { get; set; }

        public Usuario(string nome, string email, string idade, string phone, string data)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
            Phone = phone;
            DataNascimento = data;
        }
    }
}
