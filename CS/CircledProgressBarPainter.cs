using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using System.Drawing;

namespace CircledProgressBarEditor
{
    class CircledProgressBarPainter : ProgressBarPainter
    {
        protected internal static Rectangle CalcProportionalBorderRectangle(Rectangle initRect, int Proportion)
        {
            Rectangle returnedRectangle = Rectangle.Empty;
            initRect.Height--;
            if ((initRect.Width / initRect.Height) > Proportion)
            {
                int newWidth = initRect.Height * Proportion;
                int newX = initRect.X + initRect.Width / 2 - newWidth / 2;
                returnedRectangle = new Rectangle(newX, initRect.Y, newWidth, initRect.Height);
            }
            else
                returnedRectangle = initRect;

            return returnedRectangle;
        }


        protected void DrawEllipseAroundTheText(ControlGraphicsInfoArgs info)
        {
            CircledProgressBarViewInfo vi = info.ViewInfo as CircledProgressBarViewInfo;            
            RepositoryItemCircledProgressBar item = (RepositoryItemCircledProgressBar)vi.Item;
            if (item.CustomBehavior.ShowTextEllipse)
            {
                SizeF currentTextSize = info.Graphics.MeasureString(vi.DisplayText, vi.Appearance.Font);
                if ((vi.ContentRect.Height - currentTextSize.Height) > 20)
                {
                    int iRectForCaptionHeight = (int)currentTextSize.Height + 15;
                    int iRectForCaptionWidth = vi.ContentRect.Width / (vi.ContentRect.Height / iRectForCaptionHeight);
                    int iRectForCaptionX = vi.ContentRect.X + vi.ContentRect.Width / 2 - iRectForCaptionHeight / 2;
                    int iRectForCaptionY = vi.ContentRect.Y + vi.ContentRect.Height / 2 - iRectForCaptionHeight / 2;
                    info.Graphics.FillEllipse(new SolidBrush(item.CustomBehavior.TextEllipseColor),
                        new Rectangle(iRectForCaptionX, iRectForCaptionY, iRectForCaptionHeight, iRectForCaptionHeight));
                }
            }        
        }

        protected void DrawCircledProgressBarString(ControlGraphicsInfoArgs info)
        {
            ProgressBarBaseViewInfo vi = info.ViewInfo as ProgressBarBaseViewInfo;
            Brush emptyBrush = vi.ProgressAppearance.GetForeBrush(info.Cache);
            Brush fillBrush = vi.ProgressAppearance.GetFore2Brush(info.Cache);
            GraphicsClipState clip = info.Cache.ClipInfo.SaveAndSetClip(info.Bounds);
            try
            {
                if (vi.ProgressInfo.ProgressBounds.Width == 0)
                {
                    info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat);
                    return;
                }
                info.Cache.ClipInfo.ExcludeClip(vi.ProgressInfo.ProgressBounds);
                DrawEllipseAroundTheText(info);
                info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat);
                info.Cache.ClipInfo.SetClip(vi.ProgressInfo.ProgressBounds);
                DrawEllipseAroundTheText(info);
                info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat);                

            }
            finally
            {
                info.Cache.ClipInfo.RestoreClipRelease(clip);
            }
        }

        protected override void DrawContent(ControlGraphicsInfoArgs info)
        {
            ProgressBarBaseViewInfo vi = info.ViewInfo as ProgressBarBaseViewInfo;
            RepositoryItemCircledProgressBar item = (RepositoryItemCircledProgressBar)vi.Item;            
            ObjectPainter.DrawObject(info.Cache, vi.ProgressPainter, vi.ProgressInfo);
            info.Graphics.DrawEllipse(new Pen(item.Appearance.BackColor), CalcProportionalBorderRectangle(info.Bounds, item.CustomBehavior.MinWidthHeightProportion));            
            DrawCircledProgressBarString(info);            
        }

        protected override void DrawBorder(ControlGraphicsInfoArgs info)
        {
            ProgressBarBaseViewInfo vi = info.ViewInfo as ProgressBarBaseViewInfo;
            RepositoryItemCircledProgressBar item = (RepositoryItemCircledProgressBar)vi.Item;
            if (item.OwnerEdit != null && item.OwnerEdit.InplaceType == DevExpress.XtraEditors.Controls.InplaceType.Standalone)
            {
                info.Graphics.FillRectangle(new SolidBrush(item.OwnerEdit.Parent.BackColor), info.Bounds);
            }
        }

        protected override bool IsDrawBorderLast(ControlGraphicsInfoArgs info)
        {
            ProgressBarBaseViewInfo vi = info.ViewInfo as ProgressBarBaseViewInfo;
            if (vi.BorderPainter is WindowsXPProgressBarBorderPainter) return false;
            if (vi.ProgressPainter is CircledProgressBarObjectPainter) return false;
            return true;
        }        
    }
}
