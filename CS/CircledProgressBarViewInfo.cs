using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils.Drawing;
using DevExpress.LookAndFeel;

namespace CircledProgressBarEditor
{
    class CircledProgressBarViewInfo : ProgressBarViewInfo
    {
        // constructor
        public CircledProgressBarViewInfo(RepositoryItem item) : base(item) { }

        public override ProgressBarObjectPainter ProgressPainter
        {
            get
            {
                return new CircledProgressBarObjectPainter(Owner);
            }
        }
    }
}
