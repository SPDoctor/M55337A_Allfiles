namespace EncapsulationDemo
{
    class Person
    {
        private string _name;
        private float _weight;
        private float _height;

        #region Properties
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    this._weight = value;
                }
            }
        }

        public float Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                    this._height = value;
                }
            }
        }
        #endregion

        public Person(string name, float height, float weight)
        {
            this._name = name;
            this._height = height;
            this._weight = weight;
        }
    }
}