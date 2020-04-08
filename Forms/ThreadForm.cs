using System;
using System.Windows.Forms;

namespace Engineer_Calculator.Forms
{
    public partial class ThreadForm : Form
    {
        public ThreadForm()
        {
            InitializeComponent();


        }

        private void ThreadForm_Load(object sender, EventArgs e)
        {
            InitializeMenu();
            Drill_Size_Btn.Click += (s, a) =>  OpenSubMenu(DrillSize_SubMenu_Panel); 

        }

        private void InitializeMenu()
        {
            DrillSize_SubMenu_Panel.Visible = false;
        }

        private void HideSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
        }

        private void OpenSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildForm_Panel.Controls.Add(childForm);
            ChildForm_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThreadFormAdds.NormalTap());
        }
    }
}
