using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Program;
using Program.forms;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLoginForm()
        {
            Program.forms.loginForm testForm = new Program.forms.loginForm();
            DialogResult result = testForm.ShowDialog();
            result.Equals(DialogResult.OK);
        }
        
        [TestMethod]
        public void TestMethodAdminForm()
        {
            Program.forms.adminForm testForm = new Program.forms.adminForm();
            DialogResult result = testForm.ShowDialog();
            result.Equals(DialogResult.OK);
        }

        [TestMethod]
        public void TestMethodClientForm()
        {
            Program.forms.clientForm testForm = new Program.forms.clientForm();
            DialogResult result = testForm.ShowDialog();
            result.Equals(DialogResult.OK);
        }

        [TestMethod]
        public void TestMethodAssortmentForm()
        {
            Program.forms.assortmentForm testForm = new Program.forms.assortmentForm();
            DialogResult result = testForm.ShowDialog();
            result.Equals(DialogResult.OK);
        }
    }
}
