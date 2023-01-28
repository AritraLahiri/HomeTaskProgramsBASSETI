namespace HomeTasksModels
{
    internal class EmployeeDetails
    {
        private string _id;
        private string _name;
        private string _email;
        private string _password;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
            }
        }


    }
}
