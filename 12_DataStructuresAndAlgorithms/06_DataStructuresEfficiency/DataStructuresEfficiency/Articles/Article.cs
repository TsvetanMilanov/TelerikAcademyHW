namespace Articles
{
    using System;

    public class Article : IComparable<Article>
    {
        public string Title { get; set; }

        public string Vendor { get; set; }

        public string Barcode { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Article other)
        {
            if (this.Title.CompareTo(other.Title) != 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            else if (this.Vendor.CompareTo(other.Vendor) != 0)
            {
                return this.Vendor.CompareTo(other.Vendor);
            }
            else if (this.Barcode.CompareTo(other.Barcode) != 0)
            {
                return this.Barcode.CompareTo(other.Barcode);
            }
            else if (this.Price.CompareTo(other.Price) != 0)
            {
                return this.Price.CompareTo(other.Price);
            }
            else
            {
                return 0;
            }
        }
    }
}
