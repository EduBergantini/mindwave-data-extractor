namespace BrainsOfTomorrow.MindWave
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.systemVersionLabel = new System.Windows.Forms.Label();
            this.saveLogCheckBox = new System.Windows.Forms.CheckBox();
            this.thinkGearDataPanel = new System.Windows.Forms.Panel();
            this.thetaValueLabel = new System.Windows.Forms.Label();
            this.thetaDescLabel = new System.Windows.Forms.Label();
            this.deltaValueLabel = new System.Windows.Forms.Label();
            this.deltaDescLabel = new System.Windows.Forms.Label();
            this.gammaLowerValueLabel = new System.Windows.Forms.Label();
            this.gammaLowerDescLabel = new System.Windows.Forms.Label();
            this.gammaUpperValueLabel = new System.Windows.Forms.Label();
            this.gammaUpperDescLabel = new System.Windows.Forms.Label();
            this.betaLowerValueLabel = new System.Windows.Forms.Label();
            this.betaLowerDescLabel = new System.Windows.Forms.Label();
            this.betaUpperValueLabel = new System.Windows.Forms.Label();
            this.betaUpperDescLabel = new System.Windows.Forms.Label();
            this.alphaLowerValueLabel = new System.Windows.Forms.Label();
            this.alphaLowerDescLabel = new System.Windows.Forms.Label();
            this.alphaUpperValueLabel = new System.Windows.Forms.Label();
            this.alphaUpperDescLabel = new System.Windows.Forms.Label();
            this.baseValuesDescLabel = new System.Windows.Forms.Label();
            this.blinkValueLabel = new System.Windows.Forms.Label();
            this.blinkDescLabel = new System.Windows.Forms.Label();
            this.meditationValueLabel = new System.Windows.Forms.Label();
            this.meditationDescLabel = new System.Windows.Forms.Label();
            this.attentionValueLabel = new System.Windows.Forms.Label();
            this.attentionDescLabel = new System.Windows.Forms.Label();
            this.signalValueLabel = new System.Windows.Forms.Label();
            this.signalDescLabel = new System.Windows.Forms.Label();
            this.batteryValueLabel = new System.Windows.Forms.Label();
            this.batteryDescLabel = new System.Windows.Forms.Label();
            this.thinkGearVersionValueLabel = new System.Windows.Forms.Label();
            this.thinkGearVersionDescLabel = new System.Windows.Forms.Label();
            this.enableBlinkCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.windowsCodeTab = new System.Windows.Forms.TabPage();
            this.arduinoComPortTab = new System.Windows.Forms.TabPage();
            this.arduinoPortsComboBox = new System.Windows.Forms.ComboBox();
            this.arduinoConnectButton = new System.Windows.Forms.Button();
            this.arduinoDisconnectButton = new System.Windows.Forms.Button();
            this.thinkGearDataPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.windowsCodeTab.SuspendLayout();
            this.arduinoComPortTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 37);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(85, 32);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.OnConnectButtonClick);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(97, 37);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(117, 32);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Desconectar";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.OnDisconnectButtonClick);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(6, 6);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(208, 29);
            this.comPortComboBox.TabIndex = 1;
            // 
            // systemVersionLabel
            // 
            this.systemVersionLabel.AutoSize = true;
            this.systemVersionLabel.Location = new System.Drawing.Point(229, 374);
            this.systemVersionLabel.Name = "systemVersionLabel";
            this.systemVersionLabel.Size = new System.Drawing.Size(207, 23);
            this.systemVersionLabel.TabIndex = 35;
            this.systemVersionLabel.Text = "Versão do Sistema: 1.0.0.0";
            // 
            // saveLogCheckBox
            // 
            this.saveLogCheckBox.AutoSize = true;
            this.saveLogCheckBox.Checked = true;
            this.saveLogCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveLogCheckBox.Location = new System.Drawing.Point(220, 3);
            this.saveLogCheckBox.Name = "saveLogCheckBox";
            this.saveLogCheckBox.Size = new System.Drawing.Size(213, 27);
            this.saveLogCheckBox.TabIndex = 4;
            this.saveLogCheckBox.Text = "Registrar comunicação?";
            this.saveLogCheckBox.UseVisualStyleBackColor = true;
            // 
            // thinkGearDataPanel
            // 
            this.thinkGearDataPanel.Controls.Add(this.thetaValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.thetaDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.deltaValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.deltaDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.gammaLowerValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.gammaLowerDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.gammaUpperValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.gammaUpperDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.betaLowerValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.betaLowerDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.betaUpperValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.betaUpperDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.alphaLowerValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.alphaLowerDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.alphaUpperValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.alphaUpperDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.baseValuesDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.blinkValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.blinkDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.meditationValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.meditationDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.attentionValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.attentionDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.signalValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.signalDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.batteryValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.batteryDescLabel);
            this.thinkGearDataPanel.Controls.Add(this.thinkGearVersionValueLabel);
            this.thinkGearDataPanel.Controls.Add(this.thinkGearVersionDescLabel);
            this.thinkGearDataPanel.Location = new System.Drawing.Point(6, 75);
            this.thinkGearDataPanel.Name = "thinkGearDataPanel";
            this.thinkGearDataPanel.Size = new System.Drawing.Size(427, 285);
            this.thinkGearDataPanel.TabIndex = 5;
            // 
            // thetaValueLabel
            // 
            this.thetaValueLabel.AutoSize = true;
            this.thetaValueLabel.Location = new System.Drawing.Point(348, 248);
            this.thetaValueLabel.Name = "thetaValueLabel";
            this.thetaValueLabel.Size = new System.Drawing.Size(64, 23);
            this.thetaValueLabel.TabIndex = 34;
            this.thetaValueLabel.Text = "123456";
            // 
            // thetaDescLabel
            // 
            this.thetaDescLabel.AutoSize = true;
            this.thetaDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thetaDescLabel.Location = new System.Drawing.Point(282, 248);
            this.thetaDescLabel.Name = "thetaDescLabel";
            this.thetaDescLabel.Size = new System.Drawing.Size(60, 23);
            this.thetaDescLabel.TabIndex = 33;
            this.thetaDescLabel.Text = "Theta:";
            // 
            // deltaValueLabel
            // 
            this.deltaValueLabel.AutoSize = true;
            this.deltaValueLabel.Location = new System.Drawing.Point(135, 248);
            this.deltaValueLabel.Name = "deltaValueLabel";
            this.deltaValueLabel.Size = new System.Drawing.Size(64, 23);
            this.deltaValueLabel.TabIndex = 32;
            this.deltaValueLabel.Text = "123456";
            // 
            // deltaDescLabel
            // 
            this.deltaDescLabel.AutoSize = true;
            this.deltaDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deltaDescLabel.Location = new System.Drawing.Point(71, 248);
            this.deltaDescLabel.Name = "deltaDescLabel";
            this.deltaDescLabel.Size = new System.Drawing.Size(58, 23);
            this.deltaDescLabel.TabIndex = 31;
            this.deltaDescLabel.Text = "Delta:";
            // 
            // gammaLowerValueLabel
            // 
            this.gammaLowerValueLabel.AutoSize = true;
            this.gammaLowerValueLabel.Location = new System.Drawing.Point(348, 217);
            this.gammaLowerValueLabel.Name = "gammaLowerValueLabel";
            this.gammaLowerValueLabel.Size = new System.Drawing.Size(64, 23);
            this.gammaLowerValueLabel.TabIndex = 30;
            this.gammaLowerValueLabel.Text = "123456";
            // 
            // gammaLowerDescLabel
            // 
            this.gammaLowerDescLabel.AutoSize = true;
            this.gammaLowerDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gammaLowerDescLabel.Location = new System.Drawing.Point(217, 217);
            this.gammaLowerDescLabel.Name = "gammaLowerDescLabel";
            this.gammaLowerDescLabel.Size = new System.Drawing.Size(125, 23);
            this.gammaLowerDescLabel.TabIndex = 29;
            this.gammaLowerDescLabel.Text = "Gamma Baixa:";
            // 
            // gammaUpperValueLabel
            // 
            this.gammaUpperValueLabel.AutoSize = true;
            this.gammaUpperValueLabel.Location = new System.Drawing.Point(135, 217);
            this.gammaUpperValueLabel.Name = "gammaUpperValueLabel";
            this.gammaUpperValueLabel.Size = new System.Drawing.Size(64, 23);
            this.gammaUpperValueLabel.TabIndex = 28;
            this.gammaUpperValueLabel.Text = "123456";
            // 
            // gammaUpperDescLabel
            // 
            this.gammaUpperDescLabel.AutoSize = true;
            this.gammaUpperDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gammaUpperDescLabel.Location = new System.Drawing.Point(19, 217);
            this.gammaUpperDescLabel.Name = "gammaUpperDescLabel";
            this.gammaUpperDescLabel.Size = new System.Drawing.Size(115, 23);
            this.gammaUpperDescLabel.TabIndex = 27;
            this.gammaUpperDescLabel.Text = "Gamma Alta:";
            // 
            // betaLowerValueLabel
            // 
            this.betaLowerValueLabel.AutoSize = true;
            this.betaLowerValueLabel.Location = new System.Drawing.Point(348, 183);
            this.betaLowerValueLabel.Name = "betaLowerValueLabel";
            this.betaLowerValueLabel.Size = new System.Drawing.Size(64, 23);
            this.betaLowerValueLabel.TabIndex = 26;
            this.betaLowerValueLabel.Text = "123456";
            // 
            // betaLowerDescLabel
            // 
            this.betaLowerDescLabel.AutoSize = true;
            this.betaLowerDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaLowerDescLabel.Location = new System.Drawing.Point(243, 183);
            this.betaLowerDescLabel.Name = "betaLowerDescLabel";
            this.betaLowerDescLabel.Size = new System.Drawing.Size(99, 23);
            this.betaLowerDescLabel.TabIndex = 25;
            this.betaLowerDescLabel.Text = "Beta Baixa:";
            // 
            // betaUpperValueLabel
            // 
            this.betaUpperValueLabel.AutoSize = true;
            this.betaUpperValueLabel.Location = new System.Drawing.Point(135, 183);
            this.betaUpperValueLabel.Name = "betaUpperValueLabel";
            this.betaUpperValueLabel.Size = new System.Drawing.Size(64, 23);
            this.betaUpperValueLabel.TabIndex = 24;
            this.betaUpperValueLabel.Text = "123456";
            // 
            // betaUpperDescLabel
            // 
            this.betaUpperDescLabel.AutoSize = true;
            this.betaUpperDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betaUpperDescLabel.Location = new System.Drawing.Point(45, 183);
            this.betaUpperDescLabel.Name = "betaUpperDescLabel";
            this.betaUpperDescLabel.Size = new System.Drawing.Size(89, 23);
            this.betaUpperDescLabel.TabIndex = 23;
            this.betaUpperDescLabel.Text = "Beta Alta:";
            // 
            // alphaLowerValueLabel
            // 
            this.alphaLowerValueLabel.AutoSize = true;
            this.alphaLowerValueLabel.Location = new System.Drawing.Point(348, 150);
            this.alphaLowerValueLabel.Name = "alphaLowerValueLabel";
            this.alphaLowerValueLabel.Size = new System.Drawing.Size(64, 23);
            this.alphaLowerValueLabel.TabIndex = 22;
            this.alphaLowerValueLabel.Text = "123456";
            // 
            // alphaLowerDescLabel
            // 
            this.alphaLowerDescLabel.AutoSize = true;
            this.alphaLowerDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaLowerDescLabel.Location = new System.Drawing.Point(246, 150);
            this.alphaLowerDescLabel.Name = "alphaLowerDescLabel";
            this.alphaLowerDescLabel.Size = new System.Drawing.Size(96, 23);
            this.alphaLowerDescLabel.TabIndex = 21;
            this.alphaLowerDescLabel.Text = "Alfa Baixa:";
            // 
            // alphaUpperValueLabel
            // 
            this.alphaUpperValueLabel.AutoSize = true;
            this.alphaUpperValueLabel.Location = new System.Drawing.Point(135, 150);
            this.alphaUpperValueLabel.Name = "alphaUpperValueLabel";
            this.alphaUpperValueLabel.Size = new System.Drawing.Size(64, 23);
            this.alphaUpperValueLabel.TabIndex = 20;
            this.alphaUpperValueLabel.Text = "123456";
            // 
            // alphaUpperDescLabel
            // 
            this.alphaUpperDescLabel.AutoSize = true;
            this.alphaUpperDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaUpperDescLabel.Location = new System.Drawing.Point(48, 150);
            this.alphaUpperDescLabel.Name = "alphaUpperDescLabel";
            this.alphaUpperDescLabel.Size = new System.Drawing.Size(86, 23);
            this.alphaUpperDescLabel.TabIndex = 19;
            this.alphaUpperDescLabel.Text = "Alfa Alta:";
            // 
            // baseValuesDescLabel
            // 
            this.baseValuesDescLabel.AutoSize = true;
            this.baseValuesDescLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseValuesDescLabel.Location = new System.Drawing.Point(62, 108);
            this.baseValuesDescLabel.Name = "baseValuesDescLabel";
            this.baseValuesDescLabel.Size = new System.Drawing.Size(257, 28);
            this.baseValuesDescLabel.TabIndex = 18;
            this.baseValuesDescLabel.Text = "Valores base encontrados.";
            // 
            // blinkValueLabel
            // 
            this.blinkValueLabel.AutoSize = true;
            this.blinkValueLabel.Location = new System.Drawing.Point(348, 71);
            this.blinkValueLabel.Name = "blinkValueLabel";
            this.blinkValueLabel.Size = new System.Drawing.Size(64, 23);
            this.blinkValueLabel.TabIndex = 17;
            this.blinkValueLabel.Text = "123456";
            // 
            // blinkDescLabel
            // 
            this.blinkDescLabel.AutoSize = true;
            this.blinkDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blinkDescLabel.Location = new System.Drawing.Point(266, 71);
            this.blinkDescLabel.Name = "blinkDescLabel";
            this.blinkDescLabel.Size = new System.Drawing.Size(74, 23);
            this.blinkDescLabel.TabIndex = 16;
            this.blinkDescLabel.Text = "Piscada:";
            // 
            // meditationValueLabel
            // 
            this.meditationValueLabel.AutoSize = true;
            this.meditationValueLabel.Location = new System.Drawing.Point(348, 41);
            this.meditationValueLabel.Name = "meditationValueLabel";
            this.meditationValueLabel.Size = new System.Drawing.Size(64, 23);
            this.meditationValueLabel.TabIndex = 13;
            this.meditationValueLabel.Text = "123456";
            // 
            // meditationDescLabel
            // 
            this.meditationDescLabel.AutoSize = true;
            this.meditationDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meditationDescLabel.Location = new System.Drawing.Point(243, 41);
            this.meditationDescLabel.Name = "meditationDescLabel";
            this.meditationDescLabel.Size = new System.Drawing.Size(99, 23);
            this.meditationDescLabel.TabIndex = 12;
            this.meditationDescLabel.Text = "Meditação:";
            // 
            // attentionValueLabel
            // 
            this.attentionValueLabel.AutoSize = true;
            this.attentionValueLabel.Location = new System.Drawing.Point(348, 10);
            this.attentionValueLabel.Name = "attentionValueLabel";
            this.attentionValueLabel.Size = new System.Drawing.Size(64, 23);
            this.attentionValueLabel.TabIndex = 9;
            this.attentionValueLabel.Text = "123456";
            // 
            // attentionDescLabel
            // 
            this.attentionDescLabel.AutoSize = true;
            this.attentionDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attentionDescLabel.Location = new System.Drawing.Point(262, 10);
            this.attentionDescLabel.Name = "attentionDescLabel";
            this.attentionDescLabel.Size = new System.Drawing.Size(80, 23);
            this.attentionDescLabel.TabIndex = 8;
            this.attentionDescLabel.Text = "Atenção:";
            // 
            // signalValueLabel
            // 
            this.signalValueLabel.AutoSize = true;
            this.signalValueLabel.Location = new System.Drawing.Point(135, 71);
            this.signalValueLabel.Name = "signalValueLabel";
            this.signalValueLabel.Size = new System.Drawing.Size(64, 23);
            this.signalValueLabel.TabIndex = 15;
            this.signalValueLabel.Text = "123456";
            // 
            // signalDescLabel
            // 
            this.signalDescLabel.AutoSize = true;
            this.signalDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signalDescLabel.Location = new System.Drawing.Point(71, 71);
            this.signalDescLabel.Name = "signalDescLabel";
            this.signalDescLabel.Size = new System.Drawing.Size(54, 23);
            this.signalDescLabel.TabIndex = 14;
            this.signalDescLabel.Text = "Sinal:";
            // 
            // batteryValueLabel
            // 
            this.batteryValueLabel.AutoSize = true;
            this.batteryValueLabel.Location = new System.Drawing.Point(135, 41);
            this.batteryValueLabel.Name = "batteryValueLabel";
            this.batteryValueLabel.Size = new System.Drawing.Size(64, 23);
            this.batteryValueLabel.TabIndex = 11;
            this.batteryValueLabel.Text = "123456";
            // 
            // batteryDescLabel
            // 
            this.batteryDescLabel.AutoSize = true;
            this.batteryDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryDescLabel.Location = new System.Drawing.Point(54, 41);
            this.batteryDescLabel.Name = "batteryDescLabel";
            this.batteryDescLabel.Size = new System.Drawing.Size(72, 23);
            this.batteryDescLabel.TabIndex = 10;
            this.batteryDescLabel.Text = "Bateria:";
            // 
            // thinkGearVersionValueLabel
            // 
            this.thinkGearVersionValueLabel.AutoSize = true;
            this.thinkGearVersionValueLabel.Location = new System.Drawing.Point(135, 10);
            this.thinkGearVersionValueLabel.Name = "thinkGearVersionValueLabel";
            this.thinkGearVersionValueLabel.Size = new System.Drawing.Size(64, 23);
            this.thinkGearVersionValueLabel.TabIndex = 7;
            this.thinkGearVersionValueLabel.Text = "123456";
            // 
            // thinkGearVersionDescLabel
            // 
            this.thinkGearVersionDescLabel.AutoSize = true;
            this.thinkGearVersionDescLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinkGearVersionDescLabel.Location = new System.Drawing.Point(59, 10);
            this.thinkGearVersionDescLabel.Name = "thinkGearVersionDescLabel";
            this.thinkGearVersionDescLabel.Size = new System.Drawing.Size(67, 23);
            this.thinkGearVersionDescLabel.TabIndex = 6;
            this.thinkGearVersionDescLabel.Text = "Versão:";
            // 
            // enableBlinkCheckBox
            // 
            this.enableBlinkCheckBox.AutoSize = true;
            this.enableBlinkCheckBox.Location = new System.Drawing.Point(220, 30);
            this.enableBlinkCheckBox.Name = "enableBlinkCheckBox";
            this.enableBlinkCheckBox.Size = new System.Drawing.Size(158, 27);
            this.enableBlinkCheckBox.TabIndex = 5;
            this.enableBlinkCheckBox.Text = "Habilitar Piscada";
            this.enableBlinkCheckBox.UseVisualStyleBackColor = true;
            this.enableBlinkCheckBox.CheckStateChanged += new System.EventHandler(this.OnEnableBlinkCheckStateChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.windowsCodeTab);
            this.tabControl1.Controls.Add(this.arduinoComPortTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 449);
            this.tabControl1.TabIndex = 36;
            // 
            // windowsCodeTab
            // 
            this.windowsCodeTab.Controls.Add(this.comPortComboBox);
            this.windowsCodeTab.Controls.Add(this.enableBlinkCheckBox);
            this.windowsCodeTab.Controls.Add(this.connectButton);
            this.windowsCodeTab.Controls.Add(this.thinkGearDataPanel);
            this.windowsCodeTab.Controls.Add(this.disconnectButton);
            this.windowsCodeTab.Controls.Add(this.saveLogCheckBox);
            this.windowsCodeTab.Controls.Add(this.systemVersionLabel);
            this.windowsCodeTab.Location = new System.Drawing.Point(4, 30);
            this.windowsCodeTab.Name = "windowsCodeTab";
            this.windowsCodeTab.Padding = new System.Windows.Forms.Padding(3);
            this.windowsCodeTab.Size = new System.Drawing.Size(441, 415);
            this.windowsCodeTab.TabIndex = 0;
            this.windowsCodeTab.Text = "Código C#";
            this.windowsCodeTab.UseVisualStyleBackColor = true;
            // 
            // arduinoComPortTab
            // 
            this.arduinoComPortTab.Controls.Add(this.arduinoPortsComboBox);
            this.arduinoComPortTab.Controls.Add(this.arduinoConnectButton);
            this.arduinoComPortTab.Controls.Add(this.arduinoDisconnectButton);
            this.arduinoComPortTab.Location = new System.Drawing.Point(4, 30);
            this.arduinoComPortTab.Name = "arduinoComPortTab";
            this.arduinoComPortTab.Padding = new System.Windows.Forms.Padding(3);
            this.arduinoComPortTab.Size = new System.Drawing.Size(441, 415);
            this.arduinoComPortTab.TabIndex = 1;
            this.arduinoComPortTab.Text = "Arduino";
            this.arduinoComPortTab.UseVisualStyleBackColor = true;
            // 
            // arduinoPortsComboBox
            // 
            this.arduinoPortsComboBox.FormattingEnabled = true;
            this.arduinoPortsComboBox.Location = new System.Drawing.Point(6, 6);
            this.arduinoPortsComboBox.Name = "arduinoPortsComboBox";
            this.arduinoPortsComboBox.Size = new System.Drawing.Size(214, 29);
            this.arduinoPortsComboBox.TabIndex = 6;
            // 
            // arduinoConnectButton
            // 
            this.arduinoConnectButton.Location = new System.Drawing.Point(6, 37);
            this.arduinoConnectButton.Name = "arduinoConnectButton";
            this.arduinoConnectButton.Size = new System.Drawing.Size(94, 32);
            this.arduinoConnectButton.TabIndex = 7;
            this.arduinoConnectButton.Text = "Conectar";
            this.arduinoConnectButton.UseVisualStyleBackColor = true;
            this.arduinoConnectButton.Click += new System.EventHandler(this.OnArduinoConnectClick);
            // 
            // arduinoDisconnectButton
            // 
            this.arduinoDisconnectButton.Location = new System.Drawing.Point(106, 37);
            this.arduinoDisconnectButton.Name = "arduinoDisconnectButton";
            this.arduinoDisconnectButton.Size = new System.Drawing.Size(114, 32);
            this.arduinoDisconnectButton.TabIndex = 8;
            this.arduinoDisconnectButton.Text = "Desconectar";
            this.arduinoDisconnectButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(472, 476);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "B.O.T MindWave Tester";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.thinkGearDataPanel.ResumeLayout(false);
            this.thinkGearDataPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.windowsCodeTab.ResumeLayout(false);
            this.windowsCodeTab.PerformLayout();
            this.arduinoComPortTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Label systemVersionLabel;
        private System.Windows.Forms.CheckBox saveLogCheckBox;
        private System.Windows.Forms.Panel thinkGearDataPanel;
        private System.Windows.Forms.Label signalValueLabel;
        private System.Windows.Forms.Label signalDescLabel;
        private System.Windows.Forms.Label batteryValueLabel;
        private System.Windows.Forms.Label batteryDescLabel;
        private System.Windows.Forms.Label thinkGearVersionValueLabel;
        private System.Windows.Forms.Label thinkGearVersionDescLabel;
        private System.Windows.Forms.Label meditationValueLabel;
        private System.Windows.Forms.Label meditationDescLabel;
        private System.Windows.Forms.Label attentionValueLabel;
        private System.Windows.Forms.Label attentionDescLabel;
        private System.Windows.Forms.Label baseValuesDescLabel;
        private System.Windows.Forms.Label blinkValueLabel;
        private System.Windows.Forms.Label blinkDescLabel;
        private System.Windows.Forms.Label alphaUpperValueLabel;
        private System.Windows.Forms.Label alphaUpperDescLabel;
        private System.Windows.Forms.Label gammaLowerValueLabel;
        private System.Windows.Forms.Label gammaLowerDescLabel;
        private System.Windows.Forms.Label gammaUpperValueLabel;
        private System.Windows.Forms.Label gammaUpperDescLabel;
        private System.Windows.Forms.Label betaLowerValueLabel;
        private System.Windows.Forms.Label betaLowerDescLabel;
        private System.Windows.Forms.Label betaUpperValueLabel;
        private System.Windows.Forms.Label betaUpperDescLabel;
        private System.Windows.Forms.Label alphaLowerValueLabel;
        private System.Windows.Forms.Label alphaLowerDescLabel;
        private System.Windows.Forms.Label thetaValueLabel;
        private System.Windows.Forms.Label thetaDescLabel;
        private System.Windows.Forms.Label deltaValueLabel;
        private System.Windows.Forms.Label deltaDescLabel;
        private System.Windows.Forms.CheckBox enableBlinkCheckBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage windowsCodeTab;
        private System.Windows.Forms.TabPage arduinoComPortTab;
        private System.Windows.Forms.ComboBox arduinoPortsComboBox;
        private System.Windows.Forms.Button arduinoConnectButton;
        private System.Windows.Forms.Button arduinoDisconnectButton;
    }
}

