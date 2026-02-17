using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArendsAvto
{
    public class Avto
    {
        private string brand_;
        private string model_;
        private double price_;
        private string owner_;

        public string Brand
        {
            get { return brand_; }
        }

        public string Model
        {
            get { return model_; }
        }

        public double Price
        {
            get { return price_; }
        }

        public string Owner
        {
            get { return owner_; }
        }
        public Avto(string bre)
        {

        }
    }
}
