using Godot;
using System;


public partial class start_button : Button
{
	public override void _Pressed()
	{
		base._Pressed();
		GetTree().ChangeSceneToFile("res://scenes/main.tscn");
	}
}
