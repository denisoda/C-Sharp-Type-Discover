using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool clic;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        

            if (clic == true)
            {
                lstMethods.Items.Clear();
                lstConstructors.Items.Clear();
                lstProperties.Items.Clear();
               
                
            }

            #region MethodList

            

           
            string TypeName = txtTypeName.Text;
            Type T= Type.GetType(TypeName);
            try
            {

            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method  in methods)
            {
                lstMethods.Items.Add(method);

            }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

            #endregion


            #region PropertiesList

            

            try
            {

               PropertyInfo[] properties = T.GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    lstProperties.Items.Add(prop);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            #region ConstructsList

            

            try
            {

               ConstructorInfo[] constrc = T.GetConstructors();

                foreach (ConstructorInfo constr in constrc)
                {
                    lstConstructors.Items.Add(constr);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            #endregion

            clic = true;

        }
    }
}
