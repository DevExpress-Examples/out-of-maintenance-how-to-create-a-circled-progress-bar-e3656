using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace CircledProgressBarEditor
{
    public class CircledProgressBar : ProgressBarControl
    {
        // static constructor
        static CircledProgressBar() { RepositoryItemCircledProgressBar.RegisterCircledProgressBar(); }

        // public constructor
        public CircledProgressBar() { }

        // ovverride property
        public override string EditorTypeName
        {
            get { return RepositoryItemCircledProgressBar.CircledProgressBarEditorName; }
        }

        // property as corresponded repositoryitem
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCircledProgressBar Properties
        {
            get { return base.Properties as RepositoryItemCircledProgressBar; }
        }
    }
}
