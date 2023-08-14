using System;
using System.Windows.Forms;

public class HelloWorld : Form
{
    public static void Main()
    {
        Applica  tion.Run(new HelloWorld());
    }

    public HelloWorld()
    {
        Text = "Hello Mono World";
    }
}
