
namespace FieldHospital
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.deathCountLabelValue = new System.Windows.Forms.Label();
            this.doctor3SkillLabelValue = new System.Windows.Forms.Label();
            this.doctor2SkillLabelValue = new System.Windows.Forms.Label();
            this.doctor1SkillLabelValue = new System.Windows.Forms.Label();
            this.doctor3CuredCountLabelValue = new System.Windows.Forms.Label();
            this.doctor2CuredCountLabelValue = new System.Windows.Forms.Label();
            this.doctor1CuredCountLabelValue = new System.Windows.Forms.Label();
            this.fightersCountеLabelValue = new System.Windows.Forms.Label();
            this.deathCountLabel = new System.Windows.Forms.Label();
            this.doctor3CuredCountLabel = new System.Windows.Forms.Label();
            this.doctor2CuredCountLabel = new System.Windows.Forms.Label();
            this.doctor1CuredCountLabel = new System.Windows.Forms.Label();
            this.doctor3SkillLabel = new System.Windows.Forms.Label();
            this.doctor2SkillLabel = new System.Windows.Forms.Label();
            this.doctor1SkillLabel = new System.Windows.Forms.Label();
            this.doctor3Label = new System.Windows.Forms.Label();
            this.doctor2Label = new System.Windows.Forms.Label();
            this.doctor1Label = new System.Windows.Forms.Label();
            this.fightersCountLabel = new System.Windows.Forms.Label();
            this.newFigtherRandomLabel = new System.Windows.Forms.Label();
            this.newFigtherRandomUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthRangeLabel = new System.Windows.Forms.Label();
            this.healthRangeMinUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthRangeMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFigtherRandomUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRangeMinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRangeMaxUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startButton.Location = new System.Drawing.Point(383, 24);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(274, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.healthRangeMaxUpDown);
            this.panel1.Controls.Add(this.healthRangeMinUpDown);
            this.panel1.Controls.Add(this.newFigtherRandomUpDown);
            this.panel1.Controls.Add(this.healthRangeLabel);
            this.panel1.Controls.Add(this.newFigtherRandomLabel);
            this.panel1.Controls.Add(this.deathCountLabelValue);
            this.panel1.Controls.Add(this.doctor3SkillLabelValue);
            this.panel1.Controls.Add(this.doctor2SkillLabelValue);
            this.panel1.Controls.Add(this.doctor1SkillLabelValue);
            this.panel1.Controls.Add(this.doctor3CuredCountLabelValue);
            this.panel1.Controls.Add(this.doctor2CuredCountLabelValue);
            this.panel1.Controls.Add(this.doctor1CuredCountLabelValue);
            this.panel1.Controls.Add(this.fightersCountеLabelValue);
            this.panel1.Controls.Add(this.deathCountLabel);
            this.panel1.Controls.Add(this.doctor3CuredCountLabel);
            this.panel1.Controls.Add(this.doctor2CuredCountLabel);
            this.panel1.Controls.Add(this.doctor1CuredCountLabel);
            this.panel1.Controls.Add(this.doctor3SkillLabel);
            this.panel1.Controls.Add(this.doctor2SkillLabel);
            this.panel1.Controls.Add(this.doctor1SkillLabel);
            this.panel1.Controls.Add(this.doctor3Label);
            this.panel1.Controls.Add(this.doctor2Label);
            this.panel1.Controls.Add(this.doctor1Label);
            this.panel1.Controls.Add(this.fightersCountLabel);
            this.panel1.Location = new System.Drawing.Point(383, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 283);
            this.panel1.TabIndex = 1;
            // 
            // deathCountLabelValue
            // 
            this.deathCountLabelValue.AutoSize = true;
            this.deathCountLabelValue.BackColor = System.Drawing.Color.Red;
            this.deathCountLabelValue.Location = new System.Drawing.Point(177, 234);
            this.deathCountLabelValue.Name = "deathCountLabelValue";
            this.deathCountLabelValue.Size = new System.Drawing.Size(13, 13);
            this.deathCountLabelValue.TabIndex = 0;
            this.deathCountLabelValue.Text = "0";
            // 
            // doctor3SkillLabelValue
            // 
            this.doctor3SkillLabelValue.AutoSize = true;
            this.doctor3SkillLabelValue.Location = new System.Drawing.Point(123, 90);
            this.doctor3SkillLabelValue.Name = "doctor3SkillLabelValue";
            this.doctor3SkillLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor3SkillLabelValue.TabIndex = 0;
            this.doctor3SkillLabelValue.Text = "0";
            // 
            // doctor2SkillLabelValue
            // 
            this.doctor2SkillLabelValue.AutoSize = true;
            this.doctor2SkillLabelValue.Location = new System.Drawing.Point(123, 68);
            this.doctor2SkillLabelValue.Name = "doctor2SkillLabelValue";
            this.doctor2SkillLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor2SkillLabelValue.TabIndex = 0;
            this.doctor2SkillLabelValue.Text = "0";
            // 
            // doctor1SkillLabelValue
            // 
            this.doctor1SkillLabelValue.AutoSize = true;
            this.doctor1SkillLabelValue.Location = new System.Drawing.Point(123, 45);
            this.doctor1SkillLabelValue.Name = "doctor1SkillLabelValue";
            this.doctor1SkillLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor1SkillLabelValue.TabIndex = 0;
            this.doctor1SkillLabelValue.Text = "0";
            // 
            // doctor3CuredCountLabelValue
            // 
            this.doctor3CuredCountLabelValue.AutoSize = true;
            this.doctor3CuredCountLabelValue.Location = new System.Drawing.Point(204, 90);
            this.doctor3CuredCountLabelValue.Name = "doctor3CuredCountLabelValue";
            this.doctor3CuredCountLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor3CuredCountLabelValue.TabIndex = 0;
            this.doctor3CuredCountLabelValue.Text = "0";
            // 
            // doctor2CuredCountLabelValue
            // 
            this.doctor2CuredCountLabelValue.AutoSize = true;
            this.doctor2CuredCountLabelValue.Location = new System.Drawing.Point(204, 68);
            this.doctor2CuredCountLabelValue.Name = "doctor2CuredCountLabelValue";
            this.doctor2CuredCountLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor2CuredCountLabelValue.TabIndex = 0;
            this.doctor2CuredCountLabelValue.Text = "0";
            // 
            // doctor1CuredCountLabelValue
            // 
            this.doctor1CuredCountLabelValue.AutoSize = true;
            this.doctor1CuredCountLabelValue.Location = new System.Drawing.Point(204, 45);
            this.doctor1CuredCountLabelValue.Name = "doctor1CuredCountLabelValue";
            this.doctor1CuredCountLabelValue.Size = new System.Drawing.Size(13, 13);
            this.doctor1CuredCountLabelValue.TabIndex = 0;
            this.doctor1CuredCountLabelValue.Text = "0";
            // 
            // fightersCountеLabelValue
            // 
            this.fightersCountеLabelValue.AutoSize = true;
            this.fightersCountеLabelValue.Location = new System.Drawing.Point(177, 16);
            this.fightersCountеLabelValue.Name = "fightersCountеLabelValue";
            this.fightersCountеLabelValue.Size = new System.Drawing.Size(13, 13);
            this.fightersCountеLabelValue.TabIndex = 0;
            this.fightersCountеLabelValue.Text = "0";
            // 
            // deathCountLabel
            // 
            this.deathCountLabel.AutoSize = true;
            this.deathCountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deathCountLabel.Location = new System.Drawing.Point(12, 234);
            this.deathCountLabel.Name = "deathCountLabel";
            this.deathCountLabel.Size = new System.Drawing.Size(112, 13);
            this.deathCountLabel.TabIndex = 0;
            this.deathCountLabel.Text = "Количество смертей";
            // 
            // doctor3CuredCountLabel
            // 
            this.doctor3CuredCountLabel.AutoSize = true;
            this.doctor3CuredCountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor3CuredCountLabel.Location = new System.Drawing.Point(151, 90);
            this.doctor3CuredCountLabel.Name = "doctor3CuredCountLabel";
            this.doctor3CuredCountLabel.Size = new System.Drawing.Size(57, 13);
            this.doctor3CuredCountLabel.TabIndex = 0;
            this.doctor3CuredCountLabel.Text = "Вылечено";
            // 
            // doctor2CuredCountLabel
            // 
            this.doctor2CuredCountLabel.AutoSize = true;
            this.doctor2CuredCountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor2CuredCountLabel.Location = new System.Drawing.Point(151, 68);
            this.doctor2CuredCountLabel.Name = "doctor2CuredCountLabel";
            this.doctor2CuredCountLabel.Size = new System.Drawing.Size(57, 13);
            this.doctor2CuredCountLabel.TabIndex = 0;
            this.doctor2CuredCountLabel.Text = "Вылечено";
            // 
            // doctor1CuredCountLabel
            // 
            this.doctor1CuredCountLabel.AutoSize = true;
            this.doctor1CuredCountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor1CuredCountLabel.Location = new System.Drawing.Point(151, 45);
            this.doctor1CuredCountLabel.Name = "doctor1CuredCountLabel";
            this.doctor1CuredCountLabel.Size = new System.Drawing.Size(57, 13);
            this.doctor1CuredCountLabel.TabIndex = 0;
            this.doctor1CuredCountLabel.Text = "Вылечено";
            // 
            // doctor3SkillLabel
            // 
            this.doctor3SkillLabel.AutoSize = true;
            this.doctor3SkillLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor3SkillLabel.Location = new System.Drawing.Point(83, 90);
            this.doctor3SkillLabel.Name = "doctor3SkillLabel";
            this.doctor3SkillLabel.Size = new System.Drawing.Size(34, 13);
            this.doctor3SkillLabel.TabIndex = 0;
            this.doctor3SkillLabel.Text = "Опыт";
            // 
            // doctor2SkillLabel
            // 
            this.doctor2SkillLabel.AutoSize = true;
            this.doctor2SkillLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor2SkillLabel.Location = new System.Drawing.Point(83, 68);
            this.doctor2SkillLabel.Name = "doctor2SkillLabel";
            this.doctor2SkillLabel.Size = new System.Drawing.Size(34, 13);
            this.doctor2SkillLabel.TabIndex = 0;
            this.doctor2SkillLabel.Text = "Опыт";
            // 
            // doctor1SkillLabel
            // 
            this.doctor1SkillLabel.AutoSize = true;
            this.doctor1SkillLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor1SkillLabel.Location = new System.Drawing.Point(83, 45);
            this.doctor1SkillLabel.Name = "doctor1SkillLabel";
            this.doctor1SkillLabel.Size = new System.Drawing.Size(34, 13);
            this.doctor1SkillLabel.TabIndex = 0;
            this.doctor1SkillLabel.Text = "Опыт";
            // 
            // doctor3Label
            // 
            this.doctor3Label.AutoSize = true;
            this.doctor3Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor3Label.Location = new System.Drawing.Point(12, 90);
            this.doctor3Label.Name = "doctor3Label";
            this.doctor3Label.Size = new System.Drawing.Size(65, 13);
            this.doctor3Label.TabIndex = 0;
            this.doctor3Label.Text = "Доктор №3";
            // 
            // doctor2Label
            // 
            this.doctor2Label.AutoSize = true;
            this.doctor2Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor2Label.Location = new System.Drawing.Point(12, 68);
            this.doctor2Label.Name = "doctor2Label";
            this.doctor2Label.Size = new System.Drawing.Size(65, 13);
            this.doctor2Label.TabIndex = 0;
            this.doctor2Label.Text = "Доктор №2";
            // 
            // doctor1Label
            // 
            this.doctor1Label.AutoSize = true;
            this.doctor1Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctor1Label.Location = new System.Drawing.Point(12, 45);
            this.doctor1Label.Name = "doctor1Label";
            this.doctor1Label.Size = new System.Drawing.Size(65, 13);
            this.doctor1Label.TabIndex = 0;
            this.doctor1Label.Text = "Доктор №1";
            // 
            // fightersCountLabel
            // 
            this.fightersCountLabel.AutoSize = true;
            this.fightersCountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fightersCountLabel.Location = new System.Drawing.Point(12, 16);
            this.fightersCountLabel.Name = "fightersCountLabel";
            this.fightersCountLabel.Size = new System.Drawing.Size(159, 13);
            this.fightersCountLabel.TabIndex = 0;
            this.fightersCountLabel.Text = "Общее количество пациентов";
            // 
            // newFigtherRandomLabel
            // 
            this.newFigtherRandomLabel.AutoSize = true;
            this.newFigtherRandomLabel.Location = new System.Drawing.Point(15, 129);
            this.newFigtherRandomLabel.Name = "newFigtherRandomLabel";
            this.newFigtherRandomLabel.Size = new System.Drawing.Size(225, 13);
            this.newFigtherRandomLabel.TabIndex = 1;
            this.newFigtherRandomLabel.Text = "Вероятность поступления новых раненных";
            // 
            // newFigtherRandomUpDown
            // 
            this.newFigtherRandomUpDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newFigtherRandomUpDown.Location = new System.Drawing.Point(18, 145);
            this.newFigtherRandomUpDown.Name = "newFigtherRandomUpDown";
            this.newFigtherRandomUpDown.Size = new System.Drawing.Size(59, 20);
            this.newFigtherRandomUpDown.TabIndex = 2;
            this.newFigtherRandomUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // healthRangeLabel
            // 
            this.healthRangeLabel.AutoSize = true;
            this.healthRangeLabel.Location = new System.Drawing.Point(15, 168);
            this.healthRangeLabel.Name = "healthRangeLabel";
            this.healthRangeLabel.Size = new System.Drawing.Size(182, 13);
            this.healthRangeLabel.TabIndex = 1;
            this.healthRangeLabel.Text = "Предел здоровья новых ранненых";
            // 
            // healthRangeMinUpDown
            // 
            this.healthRangeMinUpDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.healthRangeMinUpDown.Location = new System.Drawing.Point(15, 184);
            this.healthRangeMinUpDown.Name = "healthRangeMinUpDown";
            this.healthRangeMinUpDown.Size = new System.Drawing.Size(59, 20);
            this.healthRangeMinUpDown.TabIndex = 2;
            this.healthRangeMinUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.healthRangeMinUpDown.ValueChanged += new System.EventHandler(this.healthRangeMinUpDown_ValueChanged);
            // 
            // healthRangeMaxUpDown
            // 
            this.healthRangeMaxUpDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.healthRangeMaxUpDown.Location = new System.Drawing.Point(80, 184);
            this.healthRangeMaxUpDown.Name = "healthRangeMaxUpDown";
            this.healthRangeMaxUpDown.Size = new System.Drawing.Size(59, 20);
            this.healthRangeMaxUpDown.TabIndex = 2;
            this.healthRangeMaxUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.healthRangeMaxUpDown.ValueChanged += new System.EventHandler(this.healthRangeMaxUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FieldHospital.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "FieldHospital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFigtherRandomUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRangeMinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthRangeMaxUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fightersCountеLabelValue;
        private System.Windows.Forms.Label fightersCountLabel;
        private System.Windows.Forms.Label deathCountLabelValue;
        private System.Windows.Forms.Label doctor3SkillLabelValue;
        private System.Windows.Forms.Label doctor2SkillLabelValue;
        private System.Windows.Forms.Label doctor1SkillLabelValue;
        private System.Windows.Forms.Label doctor3CuredCountLabelValue;
        private System.Windows.Forms.Label doctor2CuredCountLabelValue;
        private System.Windows.Forms.Label doctor1CuredCountLabelValue;
        private System.Windows.Forms.Label deathCountLabel;
        private System.Windows.Forms.Label doctor3CuredCountLabel;
        private System.Windows.Forms.Label doctor2CuredCountLabel;
        private System.Windows.Forms.Label doctor1CuredCountLabel;
        private System.Windows.Forms.Label doctor3SkillLabel;
        private System.Windows.Forms.Label doctor2SkillLabel;
        private System.Windows.Forms.Label doctor1SkillLabel;
        private System.Windows.Forms.Label doctor3Label;
        private System.Windows.Forms.Label doctor2Label;
        private System.Windows.Forms.Label doctor1Label;
        private System.Windows.Forms.NumericUpDown newFigtherRandomUpDown;
        private System.Windows.Forms.Label newFigtherRandomLabel;
        private System.Windows.Forms.NumericUpDown healthRangeMaxUpDown;
        private System.Windows.Forms.NumericUpDown healthRangeMinUpDown;
        private System.Windows.Forms.Label healthRangeLabel;
    }
}

