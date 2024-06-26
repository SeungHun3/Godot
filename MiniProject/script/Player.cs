using Godot;
using System;

public class Player : KinematicBody2D
{
	AnimatedSprite animatedSprite;
	float speed = 500f;
	float gravity = 300f;
	float jump = -3000;
	Vector2 velocity = new Vector2();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		animatedSprite = GetNode<AnimatedSprite>("PlayerImage");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{

		if (Input.IsActionPressed("ui_right"))
		{
			velocity.x = speed;
			animatedSprite.Play("walk");
			animatedSprite.FlipH = false;
		}
		else if (Input.IsActionPressed("ui_left"))
		{
			velocity.x = -speed;
			animatedSprite.Play("walk");
			animatedSprite.FlipH = true;
		}
		else
		{
			animatedSprite.Play("idle");
		}

		if(!IsOnFloor())
		{
			animatedSprite.Play("jump");
		}


		if(IsOnFloor() && Input.IsActionPressed("jump"))
		{
			velocity.y = jump;
		}

		velocity.y += gravity;
		velocity.x = Mathf.Lerp(velocity.x, 0, 0.1f);
		MoveAndSlide(velocity, Vector2.Up);
	}
	private void _on_FallZone_body_entered(object body)
	{
		GetTree().ChangeScene("res://Menu.tscn");
		GD.Print("restart");
	}
	public void MiniJump()
	{
		velocity.y = jump * 0.8f;
	}
	public void Die()
	{
		Modulate = new Color(1f, 0.2f, 0.2f, 0.2f);
		velocity.y = jump * 1;
		GetNode<Timer>("PlayerTimer").Start();
	}
	private void _on_Timer_timeout()
	{
		QueueFree();
		GetTree().ChangeScene("res://Menu.tscn");
	}


}


