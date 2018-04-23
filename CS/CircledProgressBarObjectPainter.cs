using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace CircledProgressBarEditor
{
    class CircledProgressBarObjectPainter : ProgressBarObjectPainter
    {
        CircleStartAngle currentAngle;
        int currentWidthHeightProportion;

        // constructor
        public CircledProgressBarObjectPainter(object paramObject)
        {
            RepositoryItemCircledProgressBar CurrentRepository = paramObject as RepositoryItemCircledProgressBar;
            currentAngle = CurrentRepository != null ? CurrentRepository.CustomBehavior.StartAngle : CircleStartAngle.Angle90;
            currentWidthHeightProportion = CurrentRepository != null ? CurrentRepository.CustomBehavior.MinWidthHeightProportion : 5;
        }

        protected void DrawCircledBar(ProgressBarObjectInfoArgs e) { DrawCircledBar(e, CalcProgressBounds(e)); }

        protected void DrawCircledBar(ProgressBarObjectInfoArgs e, Rectangle pb)
        {
            Rectangle rectForPie = CircledProgressBarPainter.CalcProportionalBorderRectangle(e.Bounds, currentWidthHeightProportion);
            Brush brush = e.Cache.GetGradientBrush(e.Bounds, e.StartColor, e.EndColor, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            float beginAngle = -90 + 90 * (int)currentAngle;
            float endAngle = 360 * e.Percent;
            if (rectForPie.Width > 0)
            {
                e.Cache.Graphics.FillPie(brush, rectForPie, beginAngle, endAngle);                
            }            
        }

        protected override void DrawBar(ProgressBarObjectInfoArgs e)
        {
            DrawCircledBar(e);
        }

        public override void DrawObject(ObjectInfoArgs e)
        {
            Color color = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel, SystemColors.Control);
            ProgressBarObjectInfoArgs ee = e as ProgressBarObjectInfoArgs;
            if (ee.FillBackground) e.Cache.Paint.FillRectangle(e.Graphics, new SolidBrush(color), e.Bounds);
            DrawBar(ee);
        }
    }
}
