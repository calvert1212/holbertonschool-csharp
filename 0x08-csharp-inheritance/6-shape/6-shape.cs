using System;

/// <summary>Class Shape not implemented</summary>
class Shape
{
    /// <summary>Method Area not implemented yet</summary>
    /// <exceptions>NotImplementedException</exceptions>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}


/// <summary>Define a rectangle, inherited of Shape</summary>
class Rectangle : Shape
{
    // The width of rectangle
    private int width;
    // The height of rectangle
    private int height;

    /// <summary>Get or set the width with value</summary>
    /// <exceptions>ArgumentException when value is less than 0</exceptions>
    /// <returns>The width of the rectangle</returns>
    public int Width
    {
        get { return this.width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            this.width = value;
        }
    }

    /// <summary>Get or set the height with value</summary>
    /// <exceptions>ArgumentException when value is less than 0</exceptions>
    /// <returns>The height of the rectangle</returns>
    public int Height
    {
        get { return this.height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            this.height = value;
        }
    }
}
