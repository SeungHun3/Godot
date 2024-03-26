using Godot;
using System;

public class Screen : Node
{
	private Vector2 currentWindowSize = OS.WindowSize;

	public override void _Ready()
	{
		// ScreenSizeChanged 이벤트를 연결합니다.
		GetTree().Connect("screen_resized", this, "_OnScreenSizeChanged");
	}

	private void _OnScreenSizeChanged()
	{
		Vector2 newWindowSize = OS.WindowSize;
		// 이전 창 크기와 현재 창 크기를 비교하여 해상도가 변경되었는지 확인합니다.
		if (newWindowSize != currentWindowSize)
		{
			currentWindowSize = newWindowSize;
			// 해상도가 변경될 때 실행할 작업을 여기에 추가합니다.
			float newWidth = newWindowSize.x;
			float newHeight = newWindowSize.y;
			GD.Print("Screen resolution changed to: " + newWidth + "x" + newHeight);
			// 여기에 다른 작업을 추가하세요.
		}
	}
}
