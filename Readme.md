<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619423/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3656)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CircledProgressBar.cs](./CS/CircledProgressBar.cs) (VB: [CircledProgressBarPainter.vb](./VB/CircledProgressBarPainter.vb))
* [CircledProgressBarObjectPainter.cs](./CS/CircledProgressBarObjectPainter.cs) (VB: [CircledProgressBarObjectPainter.vb](./VB/CircledProgressBarObjectPainter.vb))
* [CircledProgressBarPainter.cs](./CS/CircledProgressBarPainter.cs) (VB: [CircledProgressBarPainter.vb](./VB/CircledProgressBarPainter.vb))
* [CircledProgressBarViewInfo.cs](./CS/CircledProgressBarViewInfo.cs) (VB: [CircledProgressBarViewInfo.vb](./VB/CircledProgressBarViewInfo.vb))
* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
* [RepositoryItemCircledProgressBar.cs](./CS/RepositoryItemCircledProgressBar.cs) (VB: [RepositoryItemCircledProgressBar.vb](./VB/RepositoryItemCircledProgressBar.vb))
<!-- default file list end -->
# How to create a circled progress bar


<p>This example demonstrates how to create a <strong>circled progress bar</strong>. </p><p>The main difference from a linear progress bar is that the progress status is displayed as a <strong>clockwise ellipse segment</strong>.</p><p>In this example we have created a <strong>RepositoryItemProgressBar</strong> descendant with the following additional properties.</p><br />
<p><strong><u>StartAngle (Start progress bar angle).</u></strong> This property defines the initial position for progress flushing</p><p><strong><u>MinWidthHeightProportion (Minimal width/height proportion).</u></strong> This property defines the minimal width to height proportion for drawing the progress ellipse. If it's equals to one, a circle will be drawn.</p><p><strong><u>ShowTextEllipse (Show ellipse around percents).</u></strong> This property defines whether to draw an ellipse around a percent string.</p><p>For flushing the gradient progress, two standard properties are used - <strong><u>StartColor</u></strong> and <strong><u>End Color</u></strong>.</p><p><strong><u>TextEllipseColor.</u></strong> This property defines the ellipse color around the percent</p><br />
<p>Thus, you can change these properties to achieve the required progress bar appearance.</p><br />


<br/>


