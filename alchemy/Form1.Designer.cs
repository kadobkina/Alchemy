
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
            "f-1;вода",
            "f-2;огонь",
            "f-3;земля",
            "f-4;воздух",
            "f-5;ветер",
            "f-6;давление",
            "f-7;спирт",
            "f-8;море",
            "f-9;пар",
            "f-10;лава",
            "f-11;вулкан",
            "f-12;болото",
            "f-13;камень",
            "f-14;металл",
            "f-15;торф",
            "f-16;остров",
            "f-17;паровой котел",
            "f-18;песок",
            "f-19;пляж",
            "f-20;пыль",
            "f-21;пепел",
            "f-22;порох",
            "f-23;гейзер",
            "f-24;пустыня",
            "f-25;грязь",
            "f-26;дым",
            "f-27;энергия",
            "f-28;буря",
            "f-29;глина",
            "f-30;звук",
            "f-31;облако",
            "f-32;небо",
            "f-33;кирпич",
            "f-34;стекло",
            "f-35;плотина",
            "f-36;взрыв",
            "f-37;водка",
            "f-38;лед",
            "f-39;лампа",
            "f-40;электричество",
            "f-41;жизнь",
            "f-42;бактерии",
            "f-43;водоросли",
            "f-44;голем",
            "f-45;человек",
            "f-46;хижина",
            "f-47;яйцо",
            "f-48;курица",
            "f-49;дилемма",
            "f-50;металлический голем",
            "f-51;лавовый голем",
            "f-52;огненный элементал",
            "f-53;призрак",
            "f-54;семена",
            "f-55;робот",
            "f-56;курятник",
            "f-57;гриб",
            "f-58;динозавр",
            "f-59;инструменты",
            "f-60;оружие",
            "f-61;дерево",
            "f-62;уголь",
            "f-63;труп",
            "f-64;зомби",
            "f-65;алкаш",
            "f-66;могила",
            "f-67;курица-гриль",
            "f-68;птица",
            "f-69;ящерица",
            "f-70;зверь",
            "f-71;кит",
            "f-72;домашний скот",
            "f-73;молоко",
            "f-74;женщина",
            "f-75;самолет",
            "f-76;цветок",
            "f-77;верблюд",
            "f-78;плесень",
            "f-79;планктон",
            "f-80;дракон",
            "f-81;черепаха",
            "f-82;эктоплазма",
            "f-83;энты",
            "f-84;грипп",
            "f-85;озон",
            "f-86;франкенштейн",
            "f-87;гриф",
            "f-88;статуя",
            "f-89;мясо",
            "f-90;шерсть",
            "f-91;нож",
            "f-92;сауна",
            "f-93;древесина",
            "f-94;ткань",
            "f-95;колесо",
            "f-96;охотник",
            "f-97;йод",
            "f-98;окаменелость",
            "f-99;виноград",
            "f-100;пашня",
            "f-101;жареное мясо",
            "f-102;огнестрельное оружие",
            "f-103;воин",
            "f-104;солдат",
            "f-105;кровь",
            "f-106;телега",
            "f-107;червь",
            "f-108;бабочка",
            "f-109;жук",
            "f-110;больной",
            "f-111;прялка",
            "f-112;ракушки",
            "f-113;бумага",
            "f-114;алюминий",
            "f-115;зеркало",
            "f-116;известняк",
            "f-117;вино",
            "f-118;фрукт",
            "f-119;птичий грипп"});
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

