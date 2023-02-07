using CustomControl_Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Cacti
{

    public partial class Shop : Form
    {
        bool clicked;
        Client client;
        Dictionary<Plant,int> dictionary;

        public Shop(Client c)
        {
            InitializeComponent();
            clicked = false;
            client = c;

            if (dictionary == null)
            {
                if (PlantsDictionary != null)
                {
                    display_dictionary(PlantsDictionary.OrderBy(i => i.Key.Name));
                }
            }
            else display_dictionary(dictionary);

        }

        public Shop(Client c, Dictionary<Plant,int> d)
        {
            InitializeComponent();
            clicked = false;
            client = c;
            dictionary = d;
            if (dictionary == null)
            {
                if (PlantsDictionary != null)
                {
                    display_dictionary(PlantsDictionary.OrderBy(i => i.Key.Name));
                }
            }
            else display_dictionary(dictionary);
        }



        Dictionary<Plant, int> PlantsDictionary;
        List<Plant> plants;
        List<int> QuantityList;
        CactiDataContext DB;
        FilterPanel FP;
        Dictionary<Plant, int> SearchedPlantsDictionary;
        int nameIndex = -2;
        int quantityIndex = -1;
        List<Product> products;

        FilterMode filterMode; 
        //List<Product> SearchedProd;
        

        #region Initialize to zero
        public void InitializeToZero(List<int> list,List<Plant> reference)
        {
            for (int i = 0; i < reference.Count; i++)
            {
                list.Add(0);
            }
        }
        #endregion Initialize to zero


        #region Find index of Name in product

        public int NameIndex()
        {
            Product p = new Product();
            for (int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].Name == "nameLbl")
                {
                    nameIndex = i;
                    break;
                }
            }
            return nameIndex;
        }

        #endregion


        #region Find index of Quantity in product

        public int QuantityIndex()
        {
            Product p = new Product();
            for (int i = 0; i < p.Controls.Count; i++)
            {
                if (p.Controls[i].Name == "quantityNumeric")
                {
                    quantityIndex = i;
                    break;
                }
            }
            return quantityIndex;
        }
        #endregion


        #region Dictionary display
        //private void display_dictionary(Dictionary<Plant, int> dictionary)
        public void display_dictionary(IEnumerable<KeyValuePair<Plant, int>> dictionary)
        { 
            NameIndex();
            QuantityIndex();
            int i = 1;
            centerPanel.Controls.Clear();
            FP = new FilterPanel();

            FP.Location = new System.Drawing.Point(307, 6);
            FP.Size = new System.Drawing.Size(127, 77);
            centerPanel.Controls.Add(FP);
            FP.Controls[1].Click += filterByNameBtn_Click;
            FP.Controls[0].Click += filterByPriceBtn_Click;
            FP.Hide();
             


            if (SearchedPlantsDictionary == null)
            {
                foreach (var DictionaryElement in dictionary)
                {
                    Product p = new Product();

                    if (i % 3 == 0)
                    {
                        p.Location = new System.Drawing.Point(2 * (181 + 1), (i / 3 - 1) * (201 + 1));

                    }

                    if (i % 3 == 1)
                    {  p.Location = new System.Drawing.Point(0, i / 3 * (201 + 1));
                      
                    }

                    if (i % 3 == 2)
                    {
                        p.Location = new System.Drawing.Point(181 + 1, i / 3 * (201 + 1));
                    }
                    p.Controls[nameIndex].Text = DictionaryElement.Key.Name;
                    p.Controls[quantityIndex].Text = DictionaryElement.Value.ToString();
                    p.Controls.OfType<Label>().Single(l => l.Name == "priceLbl").Text = DictionaryElement.Key.Price.ToString();
                    i++;
                    centerPanel.Controls.Add(p);
                }
            }
            else if (SearchedPlantsDictionary != null)
            {
                NameIndex();
                foreach (var SearchedDictionaryElement in SearchedPlantsDictionary)
                {
                    foreach (var DictionaryElement in PlantsDictionary)
                    {
                        if (SearchedDictionaryElement.Key.Name == DictionaryElement.Key.Name)
                        {
                            PlantsDictionary[DictionaryElement.Key] = SearchedDictionaryElement.Value;
                            break;
                        }
                    }
                }

                SearchedPlantsDictionary = null;
            }
        }


        #endregion


        #region Filter
        private void filterByNameBtn_Click(object sender, EventArgs e)
        {
            filterMode = FilterMode.FilterByName;
            List<Product> lop = centerPanel.Controls.OfType<Product>().ToList();

            //Dictionary<Plant, int> dic = new Dictionary<Plant, int>();

            ////foreach(Product pdct in lop)
            ////{
            ////    foreach(var pl in dictionary)
            ////    {
            ////        if (pl.Key.Name == pdct.Name)
            ////        {
            ////            dictionary[pl.Key] = (int)(pdct.Controls[QuantityIndex()] as NumericUpDown).Value;
            ////        }
            ////    }
            ////}
            ///

            products = centerPanel.Controls.OfType<Product>().ToList();
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            centerPanel.Controls.Clear();
            FP = new FilterPanel();

            FP.Location = new System.Drawing.Point(307, 6);
            FP.Size = new System.Drawing.Size(127, 77);
            centerPanel.Controls.Add(FP);
            FP.Controls[1].Click += filterByNameBtn_Click;
            FP.Controls[0].Click += filterByPriceBtn_Click;
            display_dictionary(PlantsDictionary.OrderBy(pair => pair.Key.Name)); 
            
            searchTextBox.Text = "Search";
            searchTextBox.ForeColor = Color.Gray;
            FP.Hide();
            clicked = false;
        }


        private void filterByPriceBtn_Click(object sender, EventArgs e)
        {

            filterMode = FilterMode.FilterByPrice;
            
            
           
            products = centerPanel.Controls.OfType<Product>().ToList();
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            centerPanel.Controls.Clear();
            FP = new FilterPanel();
            FP.Location = new System.Drawing.Point(307, 6);
            FP.Size = new System.Drawing.Size(127, 77);
            centerPanel.Controls.Add(FP);
            FP.Controls[1].Click += filterByNameBtn_Click;
            FP.Controls[0].Click += filterByPriceBtn_Click;
            searchTextBox.Text = "Search";
            searchTextBox.ForeColor = Color.Gray;
            display_dictionary(PlantsDictionary.OrderBy(pair => pair.Key.Price));

           
            FP.Hide();
            clicked=false;
        }


        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {   
                FP.Location = new System.Drawing.Point(307, 6);
                FP.Size = new System.Drawing.Size(127, 77);
                FP.Controls[0].Click += filterByPriceBtn_Click;
                FP.Controls[1].Click += filterByNameBtn_Click;
                FP.BringToFront();
                FP.Show();
                clicked = true;
            }
            else
            {
                FP.Hide();
                clicked = false;
            }
            
        }
        #endregion Filter


        #region Menu


        #region Homebtn
        private void homeBtn_Click(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            HomePage HP = new HomePage(client,PlantsDictionary);
            this.Hide();
            HP.ShowDialog();
            PlantsDictionary.OrderBy(pair => pair.Key.Name);
            display_dictionary(PlantsDictionary);

        }

        #endregion Home btn


        #region Sign out btn
        private void signOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Sign Out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WelcomePage WP = new WelcomePage();
                this.Hide();
                WP.ShowDialog();
            }
        }
        #endregion Sign out Btn


        #region account btn

        private void accountBtn_Click(object sender, EventArgs e)
        {

            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            Account account = new Account(client, PlantsDictionary);
            this.Hide();
            account.ShowDialog();
        }

        #endregion Account Btn


        #endregion Menu


        #region OnLoad

        private void Shop_Load(object sender, EventArgs e)
        {
            try

            {
                DB = new CactiDataContext();
                QuantityList = new List<int>();
                //
                
                    products = new List<Product>();
                
                //
                PlantsDictionary = new Dictionary<Plant, int>();
                plants = new List<Plant>();
                plants = DB.Plants.ToList();
                InitializeToZero(QuantityList, plants);
                PlantsDictionary.AddRange(plants, QuantityList);
                if (dictionary == null)
                { display_dictionary(PlantsDictionary.OrderBy(i => i.Key.Name)); }
                else display_dictionary(dictionary);
                FP = new FilterPanel();
                FP.Location = new System.Drawing.Point(307, 6);
                FP.Size = new System.Drawing.Size(127, 77);
                centerPanel.Controls.Add(FP);
                FP.Hide();
                FP.Controls[1].Click += filterByNameBtn_Click;
                FP.Controls[0].Click += filterByPriceBtn_Click;
                FP.BringToFront();



                products = centerPanel.Controls.OfType<Product>().ToList();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        #endregion OnLoad


        #region Close btn
        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }

        }
        #endregion  Close btn


        #region Search

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.Text = "Search";
                searchTextBox.ForeColor = Color.Gray;
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            //
            products = centerPanel.Controls.OfType<Product>().ToList();
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            //
            if (searchTextBox.Text == "Search")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.FromArgb(31, 167, 127);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            QuantityIndex();
            //products = centerPanel.Controls.OfType<Product>().ToList();
            if (searchTextBox.Text != "" && searchTextBox.Text != "Search")
            {
                char[] searchedPlant = searchTextBox.Text.ToCharArray();
                searchedPlant[0] = char.ToUpper(searchedPlant[0]);
                for (int i = 1; i < searchedPlant.Length; i++)
                {
                   searchedPlant.SetValue(char.ToLower(searchedPlant[i]), i);
                }
               
                Dictionary<Plant, int> SearchedPlantsDictionary = new Dictionary<Plant, int>();
                string test = new string(searchedPlant);
                foreach (var dictionaryElement in PlantsDictionary)
                {
                    if (dictionaryElement.Key.Name.Contains(test))
                    {
                        SearchedPlantsDictionary.Add(dictionaryElement.Key, dictionaryElement.Value);
                    }
                }


                if (SearchedPlantsDictionary != null)
                {
                    centerPanel.Controls.Clear();
                    display_dictionary(SearchedPlantsDictionary);
                    FP = new FilterPanel();
                    FP.Location = new System.Drawing.Point(307, 6);
                    FP.Size = new System.Drawing.Size(127, 77);
                    centerPanel.Controls.Add(FP);
                    FP.Hide();
                    FP.Controls[1].Click += filterByNameBtn_Click;
                    FP.Controls[0].Click += filterByPriceBtn_Click;
                    foreach (Product p in products)
                    {
                        Plant match = SearchedPlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].ToString());
                        if (match != null)
                        {
                            SearchedPlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("No results");
                }
            }
            else
            { 
                FP = new FilterPanel();
                FP.Location = new System.Drawing.Point(307, 6);
                FP.Size = new System.Drawing.Size(127, 77);
                centerPanel.Controls.Add(FP);
                FP.Hide();
                FP.Controls[1].Click += filterByNameBtn_Click;
                FP.Controls[0].Click += filterByPriceBtn_Click;

                if (filterMode == FilterMode.FilterByName)
                {
                    display_dictionary(PlantsDictionary.OrderBy(i => i.Key.Name));
                }
                else display_dictionary(PlantsDictionary.OrderBy(i => i.Key.Price));
            }
        }
        #endregion Search

        private void cartBtn_Click(object sender, EventArgs e)
        {
            products = centerPanel.Controls.OfType<Product>().ToList();
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            //Dictionary<Plant, int> cartDictionary = new Dictionary<Plant, int>();
            //foreach(var dict in PlantsDictionary)
            //{
            //    if(dict.Value!= 0)
            //    {
            //        cartDictionary.Add(dict.Key,dict.Value);
            //    }
            //}
            Cart cart = new Cart(client, PlantsDictionary);
            this.Hide();
            cart.ShowDialog();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            products = centerPanel.Controls.OfType<Product>().ToList();
            foreach (Product p in products)
            {
                Plant match = PlantsDictionary.Keys.SingleOrDefault(i => i.Name == p.Controls[nameIndex].Text.ToString());
                if (match != null)
                {
                    PlantsDictionary[match] = (int)p.Controls.OfType<NumericUpDown>().First().Value;
                }
            }
            //Dictionary<Plant, int> cartDictionary = new Dictionary<Plant, int>();
            //foreach (var dict in PlantsDictionary)
            //{
            //    if (dict.Value != 0)
            //    {
            //        cartDictionary.Add(dict.Key, dict.Value);
            //    }
            //}
            Cart cart = new Cart(client,PlantsDictionary);
            this.Hide();
            cart.ShowDialog();
        }

        
    }

    enum FilterMode 
    {
        FilterByName,
        FilterByPrice
        
    }
}
