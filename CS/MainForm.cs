using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using CircledProgressBarEditor;

namespace CircledProgressBar
{
    public partial class MainForm : Form    
    {
        DataTable Customers = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetRepositoryItemsSettings(RepositoryItemCircledProgressBar currentRepository)
        {
            currentRepository.CustomBehavior.MinWidthHeightProportion = Convert.ToInt32(spinEditProportion.EditValue);
            currentRepository.CustomBehavior.ShowTextEllipse = (bool)checkEditShowTextEllipse.EditValue;
            currentRepository.CustomBehavior.StartAngle = (CircledProgressBarEditor.CircleStartAngle)radioGroupSartAngle.EditValue;
            currentRepository.CustomBehavior.TextEllipseColor = (Color)colorEditEllipseText.EditValue;

            currentRepository.EndColor = (Color)colorEditFirstColor.EditValue;
            currentRepository.StartColor = (Color)colorEditSecondColor.EditValue;        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            circledProgressBarForTest.Properties.Minimum = 1;
            circledProgressBarForTest.Properties.Maximum = 100;
            circledProgressBarForTest.EditValue = 0;

            timerForProgressBar.Interval = 500;
            radioGroupSartAngle.SelectedIndex = 0;
            spinEditProportion.EditValue = 5;
            checkEditShowTextEllipse.EditValue = true;
            colorEditEllipseText.EditValue = Color.White;
            colorEditFirstColor.EditValue = Color.LightBlue;
            colorEditSecondColor.EditValue = Color.LightYellow;
            SetRepositoryItemsSettings(circledProgressBarForTest.Properties);

            // events
            radioGroupSartAngle.EditValueChanged += new EventHandler(radioGroupSartAngle_EditValueChanged);
            spinEditProportion.EditValueChanged += new EventHandler(spinEditProportion_EditValueChanged);
            checkEditShowTextEllipse.EditValueChanged += new EventHandler(checkEditShowTextEllipse_EditValueChanged);
            colorEditEllipseText.EditValueChanged += new EventHandler(colorEditEllipseText_EditValueChanged);
            colorEditFirstColor.EditValueChanged += new EventHandler(colorEditFirstColor_EditValueChanged);
            colorEditSecondColor.EditValueChanged += new EventHandler(colorEditSecondColor_EditValueChanged);
        }

        void colorEditSecondColor_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }
        void colorEditFirstColor_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }
        void colorEditEllipseText_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }
        void checkEditShowTextEllipse_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }
        void spinEditProportion_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }
        void radioGroupSartAngle_EditValueChanged(object sender, EventArgs e) { SetRepositoryItemsSettings(circledProgressBarForTest.Properties); }



        private void Start_Click(object sender, EventArgs e)
        {
            circledProgressBarForTest.EditValue = 0;
            timerForProgressBar.Start();
        }

        private void timerForProgressBar_Tick(object sender, EventArgs e)
        {
            if ((int)circledProgressBarForTest.EditValue == circledProgressBarForTest.Properties.Maximum)
                timerForProgressBar.Stop();
            else
            {
                circledProgressBarForTest.EditValue = (int)circledProgressBarForTest.EditValue + 1;
            }
        }

        private void simpleButtonStop_Click(object sender, EventArgs e)
        {
            timerForProgressBar.Stop();
        }
    }
}
