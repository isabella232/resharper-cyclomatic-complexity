using System;

class ComplexityExample
{
    // From http://dontcodetired.com/blog/post/Using-Cyclomatic-Complexity-as-an-Indicator-of-Clean-Code.aspx
    // Used by permission :) https://twitter.com/robertsjason/status/618041977997627392
    public bool SomeComplexMethod(int age, string name, bool isAdmin)
    {
        bool result = false;
        bool value = false;
     
        if (name == "Sarah")
        {
            if (age < 20 || age > 100)
            {
                if (isAdmin)
                {
                    result = true;
                    value = true;
                }
                else if (age == 42)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
        }
        else if (name == "Gentry" && isAdmin)
        {
            result = false;
        }
        else
        {
            if (age == 50)
            {
                if (isAdmin)
                {
                    if (name == "Amrit")
                    {
                        result = false;
                    }
                    else if (name == "Jane")
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
        }
     
        return result;
    }
}
