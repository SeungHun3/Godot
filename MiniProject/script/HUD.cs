using Godot;
using System;

public class HUD : CanvasLayer
{
	int coins = 0;
	public override void _Ready()
	{
		GetNode<Label>("Score").Text = coins.ToString();
			coins.ToString();
	}
	private void _on_Coin_CoinCollected()
	{
		coins++;
		_Ready();
	}


}

