using Godot;
using System;

public class Coin : Area2D
{
	[Signal]
	public delegate void CoinCollected();
	public override void _Ready()
	{
		Set("custom_signals/coin_collected", new Godot.Collections.Array());
	}

	private void _on_Coin_body_entered(object body)
	{
		QueueFree();
		EmitSignal("CoinCollected");
	}

}

