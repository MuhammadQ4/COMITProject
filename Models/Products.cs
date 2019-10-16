using System.Collections.Generic;
namespace MyProject.Models
{
    public class Products
    {
        public int prodId {get; set;}
        public string prodName {get; set;}
        public double prodRetail{get; set;}
        public double prodPerMonth {get; set;}

    public Products(int _prodId, string _prodName, double _prodRetail, double _prodPerMonth)
    {
        prodId = _prodId;
        prodName = _prodName;
        prodRetail = _prodRetail;
        prodPerMonth = _prodPerMonth;
    }
    public Products()
    {
        //Costructor
    }
    }
}