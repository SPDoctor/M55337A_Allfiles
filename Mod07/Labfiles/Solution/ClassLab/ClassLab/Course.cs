namespace ClassLab
{
    class Course
    {
        private string _title;
        private int _creditHours;
        private string _program;
        private string _instructor;

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public int CreditHours
        {
            get { return this._creditHours; }
            set {
                if (value >= 3 || value <= 6)
                {
                    this._creditHours = value;
                }
            }
        }

        public string Program
        {
            get { return this._program; }
            set { this._program = value; }
        }
        
        public string Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }

        public Course()
        {
            this._title = "";
            this._creditHours = 0;
            this._program = "";
            this._instructor = "";
        }
        public Course(string title, int credits, string prog, string inst)
        {
            this._title = title;
            this._creditHours = credits;
            this._program = prog;
            this._instructor = inst;
        }

        public string GetTitle()
        {
            return this._title.ToUpper();
        }
    }
}
