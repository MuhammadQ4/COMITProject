using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace MyProject.Models
{
    public class pivotSub
    {
        public List<Products> productsList = new List<Products>();
        private MySqlConnection createConnection()
        {
            string connection = "server=localhost;database=myproject_db;user=root;password=Elect30@4;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }
        public List<Products> getProductsFromDB()
        {
            List<Products> productsList = new List<Products>();
            var con = this.createConnection();
            string cmdTxt = $"SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);

            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                productsList.Add(prod);
            } 
            con.Close();
            return productsList;
        }
        public void addProductToDB(Products prod)
        {
            var con = this.createConnection();
            string cmdTxt = $"INSERT INTO inventory VALUES({prod.prodId}, '{prod.prodName}',{prod.prodRetail},{prod.prodPerMonth})";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deletePorductFromDB(Products prod)
        {
            var con = this.createConnection();
            string cmdTxt = $"DELETE from inventory where ID = {prod.prodId}";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            cmd.ExecuteNonQuery();
            con.Close(); 
        }
        public List<Products> searchProductByName(string searchTxt)
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT * FROM inventory WHERE Name LIKE '%{searchTxt}%';";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> searchByLiving()
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id INNER JOIN categories ON categories.catID = catinv.cat_id WHERE catName LIKE 'Living';";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> searchByDining()
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id INNER JOIN categories ON categories.catID = catinv.cat_id WHERE catName LIKE 'Dining';";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> searchByBedroom()
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id INNER JOIN categories ON categories.catID = catinv.cat_id WHERE catName LIKE 'Bedroom';";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> searchByDecor()
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id INNER JOIN categories ON categories.catID = catinv.cat_id WHERE catName LIKE 'Decor';";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> searchBySubcat(int _catID, int _subcatID)
        {
            List<Products> tempList = new List<Products>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id WHERE catinv.cat_id = {_catID} AND catinv.subcat_id = {_subcatID};";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }

        public List<Products> sortFromHighToLow(int _catId, int _subcatId)
        {
            List<Products> tempList = new List<Products>();
            string cmdTxt = null;
            var con = this.createConnection();
            if(_subcatId!=0)
            {
                cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth from inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id WHERE catinv.cat_id = {_catId} AND catinv.subcat_id = {_subcatId} ORDER BY PerMonth;";
            }
            else
            {
                cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth from inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id WHERE catinv.cat_id = {_catId} ORDER BY PerMonth;";
                
            }
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Products prod = new Products();
                prod.prodId = Convert.ToInt32(result["ID"]);
                prod.prodName = result["Name"].ToString();
                prod.prodRetail = Convert.ToDouble(result["Retail"]);
                prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
                tempList.Add(prod);
            }
            con.Close();
            return tempList;
        }
        
         public List<subCategory> options()
        {
            List<subCategory> optionsList = new List<subCategory>();

            var con = this.createConnection();
            string cmdTxt = $"SELECT * from subcategories;";
            MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
            var result = cmd.ExecuteReader();
            // optionsList = cmd.ExecuteReader();

            while(result.Read())
            {
                subCategory subcat = new subCategory();
                subcat.subcatID = Convert.ToInt32(result["subcatID"]);
                subcat.subcatName = result["subcatName"].ToString();
                optionsList.Add(subcat);
            }
            con.Close();
            return optionsList;
        }

        //  public subCategory option(int _subcatID)
        // {
        //     // List<subCategory> optionsList = new List<subCategory>();
        //     subCategory _subcat = new subCategory();

        //     var con = this.createConnection();
        //     string cmdTxt = $"SELECT * from subcategories where subcatID = {_subcatID};";
        //     MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
        //     var result = cmd.ExecuteReader();
        //     // optionsList = cmd.ExecuteReader();

        //     while(result.Read())
        //     {
        //         // subCategory _subcat = new subCategory();
        //         _subcat.subcatID = Convert.ToInt32(result["subcatID"]);
        //         _subcat.subcatName = result["subcatName"].ToString();
        //         // optionsList.Add(subcat);
        //         // break;
        //     }
        //     // _subcat.subcatID = Convert.ToInt32(result["subcatID"]);
        //     // _subcat.subcatName = result["subcatName"].ToString();
        //     con.Close();
        //     return _subcat;
        // }


        // public List<Products> searchProductByCategory(string searchTxt)
        // {
        //     List<Products> tempList = new List<Products>();

        //     var con = this.createConnection();
        //     string cmdTxt = $"SELECT inventory.ID, name,Retail, PerMonth FROM inventory INNER JOIN catinv ON inventory.ID = catinv.inv_id INNER JOIN categories ON categories.catID = catinv.cat_id WHERE catName LIKE '%{searchTxt}%';";
        //     MySqlCommand cmd = new MySqlCommand(cmdTxt,con);
            
        //     var result = cmd.ExecuteReader();

        //     while(result.Read())
        //     {
        //         Products prod = new Products();
        //         prod.prodId = Convert.ToInt32(result["ID"]);
        //         prod.prodName = result["Name"].ToString();
        //         prod.prodRetail = Convert.ToDouble(result["Retail"]);
        //         prod.prodPerMonth = Convert.ToDouble(result["PerMonth"]);
        //         tempList.Add(prod);
        //     }
        //     con.Close();
        //     return tempList;
        // }
    }
}