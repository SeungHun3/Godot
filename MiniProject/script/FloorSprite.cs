using Godot;
using System;

public class Sprite : Godot.Sprite
{
	public override void _Ready()
	{
		
		Texture texture = (Texture)GD.Load("res://Resources/Environment/ground_wood.png");
		
		// 자신이 연결된 스프라이트 노드를 찾습니다.
		Sprite sprite = GetNode<Sprite>(".");
		
		// Sprite의 Texture 속성에 Texture 객체 할당
		sprite.Texture = texture;

		mycheck temp = new mycheck();
		GD.Print(temp.a);

		
	}


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
