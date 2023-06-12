using MedApp.Services;
using System;
using System.Windows.Forms;

namespace MedApp
{
    public partial class Form1 : Form
    {
        private readonly DoctorService doctorService;
        private readonly PatientService patientService;

        public Form1(DoctorService doctorService, PatientService patientService)
        {
            this.doctorService = doctorService;
            this.patientService = patientService;
            InitializeComponent();
            HomeOnePanel.BringToFront();
            DoctorPanel.Visible = false;
            PatientPanel.Visible = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeOnePanel.BringToFront();
            DoctorPanel.Visible = false;
            DoctorPanel.SendToBack();
            PatientPanel.Visible = false;
            PatientPanel.SendToBack();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            DoctorPanel.BringToFront();
            DoctorPanel.Visible = true;
            HomeOnePanel.SendToBack();
            PatientPanel.Visible = false;
            PatientPanel.SendToBack();
            LoadDoctors();
        }

        private async void LoadDoctors()
        {
            try
            {
                DoctorsList.Items.Clear();
                var list = await doctorService.Get();
                if (list.Count > 0)
                    foreach (var obj in list)
                    {
                        var listItem = new ListViewItem(new string[] { obj.Id.ToString(), obj.Name, obj.Specialization, obj.PatientsCount.ToString() });
                        DoctorsList.Items.Add(listItem);
                    }
            }
            catch (Exception loadDoctorEx)
            {
                //Handle Exception
            }
        }

        private async void LoadPatiens()
        {
            try
            {
                PatiensList.Items.Clear();
                var list = await patientService.Get();
                if (list.Count > 0)
                    foreach (var obj in list)
                    {
                        var listItem = new ListViewItem(new string[] { obj.Id.ToString(), obj.Name, obj.Date.ToString(), obj.DoctorName });
                        PatiensList.Items.Add(listItem);
                    }

                PatiensBox.Items.Clear();
                var doctorsName = await doctorService.GetByName();
                if (doctorsName.Count > 0)
                    PatiensBox.Items.AddRange(doctorsName.ToArray());
            }
            catch (Exception loadDoctorEx)
            {
                //Handle Exception
            }
        }

        private async void AddNewDoctor_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewDoctorNameBox.Text) && !string.IsNullOrWhiteSpace(NewDoctorSpecBox.Text))
            {
                await doctorService.Post(NewDoctorNameBox.Text, NewDoctorSpecBox.Text);
                LoadDoctors();
                NewDoctorNameBox.Text = string.Empty;
                NewDoctorSpecBox.Text = string.Empty;
            }
        }

        private async void DoctorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DocId.Text = DoctorsList.SelectedItems[0].Text;
                DoctorsList.SelectedIndices.Clear();
                var docData = await doctorService.Get(DocId.Text);
                DocName.Text = docData.Name;
                DocSpec.Text = docData.Specialization;
            }
            catch (Exception selectDocEx)
            {
                //To handle
            }
        }

        private async void DoctorEditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DocName.Text) && !string.IsNullOrWhiteSpace(DocSpec.Text))
            {
                await doctorService.Put(DocId.Text, DocName.Text, DocSpec.Text);
                LoadDoctors();
                DoctorsList.SelectedIndices.Clear();
                DocId.Text = string.Empty;
                DocName.Text = string.Empty;
                DocSpec.Text = string.Empty;
            }
        }

        private async void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DocId.Text))
            {
                await doctorService.Delete(DocId.Text);
                LoadDoctors();
                DoctorsList.SelectedIndices.Clear();
                DocId.Text = string.Empty;
                DocName.Text = string.Empty;
                DocSpec.Text = string.Empty;
            }
        }

        private void PatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                PatientPanel.BringToFront();
                PatientPanel.Visible = true;
                HomeOnePanel.SendToBack();
                DoctorPanel.Visible = false;
                DoctorPanel.SendToBack();

                LoadPatiens();
            }
            catch (Exception testEx)
            {
            }
        }

        private async void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PatientName.Text) && !string.IsNullOrWhiteSpace(PatiensBox.SelectedItem.ToString()))
            {
                await patientService.Put(PatientName.Text, PatiensBox.SelectedItem.ToString());
                LoadPatiens();
                PatientName.Text = string.Empty;
            }
        }

        private async void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PatientName.Text) && !string.IsNullOrWhiteSpace(PatiensBox.SelectedItem.ToString()))
            {
                await patientService.Put(PatientName.Text, PatiensBox.SelectedItem.ToString());
                LoadPatiens();
                PatientName.Text = string.Empty;
            }
        }
    }
}