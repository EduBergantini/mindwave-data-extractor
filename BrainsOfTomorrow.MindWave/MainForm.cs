using System;
using System.Globalization;
using System.IO.Ports;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BrainsOfTomorrow.MindWave.Core.Domain.Builders;
using BrainsOfTomorrow.MindWave.Core.Domain.Controllers;
using BrainsOfTomorrow.MindWave.Core.Domain.Controllers.Bases;
using BrainsOfTomorrow.MindWave.Core.Domain.Entities;
using BrainsOfTomorrow.MindWave.Core.Loggers;
using BrainsOfTomorrow.MindWave.Core.Loggers.Entities;
using BrainsOfTomorrow.MindWave.Properties;
using ThinkGearNET;

namespace BrainsOfTomorrow.MindWave
{
    public partial class MainForm : Form
    {
        private readonly IRecordableLog _fileLog;
        private readonly IRecordableLog _csvLog;
        private readonly IFormatProvider _formatProvider;
        private CommunicationControllerBase _controllerBase;
        private readonly SynchronizationContext _context;

        public MainForm()
        {
            _formatProvider = CultureInfo.CurrentCulture;
            _fileLog = new FileLog();
            _csvLog = new CsvLog(CsvBuilder.BuildHeader(_formatProvider));
            _context = SynchronizationContext.Current;
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            systemVersionLabel.Text = string.Format(Resources.SystemVersionMessage, Assembly.GetExecutingAssembly().GetName().Version);
            comPortComboBox.DataSource = SerialPort.GetPortNames();
            arduinoPortsComboBox.DataSource = SerialPort.GetPortNames();
            _fileLog.RegisterLog(Log.RegisterSuccess("Iniciando Atividades").ToString());
            ChangeInteractionState(true);
        }

        private void OnConnectButtonClick(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = comPortComboBox.SelectedItem;
                if (selectedItem == null)
                {
                    MessageBox.Show(Resources.NoComPortSelected);
                    return;
                }

                ChangeInteractionState(false);
                var configurator = SerialConfigurator.GetInstance(selectedItem.ToString(), 57600, saveLogCheckBox.Checked);
                _controllerBase = new ThinkGearController();
                _controllerBase.DataReceived += OnThinkGearDataReceived;
                if (_controllerBase.Connect(configurator)) return;
                MessageBox.Show(Resources.ConnectionFailureMessage);
                ChangeInteractionState(true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                ChangeInteractionState(true);
            }
        }

        private void OnThinkGearDataReceived(object sender, EventArgs thinkGearChangedEventArgs)
        {
            try
            {

                if (_controllerBase.IntegrationType == IntegrationType.Arduino)
                {
                    #region Via Arduino

                    var bytesToRead = ((SerialPort) sender).BytesToRead;
                    var elements = new byte[bytesToRead];
                    ((SerialPort) sender).Read(elements, 0, bytesToRead);
                    var generated = Encoding.ASCII.GetString(elements);
                    _csvLog.RegisterLog(generated);
                    
                    #endregion
                }
                else
                {
                    #region Direct via Neurosky

                    _fileLog.RegisterLog($"Informações Recebidas: {((ThinkGearChangedEventArgs)thinkGearChangedEventArgs).ThinkGearState}");

                    _context.Post(state =>
                    {
                        var data = state as ThinkGearState;
                        if (data == null) return;
                        _csvLog.RegisterLog(CsvBuilder.BuildInformation(_formatProvider, data));
                        thinkGearVersionValueLabel.Text = data.Version.ToString(_formatProvider);
                        batteryValueLabel.Text = data.Battery.ToString(_formatProvider);
                        signalValueLabel.Text = data.PoorSignal.ToString(_formatProvider);
                        attentionValueLabel.Text = data.Attention.ToString(_formatProvider);
                        meditationValueLabel.Text = data.Meditation.ToString(_formatProvider);
                        blinkValueLabel.Text = "0";
                        blinkValueLabel.Text = data.BlinkStrength.ToString(_formatProvider);

                        alphaUpperValueLabel.Text = data.Alpha1.ToString(_formatProvider);
                        alphaLowerValueLabel.Text = data.Alpha2.ToString(_formatProvider);
                        betaUpperValueLabel.Text = data.Beta1.ToString(_formatProvider);
                        betaLowerValueLabel.Text = data.Beta2.ToString(_formatProvider);
                        gammaUpperValueLabel.Text = data.Gamma1.ToString(_formatProvider);
                        gammaLowerValueLabel.Text = data.Gamma2.ToString(_formatProvider);
                        deltaValueLabel.Text = data.Delta.ToString(_formatProvider);
                        thetaValueLabel.Text = data.Theta.ToString(_formatProvider);
                    }, ((ThinkGearChangedEventArgs)thinkGearChangedEventArgs).ThinkGearState);
                    Thread.Sleep(100);

                    #endregion
                }
            }
            catch (Exception exception)
            {
                _fileLog.RegisterLog(Log.RegisterException(exception).ToString());
            }
        }

        private void OnDisconnectButtonClick(object sender, EventArgs e)
        {
            try
            {
                _controllerBase.Disconnect();
            }
            catch (Exception exception)
            {
                _fileLog.RegisterLog(Log.RegisterException(exception).ToString());
            }
            finally
            {
                ChangeInteractionState(true);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _controllerBase?.Dispose();
            _fileLog?.Dispose();
            base.OnFormClosed(e);
        }

        private void ChangeInteractionState(bool actualState)
        {
            disconnectButton.Enabled = !actualState;
            thinkGearDataPanel.Visible = !actualState;
            enableBlinkCheckBox.Enabled = !actualState;
            connectButton.Enabled = actualState;
            comPortComboBox.Enabled = actualState;
            saveLogCheckBox.Enabled = actualState;

        }

        private void OnEnableBlinkCheckStateChanged(object sender, EventArgs e)
        {
            _controllerBase.ChangeBlinkState(((CheckBox)sender).Checked);
        }

        private void OnArduinoConnectClick(object sender, EventArgs e)
        {
            var selectedItem = arduinoPortsComboBox.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show(Resources.NoComPortSelected);
                return;
            }

            ChangeInteractionState(false);
            var configurator = SerialConfigurator.GetInstance(selectedItem.ToString(), 9600, saveLogCheckBox.Checked);
            _controllerBase = new ArduinoController();
            _controllerBase.DataReceived += OnThinkGearDataReceived;
            if (_controllerBase.Connect(configurator)) return;
            MessageBox.Show(Resources.ConnectionFailureMessage);
            ChangeInteractionState(true);
        }
    }
}
