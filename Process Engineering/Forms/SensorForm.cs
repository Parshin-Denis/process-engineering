using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class SensorForm : Form
    {
        private Sensor sensor = new Sensor();

        public SensorForm()
        {
            InitializeComponent();            
            tbNumber.DataBindings.Add("Text", sensor, "number");
            tbMinTorque.DataBindings.Add("Text", sensor, "minTorque");
            tbMinTorque.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            tbMaxTorque.DataBindings.Add("Text", sensor, "maxTorque");
            tbMaxTorque.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            cbBlmFilter.Items.Add("Все типы");
            cbBlmFilter.Items.AddRange(Sensor.sensors.Select(s => s.blm.ToString()).Distinct().ToArray());
            
            cbBlm.DataSource = ConstStorage.BLM_LIST;
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            cbBlmFilter.SelectedIndex = 0;
            //updateDataGrid(sender, e);
            dgSensors.Columns[0].HeaderText = "№ BLM";
            dgSensors.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgSensors.Columns[1].HeaderText = "№ датчика";
            dgSensors.Columns[2].HeaderText = "Момент МИН, Н*м";
            dgSensors.Columns[3].HeaderText = "Момент Макс, Н*м";
            dgSensors.Columns[0].Width = 70;
            dgSensors.Columns[1].Width = 70;
            dgSensors.Columns[2].Width = (dgSensors.Width - SystemInformation.VerticalScrollBarWidth -
                dgSensors.Columns[0].Width - dgSensors.Columns[1].Width - 3) / 2;
            dgSensors.Columns[3].Width = dgSensors.Columns[2].Width;
            dgSensors.ReadOnly = true;
        }

        private void dgTools_SelectionChanged(object sender, EventArgs e)
        {            
            sensor.copyFrom(dgSensors.SelectedRows.Count == 0 ? new Sensor() : dgSensors.SelectedRows[0].DataBoundItem as Sensor);
            
            cbBlm.SelectedIndex = sensor.blm == 0 ? -1 : cbBlm.Items.IndexOf(sensor.blm);            
            tbNumber.DataBindings[0].ReadValue();
            tbMinTorque.DataBindings[0].ReadValue();
            tbMaxTorque.DataBindings[0].ReadValue();
            
            gbParameters.Enabled = false;
            
            bUpdate.Enabled = dgSensors.SelectedRows.Count != 0 && User.isScrewingEditingAllowed();
            bUpdate.Text = ConstStorage.EDIT;
            bAdd.Enabled = User.isScrewingEditingAllowed();
            bDelete.Enabled = dgSensors.SelectedRows.Count != 0 && User.isScrewingEditingAllowed();
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            if (!gbParameters.Enabled)
            {
                dgSensors.ClearSelection();
                gbParameters.Enabled = true;
                bAdd.Enabled = false;
                cbBlm.Enabled = true;
                tbNumber.ReadOnly = false;
                return;
            }
            GeneralResponse<Sensor> response = await DataBaseService.createSensor(sensor);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.ADD_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sensor newSensor = response.data;
            Sensor.sensors.Add(newSensor);            
            updateDataGrid(sender, e);
            MessageBox.Show(ConstStorage.TOOL_IS_ADDED, ConstStorage.TOOL_EDITING);
        }

        private async void bUpdate_Click(object sender, EventArgs e)
        {
            if (!gbParameters.Enabled)
            {
                gbParameters.Enabled = true;
                bUpdate.Enabled = false;
                bUpdate.Text = ConstStorage.ACCEPT_CHANGES;
                bAdd.Enabled = false;
                bDelete.Enabled = false;                
                tbNumber.ReadOnly = true;
                cbBlm.Enabled = false;
                return;
            }
            
            GeneralResponse<object> response = await DataBaseService.updateSensor(sensor);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sensor sensorToUpdate = Sensor.sensors.First(s => s.blm == sensor.blm && s.number == sensor.number);
            sensorToUpdate.copyFrom(sensor);
            MessageBox.Show(ConstStorage.TOOL_IS_UPDATED, ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgSensors.Refresh();
            dgTools_SelectionChanged(sender, EventArgs.Empty);
        }        

        private void updateDataGrid(object sender, EventArgs e)
        {            
            dgSensors.DataSource = new BindingList<Sensor>(cbBlmFilter.SelectedIndex == 0
                ? Sensor.sensors 
                : Sensor.sensors.Where(s => s.blm == int.Parse(cbBlmFilter.SelectedItem.ToString())).ToList());
            lCount.Text = $"Найдено: {dgSensors.Rows.Count} шт.";
            dgSensors.ClearSelection();
        }

        private async void bDelete_Click(object sender, EventArgs e)
        {
            GeneralResponse<object> response = await DataBaseService.deleteSensor(sensor);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.DELETE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sensor.sensors.Remove(Sensor.sensors.First(s => s.blm == sensor.blm && s.number == sensor.number));
            updateDataGrid(sender, e);            
        }

        private void tbParameters_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            GeneralService.FilterDigitKeyPress(textBox, e, !textBox.Name.Contains("Torque"));
        }

        private void sensorParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cbBlm))
            {
                sensor.blm = cbBlm.SelectedIndex != -1 ? (int)cbBlm.SelectedItem : 0;
            }
            else
            {
                (sender as TextBox).DataBindings[0].WriteValue();
            }            
            bAdd.Enabled = dgSensors.SelectedRows.Count == 0;
            bUpdate.Enabled = dgSensors.SelectedRows.Count > 0 && !sensor.Equals(dgSensors.SelectedRows[0].DataBoundItem as Sensor);
        }
        
    }
}
