using System;
/// <summary>Base class containing the name and string override.</summary>
public abstract class Base{
	/// <summary>Object name</summary>
	public string name;
	/// <summary>String override</summary>
	public override string ToString() => $"{this.name} is a {this.GetType()}";
}
