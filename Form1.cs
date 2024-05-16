namespace Ccs_Lab3_02
{
    public partial class Form1 : Form
    {
        private HSVColor hsvColor;
        public Form1()
        {
            InitializeComponent();
            hsvColor = new HSVColor(0, 1, 1); // Начальный цвет: красный (0), максимальная насыщенность и яркость
            UpdateColorValues();
        }

        private void UpdateColorValues()
        {
            // Обновление значений в текстовых полях
            textBoxHue.Text = hsvColor.Hue.ToString();
            textBoxSaturation.Text = hsvColor.Saturation.ToString();
            textBoxValue.Text = hsvColor.Value.ToString();

            // Обновление цвета на форме
            panelColor.BackColor = hsvColor.ToRGB().ToColor();
        }



        private void InitializeComponent()
        {
            panelColor = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxHue = new TextBox();
            textBoxAmount = new TextBox();
            textBoxValue = new TextBox();
            textBoxSaturation = new TextBox();
            buttonAddRed = new Button();
            buttonSubtractRed = new Button();
            buttonAddGreen = new Button();
            buttonSubtractGreen = new Button();
            buttonAddBlue = new Button();
            buttonSubtractBlue = new Button();
            buttonAddSaturation = new Button();
            buttonSubtractSaturation = new Button();
            buttonAddBrightness = new Button();
            buttonSubtractBrightness = new Button();
            panelColor.SuspendLayout();
            SuspendLayout();
            // 
            // panelColor
            // 
            panelColor.Controls.Add(label5);
            panelColor.Location = new Point(12, 513);
            panelColor.Name = "panelColor";
            panelColor.Size = new Size(335, 76);
            panelColor.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(87, 22);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 19;
            label5.Text = "Калор панэл";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 32);
            label1.TabIndex = 1;
            label1.Text = "Рэд:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(22, 92);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 2;
            label2.Text = "Грин:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(22, 137);
            label3.Name = "label3";
            label3.Size = new Size(66, 32);
            label3.TabIndex = 3;
            label3.Text = "Блю:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(22, 187);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 4;
            label4.Text = "Шаг:";
            // 
            // textBoxHue
            // 
            textBoxHue.Location = new Point(191, 54);
            textBoxHue.Name = "textBoxHue";
            textBoxHue.Size = new Size(125, 27);
            textBoxHue.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(191, 187);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(125, 27);
            textBoxAmount.TabIndex = 6;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(191, 142);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(125, 27);
            textBoxValue.TabIndex = 7;
            // 
            // textBoxSaturation
            // 
            textBoxSaturation.Location = new Point(191, 98);
            textBoxSaturation.Name = "textBoxSaturation";
            textBoxSaturation.Size = new Size(125, 27);
            textBoxSaturation.TabIndex = 8;
            // 
            // buttonAddRed
            // 
            buttonAddRed.Location = new Point(22, 251);
            buttonAddRed.Name = "buttonAddRed";
            buttonAddRed.Size = new Size(146, 29);
            buttonAddRed.TabIndex = 9;
            buttonAddRed.Text = "Эд Рэд";
            buttonAddRed.UseVisualStyleBackColor = true;
            buttonAddRed.Click += buttonAddRed_Click;
            // 
            // buttonSubtractRed
            // 
            buttonSubtractRed.Location = new Point(174, 251);
            buttonSubtractRed.Name = "buttonSubtractRed";
            buttonSubtractRed.Size = new Size(142, 29);
            buttonSubtractRed.TabIndex = 10;
            buttonSubtractRed.Text = "Сабстракт Рэд";
            buttonSubtractRed.UseVisualStyleBackColor = true;
            buttonSubtractRed.Click += buttonSubtractRed_Click;
            // 
            // buttonAddGreen
            // 
            buttonAddGreen.Location = new Point(22, 286);
            buttonAddGreen.Name = "buttonAddGreen";
            buttonAddGreen.Size = new Size(146, 29);
            buttonAddGreen.TabIndex = 11;
            buttonAddGreen.Text = "Эд Грин";
            buttonAddGreen.UseVisualStyleBackColor = true;
            buttonAddGreen.Click += buttonAddGreen_Click;
            // 
            // buttonSubtractGreen
            // 
            buttonSubtractGreen.Location = new Point(174, 286);
            buttonSubtractGreen.Name = "buttonSubtractGreen";
            buttonSubtractGreen.Size = new Size(142, 29);
            buttonSubtractGreen.TabIndex = 12;
            buttonSubtractGreen.Text = "Сабстракт Грин";
            buttonSubtractGreen.UseVisualStyleBackColor = true;
            buttonSubtractGreen.Click += buttonSubtractGreen_Click;
            // 
            // buttonAddBlue
            // 
            buttonAddBlue.Location = new Point(22, 321);
            buttonAddBlue.Name = "buttonAddBlue";
            buttonAddBlue.Size = new Size(146, 29);
            buttonAddBlue.TabIndex = 13;
            buttonAddBlue.Text = "Эд Блю";
            buttonAddBlue.UseVisualStyleBackColor = true;
            buttonAddBlue.Click += buttonAddBlue_Click;
            // 
            // buttonSubtractBlue
            // 
            buttonSubtractBlue.Location = new Point(174, 321);
            buttonSubtractBlue.Name = "buttonSubtractBlue";
            buttonSubtractBlue.Size = new Size(142, 29);
            buttonSubtractBlue.TabIndex = 14;
            buttonSubtractBlue.Text = "Сабстракт Блю";
            buttonSubtractBlue.UseVisualStyleBackColor = true;
            buttonSubtractBlue.Click += buttonSubtractBlue_Click;
            // 
            // buttonAddSaturation
            // 
            buttonAddSaturation.Location = new Point(22, 356);
            buttonAddSaturation.Name = "buttonAddSaturation";
            buttonAddSaturation.Size = new Size(294, 29);
            buttonAddSaturation.TabIndex = 15;
            buttonAddSaturation.Text = "Эд Сатуратион";
            buttonAddSaturation.UseVisualStyleBackColor = true;
            buttonAddSaturation.Click += buttonAddSaturation_Click;
            // 
            // buttonSubtractSaturation
            // 
            buttonSubtractSaturation.Location = new Point(22, 391);
            buttonSubtractSaturation.Name = "buttonSubtractSaturation";
            buttonSubtractSaturation.Size = new Size(294, 29);
            buttonSubtractSaturation.TabIndex = 16;
            buttonSubtractSaturation.Text = "Сабстракт Сатуратион";
            buttonSubtractSaturation.UseVisualStyleBackColor = true;
            buttonSubtractSaturation.Click += buttonSubtractSaturation_Click;
            // 
            // buttonAddBrightness
            // 
            buttonAddBrightness.Location = new Point(22, 426);
            buttonAddBrightness.Name = "buttonAddBrightness";
            buttonAddBrightness.Size = new Size(294, 29);
            buttonAddBrightness.TabIndex = 17;
            buttonAddBrightness.Text = "Эд Бритхнес";
            buttonAddBrightness.UseVisualStyleBackColor = true;
            buttonAddBrightness.Click += buttonAddBrightness_Click;
            // 
            // buttonSubtractBrightness
            // 
            buttonSubtractBrightness.Location = new Point(22, 461);
            buttonSubtractBrightness.Name = "buttonSubtractBrightness";
            buttonSubtractBrightness.Size = new Size(294, 29);
            buttonSubtractBrightness.TabIndex = 18;
            buttonSubtractBrightness.Text = "Сабстракт Бритхнес";
            buttonSubtractBrightness.UseVisualStyleBackColor = true;
            buttonSubtractBrightness.Click += buttonSubtractBrightness_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(359, 601);
            Controls.Add(buttonSubtractBrightness);
            Controls.Add(buttonAddBrightness);
            Controls.Add(buttonSubtractSaturation);
            Controls.Add(buttonAddSaturation);
            Controls.Add(buttonSubtractBlue);
            Controls.Add(buttonAddBlue);
            Controls.Add(buttonSubtractGreen);
            Controls.Add(buttonAddGreen);
            Controls.Add(buttonSubtractRed);
            Controls.Add(buttonAddRed);
            Controls.Add(textBoxSaturation);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxHue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelColor);
            Name = "Form1";
            panelColor.ResumeLayout(false);
            panelColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelColor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxHue;
        private TextBox textBoxAmount;
        private TextBox textBoxValue;
        private TextBox textBoxSaturation;
        private Button buttonAddRed;
        private Button buttonSubtractRed;
        private Button buttonAddGreen;
        private Button buttonSubtractGreen;
        private Button buttonAddBlue;
        private Button buttonSubtractBlue;
        private Button buttonAddSaturation;
        private Button buttonSubtractSaturation;
        private Button buttonAddBrightness;
        private Button buttonSubtractBrightness;
        private Label label5;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRed_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddRed(amount);
            UpdateColorValues();
        }

        private void buttonSubtractRed_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractRed(amount);
            UpdateColorValues();
        }

        private void buttonAddGreen_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddGreen(amount);
            UpdateColorValues();
        }

        private void buttonSubtractGreen_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractGreen(amount);
            UpdateColorValues();
        }

        private void buttonAddBlue_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddBlue(amount);
            UpdateColorValues();
        }

        private void buttonSubtractBlue_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractBlue(amount);
            UpdateColorValues();
        }

        private void buttonAddSaturation_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddSaturation(amount);
            UpdateColorValues();
        }

        private void buttonSubtractSaturation_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractSaturation(amount);
            UpdateColorValues();
        }

        private void buttonAddBrightness_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.AddBrightness(amount);
            UpdateColorValues();
        }

        private void buttonSubtractBrightness_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBoxAmount.Text);
            hsvColor.SubtractBrightness(amount);
            UpdateColorValues();
        }
    }
}
