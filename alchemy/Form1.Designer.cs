
namespace alchemy
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
            this.checkedListBoxFacts = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.buttonCheckSolution = new System.Windows.Forms.Button();
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkedListBoxFacts
            // 
            this.checkedListBoxFacts.FormattingEnabled = true;
            this.checkedListBoxFacts.Items.AddRange(new object[] {
            "f-1;Вода",
            "f-2;Огонь",
            "f-3;Земля",
            "f-4;Воздух",
            "f-5;Ветер",
            "f-6;Давление",
            "f-7;Спирт",
            "f-8;Море",
            "f-9;Пар",
            "f-10;Лава",
            "f-11;Вулкан",
            "f-12;Болото",
            "f-13;Камень",
            "f-14;Металл",
            "f-15;Торф",
            "f-16;Остров",
            "f-17;Паровой котел",
            "f-18;Песок",
            "f-19;Пляж",
            "f-20;Пыль",
            "f-21;Пепел",
            "f-22;Порох",
            "f-23;Гейзер",
            "f-24;Пустыня",
            "f-25;Грязь",
            "f-26;Дым",
            "f-27;Энергия",
            "f-28;Буря",
            "f-29;Глина",
            "f-30;Звук",
            "f-31;Облако",
            "f-32;Небо",
            "f-33;Кирпич",
            "f-34;Стекло",
            "f-35;Плотина",
            "f-36;Взрыв",
            "f-37;Водка",
            "f-38;Лед",
            "f-39;Лампа",
            "f-40;Электричество",
            "f-41;Жизнь",
            "f-42;Бактерии",
            "f-43;Водоросли",
            "f-44;Голем",
            "f-45;Человек",
            "f-46;Хижина",
            "f-47;Яйцо",
            "f-48;Курица",
            "f-49;Дилемма",
            "f-50;Металлический голем",
            "f-51;Лавовый голем",
            "f-52;Огненный элементал",
            "f-53;Призрак",
            "f-54;Семена",
            "f-55;Робот",
            "f-56;Курятник",
            "f-57;Гриб",
            "f-58;Динозавр",
            "f-59;Инструменты",
            "f-60;Оружие",
            "f-61;Дерево",
            "f-62;Уголь",
            "f-63;Труп",
            "f-64;Зомби",
            "f-65;Алкаш",
            "f-66;Могила",
            "f-67;Курица-гриль",
            "f-68;Птица",
            "f-69;Ящерица",
            "f-70;Зверь",
            "f-71;Кит",
            "f-72;Домашний скот",
            "f-73;Молоко",
            "f-74;Женщина",
            "f-75;Самолет",
            "f-76;Цветок",
            "f-77;Верблюд",
            "f-78;Плесень",
            "f-79;Планктон",
            "f-80;Дракон",
            "f-81;Черепаха",
            "f-82;Эктоплазма",
            "f-83;Энты",
            "f-84;Грипп",
            "f-85;Озон",
            "f-86;Франкенштейн",
            "f-87;Гриф",
            "f-88;Статуя",
            "f-89;Мясо",
            "f-90;Шерсть",
            "f-91;Нож",
            "f-92;Сауна",
            "f-93;Древесина",
            "f-94;Ткань",
            "f-95;Колесо",
            "f-96;Охотник",
            "f-97;Йод",
            "f-98;Окаменелость",
            "f-99;Виноград",
            "f-100;Пашня",
            "f-101;Жареное мясо",
            "f-102;Огнестрельное оружие",
            "f-103;Воин",
            "f-104;Солдат",
            "f-105;Кровь",
            "f-106;Телега",
            "f-107;Червь",
            "f-108;Бабочка",
            "f-109;Жук",
            "f-110;Больной",
            "f-111;Прялка",
            "f-112;Ракушки",
            "f-113;Бумага",
            "f-114;Алюминий",
            "f-115;Зеркало",
            "f-116;Известняк",
            "f-117;Вино",
            "f-118;Фрукт",
            "f-119;Птичий грипп"});
            this.checkedListBoxFacts.Location = new System.Drawing.Point(12, 40);
            this.checkedListBoxFacts.Name = "checkedListBoxFacts";
            this.checkedListBoxFacts.ScrollAlwaysVisible = true;
            this.checkedListBoxFacts.Size = new System.Drawing.Size(203, 394);
            this.checkedListBoxFacts.TabIndex = 0;
            this.checkedListBoxFacts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFacts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Что у нас есть?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Что хотим получить?";
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Items.AddRange(new object[] {
            "Алкаш ",
            "Алюминий",
            "Бабочка",
            "Бактерии",
            "Болото",
            "Больной ",
            "Бумага ",
            "Буря",
            "Верблюд",
            "Ветер",
            "Взрыв",
            "Вино",
            "Виноград ",
            "Водка ",
            "Водоросли",
            "Воин",
            "Вулкан",
            "Гейзер",
            "Глина",
            "Голем",
            "Гриб",
            "Грипп ",
            "Гриф",
            "Грязь",
            "Давление ",
            "Дерево",
            "Дилемма",
            "Динозавр",
            "Домашний скот",
            "Древесина",
            "Дым",
            "Жареное мясо",
            "Женщина",
            "Жизнь",
            "Жук",
            "Зверь",
            "Звук",
            "Зеркало",
            "Зомби",
            "Известняк",
            "Инструменты",
            "Йод ",
            "Камень",
            "Кирпич",
            "Кит ",
            "Колесо",
            "Кровь ",
            "Курица",
            "Курица-гриль",
            "Курятник",
            "Лава",
            "Лавовый голем",
            "Лампа",
            "Лед",
            "Металл",
            "Металлический голем",
            "Могила",
            "Молоко",
            "Море",
            "Мясо",
            "Небо",
            "Нож",
            "Облако ",
            "Огненный голем",
            "Огнестрельное оружие",
            "Озон ",
            "Окаменелость",
            "Оружие",
            "Остров",
            "Охотник",
            "Пар ",
            "Паровой котел",
            "Пашня",
            "Пепел",
            "Песок",
            "Планктон ",
            "Плесень",
            "Плотина",
            "Пляж",
            "Порох",
            "Призрак",
            "Прялка",
            "Птица",
            "Птичий грипп",
            "Пустыня",
            "Пыль",
            "Ракушки",
            "Робот",
            "Самолет",
            "Сауна",
            "Семена",
            "Солдат",
            "Солдат",
            "Спирт",
            "Статуя ",
            "Стекло",
            "Телега",
            "Ткань",
            "Торф",
            "Труп",
            "Уголь",
            "Франкенштейн",
            "Фрукт ",
            "Хижина",
            "Цветок ",
            "Человек ",
            "Червь",
            "Черепаха",
            "Шерсть",
            "Эктоплазма ",
            "Электричество ",
            "Энергия",
            "Энты",
            "Яйцо",
            "Ящерица"});
            this.comboBoxOutput.Location = new System.Drawing.Point(269, 61);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(159, 21);
            this.comboBoxOutput.TabIndex = 3;
            this.comboBoxOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutput_SelectedIndexChanged);
            // 
            // buttonCheckSolution
            // 
            this.buttonCheckSolution.Enabled = false;
            this.buttonCheckSolution.Location = new System.Drawing.Point(482, 40);
            this.buttonCheckSolution.Name = "buttonCheckSolution";
            this.buttonCheckSolution.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckSolution.TabIndex = 4;
            this.buttonCheckSolution.Text = "Проверить";
            this.buttonCheckSolution.UseVisualStyleBackColor = true;
            this.buttonCheckSolution.Click += new System.EventHandler(this.buttonCheckSolution_Click);
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(232, 105);
            this.textBoxSolution.Multiline = true;
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(556, 329);
            this.textBoxSolution.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSolution);
            this.Controls.Add(this.buttonCheckSolution);
            this.Controls.Add(this.comboBoxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxFacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFacts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.Button buttonCheckSolution;
        private System.Windows.Forms.TextBox textBoxSolution;
    }
}

