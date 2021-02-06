using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace AlgoritmaProje1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //ButtonClick event funtion for calling the main CallPython function
        public void Button1_Click(object sender, EventArgs e)
        {

            distance.Text = CallPython();

        }

        //protected void DropDownList1_Changed(object sender, System.EventArgs e)
        //{
        //    /*
        //    if (DropDownList1.SelectedItem.Value == "1")
        //    {
        //    }
        //    else
        //    {
        //    }
        //    */
            
        //    for(int i = 0; i < Int32.Parse(DropDownList1.SelectedItem.Value) ; i++)
        //    {

        //        Label mylabel = new Label();
        //        mylabel.Text = i.ToString();
        //        content.Controls.Add(mylabel);

        //        TextBox box = new TextBox();
        //        content.Controls.Add(box);
        //    }


        //}

        public string CallPython()
        {
            //Starting a new process
            Process p = new Process();

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;

            //The installation path of the Pyton executable
            p.StartInfo.FileName = @"G:\Python\Python39\python.exe";

            //The path of the python file which is our algorithm
            string script = @"C:\Users\meric_\Desktop\tsp.py";

            p.StartInfo.Arguments = script;

            //The inputs to be sent as arguments to the python file
            string c1c2 = Request.Form["c1c2"];
            string c1c3 = Request.Form["c1c3"];
            string c1c4 = Request.Form["c1c4"];
            string c2c3 = Request.Form["c2c3"];
            string c2c4 = Request.Form["c2c4"];
            string c3c4 = Request.Form["c3c4"];

            p.StartInfo.Arguments = string.Format("{0} {1} {2} {3} {4} {5} {6}", script, c1c2, c1c3, c1c4, c2c3, c2c4, c3c4);

            // p.StartInfo.Arguments = $"\"{script}\"";

            //Starting the procedure
            p.Start();

            //Reading the python output and and storing it as a variable: 
            string distance = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            return distance;
        }
    }

    //public class Graph
    //{
    //    public int n;
    //    public int[,] g = new int[10, 10];

    //   public Graph(int cities)
    //    {
    //        n = cities;

    //        for (int i = 0; i < n; i++)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                g[i, j] = 0;
    //            }
    //        }

    //    }

    //    public void displayAdjacencyMatrix()
    //    {

    //        for (int i = 0; i < n; i++)
    //        {
    //            Console.WriteLine("");
    //            for (int j = 0; j < n; j++)
    //            {
    //                Console.WriteLine(" " + g[i, j]);
    //            }

    //        }

    //    }

    //    public void addEdge(int x, int y, int distance)
    //    {

    //        if ((x<0)|| (x >= n))
    //        {
    //            Console.WriteLine("Vertex " + x + " does not exist");
    //        }

    //        if ((x < 0) || (y >= n))
    //        {
    //            Console.WriteLine("Vertex " + y + " does not exist");
    //        }

    //        if (x == y)
    //        {
    //            Console.WriteLine("Same Vertex");
    //        }
    //        else
    //        {
    //            g[y, x] = distance;
    //            g[x, y] = distance;
    //        }

    //    }

    //}
}