using Godot;
using System;

public partial class Button : Godot.Button
{
	[Signal]
	public delegate void TestSignalEventHandler();
	public override void _Ready()
	{
		TestSignal += () => GD.Print("Emitting Test Signal!");
	}
}
