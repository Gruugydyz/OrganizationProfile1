using System.Text.RegularExpressions;

namespace OrganizationProfile1

{
    public partial class frmRegsitration : Form
    {
        private string _FullName;
        private int _Age;
        private long _StudentNo;
        private long _ContactNo;

        public frmRegsitration()
        {
            InitializeComponent();
        }
        /////return methods 
        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
                return _StudentNo;
            }
            catch (FormatException f)
            {
                MessageBox.Show("Format Exception for student number." + f.Message);
                throw;
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Overflow Exception for Student number." + o.Message);
                throw;
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("Argument null Execption for Student number." + a.Message);
                throw;
            }
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                    return _ContactNo;
                }
                else
                {
                    throw new FormatException("Invalid contact number format.");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Exception for contact number." + ex.Message);
                throw;
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Overflow Exception for Contact number." + o.Message);
                throw;
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("Argument Null Execption for Contact number." + a.Message);
                throw;
            }
            catch (IndexOutOfRangeException i)
            {
                MessageBox.Show("Index is out of range Exception for Contact Number." + i.Message);
                throw;

            }
        }


        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            try
            {
                if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
                    return _FullName;
                }
                else
                {
                    throw new FormatException("Invalid name format.");
                }
            }
            catch (FormatException f)
            {
                MessageBox.Show("Format Exception for full name." + f.Message);
                throw;
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Overflow Exception for Full name." + o.Message);
                throw;
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("Argument null Execption for Full name." + a.Message);
                throw;
            }
        }

        public int Age(string age)
        {
            try
            {
                if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                {
                    _Age = Int32.Parse(age);
                    return _Age;
                }
                else
                {
                    throw new FormatException("Invalid age format.");
                }
            }
            catch (FormatException f)
            {
                MessageBox.Show("Format Exception for Age." + f.Message);
                throw;
            }
            catch (OverflowException o)
            {
                MessageBox.Show("Overflow Exception for Age." + o.Message);
                throw;
            }
            catch (ArgumentNullException a)
            {
                MessageBox.Show("Argument null Execption for Age." + a.Message);
                throw;
            }
        }

        private void frmRegsitration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                 "BS Information Technology",
                 "BS Computer Science",
                 "BS Information Systems",
                 "BS in Accountancy",
                 "BS in Hospitality Management",
                 "BS in Tourism Management"

            };
            cbGender.Items.Add("Male"); cbGender.Items.Add("Female");

            for (int i = 0; i < 6; i++)
            {

                cbPrograms.Items.Add(ListOfProgram[i].ToString());

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentInformationClass.SetFullName = FullName(txtLastName.Text,txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.SetStudentNo = (Int32)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.Text;
            StudentInformationClass.SetGender = cbGender.Text;
            StudentInformationClass.SetContactNo = (Int32)ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Age(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();

            
        }
    }

}





