using Godot;
using System;

public class Enemy : KinematicBody2D
{
	Vector2 velocity = new Vector2();
	int direction = 1;
	public override void _Ready()
	{
		if(direction == -1) {
			GetNode<AnimatedSprite>("EnemyImage").FlipH = true;
		}

		Vector2 position = GetNode<RayCast2D>("F_sensor").Position;
		position.x = GetNode<CollisionShape2D>("EnemyCollision").GetViewportRect().Position.x * direction;
		GetNode<RayCast2D>("F_sensor").Position = position;
	}
	public override void _PhysicsProcess(float delta)
	{
		if(IsOnWall() || !GetNode<RayCast2D>("F_sensor").IsColliding())
		{
			direction *= -1;
			GetNode<AnimatedSprite>("EnemyImage").FlipH = !GetNode<AnimatedSprite>("EnemyImage").FlipH;
			Vector2 position = GetNode<RayCast2D>("F_sensor").Position;
			position.x = GetNode<CollisionShape2D>("EnemyCollision").GetViewportRect().Position.x * direction;
			GetNode<RayCast2D>("F_sensor").Position = position;

		}

		velocity.y += 30;
		velocity.x = 40 * direction;

		MoveAndSlide(velocity, Vector2.Up);
	}

	private void _on_Top_sensor_body_entered(object body)
	{
		QueueFree(); 
		Player player = body as Player;
		if (player != null)
		{
			player.MiniJump();
		}
	}

	private void _on_Side_Sensor_body_entered(object body)
	{
		Player player = body as Player;
		if (player != null)
		{
			player.Die();
		}
	}


}

