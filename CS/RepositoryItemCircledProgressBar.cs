using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors;
using System.Drawing;

namespace CircledProgressBarEditor
{
    public enum CircleStartAngle {
        Angle0 = 0, Angle90 = 1, Angle180 = 2, Angle270 = 3
    }

    [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public class CircledProgressBarBehaviourOptions
    {
        public CircledProgressBarBehaviourOptions()
        {
            MinWidthHeightProportion = 5;
            ShowTextEllipse = true;
            TextEllipseColor = Color.White;
            StartAngle = CircleStartAngle.Angle0;
        }

        [Description("Gets or sets a start angle on drawing a circle surface."), DefaultValue(CircleStartAngle.Angle90)]
        public CircleStartAngle StartAngle { get; set; }
        protected int WidthHeightProportion;
        [Description("Gets or sets the minimal value of the width to height proportion on drawing a circle surface."), DefaultValue(5)]
        public int MinWidthHeightProportion
        {
            get { return WidthHeightProportion; }
            set
            {
                if (value > 0)
                {
                    WidthHeightProportion = value;
                }
            }
        }

        [Description("Gets or sets drawing ellipse mode around displayed text."), DefaultValue(true)]
        public bool ShowTextEllipse { get; set; }
        [Description("Gets or sets the ellipse color which will be drawn around the displayed text.")]
        public Color TextEllipseColor { get; set; }

        public override string ToString()
        {
            return "Behaviour";
        }
    }

    public class RepositoryItemCircledProgressBar : RepositoryItemProgressBar
    {
        // static constructor which calls static registration method
        static RepositoryItemCircledProgressBar() { RegisterCircledProgressBar(); }

        // static register method
        public static void RegisterCircledProgressBar()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(
                CircledProgressBarEditorName,
                typeof(CircledProgressBar),
                typeof(RepositoryItemCircledProgressBar),
                typeof(CircledProgressBarViewInfo),
                new CircledProgressBarPainter(),
                true,
                null));
        }

        // internal editor name
        internal const string CircledProgressBarEditorName = "CircledProgressBar";

        // public constructor
        public RepositoryItemCircledProgressBar() : base()
        {
            protBehavior = new CircledProgressBarBehaviourOptions();
        }

        protected CircledProgressBarBehaviourOptions protBehavior;
        [Description("Gets behavior options of a circled progress bar.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Category("CustomBehavior")]
        public CircledProgressBarBehaviourOptions CustomBehavior
        {
            get { return protBehavior; } 
        }

        // ovverride property
        public override string EditorTypeName
        {
            get { return CircledProgressBarEditorName; }
        }

        public override BaseEditPainter CreatePainter()
        {
            return new CircledProgressBarPainter();
        }

        public override void Assign(RepositoryItem item)
        {
            base.Assign(item);
            RepositoryItemCircledProgressBar currentRepository = (item as RepositoryItemCircledProgressBar);
            this.CustomBehavior.MinWidthHeightProportion = currentRepository.CustomBehavior.MinWidthHeightProportion;
            this.CustomBehavior.ShowTextEllipse = currentRepository.CustomBehavior.ShowTextEllipse;
            this.CustomBehavior.StartAngle = currentRepository.CustomBehavior.StartAngle;
            this.CustomBehavior.TextEllipseColor = currentRepository.CustomBehavior.TextEllipseColor;
        }
    }
}
