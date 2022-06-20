using System;

/// <summary>
/// The type of bitmap shape to generate.
/// </summary>
public enum BitmapType
{
	/// <summary>
	/// Generate an 'X' shape.
	/// </summary>
	Close = 874892,

	/// <summary>
	/// Generate a 'box' shape.
	/// </summary>
	Maximize = 473282,

	/// <summary>
	/// Generate a 'plate' shape.
	/// </summary>
	Minimize = 183783,

	/// <summary>
	/// Generate a 'box overlaying another box' shape.
	/// </summary>
	Restore = 927582,

	/// <summary>
	/// Generate a 'question mark' shape.
	/// </summary>
	Help = 395839,

	/// <summary>
	/// Generate a 'down arrow' shape.
	/// </summary>
	DownArrow = 928482,

	/// <summary>
	/// Generate an 'up arrow' shape.
	/// </summary>
	UpArrow = 727932,

	/// <summary>
	/// Generate a 'left arrow' shape.
	/// </summary>
	LeftArrow = 294832,

	/// <summary>
	/// Generate a 'right arrow' shape.
	/// </summary>
	RightArrow = 727589,
}

public static class BitmapTypeExtensions
{
	/// <summary>
	/// Converts an integer to a <see cref="BitmapType"/> object.
	/// </summary>
	/// <param name="ID">The id of the <see cref="BitmapType"/> enumeration to convert from.</param>
	/// <returns>
	/// A <see cref="BitmapType"/> <see langword="enumeration"/>, if the id matches one of the values.
	/// </returns>
	public static BitmapType ToBmpType(this int ID)
	{
		if (ID == (int)BitmapType.Close || ID == (int)BitmapType.Maximize || ID == (int)BitmapType.Minimize || ID == (int)BitmapType.Restore || ID == (int)BitmapType.Help || ID == (int)BitmapType.DownArrow || ID == (int)BitmapType.UpArrow || ID == (int)BitmapType.LeftArrow || ID == (int)BitmapType.RightArrow)
		{
			return (BitmapType)ID;
		}
		else throw new ArgumentException("The integer given does not match any of the BitmapType enumerations.", "ID");
	}

	/// <summary>
	/// Converts an unsigned integer to a <see cref="BitmapType"/> object.
	/// </summary>
	/// <param name="ID">The id of the <see cref="BitmapType"/> enumeration to convert from.</param>
	/// <returns>
	/// A <see cref="BitmapType"/> <see langword="enumeration"/>, if the id matches one of the values.
	/// </returns>
	public static BitmapType ToBmpType(this uint ID)
	{
		if (ID == (int)BitmapType.Close || ID == (int)BitmapType.Maximize || ID == (int)BitmapType.Minimize || ID == (int)BitmapType.Restore || ID == (int)BitmapType.Help || ID == (int)BitmapType.DownArrow || ID == (int)BitmapType.UpArrow || ID == (int)BitmapType.LeftArrow || ID == (int)BitmapType.RightArrow)
		{
			return (BitmapType)ID;
		}
		else throw new ArgumentException("The unsigned integer given does not match any of the BitmapType enumerations.", "ID");
	}
}
