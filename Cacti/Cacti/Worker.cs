using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cacti
{
    public abstract class Worker
    {
        CactiDataContext DB = new CactiDataContext();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public abstract void WorkerLogin(string email, string password, Form form);


        #region Add Plant
        public void AddPlant(string namE, string pricE)
        {
            try
            {
                if (namE != "" && pricE != "")
                {
                    if (Regex.IsMatch(namE, @"^[a-zA-Z ]{4,50}$")) // verify the the name does not contain any nb
                    {
                        if (!pricE.Any(c => char.IsDigit(c) == false))
                        {
                            if (Convert.ToInt32(pricE) > 0)
                            {

                                DB = new CactiDataContext();
                                var p = DB.Plants.Where(i => i.Name == namE);

                                if (p.Count().ToString() == "0")
                                {
                                    if (MessageBox.Show("Are you sure you want to add this plant?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {

                                        char[] addedPlant = namE.ToCharArray();
                                        addedPlant[0] = char.ToUpper(addedPlant[0]);
                                        string s = new string(addedPlant);
                                        for (int i = 1; i < addedPlant.Length; i++)
                                        {
                                            addedPlant.SetValue(char.ToLower(addedPlant[i]), i);

                                        }
                                        var plant = new Plant();
                                        plant.Name = s;
                                        plant.Price = Convert.ToInt32(pricE);
                                        MessageBox.Show($"{plant.Name} added.");
                                        DB.Plants.InsertOnSubmit(plant);
                                        DB.SubmitChanges();
                                    }

                                }
                                else //name already exists in db
                                {
                                    namE = "";
                                    pricE = "";
                                    throw new Exception("This plant already exists.");
                                }
                            }
                            else //price < 0
                            {
                                pricE = "";
                                throw new Exception("The price must be > 0.");
                            }
                        }
                        else //price with letters
                        {
                            pricE = "";
                            throw new Exception("The price must contain ONLY digits.");
                        }
                    }
                    else //name with nb
                    {
                        namE = "";
                        throw new Exception("Invalid name.");
                    }

                }
                else //empty texboxes
                {
                    throw new Exception("Missing data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Add Plant


        #region Remove Plant
        public void RemovePlant(string namE)
        {
            try
            {
                if (namE != "")
                {
                    DB = new CactiDataContext();
                    char[] removedPlant = namE.ToCharArray();
                    removedPlant[0] = char.ToUpper(removedPlant[0]);
                    for (int i = 1; i < removedPlant.Length; i++)
                    {
                        removedPlant.SetValue(removedPlant[i], i);
                    }
                    string str = new string(removedPlant);
                    var pl = DB.Plants.SingleOrDefault(i => i.Name == str);
                    if (pl != null)
                    {
                        if (MessageBox.Show("Are you sure you want to Remove this plant?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show($"{pl.Name} removed");
                            DB.Plants.DeleteOnSubmit(pl);
                            DB.SubmitChanges();
                        }
                    }
                    else //Plant not found
                    {
                        namE = "";
                        throw new Exception("Plant not found.");
                    }
                }
                else //missing data
                {
                    throw new Exception("Enter the name of the plant you want to remove.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Remove Plant


        #region Update Price
        public void UpdatePlant(string namE, string pricE)
        {
            try
            {
                if (namE != "" && pricE != "")
                {
                    DB = new CactiDataContext();
                    char[] updatedPlant = namE.ToCharArray();
                    updatedPlant[0] = char.ToUpper(updatedPlant[0]);
                    for (int i = 1; i < updatedPlant.Length; i++)
                    {
                        updatedPlant.SetValue(char.ToLower(updatedPlant[i]), i);
                    }
                    string str = new string(updatedPlant);
                    var pl = DB.Plants.SingleOrDefault(i => i.Name == str);
                    if (pl != null)
                    {
                        if (!pricE.Any(c => char.IsDigit(c) == false))
                        {
                            if (Convert.ToInt32(pricE) > 0)
                            {
                                if (MessageBox.Show("Are you sure you want to update the price of this plant?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    pl.Price = Convert.ToInt32(pricE);
                                    MessageBox.Show($"Price of {pl.Name} updated.");
                                    DB.SubmitChanges();
                                   
                                }

                            }
                            else //price < 0
                            {
                                pricE = "";
                                throw new Exception("The price must be > 0.");
                            }
                        }
                        else //price with letters
                        {
                            pricE = "";
                            throw new Exception("The price must contain ONLY digits.");
                        }
                    }
                    else //plant does not exist
                    {
                        namE = "";
                        throw new Exception("Plant Does not exist.");
                    }

                }
                else //empty textboxes
                {
                    throw new Exception("Missing data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Update Price
       
    }

}
