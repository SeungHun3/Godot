using Godot;
using System;

public class Main : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}


	private void _on_Button_pressed()
	{
		GetTree().ChangeScene("res://Scene1.tscn");
	}



	private void _on_Button2_pressed()
	{
		GetTree().ChangeScene("res://Level1.tscn");
	}


	private void _on_Button3_pressed()
	{
		GD.Print("button3 클릭");
	}


	/*
	private void _on_Button_ready()
	{
		// Replace with function body.
			GD.Print("_on_Button_ready");
	}

	private void _on_Button_draw()
	{
		GD.Print("_on_Button_draw");
	}

	private void _on_Button_focus_entered()
	{
		GD.Print("_on_Button_focus_entered");
	}


	private void _on_Button_focus_exited()
	{
		GD.Print("_on_Button_focus_exited");
	}
	*/

}
