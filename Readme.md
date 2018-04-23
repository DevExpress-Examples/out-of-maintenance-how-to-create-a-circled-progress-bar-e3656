# How to create a circled progress bar


<p>This example demonstrates how to create a <strong>circled progress bar</strong>. </p><p>The main difference from a linear progress bar is that the progress status is displayed as a <strong>clockwise ellipse segment</strong>.</p><p>In this example we have created a <strong>RepositoryItemProgressBar</strong> descendant with the following additional properties.</p><br />
<p><strong><u>StartAngle (Start progress bar angle).</u></strong> This property defines the initial position for progress flushing</p><p><strong><u>MinWidthHeightProportion (Minimal width/height proportion).</u></strong> This property defines the minimal width to height proportion for drawing the progress ellipse. If it's equals to one, a circle will be drawn.</p><p><strong><u>ShowTextEllipse (Show ellipse around percents).</u></strong> This property defines whether to draw an ellipse around a percent string.</p><p>For flushing the gradient progress, two standard properties are used - <strong><u>StartColor</u></strong> and <strong><u>End Color</u></strong>.</p><p><strong><u>TextEllipseColor.</u></strong> This property defines the ellipse color around the percent</p><br />
<p>Thus, you can change these properties to achieve the required progress bar appearance.</p><br />


<br/>


