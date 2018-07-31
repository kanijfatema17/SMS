using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class StudentRegister : Form
    {
        List<string> _name = new List<string>();
        List<double> _regNo = new List<Double>();
      
            
        public StudentRegister()
        {
            InitializeComponent();
        }
     
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            _name.Add(nameTextBox.Text);
            _regNo.Add(regTextBox2.Text);



            nameTextBox.Text = String.Empty;
            regTextBox2

            //regTextBox2.Text = String.Empty;


           
            
        }

       

        private void searchButton_Click(object sender, EventArgs e)
        {
             //searchRichTextBox.Text=_name<>;
            //string names="";
            //for(int i= 0;i<_name.Count;i++)
            //{
            //    names += _name<i>+"\n";

            
            //}

            searchRichTextBox.Text = Convert.ToString(nameTextBox.Text);
            }

       
    }
}
 
 