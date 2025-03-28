namespace Encapsulation
{
    internal class Product
    {
        private string _id;
        private string _brandName;
        private string _model;
        private double _price;
        private double _cost;
        private double _income;
        private int _count;

        public Product(string brandName, string model, double price, double cost, int count)
        {
            _brandName = brandName;
            _model = model;
            _price = price;
            _cost = cost;
            _income = 0;
            _count = count;
            if (brandName.Length >= 2 && model.Length >= 2)
            {
                _id = brandName.Substring(0, 2) + model.Substring(0, 2);
            }
            else if (brandName.Length >= 2)
            {
                _id = brandName.Substring(0, 2) + model;
            }
            else if (model.Length >= 2)
            {
                _id = brandName + model.Substring(0, 2);
            }
            else
            {
                _id = brandName + model;
            }
        }





        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;

            }
        }


        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("qiymet menfi ola bilmez");
                }
            }
        }


        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
                else
                {
                    Console.WriteLine("xerc menfi ola bilmez");
                }
            }

        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {

                    _count = 0;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Concat("Id: ", _id));
            Console.WriteLine(string.Concat("Brand name:", _brandName));
            Console.WriteLine($"Model: {_model}");
            Console.WriteLine($"Qiymet: {_price}");
            Console.WriteLine("Say: " + _count);
        }
        public void Sale(int count)
        {
            if (count < 0)
            {
                Console.WriteLine("say menfi ola bilmez");
                return;
            }
            if (_count >= count)
            {
                double TotalIncome = (_price - _cost) * count;
                _income += TotalIncome;
                _count -= count;
                Console.WriteLine("Gelir: " + _income);
                Console.WriteLine("qalan mehsul: " + _count);
            }
            else
            {
                Console.WriteLine("Mehsul qalmayib");
            }
        }
    }
}
