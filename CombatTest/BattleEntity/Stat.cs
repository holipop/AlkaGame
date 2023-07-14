using Godot;
using System;

public partial class Stat
{
	private int value;
	private int min;
	private int max;
	
	public Stat(int value, int max, int min = 0)
	{
		this.value = value;
		this.max = max;
		this.min = min;
	}

	public int getValue() => this.value;
	public int setValue(int value) => this.value = value;
}
