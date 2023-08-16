using System;
using System.Windows.Forms;

public class HelloWorld : Form
{
    public static void Main()
    {
        Application.Run(new HelloWorld());
    }

    public HelloWorld()
    {
        Text = "Hello Mono World";
    }
}
