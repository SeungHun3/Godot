using Godot;
using System;

public class Screen : Node
{
	private Vector2 currentWindowSize = OS.WindowSize;

	public override void _Ready()
	{
		GetTree().Connect("screen_resized", this, "_OnScreenSizeChanged");
		float Width = OS.WindowSize.x;
		float Height = OS.WindowSize.y;
		GD.Print("Screen resolution changed to: " + Width + "x" + Height);
		GD.Print(Width > Height ? "가로" : "세로");
		GetNode<Label>("ScreenText").Text = Width.ToString() + "*" + Height.ToString();
	}

	private void _OnScreenSizeChanged()
	{
		Vector2 newWindowSize = OS.WindowSize;
		if (newWindowSize != currentWindowSize)
		{
			currentWindowSize = newWindowSize;
			float newWidth = newWindowSize.x;
			float newHeight = newWindowSize.y;
			GD.Print("Screen resolution changed to: " + newWidth + "x" + newHeight);
			GD.Print(newWidth > newHeight ? "가로" : "세로");
			GetNode<Label>("ScreenText").Text = newWidth.ToString() + "*" + newHeight.ToString();
		}
	}
}
