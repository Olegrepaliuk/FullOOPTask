namespace Lab1Classes
{
    partial class FormClasses
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
            this.btCreateDoc = new System.Windows.Forms.Button();
            this.tbDocName = new System.Windows.Forms.TextBox();
            this.tbDocNum = new System.Windows.Forms.TextBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.tbPartNum = new System.Windows.Forms.TextBox();
            this.btCreatePart = new System.Windows.Forms.Button();
            this.tbItmNum = new System.Windows.Forms.TextBox();
            this.tbParText = new System.Windows.Forms.TextBox();
            this.btCreateItm = new System.Windows.Forms.Button();
            this.btCreatePar = new System.Windows.Forms.Button();
            this.LBDocs = new System.Windows.Forms.ListBox();
            this.btDeleteDoc = new System.Windows.Forms.Button();
            this.chbDocIsEdt = new System.Windows.Forms.CheckBox();
            this.btDocEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeletePart = new System.Windows.Forms.Button();
            this.btPartEdit = new System.Windows.Forms.Button();
            this.btDeleteItm = new System.Windows.Forms.Button();
            this.btItmEdit = new System.Windows.Forms.Button();
            this.btDeletePar = new System.Windows.Forms.Button();
            this.btParEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LBParts = new System.Windows.Forms.ListBox();
            this.LBItems = new System.Windows.Forms.ListBox();
            this.LBParagraphs = new System.Windows.Forms.ListBox();
            this.chbShowAll = new System.Windows.Forms.CheckBox();
            this.btLinkDocPrt = new System.Windows.Forms.Button();
            this.btUnlinkDocPrt = new System.Windows.Forms.Button();
            this.btLinkPrtItm = new System.Windows.Forms.Button();
            this.btUnlinkPrtItm = new System.Windows.Forms.Button();
            this.lbStatDoc = new System.Windows.Forms.Label();
            this.btStatDoc = new System.Windows.Forms.Button();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.tbParSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbItmFontSize = new System.Windows.Forms.TextBox();
            this.chbParBold = new System.Windows.Forms.CheckBox();
            this.lbFontSize = new System.Windows.Forms.Label();
            this.chbItmBold = new System.Windows.Forms.CheckBox();
            this.tbParNum = new System.Windows.Forms.TextBox();
            this.lbParNum = new System.Windows.Forms.Label();
            this.btLinkItmPar = new System.Windows.Forms.Button();
            this.btUnlinkItmPar = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.rbMemory = new System.Windows.Forms.RadioButton();
            this.rbXml = new System.Windows.Forms.RadioButton();
            this.rbTxt = new System.Windows.Forms.RadioButton();
            this.lbInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreateDoc
            // 
            this.btCreateDoc.Location = new System.Drawing.Point(127, 306);
            this.btCreateDoc.Name = "btCreateDoc";
            this.btCreateDoc.Size = new System.Drawing.Size(147, 33);
            this.btCreateDoc.TabIndex = 0;
            this.btCreateDoc.Text = "Create";
            this.btCreateDoc.UseVisualStyleBackColor = true;
            this.btCreateDoc.Click += new System.EventHandler(this.btCreateDoc_Click);
            // 
            // tbDocName
            // 
            this.tbDocName.Location = new System.Drawing.Point(133, 56);
            this.tbDocName.Name = "tbDocName";
            this.tbDocName.Size = new System.Drawing.Size(144, 22);
            this.tbDocName.TabIndex = 1;
            // 
            // tbDocNum
            // 
            this.tbDocNum.Location = new System.Drawing.Point(133, 93);
            this.tbDocNum.Name = "tbDocNum";
            this.tbDocNum.Size = new System.Drawing.Size(144, 22);
            this.tbDocNum.TabIndex = 2;
            // 
            // tbPartName
            // 
            this.tbPartName.Location = new System.Drawing.Point(443, 56);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.Size = new System.Drawing.Size(132, 22);
            this.tbPartName.TabIndex = 4;
            // 
            // tbPartNum
            // 
            this.tbPartNum.Location = new System.Drawing.Point(443, 93);
            this.tbPartNum.Name = "tbPartNum";
            this.tbPartNum.Size = new System.Drawing.Size(132, 22);
            this.tbPartNum.TabIndex = 5;
            // 
            // btCreatePart
            // 
            this.btCreatePart.Location = new System.Drawing.Point(443, 306);
            this.btCreatePart.Name = "btCreatePart";
            this.btCreatePart.Size = new System.Drawing.Size(132, 33);
            this.btCreatePart.TabIndex = 6;
            this.btCreatePart.Text = "Create";
            this.btCreatePart.UseVisualStyleBackColor = true;
            this.btCreatePart.Click += new System.EventHandler(this.btCreatePart_Click);
            // 
            // tbItmNum
            // 
            this.tbItmNum.Location = new System.Drawing.Point(714, 56);
            this.tbItmNum.Name = "tbItmNum";
            this.tbItmNum.Size = new System.Drawing.Size(111, 22);
            this.tbItmNum.TabIndex = 7;
            // 
            // tbParText
            // 
            this.tbParText.Location = new System.Drawing.Point(942, 89);
            this.tbParText.Multiline = true;
            this.tbParText.Name = "tbParText";
            this.tbParText.Size = new System.Drawing.Size(156, 62);
            this.tbParText.TabIndex = 8;
            // 
            // btCreateItm
            // 
            this.btCreateItm.Location = new System.Drawing.Point(701, 307);
            this.btCreateItm.Name = "btCreateItm";
            this.btCreateItm.Size = new System.Drawing.Size(124, 32);
            this.btCreateItm.TabIndex = 9;
            this.btCreateItm.Text = "Create";
            this.btCreateItm.UseVisualStyleBackColor = true;
            this.btCreateItm.Click += new System.EventHandler(this.btCreateItm_Click);
            // 
            // btCreatePar
            // 
            this.btCreatePar.Location = new System.Drawing.Point(942, 308);
            this.btCreatePar.Name = "btCreatePar";
            this.btCreatePar.Size = new System.Drawing.Size(156, 31);
            this.btCreatePar.TabIndex = 10;
            this.btCreatePar.Text = "Create";
            this.btCreatePar.UseVisualStyleBackColor = true;
            this.btCreatePar.Click += new System.EventHandler(this.btCreatePar_Click);
            // 
            // LBDocs
            // 
            this.LBDocs.FormattingEnabled = true;
            this.LBDocs.ItemHeight = 16;
            this.LBDocs.Location = new System.Drawing.Point(130, 506);
            this.LBDocs.Name = "LBDocs";
            this.LBDocs.Size = new System.Drawing.Size(144, 276);
            this.LBDocs.TabIndex = 11;
            this.LBDocs.SelectedIndexChanged += new System.EventHandler(this.LBDocs_SelectedIndexChanged);
            // 
            // btDeleteDoc
            // 
            this.btDeleteDoc.Location = new System.Drawing.Point(127, 361);
            this.btDeleteDoc.Name = "btDeleteDoc";
            this.btDeleteDoc.Size = new System.Drawing.Size(147, 35);
            this.btDeleteDoc.TabIndex = 12;
            this.btDeleteDoc.Text = "Delete";
            this.btDeleteDoc.UseVisualStyleBackColor = true;
            this.btDeleteDoc.Click += new System.EventHandler(this.btDeleteDoc_Click);
            // 
            // chbDocIsEdt
            // 
            this.chbDocIsEdt.AutoSize = true;
            this.chbDocIsEdt.Location = new System.Drawing.Point(133, 134);
            this.chbDocIsEdt.Name = "chbDocIsEdt";
            this.chbDocIsEdt.Size = new System.Drawing.Size(81, 21);
            this.chbDocIsEdt.TabIndex = 13;
            this.chbDocIsEdt.Text = "Editable";
            this.chbDocIsEdt.UseVisualStyleBackColor = true;
            // 
            // btDocEdit
            // 
            this.btDocEdit.Location = new System.Drawing.Point(130, 425);
            this.btDocEdit.Name = "btDocEdit";
            this.btDocEdit.Size = new System.Drawing.Size(144, 37);
            this.btDocEdit.TabIndex = 14;
            this.btDocEdit.Text = "Edit";
            this.btDocEdit.UseVisualStyleBackColor = true;
            this.btDocEdit.Click += new System.EventHandler(this.btDocEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Document";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Part";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(979, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Paragraph";
            // 
            // btDeletePart
            // 
            this.btDeletePart.Location = new System.Drawing.Point(443, 361);
            this.btDeletePart.Name = "btDeletePart";
            this.btDeletePart.Size = new System.Drawing.Size(132, 34);
            this.btDeletePart.TabIndex = 19;
            this.btDeletePart.Text = "Delete";
            this.btDeletePart.UseVisualStyleBackColor = true;
            this.btDeletePart.Click += new System.EventHandler(this.btDeletePart_Click);
            // 
            // btPartEdit
            // 
            this.btPartEdit.Location = new System.Drawing.Point(443, 425);
            this.btPartEdit.Name = "btPartEdit";
            this.btPartEdit.Size = new System.Drawing.Size(132, 37);
            this.btPartEdit.TabIndex = 20;
            this.btPartEdit.Text = "Edit";
            this.btPartEdit.UseVisualStyleBackColor = true;
            this.btPartEdit.Click += new System.EventHandler(this.btPartEdit_Click);
            // 
            // btDeleteItm
            // 
            this.btDeleteItm.Location = new System.Drawing.Point(701, 361);
            this.btDeleteItm.Name = "btDeleteItm";
            this.btDeleteItm.Size = new System.Drawing.Size(124, 35);
            this.btDeleteItm.TabIndex = 21;
            this.btDeleteItm.Text = "Delete";
            this.btDeleteItm.UseVisualStyleBackColor = true;
            this.btDeleteItm.Click += new System.EventHandler(this.btDeleteItm_Click);
            // 
            // btItmEdit
            // 
            this.btItmEdit.Location = new System.Drawing.Point(701, 425);
            this.btItmEdit.Name = "btItmEdit";
            this.btItmEdit.Size = new System.Drawing.Size(124, 37);
            this.btItmEdit.TabIndex = 22;
            this.btItmEdit.Text = "Edit";
            this.btItmEdit.UseVisualStyleBackColor = true;
            this.btItmEdit.Click += new System.EventHandler(this.btItmEdit_Click);
            // 
            // btDeletePar
            // 
            this.btDeletePar.Location = new System.Drawing.Point(942, 361);
            this.btDeletePar.Name = "btDeletePar";
            this.btDeletePar.Size = new System.Drawing.Size(156, 35);
            this.btDeletePar.TabIndex = 23;
            this.btDeletePar.Text = "Delete";
            this.btDeletePar.UseVisualStyleBackColor = true;
            this.btDeletePar.Click += new System.EventHandler(this.btDeletePar_Click);
            // 
            // btParEdit
            // 
            this.btParEdit.Location = new System.Drawing.Point(942, 425);
            this.btParEdit.Name = "btParEdit";
            this.btParEdit.Size = new System.Drawing.Size(156, 37);
            this.btParEdit.TabIndex = 24;
            this.btParEdit.Text = "Edit";
            this.btParEdit.UseVisualStyleBackColor = true;
            this.btParEdit.Click += new System.EventHandler(this.btParEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(901, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Text";
            // 
            // LBParts
            // 
            this.LBParts.FormattingEnabled = true;
            this.LBParts.ItemHeight = 16;
            this.LBParts.Location = new System.Drawing.Point(443, 506);
            this.LBParts.Name = "LBParts";
            this.LBParts.Size = new System.Drawing.Size(132, 276);
            this.LBParts.TabIndex = 31;
            this.LBParts.SelectedIndexChanged += new System.EventHandler(this.LBParts_SelectedIndexChanged);
            // 
            // LBItems
            // 
            this.LBItems.FormattingEnabled = true;
            this.LBItems.ItemHeight = 16;
            this.LBItems.Location = new System.Drawing.Point(701, 506);
            this.LBItems.Name = "LBItems";
            this.LBItems.Size = new System.Drawing.Size(124, 276);
            this.LBItems.TabIndex = 32;
            this.LBItems.SelectedIndexChanged += new System.EventHandler(this.LBItems_SelectedIndexChanged);
            // 
            // LBParagraphs
            // 
            this.LBParagraphs.FormattingEnabled = true;
            this.LBParagraphs.ItemHeight = 16;
            this.LBParagraphs.Location = new System.Drawing.Point(942, 506);
            this.LBParagraphs.Name = "LBParagraphs";
            this.LBParagraphs.Size = new System.Drawing.Size(156, 276);
            this.LBParagraphs.TabIndex = 33;
            this.LBParagraphs.SelectedIndexChanged += new System.EventHandler(this.LBParagraphs_SelectedIndexChanged);
            // 
            // chbShowAll
            // 
            this.chbShowAll.AutoSize = true;
            this.chbShowAll.Location = new System.Drawing.Point(553, 479);
            this.chbShowAll.Name = "chbShowAll";
            this.chbShowAll.Size = new System.Drawing.Size(183, 21);
            this.chbShowAll.TabIndex = 34;
            this.chbShowAll.Text = "Show all parts and items";
            this.chbShowAll.UseVisualStyleBackColor = true;
            this.chbShowAll.CheckedChanged += new System.EventHandler(this.chbShowAll_CheckedChanged);
            // 
            // btLinkDocPrt
            // 
            this.btLinkDocPrt.Location = new System.Drawing.Point(322, 555);
            this.btLinkDocPrt.Name = "btLinkDocPrt";
            this.btLinkDocPrt.Size = new System.Drawing.Size(75, 23);
            this.btLinkDocPrt.TabIndex = 35;
            this.btLinkDocPrt.Text = "Link";
            this.btLinkDocPrt.UseVisualStyleBackColor = true;
            this.btLinkDocPrt.Click += new System.EventHandler(this.btLinkDocPrt_Click);
            // 
            // btUnlinkDocPrt
            // 
            this.btUnlinkDocPrt.Location = new System.Drawing.Point(322, 584);
            this.btUnlinkDocPrt.Name = "btUnlinkDocPrt";
            this.btUnlinkDocPrt.Size = new System.Drawing.Size(75, 23);
            this.btUnlinkDocPrt.TabIndex = 36;
            this.btUnlinkDocPrt.Text = "Unlink";
            this.btUnlinkDocPrt.UseVisualStyleBackColor = true;
            this.btUnlinkDocPrt.Click += new System.EventHandler(this.btUnlinkDocPrt_Click);
            // 
            // btLinkPrtItm
            // 
            this.btLinkPrtItm.Location = new System.Drawing.Point(604, 555);
            this.btLinkPrtItm.Name = "btLinkPrtItm";
            this.btLinkPrtItm.Size = new System.Drawing.Size(75, 23);
            this.btLinkPrtItm.TabIndex = 38;
            this.btLinkPrtItm.Text = "Link";
            this.btLinkPrtItm.UseVisualStyleBackColor = true;
            this.btLinkPrtItm.Click += new System.EventHandler(this.btLinkPrtItm_Click);
            // 
            // btUnlinkPrtItm
            // 
            this.btUnlinkPrtItm.Location = new System.Drawing.Point(604, 584);
            this.btUnlinkPrtItm.Name = "btUnlinkPrtItm";
            this.btUnlinkPrtItm.Size = new System.Drawing.Size(75, 23);
            this.btUnlinkPrtItm.TabIndex = 39;
            this.btUnlinkPrtItm.Text = "Unlink";
            this.btUnlinkPrtItm.UseVisualStyleBackColor = true;
            this.btUnlinkPrtItm.Click += new System.EventHandler(this.btUnlinkPrtItm_Click);
            // 
            // lbStatDoc
            // 
            this.lbStatDoc.AutoSize = true;
            this.lbStatDoc.Location = new System.Drawing.Point(1171, 396);
            this.lbStatDoc.Name = "lbStatDoc";
            this.lbStatDoc.Size = new System.Drawing.Size(0, 17);
            this.lbStatDoc.TabIndex = 40;
            // 
            // btStatDoc
            // 
            this.btStatDoc.Location = new System.Drawing.Point(1232, 56);
            this.btStatDoc.Name = "btStatDoc";
            this.btStatDoc.Size = new System.Drawing.Size(97, 39);
            this.btStatDoc.TabIndex = 41;
            this.btStatDoc.Text = "Get Stats";
            this.btStatDoc.UseVisualStyleBackColor = true;
            this.btStatDoc.Click += new System.EventHandler(this.btStatDoc_Click);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(280, 287);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(76, 21);
            this.rbCustom.TabIndex = 42;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(280, 314);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(74, 21);
            this.rbDefault.TabIndex = 43;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default";
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(280, 341);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.ReadOnly = true;
            this.nudAmount.Size = new System.Drawing.Size(120, 22);
            this.nudAmount.TabIndex = 44;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbParSize
            // 
            this.tbParSize.Location = new System.Drawing.Point(942, 157);
            this.tbParSize.Name = "tbParSize";
            this.tbParSize.Size = new System.Drawing.Size(156, 22);
            this.tbParSize.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(871, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Font size";
            // 
            // tbItmFontSize
            // 
            this.tbItmFontSize.Location = new System.Drawing.Point(714, 96);
            this.tbItmFontSize.Name = "tbItmFontSize";
            this.tbItmFontSize.Size = new System.Drawing.Size(111, 22);
            this.tbItmFontSize.TabIndex = 47;
            // 
            // chbParBold
            // 
            this.chbParBold.AutoSize = true;
            this.chbParBold.Location = new System.Drawing.Point(942, 185);
            this.chbParBold.Name = "chbParBold";
            this.chbParBold.Size = new System.Drawing.Size(58, 21);
            this.chbParBold.TabIndex = 48;
            this.chbParBold.Text = "Bold";
            this.chbParBold.UseVisualStyleBackColor = true;
            // 
            // lbFontSize
            // 
            this.lbFontSize.AutoSize = true;
            this.lbFontSize.Location = new System.Drawing.Point(643, 98);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(65, 17);
            this.lbFontSize.TabIndex = 49;
            this.lbFontSize.Text = "Font size";
            // 
            // chbItmBold
            // 
            this.chbItmBold.AutoSize = true;
            this.chbItmBold.Location = new System.Drawing.Point(714, 133);
            this.chbItmBold.Name = "chbItmBold";
            this.chbItmBold.Size = new System.Drawing.Size(58, 21);
            this.chbItmBold.TabIndex = 50;
            this.chbItmBold.Text = "Bold";
            this.chbItmBold.UseVisualStyleBackColor = true;
            // 
            // tbParNum
            // 
            this.tbParNum.Location = new System.Drawing.Point(942, 56);
            this.tbParNum.Name = "tbParNum";
            this.tbParNum.Size = new System.Drawing.Size(156, 22);
            this.tbParNum.TabIndex = 51;
            // 
            // lbParNum
            // 
            this.lbParNum.AutoSize = true;
            this.lbParNum.Location = new System.Drawing.Point(871, 59);
            this.lbParNum.Name = "lbParNum";
            this.lbParNum.Size = new System.Drawing.Size(58, 17);
            this.lbParNum.TabIndex = 52;
            this.lbParNum.Text = "Number";
            // 
            // btLinkItmPar
            // 
            this.btLinkItmPar.Location = new System.Drawing.Point(854, 555);
            this.btLinkItmPar.Name = "btLinkItmPar";
            this.btLinkItmPar.Size = new System.Drawing.Size(75, 23);
            this.btLinkItmPar.TabIndex = 53;
            this.btLinkItmPar.Text = "Link";
            this.btLinkItmPar.UseVisualStyleBackColor = true;
            this.btLinkItmPar.Click += new System.EventHandler(this.btLinkItmPar_Click);
            // 
            // btUnlinkItmPar
            // 
            this.btUnlinkItmPar.Location = new System.Drawing.Point(854, 584);
            this.btUnlinkItmPar.Name = "btUnlinkItmPar";
            this.btUnlinkItmPar.Size = new System.Drawing.Size(75, 23);
            this.btUnlinkItmPar.TabIndex = 54;
            this.btUnlinkItmPar.Text = "Unlink";
            this.btUnlinkItmPar.UseVisualStyleBackColor = true;
            this.btUnlinkItmPar.Click += new System.EventHandler(this.btUnlinkItmPar_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(1194, 361);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(147, 33);
            this.btLoad.TabIndex = 55;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(1194, 308);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(147, 33);
            this.btSave.TabIndex = 56;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // rbMemory
            // 
            this.rbMemory.AutoSize = true;
            this.rbMemory.Location = new System.Drawing.Point(1364, 308);
            this.rbMemory.Name = "rbMemory";
            this.rbMemory.Size = new System.Drawing.Size(79, 21);
            this.rbMemory.TabIndex = 57;
            this.rbMemory.TabStop = true;
            this.rbMemory.Text = "Memory";
            this.rbMemory.UseVisualStyleBackColor = true;
            // 
            // rbXml
            // 
            this.rbXml.AutoSize = true;
            this.rbXml.Location = new System.Drawing.Point(1364, 341);
            this.rbXml.Name = "rbXml";
            this.rbXml.Size = new System.Drawing.Size(79, 21);
            this.rbXml.TabIndex = 58;
            this.rbXml.TabStop = true;
            this.rbXml.Text = "XML file";
            this.rbXml.UseVisualStyleBackColor = true;
            // 
            // rbTxt
            // 
            this.rbTxt.AutoSize = true;
            this.rbTxt.Location = new System.Drawing.Point(1365, 373);
            this.rbTxt.Name = "rbTxt";
            this.rbTxt.Size = new System.Drawing.Size(78, 21);
            this.rbTxt.TabIndex = 59;
            this.rbTxt.TabStop = true;
            this.rbTxt.Text = "TXT file";
            this.rbTxt.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(1191, 251);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            this.lbInfo.TabIndex = 60;
            // 
            // FormClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1045);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.rbTxt);
            this.Controls.Add(this.rbXml);
            this.Controls.Add(this.rbMemory);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btUnlinkItmPar);
            this.Controls.Add(this.btLinkItmPar);
            this.Controls.Add(this.lbParNum);
            this.Controls.Add(this.tbParNum);
            this.Controls.Add(this.chbItmBold);
            this.Controls.Add(this.lbFontSize);
            this.Controls.Add(this.chbParBold);
            this.Controls.Add(this.tbItmFontSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbParSize);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.rbDefault);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.btStatDoc);
            this.Controls.Add(this.lbStatDoc);
            this.Controls.Add(this.btUnlinkPrtItm);
            this.Controls.Add(this.btLinkPrtItm);
            this.Controls.Add(this.btUnlinkDocPrt);
            this.Controls.Add(this.btLinkDocPrt);
            this.Controls.Add(this.chbShowAll);
            this.Controls.Add(this.LBParagraphs);
            this.Controls.Add(this.LBItems);
            this.Controls.Add(this.LBParts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btParEdit);
            this.Controls.Add(this.btDeletePar);
            this.Controls.Add(this.btItmEdit);
            this.Controls.Add(this.btDeleteItm);
            this.Controls.Add(this.btPartEdit);
            this.Controls.Add(this.btDeletePart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDocEdit);
            this.Controls.Add(this.chbDocIsEdt);
            this.Controls.Add(this.btDeleteDoc);
            this.Controls.Add(this.LBDocs);
            this.Controls.Add(this.btCreatePar);
            this.Controls.Add(this.btCreateItm);
            this.Controls.Add(this.tbParText);
            this.Controls.Add(this.tbItmNum);
            this.Controls.Add(this.btCreatePart);
            this.Controls.Add(this.tbPartNum);
            this.Controls.Add(this.tbPartName);
            this.Controls.Add(this.tbDocNum);
            this.Controls.Add(this.tbDocName);
            this.Controls.Add(this.btCreateDoc);
            this.Name = "FormClasses";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClasses_FormClosing);
            this.Load += new System.EventHandler(this.FormClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateDoc;
        private System.Windows.Forms.TextBox tbDocName;
        private System.Windows.Forms.TextBox tbDocNum;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.TextBox tbPartNum;
        private System.Windows.Forms.Button btCreatePart;
        private System.Windows.Forms.TextBox tbItmNum;
        private System.Windows.Forms.TextBox tbParText;
        private System.Windows.Forms.Button btCreateItm;
        private System.Windows.Forms.Button btCreatePar;
        public System.Windows.Forms.ListBox LBDocs;
        private System.Windows.Forms.Button btDeleteDoc;
        private System.Windows.Forms.CheckBox chbDocIsEdt;
        private System.Windows.Forms.Button btDocEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeletePart;
        private System.Windows.Forms.Button btPartEdit;
        private System.Windows.Forms.Button btDeleteItm;
        private System.Windows.Forms.Button btItmEdit;
        private System.Windows.Forms.Button btDeletePar;
        private System.Windows.Forms.Button btParEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LBParts;
        private System.Windows.Forms.ListBox LBItems;
        private System.Windows.Forms.ListBox LBParagraphs;
        private System.Windows.Forms.CheckBox chbShowAll;
        private System.Windows.Forms.Button btLinkDocPrt;
        private System.Windows.Forms.Button btUnlinkDocPrt;
        private System.Windows.Forms.Button btLinkPrtItm;
        private System.Windows.Forms.Button btUnlinkPrtItm;
        private System.Windows.Forms.Label lbStatDoc;
        private System.Windows.Forms.Button btStatDoc;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox tbParSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbItmFontSize;
        private System.Windows.Forms.CheckBox chbParBold;
        private System.Windows.Forms.Label lbFontSize;
        private System.Windows.Forms.CheckBox chbItmBold;
        private System.Windows.Forms.TextBox tbParNum;
        private System.Windows.Forms.Label lbParNum;
        private System.Windows.Forms.Button btLinkItmPar;
        private System.Windows.Forms.Button btUnlinkItmPar;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RadioButton rbMemory;
        private System.Windows.Forms.RadioButton rbXml;
        private System.Windows.Forms.RadioButton rbTxt;
        private System.Windows.Forms.Label lbInfo;
    }
}

